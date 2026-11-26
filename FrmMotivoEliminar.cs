//   Equipo 2
//   NUÑEZ Martinez Marco Antonio
//   SUÑIGA Maciel Joule Alexander
//   VILLA Olivarez Ariel
// =============================
using System;
using System.Windows.Forms;

namespace SistemaBiblioteca1
{
    public partial class FrmMotivoEliminar : Form
    {
        public string Motivo
        {
            get { return txtMotivo.Text.Trim(); }
        }

        public FrmMotivoEliminar(string idPrestamo)
        {
            InitializeComponent();
            txtMotivo.MaxLength = LimitesCampos.MotivoEliminar;
            lblMotivo.Text = "Motivo de eliminar el préstamo " + idPrestamo + ":";
            FormClosing += FrmMotivoEliminar_FormClosing;
        }

        private void FrmMotivoEliminar_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult == DialogResult.OK && string.IsNullOrWhiteSpace(txtMotivo.Text))
            {
                MessageBox.Show("Escribe un motivo para continuar.", "Motivo requerido",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Cancel = true;
                DialogResult = DialogResult.None;
                txtMotivo.Focus();
            }
        }
    }
}