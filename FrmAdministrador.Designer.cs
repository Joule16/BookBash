//   Equipo 2
//   NUÑEZ Martinez Marco Antonio
//   SUÑIGA Maciel Joule Alexander
//   VILLA Olivarez Ariel
// =============================
namespace SistemaBiblioteca1
{
    partial class FrmAdministrador
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }


        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblNombreAdmin = new Label();
            lblApellidoAdmin = new Label();
            lblUsuarioAdmin = new Label();
            lblContrasena = new Label();
            lblNivelAcceso = new Label();
            chkEstadoAdmin = new CheckBox();
            txtNombreAdmin = new TextBox();
            txtApellidoAdmin = new TextBox();
            txtUsuarioAcceso = new TextBox();
            txtContrasena = new TextBox();
            cmbNivelAcceso = new ComboBox();
            pnlFormularioBase.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)epValidaciones).BeginInit();
            SuspendLayout();
            // 
            // pnlFormularioBase
            // 
            pnlFormularioBase.Controls.Add(txtUsuarioAcceso);
            pnlFormularioBase.Controls.Add(txtApellidoAdmin);
            pnlFormularioBase.Controls.Add(chkEstadoAdmin);
            pnlFormularioBase.Controls.Add(txtNombreAdmin);
            pnlFormularioBase.Controls.Add(lblNivelAcceso);
            pnlFormularioBase.Controls.Add(lblUsuarioAdmin);
            pnlFormularioBase.Controls.Add(lblNombreAdmin);
            pnlFormularioBase.Controls.Add(lblApellidoAdmin);
            pnlFormularioBase.Controls.Add(cmbNivelAcceso);
            pnlFormularioBase.Controls.Add(lblContrasena);
            pnlFormularioBase.Controls.Add(txtContrasena);
            pnlFormularioBase.Size = new Size(544, 235);
            pnlFormularioBase.Controls.SetChildIndex(txtId, 0);
            pnlFormularioBase.Controls.SetChildIndex(lblId, 0);
            pnlFormularioBase.Controls.SetChildIndex(txtContrasena, 0);
            pnlFormularioBase.Controls.SetChildIndex(lblContrasena, 0);
            pnlFormularioBase.Controls.SetChildIndex(cmbNivelAcceso, 0);
            pnlFormularioBase.Controls.SetChildIndex(lblApellidoAdmin, 0);
            pnlFormularioBase.Controls.SetChildIndex(lblNombreAdmin, 0);
            pnlFormularioBase.Controls.SetChildIndex(lblUsuarioAdmin, 0);
            pnlFormularioBase.Controls.SetChildIndex(lblNivelAcceso, 0);
            pnlFormularioBase.Controls.SetChildIndex(txtNombreAdmin, 0);
            pnlFormularioBase.Controls.SetChildIndex(chkEstadoAdmin, 0);
            pnlFormularioBase.Controls.SetChildIndex(txtApellidoAdmin, 0);
            pnlFormularioBase.Controls.SetChildIndex(txtUsuarioAcceso, 0);
            // 
            // lblNombreAdmin
            // 
            lblNombreAdmin.AutoSize = true;
            lblNombreAdmin.Location = new Point(14, 57);
            lblNombreAdmin.Name = "lblNombreAdmin";
            lblNombreAdmin.Size = new Size(54, 15);
            lblNombreAdmin.TabIndex = 0;
            lblNombreAdmin.Text = "Nombre:";
            // 
            // lblApellidoAdmin
            // 
            lblApellidoAdmin.AutoSize = true;
            lblApellidoAdmin.Location = new Point(14, 96);
            lblApellidoAdmin.Name = "lblApellidoAdmin";
            lblApellidoAdmin.Size = new Size(54, 15);
            lblApellidoAdmin.TabIndex = 1;
            lblApellidoAdmin.Text = "Apellido:";
            // 
            // lblUsuarioAdmin
            // 
            lblUsuarioAdmin.AutoSize = true;
            lblUsuarioAdmin.Location = new Point(14, 135);
            lblUsuarioAdmin.Name = "lblUsuarioAdmin";
            lblUsuarioAdmin.Size = new Size(50, 15);
            lblUsuarioAdmin.TabIndex = 2;
            lblUsuarioAdmin.Text = "Usuario:";
            // 
            // lblContrasena
            // 
            lblContrasena.AutoSize = true;
            lblContrasena.Location = new Point(14, 171);
            lblContrasena.Name = "lblContrasena";
            lblContrasena.Size = new Size(70, 15);
            lblContrasena.TabIndex = 3;
            lblContrasena.Text = "Contraseña:";
            // 
            // lblNivelAcceso
            // 
            lblNivelAcceso.AutoSize = true;
            lblNivelAcceso.Location = new Point(14, 207);
            lblNivelAcceso.Name = "lblNivelAcceso";
            lblNivelAcceso.Size = new Size(109, 15);
            lblNivelAcceso.TabIndex = 4;
            lblNivelAcceso.Text = "Nivel Acceso (1-3): ";
            // 
            // chkEstadoAdmin
            // 
            chkEstadoAdmin.AutoSize = true;
            chkEstadoAdmin.Location = new Point(263, 203);
            chkEstadoAdmin.Margin = new Padding(3, 2, 3, 2);
            chkEstadoAdmin.Name = "chkEstadoAdmin";
            chkEstadoAdmin.Size = new Size(60, 19);
            chkEstadoAdmin.TabIndex = 5;
            chkEstadoAdmin.Text = "Activo";
            chkEstadoAdmin.UseVisualStyleBackColor = true;
            // 
            // txtNombreAdmin
            // 
            txtNombreAdmin.Location = new Point(161, 49);
            txtNombreAdmin.Margin = new Padding(3, 2, 3, 2);
            txtNombreAdmin.Name = "txtNombreAdmin";
            txtNombreAdmin.Size = new Size(162, 23);
            txtNombreAdmin.TabIndex = 6;
            // 
            // txtApellidoAdmin
            // 
            txtApellidoAdmin.Location = new Point(161, 88);
            txtApellidoAdmin.Margin = new Padding(3, 2, 3, 2);
            txtApellidoAdmin.Name = "txtApellidoAdmin";
            txtApellidoAdmin.Size = new Size(162, 23);
            txtApellidoAdmin.TabIndex = 7;
            // 
            // txtUsuarioAcceso
            // 
            txtUsuarioAcceso.Location = new Point(161, 127);
            txtUsuarioAcceso.Margin = new Padding(3, 2, 3, 2);
            txtUsuarioAcceso.Name = "txtUsuarioAcceso";
            txtUsuarioAcceso.Size = new Size(162, 23);
            txtUsuarioAcceso.TabIndex = 8;
            // 
            // txtContrasena
            // 
            txtContrasena.Location = new Point(161, 163);
            txtContrasena.Margin = new Padding(3, 2, 3, 2);
            txtContrasena.Name = "txtContrasena";
            txtContrasena.Size = new Size(162, 23);
            txtContrasena.TabIndex = 9;
            txtContrasena.UseSystemPasswordChar = true;
            // 
            // cmbNivelAcceso
            // 
            cmbNivelAcceso.FormattingEnabled = true;
            cmbNivelAcceso.Items.AddRange(new object[] { "1", "2", "3" });
            cmbNivelAcceso.Location = new Point(159, 201);
            cmbNivelAcceso.Margin = new Padding(3, 2, 3, 2);
            cmbNivelAcceso.Name = "cmbNivelAcceso";
            cmbNivelAcceso.Size = new Size(68, 23);
            cmbNivelAcceso.TabIndex = 10;
            // 
            // FrmAdministrador
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(544, 235);
            Name = "FrmAdministrador";
            Text = "FrmAdministrador";
            pnlFormularioBase.ResumeLayout(false);
            pnlFormularioBase.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)epValidaciones).EndInit();
            ResumeLayout(false);
        }

        private Label lblNombreAdmin;
        private Label lblApellidoAdmin;
        private Label lblUsuarioAdmin;
        private Label lblContrasena;
        private Label lblNivelAcceso;
        private CheckBox chkEstadoAdmin;
        private TextBox txtNombreAdmin;
        private TextBox txtApellidoAdmin;
        private TextBox txtUsuarioAcceso;
        private TextBox txtContrasena;
        private ComboBox cmbNivelAcceso;
    }
}