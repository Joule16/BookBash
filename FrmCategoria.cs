//   Equipo 2
//   NUÑEZ Martinez Marco Antonio
//   SUÑIGA Maciel Joule Alexander
//   VILLA Olivarez Ariel
// =============================
using System;
using System.Windows.Forms;
using SistemaBiblioteca1.Models;

namespace SistemaBiblioteca1
{
    public partial class FrmCategoria : FrmBase, IPanelCRUD
    {
        public FrmCategoria()
        {
            InitializeComponent();
            txtNombreCategoria.MaxLength = LimitesCampos.Nombre;
            txtDescripcionCategoria.MaxLength = LimitesCampos.Descripcion;

            ConfigurarCampoLetras(txtNombreCategoria, "Nombre de la categoría");
            ConfigurarCampoLetras(txtDescripcionCategoria, "Descripción", false);
        }

        public void EjecutarGuardar()
        {
            if (!ValidarFormulario())
                return;

            try
            {
                Categoria categoria = CrearCategoriaDesdeControles();
                categoria.InsertarRegistro(categoria);

                MessageBox.Show("Categoría guardada correctamente.", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarControles();
            }
            catch (Exception ex) when (ex is ArgumentException || ex is InvalidOperationException || ex is FormatException)
            {
                MessageBox.Show(ex.Message, "No se pudo guardar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void EjecutarBuscar(string id, ErrorProvider alerta)
        {
            alerta.SetError(txtId, string.Empty);

            try
            {
                Categoria categoria = new Categoria().ConsultarRegistro(id) as Categoria;

                if (categoria == null)
                {
                    MostrarErrorBusqueda(alerta, "No existe una categoría con ese id.");
                    return;
                }

                txtId.Text = categoria.Id.ToString();
                txtNombreCategoria.Text = categoria.Nombre;
                txtDescripcionCategoria.Text = categoria.Descripcion;
                chkRestringidaMenores.Checked = categoria.RestringidaMenores;
                chkEstadoCategoria.Checked = categoria.EsActivo;
            }
            catch (ArgumentException ex)
            {
                MostrarErrorBusqueda(alerta, ex.Message);
            }
        }

        public void EjecutarActualizar()
        {
            if (!ValidarFormulario())
                return;

            try
            {
                Categoria categoria = CrearCategoriaDesdeControles();
                categoria.ActualizarRegistro(categoria);

                MessageBox.Show("Categoría actualizada correctamente.", "Actualizar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex) when (ex is ArgumentException || ex is InvalidOperationException || ex is FormatException)
            {
                MessageBox.Show(ex.Message, "No se pudo actualizar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void EjecutarEliminar(StatusStrip barraEstado)
        {
            if (!ValidarIdObligatorio())
            {
                MostrarEstado(barraEstado, "Escribe o busca el ID del registro que deseas eliminar.");
                return;
            }

            try
            {
                new Categoria().EliminarRegistro(txtId.Text);
                LimpiarControles();
                MostrarEstado(barraEstado, "Categoría eliminada correctamente.");
            }
            catch (Exception ex) when (ex is ArgumentException || ex is InvalidOperationException)
            {
                MessageBox.Show(ex.Message, "No se pudo eliminar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                MostrarEstado(barraEstado, ex.Message);
            }
        }

        private Categoria CrearCategoriaDesdeControles()
        {
            int id = LeerEntero(txtId.Text, "El id de la categoría");

            Categoria categoria = new Categoria()
            {
                Id = id,
                Nombre = txtNombreCategoria.Text,
                Descripcion = txtDescripcionCategoria.Text,
                RestringidaMenores = chkRestringidaMenores.Checked,
                EsActivo = chkEstadoCategoria.Checked
            };

            return categoria;
        }

        private int LeerEntero(string texto, string nombreCampo)
        {
            if (!int.TryParse(texto, out int valor))
                throw new FormatException(nombreCampo + " debe ser un número entero válido.");
            return valor;
        }

        private void LimpiarControles()
        {
            LimpiarErrores();
            txtId.Clear();
            txtNombreCategoria.Clear();
            txtDescripcionCategoria.Clear();
            chkRestringidaMenores.Checked = false;
            chkEstadoCategoria.Checked = false;
        }

        private void MostrarEstado(StatusStrip barraEstado, string mensaje)
        {
            if (barraEstado.Items.Count > 0)
                barraEstado.Items[0].Text = mensaje;
        }

        private void pnlFormularioBase_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}