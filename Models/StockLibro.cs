//   Equipo 2
//   NUÑEZ Martinez Marco Antonio
//   SUÑIGA Maciel Joule Alexander
//   VILLA Olivarez Ariel
// =============================
using System;
using System.Collections.Generic;
using System.Linq;

namespace SistemaBiblioteca1.Models
{
    public static class StockLibro
    {
        public const int STOCK_MAXIMO = 500;

        public static int Contar(int idLibro)
        {
            return DisponiblesDe(idLibro).Count;
        }

        public static int Ajustar(int idLibro, int nuevoStock)
        {
            if (idLibro < 0)
                throw new ArgumentException("El id del libro no es válido.");

            if (nuevoStock < 0 || nuevoStock > STOCK_MAXIMO)
                throw new ArgumentException("El stock debe estar entre 0 y " + STOCK_MAXIMO + ".");

            if (new Libro().ConsultarRegistro(idLibro.ToString()) == null)
                throw new InvalidOperationException("No existe un libro con el id " + idLibro + ".");

            List<Ejemplar> disponibles = DisponiblesDe(idLibro);
            int diferencia = nuevoStock - disponibles.Count;

            if (diferencia > 0)
            {
                for (int i = 0; i < diferencia; i++)
                    CrearEjemplar(idLibro);
            }
            else if (diferencia < 0)
            {
                foreach (Ejemplar e in disponibles.OrderByDescending(x => x.Id).Take(-diferencia))
                {
                    Ejemplar baja = new Ejemplar(e.Id, e.IdLibro, e.CodigoInventario, e.Condicion, e.Disponible, false);
                    baja.ActualizarRegistro(baja);
                }
            }

            return diferencia;
        }

        private static List<Ejemplar> DisponiblesDe(int idLibro)
        {
            return Ejemplar.ObtenerTodos()
                           .Where(e => e.IdLibro == idLibro && e.EsActivo && e.Disponible)
                           .ToList();
        }

        private static void CrearEjemplar(int idLibro)
        {
            List<Ejemplar> todos = Ejemplar.ObtenerTodos();
            int nuevoId = todos.Count == 0 ? 1 : todos.Max(x => x.Id) + 1;

            string codigo = "E" + nuevoId;
            int sufijo = 0;
            while (todos.Any(x => string.Equals(x.CodigoInventario, codigo, StringComparison.OrdinalIgnoreCase)))
            {
                sufijo++;
                codigo = "E" + nuevoId + "-" + sufijo;
            }

            if (codigo.Length > 12)
                throw new InvalidOperationException("No se pudo generar un código de inventario de 12 caracteres o menos.");

            Ejemplar nuevo = new Ejemplar(nuevoId, idLibro, codigo, "Nuevo", true, true);
            nuevo.InsertarRegistro(nuevo);
        }
    }
}
