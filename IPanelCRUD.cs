//   Equipo 2
//   NUÑEZ Martinez Marco Antonio
//   SUÑIGA Maciel Joule Alexander
//   VILLA Olivarez Ariel
// =============================
// Actividad 2.4
using System;
using System.Windows.Forms;

namespace SistemaBiblioteca1
{
    public interface IPanelCRUD
    {
        void EjecutarGuardar();
        void EjecutarBuscar(string id, ErrorProvider alerta);
        void EjecutarActualizar();
        void EjecutarEliminar(StatusStrip barraEstado);
    }
}