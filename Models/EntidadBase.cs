//   Equipo 2
//   NUÑEZ Martinez Marco Antonio
//   SUÑIGA Maciel Joule Alexander
//   VILLA Olivarez Ariel
// =============================
using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaBiblioteca1.Models
{
    public abstract class EntidadBase
    {
        private int _id;

        public int Id
        {
            get => _id;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("El identificador no puede ser un numero negativo.");
                }
                _id = value;
            }
        }

        public DateTime FechaRegistro { get; set; } = DateTime.Now;

        public bool EsActivo { get; set; } = true;

        protected EntidadBase()
        {
        }

        protected EntidadBase(int id)
        {
            Id = id;
        }
    }
}