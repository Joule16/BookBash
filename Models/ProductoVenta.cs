//   Equipo 2
//   NUÑEZ Martinez Marco Antonio
//   SUÑIGA Maciel Joule Alexander
//   VILLA Olivarez Ariel
// =============================
using System;

namespace SistemaBiblioteca1.Models
{
    public class ProductoVenta
    {
        public int IdLibro { get; set; }

        public string Titulo { get; set; } = string.Empty;

        public string Isbn { get; set; } = string.Empty;

        public string Autor { get; set; } = string.Empty;

        public decimal PrecioBase { get; set; }

        public string Condicion { get; set; } = string.Empty;

        public decimal DescuentoPorcentaje
        {
            get { return PoliticaDescuento.Porcentaje(Condicion); }
        }

        public decimal Precio
        {
            get { return PoliticaDescuento.Aplicar(PrecioBase, Condicion); }
        }

        public int Stock { get; set; }
    }
}
