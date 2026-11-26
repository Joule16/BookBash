//   Equipo 2
//   NUÑEZ Martinez Marco Antonio
//   SUÑIGA Maciel Joule Alexander
//   VILLA Olivarez Ariel
// =============================
using System;
using System.Drawing;
using System.Windows.Forms;
using SistemaBiblioteca1.Models;

namespace SistemaBiblioteca1
{
    public partial class FrmRegistro : Form
    {
        private const bool CUENTA_ACTIVA_AL_REGISTRARSE = true;
        private const int LONGITUD_ID_UNIVERSITARIO = 9;

        public string CorreoRegistrado { get; private set; } = string.Empty;

        public FrmRegistro()
        {
            InitializeComponent();
            txtNombre.MaxLength = LimitesCampos.Nombre;
            txtApellido.MaxLength = LimitesCampos.Nombre;
            txtCorreo.MaxLength = LimitesCampos.Email;

            TemaPersona3.Aplicar(this);

            lblMensajeRegistro.ForeColor = Color.FromArgb(255, 107, 107);
            lblMensajeRegistro.Text = string.Empty;

            foreach (TextBox caja in new TextBox[] { txtNombre, txtApellido, txtCorreo, txtTelefono,
                                                     txtIdUniversitario, txtContrasenaReg, txtConfirmar })
            {
                caja.TextChanged += (s, e) => lblMensajeRegistro.Text = string.Empty;
            }

            txtTelefono.KeyPress += (s, e) =>
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                    e.Handled = true;
            };

            txtIdUniversitario.MaxLength = LONGITUD_ID_UNIVERSITARIO;
            txtIdUniversitario.KeyPress += (s, e) =>
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                    e.Handled = true;
            };
        }

        private void btnCrearCuenta_Click(object? sender, EventArgs e)
        {
            try
            {
                if (txtContrasenaReg.Text != txtConfirmar.Text)
                    throw new ArgumentException("Las contraseñas no coinciden.");

                ValidarIdUniversitario(txtIdUniversitario.Text.Trim());

                Usuario usuario = new Usuario(SiguienteId(), txtNombre.Text, txtApellido.Text,
                                              txtCorreo.Text, txtTelefono.Text, txtIdUniversitario.Text,
                                              CUENTA_ACTIVA_AL_REGISTRARSE, RolUsuario.Usuario);

                if (ExisteCorreo(usuario.Email))
                    throw new InvalidOperationException("Ya existe una cuenta con ese correo.");

                usuario.EstablecerContrasena(txtContrasenaReg.Text);
                usuario.InsertarRegistro(usuario);

                CorreoRegistrado = usuario.Email;
                DialogResult = DialogResult.OK;
            }
            catch (Exception ex) when (ex is ArgumentException || ex is InvalidOperationException)
            {
                lblMensajeRegistro.Text = ex.Message;
                MessageBox.Show(ex.Message, "No se pudo registrar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private static void ValidarIdUniversitario(string idUniversitario)
        {
            if (idUniversitario.Length == 0)
                throw new ArgumentException("El id universitario no puede estar vacío.");

            if (idUniversitario.Length > LONGITUD_ID_UNIVERSITARIO)
                throw new ArgumentException("El id universitario no puede pasar de " + LONGITUD_ID_UNIVERSITARIO + " dígitos.");

            foreach (char c in idUniversitario)
            {
                if (!char.IsDigit(c))
                    throw new ArgumentException("El id universitario solo debe contener números.");
            }
        }

        private static int SiguienteId()
        {
            int mayor = 0;
            foreach (Usuario u in Usuario.ObtenerTodos())
            {
                if (u.Id > mayor)
                    mayor = u.Id;
            }
            return mayor + 1;
        }

        private static bool ExisteCorreo(string correo)
        {
            foreach (Usuario u in Usuario.ObtenerTodos())
            {
                if (string.Equals(u.Email, correo, StringComparison.OrdinalIgnoreCase))
                    return true;
            }
            return false;
        }
    }
}