//   Equipo 2
//   NUÑEZ Martinez Marco Antonio
//   SUÑIGA Maciel Joule Alexander
//   VILLA Olivarez Ariel
// =============================
namespace SistemaBiblioteca1
{
    partial class FrmLogin
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            lblTituloLogin = new Label();
            lblUsuario = new Label();
            txtUsuario = new TextBox();
            lblContrasena = new Label();
            txtContrasena = new TextBox();
            lblMensajeLogin = new Label();
            btnIngresar = new BotonPersona3();
            btnSalir = new BotonPersona3();
            btnRegistrarse = new BotonPersona3();
            btnInvitado = new BotonPersona3();
            lblAutoria = new Label();
            SuspendLayout();
            // 
            // lblTituloLogin
            // 
            lblTituloLogin.AutoSize = true;
            lblTituloLogin.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTituloLogin.Location = new Point(24, 15);
            lblTituloLogin.Margin = new Padding(2, 0, 2, 0);
            lblTituloLogin.Name = "lblTituloLogin";
            lblTituloLogin.Size = new Size(147, 30);
            lblTituloLogin.TabIndex = 0;
            lblTituloLogin.Text = "Iniciar sesión";
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Location = new Point(26, 60);
            lblUsuario.Margin = new Padding(2, 0, 2, 0);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(97, 15);
            lblUsuario.TabIndex = 1;
            lblUsuario.Text = "Usuario o correo:";
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(26, 80);
            txtUsuario.Margin = new Padding(2);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(316, 23);
            txtUsuario.TabIndex = 2;
            // 
            // lblContrasena
            // 
            lblContrasena.AutoSize = true;
            lblContrasena.Location = new Point(26, 112);
            lblContrasena.Margin = new Padding(2, 0, 2, 0);
            lblContrasena.Name = "lblContrasena";
            lblContrasena.Size = new Size(70, 15);
            lblContrasena.TabIndex = 3;
            lblContrasena.Text = "Contraseña:";
            // 
            // txtContrasena
            // 
            txtContrasena.Location = new Point(26, 132);
            txtContrasena.Margin = new Padding(2);
            txtContrasena.MaxLength = 64;
            txtContrasena.Name = "txtContrasena";
            txtContrasena.Size = new Size(316, 23);
            txtContrasena.TabIndex = 4;
            txtContrasena.UseSystemPasswordChar = true;
            // 
            // lblMensajeLogin
            // 
            lblMensajeLogin.Location = new Point(26, 160);
            lblMensajeLogin.Margin = new Padding(2, 0, 2, 0);
            lblMensajeLogin.Name = "lblMensajeLogin";
            lblMensajeLogin.Size = new Size(315, 33);
            lblMensajeLogin.TabIndex = 5;
            // 
            // btnIngresar
            // 
            btnIngresar.FlatStyle = FlatStyle.Flat;
            btnIngresar.Font = new Font("Segoe UI", 11F, FontStyle.Bold | FontStyle.Italic);
            btnIngresar.Location = new Point(26, 195);
            btnIngresar.Margin = new Padding(2);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(149, 28);
            btnIngresar.TabIndex = 6;
            btnIngresar.Text = "Ingresar";
            btnIngresar.UseVisualStyleBackColor = true;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // btnSalir
            // 
            btnSalir.DialogResult = DialogResult.Cancel;
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.Font = new Font("Segoe UI", 11F, FontStyle.Bold | FontStyle.Italic);
            btnSalir.Location = new Point(193, 195);
            btnSalir.Margin = new Padding(2);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(149, 28);
            btnSalir.TabIndex = 7;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            // 
            // btnRegistrarse
            // 
            btnRegistrarse.FlatStyle = FlatStyle.Flat;
            btnRegistrarse.Font = new Font("Segoe UI", 11F, FontStyle.Bold | FontStyle.Italic);
            btnRegistrarse.Location = new Point(27, 242);
            btnRegistrarse.Margin = new Padding(2);
            btnRegistrarse.Name = "btnRegistrarse";
            btnRegistrarse.Size = new Size(316, 41);
            btnRegistrarse.TabIndex = 8;
            btnRegistrarse.Text = "¿No tienes cuenta? Regístrate";
            btnRegistrarse.UseVisualStyleBackColor = true;
            btnRegistrarse.Click += btnRegistrarse_Click;
            // 
            // btnInvitado
            // 
            btnInvitado.FlatStyle = FlatStyle.Flat;
            btnInvitado.Font = new Font("Segoe UI", 11F, FontStyle.Bold | FontStyle.Italic);
            btnInvitado.Location = new Point(27, 292);
            btnInvitado.Margin = new Padding(2);
            btnInvitado.Name = "btnInvitado";
            btnInvitado.Size = new Size(316, 41);
            btnInvitado.TabIndex = 10;
            btnInvitado.Text = "Entrar como invitado (solo consulta)";
            btnInvitado.UseVisualStyleBackColor = true;
            btnInvitado.Click += btnInvitado_Click;
            // 
            // lblAutoria
            // 
            lblAutoria.Location = new Point(27, 340);
            lblAutoria.Margin = new Padding(2, 0, 2, 0);
            lblAutoria.Name = "lblAutoria";
            lblAutoria.Size = new Size(315, 69);
            lblAutoria.TabIndex = 9;
            lblAutoria.Text = "Equipo #2\r\nNUÑEZ Martinez Marco Antonio\r\nSUÑIGA Maciel Joule Alexander\r\nVILLA Olivarez Ariel";
            // 
            // FrmLogin
            // 
            AcceptButton = btnIngresar;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnSalir;
            ClientSize = new Size(368, 418);
            Controls.Add(lblTituloLogin);
            Controls.Add(lblUsuario);
            Controls.Add(txtUsuario);
            Controls.Add(lblContrasena);
            Controls.Add(txtContrasena);
            Controls.Add(lblMensajeLogin);
            Controls.Add(btnIngresar);
            Controls.Add(btnSalir);
            Controls.Add(btnRegistrarse);
            Controls.Add(btnInvitado);
            Controls.Add(lblAutoria);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Iniciar sesión";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTituloLogin;
        private Label lblUsuario;
        private TextBox txtUsuario;
        private Label lblContrasena;
        private TextBox txtContrasena;
        private Label lblMensajeLogin;
        private BotonPersona3 btnIngresar;
        private BotonPersona3 btnSalir;
        private BotonPersona3 btnRegistrarse;
        private BotonPersona3 btnInvitado;
        private Label lblAutoria;
    }
}