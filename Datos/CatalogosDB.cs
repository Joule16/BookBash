// ===============================
//   Equipo 2
//   NUÑEZ Martinez Marco Antonio
//   SUÑIGA Maciel Joule Alexander
//   VILLA Olivares Ariel
// ===============================
using System;
using System.Collections.Generic;

namespace SistemaBiblioteca1.Datos
{
    public class ItemCatalogo
    {
        public int Id { get; set; }

        public string Descripcion { get; set; } = string.Empty;

        public override string ToString()
        {
            return Descripcion;
        }
    }

    public static class CatalogosBD
    {
        public static List<ItemCatalogo> ObtenerAutores()
        {
            return ConexionBD.Leer(
                "SELECT IdAutor, CONCAT(Nombre, ' ', Apellido) FROM Autor WHERE EsActivo = 1 ORDER BY Nombre, Apellido",
                r => new ItemCatalogo { Id = ConexionBD.Entero(r, 0), Descripcion = ConexionBD.Texto(r, 1) });
        }

        public static List<ItemCatalogo> ObtenerCategorias()
        {
            return ConexionBD.Leer(
                "SELECT IdCategoria, Nombre FROM Categoria WHERE EsActivo = 1 ORDER BY Nombre",
                r => new ItemCatalogo { Id = ConexionBD.Entero(r, 0), Descripcion = ConexionBD.Texto(r, 1) });
        }

        public static List<ItemCatalogo> ObtenerEditoriales()
        {
            return ConexionBD.Leer(
                "SELECT IdEditorial, Nombre FROM Editorial WHERE EsActivo = 1 ORDER BY Nombre",
                r => new ItemCatalogo { Id = ConexionBD.Entero(r, 0), Descripcion = ConexionBD.Texto(r, 1) });
        }
    }
}