// ===============================
//   Equipo #2
//   NUÑEZ Martinez Marco Antonio
//   SUÑIGA Maciel Joule Alexander
//   VILLA Olivares Ariel
// ===============================
using SistemaBiblioteca1.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SistemaBiblioteca1.Datos
{
    public static class VentasBD
    {
        private const string SELECT_PRODUCTO =
            "SELECT l.IdLibro, l.Titulo, l.Isbn, CONCAT(a.Nombre, ' ', a.Apellido), l.Precio, " +
            "(SELECT COUNT(*) FROM Ejemplar e WHERE e.IdLibro = l.IdLibro AND e.EsActivo = 1 AND e.Disponible = 1) " +
            "FROM Libro l INNER JOIN Autor a ON a.IdAutor = l.IdAutor " +
            "WHERE l.EsActivo = 1 ";

        private static ProductoVenta Convertir(MySqlConnector.MySqlDataReader r)
        {
            return new ProductoVenta
            {
                IdLibro = ConexionBD.Entero(r, 0),
                Titulo = ConexionBD.Texto(r, 1),
                Isbn = ConexionBD.Texto(r, 2),
                Autor = ConexionBD.Texto(r, 3),
                Precio = Convert.ToDecimal(r.GetValue(4)),
                Stock = ConexionBD.Entero(r, 5)
            };
        }

        public static ProductoVenta? BuscarPorId(int idLibro)
        {
            List<ProductoVenta> encontrados = ConexionBD.Leer(
                SELECT_PRODUCTO + "AND l.IdLibro = @id",
                Convertir,
                ConexionBD.P("@id", idLibro));

            return encontrados.FirstOrDefault();
        }

        public static List<ProductoVenta> BuscarPorNombre(string texto)
        {
            string patron = "%" + EscaparLike((texto ?? string.Empty).Trim()) + "%";

            return ConexionBD.Leer(
                SELECT_PRODUCTO + "AND l.Titulo LIKE @patron ORDER BY l.Titulo LIMIT 200",
                Convertir,
                ConexionBD.P("@patron", patron));
        }

        public static int ConsultarStock(int idLibro)
        {
            List<int> conteo = ConexionBD.Leer(
                "SELECT COUNT(*) FROM Ejemplar e INNER JOIN Libro l ON l.IdLibro = e.IdLibro " +
                "WHERE e.IdLibro = @id AND l.EsActivo = 1 AND e.EsActivo = 1 AND e.Disponible = 1",
                r => ConexionBD.Entero(r, 0),
                ConexionBD.P("@id", idLibro));

            return conteo.FirstOrDefault();
        }

        private static string EscaparLike(string texto)
        {
            return texto.Replace("\\", "\\\\").Replace("%", "\\%").Replace("_", "\\_");
        }
    }
}
