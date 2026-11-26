//   Equipo 2
//   NUÑEZ Martinez Marco Antonio
//   SUÑIGA Maciel Joule Alexander
//   VILLA Olivarez Ariel
// =============================
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
            "COALESCE(e.Condicion, ''), COUNT(e.IdEjemplar) " +
            "FROM Libro l INNER JOIN Autor a ON a.IdAutor = l.IdAutor " +
            "LEFT JOIN Ejemplar e ON e.IdLibro = l.IdLibro AND e.EsActivo = 1 AND e.Disponible = 1 " +
            "WHERE l.EsActivo = 1 ";

        private const string AGRUPAR_Y_ORDENAR =
            " GROUP BY l.IdLibro, l.Titulo, l.Isbn, a.Nombre, a.Apellido, l.Precio, e.Condicion " +
            "ORDER BY l.Titulo, FIELD(e.Condicion, 'Nuevo', 'Bueno', 'Regular', 'Dañado')";

        private static ProductoVenta Convertir(MySqlConnector.MySqlDataReader r)
        {
            return new ProductoVenta
            {
                IdLibro = ConexionBD.Entero(r, 0),
                Titulo = ConexionBD.Texto(r, 1),
                Isbn = ConexionBD.Texto(r, 2),
                Autor = ConexionBD.Texto(r, 3),
                PrecioBase = Convert.ToDecimal(r.GetValue(4)),
                Condicion = ConexionBD.Texto(r, 5),
                Stock = ConexionBD.Entero(r, 6)
            };
        }

        public static List<ProductoVenta> BuscarPorId(int idLibro)
        {
            return ConexionBD.Leer(
                SELECT_PRODUCTO + "AND l.IdLibro = @id" + AGRUPAR_Y_ORDENAR,
                Convertir,
                ConexionBD.P("@id", idLibro));
        }

        public static List<ProductoVenta> BuscarPorNombre(string texto)
        {
            string patron = "%" + EscaparLike((texto ?? string.Empty).Trim()) + "%";

            return ConexionBD.Leer(
                SELECT_PRODUCTO + "AND l.Titulo LIKE @patron" + AGRUPAR_Y_ORDENAR + " LIMIT 200",
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

        public static int ConsultarStock(int idLibro, string condicion)
        {
            if (string.IsNullOrWhiteSpace(condicion))
                return ConsultarStock(idLibro);

            List<int> conteo = ConexionBD.Leer(
                "SELECT COUNT(*) FROM Ejemplar e INNER JOIN Libro l ON l.IdLibro = e.IdLibro " +
                "WHERE e.IdLibro = @id AND e.Condicion = @condicion AND l.EsActivo = 1 AND e.EsActivo = 1 AND e.Disponible = 1",
                r => ConexionBD.Entero(r, 0),
                ConexionBD.P("@id", idLibro),
                ConexionBD.P("@condicion", condicion));

            return conteo.FirstOrDefault();
        }

        private static string EscaparLike(string texto)
        {
            return texto.Replace("\\", "\\\\").Replace("%", "\\%").Replace("_", "\\_");
        }
    }
}
