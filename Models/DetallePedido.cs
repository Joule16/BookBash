// ===============================
//   Equipo #2
//   NUÑEZ Martinez Marco Antonio
//   SUÑIGA Maciel Joule Alexander
//   VILLA Olivares Ariel
// ===============================
using System;

namespace SistemaBiblioteca1.Models
{
    // Línea temporal del carrito (aún no se guarda en la base de datos).
    // El carrito es una List<DetallePedido> que vive en la vista.
    public class DetallePedido
    {
        private int cantidad;
        private decimal precioUnitario;

        public int IdLibro { get; }

        public string Titulo { get; }

        public int Cantidad
        {
            get { return cantidad; }
            set
            {
                if (value <= 0)
                    throw new ArgumentException("La cantidad debe ser un entero mayor a cero.");
                cantidad = value;
            }
        }

        public decimal PrecioUnitario
        {
            get { return precioUnitario; }
            set
            {
                if (value < 0)
                    throw new ArgumentException("El precio unitario no puede ser negativo.");
                precioUnitario = value;
            }
        }

        public decimal Subtotal
        {
            get { return CalcularSubtotal(); }
        }

        public DetallePedido(int idLibro, string titulo, decimal precioUnitario, int cantidad)
        {
            if (idLibro < 0)
                throw new ArgumentException("El id del libro no es válido.");
            if (string.IsNullOrWhiteSpace(titulo))
                throw new ArgumentException("El título no puede estar vacío.");

            IdLibro = idLibro;
            Titulo = titulo.Trim();
            PrecioUnitario = precioUnitario;
            Cantidad = cantidad;
        }

        // ===============================
        //   Equipo #2
        //   NUÑEZ Martinez Marco Antonio
        //   SUÑIGA Maciel Joule Alexander
        //   VILLA Olivares Ariel
        // ===============================
        // Subtotal de la línea = Cantidad x Precio unitario (redondeado a centavos).
        public decimal CalcularSubtotal()
        {
            return Math.Round(cantidad * precioUnitario, 2);
        }
    }
}
