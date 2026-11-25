// ===============================
//   Equipo #2
//   NUÑEZ Martinez Marco Antonio
//   SUÑIGA Maciel Joule Alexander
//   VILLA Olivares Ariel
// ===============================
using System;

namespace SistemaBiblioteca1.Models
{
    // Resultado de una búsqueda del carrito: un libro con su precio y las existencias que hay ahora.
    // Stock = ejemplares activos y disponibles de ese libro.
    public class ProductoVenta
    {
        public int IdLibro { get; set; }

        public string Titulo { get; set; } = string.Empty;

        public string Isbn { get; set; } = string.Empty;

        public string Autor { get; set; } = string.Empty;

        public decimal Precio { get; set; }

        public int Stock { get; set; }
    }
}
