//   Equipo 2
//   NUÑEZ Martinez Marco Antonio
//   SUÑIGA Maciel Joule Alexander
//   VILLA Olivarez Ariel
// =============================
using System;

namespace SistemaBiblioteca1.Models
{
    public static class PoliticaDescuento
    {
        public static decimal Porcentaje(string? condicion)
        {
            switch ((condicion ?? string.Empty).Trim())
            {
                case "Bueno":   return 15m;
                case "Regular": return 30m;
                case "Dañado":  return 50m;
                default:        return 0m;
            }
        }

        public static decimal Aplicar(decimal precioBase, string? condicion)
        {
            decimal descuento = Porcentaje(condicion);
            return Math.Round(precioBase * (100m - descuento) / 100m, 2, MidpointRounding.AwayFromZero);
        }

        public static string Etiqueta(string? condicion)
        {
            decimal p = Porcentaje(condicion);
            return p > 0 ? "-" + p.ToString("0.##") + "%" : "—";
        }
    }
}
