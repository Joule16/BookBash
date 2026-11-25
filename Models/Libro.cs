//SUÑIGA Maciel Joule Alexander
//VILLA Olivares Ariel
//NUÑEZ Martinez Marco Antonio
//Equipo 2
//=============================
using System;
using System.IO;
using SistemaBiblioteca1.Datos;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SistemaBiblioteca1.Models;

namespace SistemaBiblioteca1.Models
{
    public class Libro : EntidadBase, IAlmacenamientoCRUD
    {
        private static List<Libro> listaLibros = new List<Libro>();

        private string titulo;
        private string isbn;
        private int idAutor;
        private int idCategoria;
        private int idEditorial;
        private int anioPublicacion;
        private string puntoEntrega;
        private int? idPropietario;
        private string rutaImagen;

        public int IdLibro
        {
            get { return Id; }
            set { Id = value; }
        }

        public string Titulo
        {
            get { return titulo; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("El título no puede estar vacío.");
                titulo = value.Trim();
            }
        }

        public string Isbn
        {
            get { return isbn; }
            set
            {
                if (string.IsNullOrWhiteSpace(value) || (value.Length != 10 && value.Length != 13))
                    throw new ArgumentException("El ISBN debe tener 10 o 13 caracteres.");
                isbn = value.Trim();
            }
        }

        public int IdAutor
        {
            get { return idAutor; }
            set
            {
                if (value <= 0)
                    throw new ArgumentException("Debe asignarse un autor válido.");
                idAutor = value;
            }
        }

        public int IdCategoria
        {
            get { return idCategoria; }
            set
            {
                if (value <= 0)
                    throw new ArgumentException("Debe asignarse una categoría válida.");
                idCategoria = value;
            }
        }

        public int IdEditorial
        {
            get { return idEditorial; }
            set
            {
                if (value <= 0)
                    throw new ArgumentException("Debe asignarse una editorial válida.");
                idEditorial = value;
            }
        }

        public int AnioPublicacion
        {
            get { return anioPublicacion; }
            set
            {
                if (value < 1400 || value > DateTime.Now.Year)
                    throw new ArgumentException("El año de publicación no es válido.");
                anioPublicacion = value;
            }
        }

        public string PuntoEntrega
        {
            get { return puntoEntrega; }
            set
            {
                string limpio = string.IsNullOrWhiteSpace(value) ? string.Empty : value.Trim();
                if (limpio.Length > 100)
                    throw new ArgumentException("El punto de entrega no puede pasar de 100 caracteres.");
                puntoEntrega = limpio;
            }
        }

        public int? IdPropietario
        {
            get { return idPropietario; }
            set
            {
                if (value.HasValue && value.Value <= 0)
                    throw new ArgumentException("El propietario del libro no es válido.");
                idPropietario = value;
            }
        }

        public string RutaImagen
        {
            get { return rutaImagen; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value) && Path.IsPathRooted(value))
                    throw new ArgumentException("La ruta de la imagen debe ser relativa, no una ruta absoluta.");
                rutaImagen = string.IsNullOrWhiteSpace(value) ? string.Empty : value.Trim();
            }
        }

        public bool Estado
        {
            get { return EsActivo; }
            set { EsActivo = value; }
        }

        public Libro() : base()
        {
            titulo = string.Empty;
            isbn = string.Empty;
            idAutor = 0;
            idCategoria = 0;
            idEditorial = 0;
            anioPublicacion = DateTime.Now.Year;
            puntoEntrega = string.Empty;
            idPropietario = null;
            rutaImagen = string.Empty;
            EsActivo = false;
        }

        public Libro(int idLibro, string titulo, string isbn, int idAutor, int idCategoria,
                     int idEditorial, int anioPublicacion, bool estado, string puntoEntrega = "",
                     int? idPropietario = null, string rutaImagen = "") : base(idLibro)
        {
            Titulo = titulo;
            Isbn = isbn;
            IdAutor = idAutor;
            IdCategoria = idCategoria;
            IdEditorial = idEditorial;
            AnioPublicacion = anioPublicacion;
            PuntoEntrega = puntoEntrega;
            IdPropietario = idPropietario;
            RutaImagen = rutaImagen;
            EsActivo = estado;
        }

        public int CalcularAntiguedad()
        {
            return CalcularAntiguedad(DateTime.Now.Year);
        }

        public int CalcularAntiguedad(int anioReferencia)
        {
            if (anioReferencia < anioPublicacion)
                throw new ArgumentException("El año de referencia no puede ser anterior a la publicación.");
            return anioReferencia - anioPublicacion;
        }

        public static List<Libro> ObtenerTodos()
        {
            return listaLibros.OrderBy(x => x.Id).ToList();
        }

        public static List<Libro> ObtenerActivos()
        {
            return listaLibros.Where(x => x.EsActivo).OrderBy(x => x.Id).ToList();
        }

        public void DarDeBaja()
        {
            if (!EsActivo)
                throw new InvalidOperationException("El libro ya está dado de baja.");

            CambiarEstado(false);
        }

        public void Restaurar()
        {
            if (EsActivo)
                throw new InvalidOperationException("El libro ya está disponible en el catálogo.");

            CambiarEstado(true);
        }

        private void CambiarEstado(bool nuevoEstado)
        {
            bool anterior = EsActivo;
            EsActivo = nuevoEstado;

            if (!ConexionBD.Habilitada || !listaLibros.Contains(this))
                return;

            try
            {
                RepositorioBD.Actualizar(this);
            }
            catch
            {
                EsActivo = anterior;
                throw;
            }

            try
            {
                ConexionMongo.CambiarEstadoLibro(this);
            }
            catch (InvalidOperationException ex)
            {
                EsActivo = anterior;
                try
                {
                    RepositorioBD.Actualizar(this);
                }
                catch (InvalidOperationException exRevertir)
                {
                    throw new InvalidOperationException(
                        "El estado no cambió en MongoDB y tampoco se pudo revertir MariaDB:\n" +
                        ex.Message + "\n" + exRevertir.Message, ex);
                }

                throw new InvalidOperationException("El cambio de estado no se aplicó porque falló MongoDB:\n" + ex.Message, ex);
            }
        }

        internal static void CargarDesdeBD(IEnumerable<Libro> registros)
        {
            listaLibros.Clear();
            listaLibros.AddRange(registros);
        }

        private void GuardarCambiosEnBD()
        {
            if (ConexionBD.Habilitada && listaLibros.Contains(this))
                RepositorioBD.Actualizar(this);
        }

        public void InsertarRegistro(object objeto)
        {
            if (objeto == null)
                throw new ArgumentNullException(nameof(objeto), "El objeto a insertar no puede ser nulo.");

            if (!(objeto is Libro libro))
                throw new ArgumentException("El objeto a insertar no es de tipo Libro.");

            if (listaLibros.Any(l => l.Id == libro.Id))
                throw new InvalidOperationException($"Ya existe un libro con el id {libro.Id}.");

            RepositorioBD.Insertar(libro);
            GuardarEnMongo(libro);

            listaLibros.Add(libro);
        }

        private static void GuardarEnMongo(Libro libro)
        {
            if (!ConexionBD.Habilitada)
                return;

            try
            {
                ConexionMongo.InsertarLibro(libro);
            }
            catch (InvalidOperationException ex)
            {
                RepositorioBD.Eliminar("Libro", "IdLibro", libro.Id);
                throw new InvalidOperationException("El libro no se guardó porque falló MongoDB:\n" + ex.Message, ex);
            }
        }

        public object ConsultarRegistro(string id)
        {
            int idBuscado = ConvertirId(id);
            return listaLibros.FirstOrDefault(l => l.Id == idBuscado);
        }

        public void ActualizarRegistro(object objeto)
        {
            if (objeto == null)
                throw new ArgumentNullException(nameof(objeto), "El objeto a actualizar no puede ser nulo.");

            if (!(objeto is Libro libro))
                throw new ArgumentException("El objeto a actualizar no es de tipo Libro.");

            int indice = listaLibros.FindIndex(l => l.Id == libro.Id);
            if (indice == -1)
                throw new InvalidOperationException($"No existe un libro con el id {libro.Id}.");

            Libro anterior = listaLibros[indice];

            RepositorioBD.Actualizar(libro);
            ActualizarEnMongo(libro, anterior);

            listaLibros[indice] = libro;
        }

        private static void ActualizarEnMongo(Libro nuevo, Libro anterior)
        {
            if (!ConexionBD.Habilitada)
                return;

            try
            {
                ConexionMongo.ActualizarLibro(nuevo);
            }
            catch (InvalidOperationException ex)
            {
                try
                {
                    RepositorioBD.Actualizar(anterior);
                }
                catch (InvalidOperationException exRevertir)
                {
                    throw new InvalidOperationException(
                        "El libro no se actualizó en MongoDB y tampoco se pudo revertir MariaDB:\n" +
                        ex.Message + "\n" + exRevertir.Message, ex);
                }

                throw new InvalidOperationException("El libro no se actualizó porque falló MongoDB:\n" + ex.Message, ex);
            }
        }

        public void EliminarRegistro(string id)
        {
            int idBuscado = ConvertirId(id);

            int indice = listaLibros.FindIndex(l => l.Id == idBuscado);
            if (indice == -1)
                throw new InvalidOperationException($"No existe un libro con el id {idBuscado}.");

            Libro libro = listaLibros[indice];

            RepositorioBD.Eliminar("Libro", "IdLibro", idBuscado);

            if (ConexionBD.Habilitada)
            {
                try
                {
                    ConexionMongo.EliminarLibro(idBuscado);
                }
                catch (InvalidOperationException ex)
                {
                    try
                    {
                        RepositorioBD.Insertar(libro);
                    }
                    catch (InvalidOperationException exRevertir)
                    {
                        throw new InvalidOperationException(
                            "El libro se eliminó de MariaDB pero no de MongoDB, y no se pudo restaurar:\n" +
                            ex.Message + "\n" + exRevertir.Message, ex);
                    }

                    throw new InvalidOperationException("El libro no se eliminó porque falló MongoDB:\n" + ex.Message, ex);
                }
            }

            listaLibros.RemoveAt(indice);
        }

        private static int ConvertirId(string id)
        {
            if (!int.TryParse(id, out int resultado) || resultado < 0)
                throw new ArgumentException("El id debe ser un número entero no negativo.");
            return resultado;
        }

        public override string ToString()
        {
            string entrega = puntoEntrega.Length > 0 ? puntoEntrega : "ciudad del dueño";
            return $"Libro #{Id}: {titulo} | ISBN: {isbn} | Año: {anioPublicacion} | " +
                   $"Entrega: {entrega} | " +
                   $"Estado: {(EsActivo ? "Disponible en catálogo" : "Dado de baja")}";
        }
    }
}