//   Equipo #2
//   NUÑEZ Martinez Marco Antonio
//   SUÑIGA Maciel Joule Alexander
//   VILLA Olivarez Ariel
// ===============================
using System;
using System.Drawing;
using System.Windows.Forms;
using SistemaBiblioteca1.Models;

namespace SistemaBiblioteca1
{
    public class FrmPerfil : Form
    {
        private const int LONGITUD_ID_UNIVERSITARIO = 9;

        private readonly Label lblTitulo = new Label();

        private readonly Label lblIdUsuario = new Label();
        private readonly TextBox txtIdUsuario = new TextBox();
        private readonly Label lblIdUniversitario = new Label();
        private readonly TextBox txtIdUniversitario = new TextBox();

        private readonly Label lblNombre = new Label();
        private readonly TextBox txtNombre = new TextBox();
        private readonly Label lblApellido = new Label();
        private readonly TextBox txtApellido = new TextBox();
        private readonly Label lblCorreo = new Label();
        private readonly TextBox txtCorreo = new TextBox();
        private readonly Label lblTelefono = new Label();
        private readonly TextBox txtTelefono = new TextBox();

        private readonly PictureBox pbxFoto = new PictureBox();
        private readonly BotonPersona3 btnElegirFoto = new BotonPersona3();
        private readonly BotonPersona3 btnQuitarFoto = new BotonPersona3();
        private readonly BotonPersona3 btnGuardarPerfil = new BotonPersona3();
        private readonly Label lblMensaje = new Label();

        private string? fotoNuevaOrigen;  
        private bool quitarFoto;           

        public FrmPerfil()
        {
            Text = "Perfil";
            ClientSize = new Size(860, 480);
            Font = new Font("Segoe UI", 10F);

            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblTitulo.Location = new Point(16, 12);
            lblTitulo.Text = "Mi perfil";

            Colocar(lblIdUsuario, txtIdUsuario, "ID de usuario:", 24, 60, 150);
            Colocar(lblIdUniversitario, txtIdUniversitario, "ID universitario:", 330, 60, 200);
            txtIdUsuario.ReadOnly = true;
            txtIdUniversitario.MaxLength = LONGITUD_ID_UNIVERSITARIO;
            txtIdUniversitario.KeyPress += SoloDigitos;

            Colocar(lblNombre, txtNombre, "Nombre:", 24, 130, 260);
            Colocar(lblApellido, txtApellido, "Apellido:", 330, 130, 260);
            Colocar(lblCorreo, txtCorreo, "Correo (no editable):", 24, 200, 260);
            txtCorreo.ReadOnly = true;
            Colocar(lblTelefono, txtTelefono, "Teléfono:", 330, 200, 260);
            txtTelefono.KeyPress += SoloDigitos;

            pbxFoto.Location = new Point(660, 60);
            pbxFoto.Size = new Size(170, 170);
            pbxFoto.SizeMode = PictureBoxSizeMode.Zoom;
            pbxFoto.BorderStyle = BorderStyle.FixedSingle;

            btnElegirFoto.Location = new Point(660, 240);
            btnElegirFoto.Size = new Size(170, 36);
            btnElegirFoto.Text = "Elegir fotografía";
            btnElegirFoto.Click += btnElegirFoto_Click;

            btnQuitarFoto.Location = new Point(660, 284);
            btnQuitarFoto.Size = new Size(170, 36);
            btnQuitarFoto.Text = "Quitar fotografía";
            btnQuitarFoto.Click += btnQuitarFoto_Click;

            btnGuardarPerfil.Location = new Point(24, 290);
            btnGuardarPerfil.Size = new Size(220, 40);
            btnGuardarPerfil.Text = "Guardar cambios";
            btnGuardarPerfil.Click += btnGuardarPerfil_Click;

            lblMensaje.Location = new Point(24, 346);
            lblMensaje.Size = new Size(806, 60);

            Controls.AddRange(new Control[]
            {
                lblTitulo, pbxFoto, btnElegirFoto, btnQuitarFoto, btnGuardarPerfil, lblMensaje
            });

            foreach (Control c in Controls)
                c.Anchor = AnchorStyles.Top | AnchorStyles.Left;
        }

        private void Colocar(Label etiqueta, TextBox caja, string texto, int x, int y, int ancho)
        {
            etiqueta.AutoSize = true;
            etiqueta.Location = new Point(x, y);
            etiqueta.Text = texto;
            caja.Location = new Point(x, y + 26);
            caja.Size = new Size(ancho, 27);
            caja.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            etiqueta.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            Controls.Add(etiqueta);
            Controls.Add(caja);
        }

        private static void SoloDigitos(object? sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            CargarPerfil();
        }

        private void CargarPerfil()
        {
            Usuario? yo = Sesion.UsuarioActual;
            if (yo == null)
            {
                foreach (Control c in new Control[] { txtIdUniversitario, txtNombre, txtApellido, txtTelefono,
                                                      btnElegirFoto, btnQuitarFoto, btnGuardarPerfil })
                    c.Enabled = false;

                MostrarMensaje("Tu sesión de demostración no tiene una cuenta registrada.\n" +
                               "Entra con una cuenta creada en «Regístrate» para tener perfil.", true);
                return;
            }

            txtIdUsuario.Text = yo.Id.ToString();
            txtIdUniversitario.Text = yo.IdUniversitario;
            txtNombre.Text = yo.Nombre;
            txtApellido.Text = yo.Apellido;
            txtCorreo.Text = yo.Email;
            txtTelefono.Text = yo.Telefono;
            GestorImagenes.CargarGuardada(pbxFoto, yo.RutaImagen);
        }

        private void btnElegirFoto_Click(object? sender, EventArgs e)
        {
            string? origen = GestorImagenes.SeleccionarImagen();
            if (origen == null)
                return;

            if (GestorImagenes.MostrarVistaPrevia(pbxFoto, origen))
            {
                fotoNuevaOrigen = origen;
                quitarFoto = false;
                MostrarMensaje("Foto lista. Pulsa «Guardar cambios» para conservarla.", false);
            }
            else
            {
                MostrarMensaje("No se pudo abrir esa imagen.", true);
            }
        }

        private void btnQuitarFoto_Click(object? sender, EventArgs e)
        {
            fotoNuevaOrigen = null;
            quitarFoto = true;
            GestorImagenes.CargarGuardada(pbxFoto, string.Empty);
            MostrarMensaje("Foto quitada. Pulsa «Guardar cambios» para confirmar.", false);
        }

        private void btnGuardarPerfil_Click(object? sender, EventArgs e)
        {
            Usuario? yo = Sesion.UsuarioActual;
            if (yo == null)
                return;

            string nombreAnt = yo.Nombre, apellidoAnt = yo.Apellido,
                   telefonoAnt = yo.Telefono, idUniAnt = yo.IdUniversitario,
                   rutaAnt = yo.RutaImagen;

            try
            {
                string idUni = txtIdUniversitario.Text.Trim();
                if (idUni.Length != LONGITUD_ID_UNIVERSITARIO)
                    throw new ArgumentException("El ID universitario debe tener exactamente " +
                                                LONGITUD_ID_UNIVERSITARIO + " dígitos.");

                yo.Nombre = txtNombre.Text;
                yo.Apellido = txtApellido.Text;
                yo.Telefono = txtTelefono.Text;
                yo.IdUniversitario = idUni;

                if (fotoNuevaOrigen != null)
                {
                    string? ruta = GestorImagenes.GuardarImagen(fotoNuevaOrigen, "usuario_" + yo.Id, rutaAnt);
                    if (ruta == null)
                        throw new InvalidOperationException("No se pudo guardar la fotografía.");
                    yo.RutaImagen = ruta;
                }
                else if (quitarFoto)
                {
                    GestorImagenes.EliminarImagen(rutaAnt);
                    yo.RutaImagen = string.Empty;
                }

                yo.ActualizarRegistro(yo);

                fotoNuevaOrigen = null;
                quitarFoto = false;
                MostrarMensaje("Perfil actualizado.", false);
            }
            catch (Exception ex) when (ex is ArgumentException || ex is InvalidOperationException)
            {
                yo.Nombre = nombreAnt;
                yo.Apellido = apellidoAnt;
                yo.Telefono = telefonoAnt;
                yo.IdUniversitario = idUniAnt;
                yo.RutaImagen = rutaAnt;
                MostrarMensaje(ex.Message.Replace("\n", " "), true);
            }
        }

        private void MostrarMensaje(string mensaje, bool esError)
        {
            lblMensaje.ForeColor = esError ? Color.FromArgb(255, 107, 107) : Color.FromArgb(0, 212, 255);
            lblMensaje.Text = mensaje;
        }
    }
}
