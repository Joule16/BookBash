//   Equipo 2
//   NUÑEZ Martinez Marco Antonio
//   SUÑIGA Maciel Joule Alexander
//   VILLA Olivarez Ariel
// =============================
using System;
using System.Windows.Forms;
using SistemaBiblioteca1.Models;

namespace SistemaBiblioteca1
{
    public enum AccionBorrado
    {
        Ninguna,
        BorradoLogico,
        BorradoFisico
    }
    public partial class FrmDetalleLibro : Form
    {
        public AccionBorrado Accion { get; private set; } = AccionBorrado.Ninguna;

        public FrmDetalleLibro(Libro libro)
        {
            InitializeComponent();
            CargarDetalle(libro);
        }

        private void CargarDetalle(Libro libro)
        {
            txtId.Text = libro.Id.ToString();
            txtTitulo.Text = libro.Titulo;
            txtIsbn.Text = libro.Isbn;
            txtAutor.Text = NombreAutor(libro.IdAutor);
            txtCategoria.Text = NombreCategoria(libro.IdCategoria);
            txtEditorial.Text = NombreEditorial(libro.IdEditorial);
            txtAnio.Text = libro.AnioPublicacion.ToString();
            txtPuntoEntrega.Text = libro.PuntoEntrega;

            Ejemplar.ContarDeLibro(libro.Id, out int totalEjemplares, out int disponiblesEjemplares);
            txtEjemplares.Text = totalEjemplares + " (" + disponiblesEjemplares + " disponibles)";
            chkActivo.Checked = libro.EsActivo;

            GestorImagenes.CargarGuardada(pbxPortada, libro.RutaImagen);

            btnBajaLogica.Enabled = libro.EsActivo;
        }

        private static string NombreAutor(int id)
        {
            Autor? a = new Autor().ConsultarRegistro(id.ToString()) as Autor;
            return a == null ? "(autor #" + id + ")" : a.Nombre + " " + a.Apellido;
        }

        private static string NombreCategoria(int id)
        {
            Categoria? c = new Categoria().ConsultarRegistro(id.ToString()) as Categoria;
            return c == null ? "(categoría #" + id + ")" : c.Nombre;
        }

        private static string NombreEditorial(int id)
        {
            Editorial? e = new Editorial().ConsultarRegistro(id.ToString()) as Editorial;
            return e == null ? "(editorial #" + id + ")" : e.Nombre;
        }

        private void btnBajaLogica_Click(object? sender, EventArgs e)
        {
            Accion = AccionBorrado.BorradoLogico;
            DialogResult = DialogResult.OK;
        }

        private void btnEliminarFisico_Click(object? sender, EventArgs e)
        {
            Accion = AccionBorrado.BorradoFisico;
            DialogResult = DialogResult.OK;
        }

        private void btnCancelar_Click(object? sender, EventArgs e)
        {
            Accion = AccionBorrado.Ninguna;
            DialogResult = DialogResult.Cancel;
        }
    }
}