//   Equipo 2
//   NUÑEZ Martinez Marco Antonio
//   SUÑIGA Maciel Joule Alexander
//   VILLA Olivarez Ariel
// =============================
using System;

namespace SistemaBiblioteca1.Models
{
    public class DetallePedido
    {
        private int cantidad;
        private decimal precioUnitario;

        public int IdLibro { get; }

        public string Titulo { get; }

        public string Condicion { get; }

        public decimal PrecioBase { get; }

        public string Descripcion
        {
            get { return string.IsNullOrEmpty(Condicion) ? Titulo : Titulo + " [" + Condicion + "]"; }
        }

        public decimal Ahorro
        {
            get { return Math.Round(cantidad * (PrecioBase - precioUnitario), 2); }
        }

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

        public DetallePedido(int idLibro, string titulo, string condicion, decimal precioBase, int cantidad)
            : this(idLibro, titulo, PoliticaDescuento.Aplicar(precioBase, condicion), cantidad)
        {
            Condicion = (condicion ?? string.Empty).Trim();
            PrecioBase = precioBase;
        }

        public DetallePedido(int idLibro, string titulo, decimal precioUnitario, int cantidad)
        {
            if (idLibro < 0)
                throw new ArgumentException("El id del libro no es válido.");
            if (string.IsNullOrWhiteSpace(titulo))
                throw new ArgumentException("El título no puede estar vacío.");

            IdLibro = idLibro;
            Titulo = titulo.Trim();
            Condicion = string.Empty;
            PrecioBase = precioUnitario;
            PrecioUnitario = precioUnitario;
            Cantidad = cantidad;
        }

        public decimal CalcularSubtotal()
        {
            return Math.Round(cantidad * precioUnitario, 2);
        }
    }
}
