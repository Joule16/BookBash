//   Equipo 2
//   NUÑEZ Martinez Marco Antonio
//   SUÑIGA Maciel Joule Alexander
//   VILLA Olivarez Ariel
// =============================
namespace SistemaBiblioteca1
{
    partial class FrmEditorialcs
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblNombreEditorial = new Label();
            lblPaisOrigen = new Label();
            lblAnioFundacion = new Label();
            txtNombreEditorial = new TextBox();
            txtPaisOrigen = new TextBox();
            txtAnioFundacion = new TextBox();
            chkEstadoEditorial = new CheckBox();
            pnlFormularioBase.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)epValidaciones).BeginInit();
            SuspendLayout();
            // 
            // pnlFormularioBase
            // 
            pnlFormularioBase.Controls.Add(lblNombreEditorial);
            pnlFormularioBase.Controls.Add(txtNombreEditorial);
            pnlFormularioBase.Controls.Add(lblPaisOrigen);
            pnlFormularioBase.Controls.Add(txtPaisOrigen);
            pnlFormularioBase.Controls.Add(lblAnioFundacion);
            pnlFormularioBase.Controls.Add(txtAnioFundacion);
            pnlFormularioBase.Controls.Add(chkEstadoEditorial);
            pnlFormularioBase.Size = new Size(544, 235);
            pnlFormularioBase.Controls.SetChildIndex(chkEstadoEditorial, 0);
            pnlFormularioBase.Controls.SetChildIndex(txtAnioFundacion, 0);
            pnlFormularioBase.Controls.SetChildIndex(lblAnioFundacion, 0);
            pnlFormularioBase.Controls.SetChildIndex(txtPaisOrigen, 0);
            pnlFormularioBase.Controls.SetChildIndex(lblPaisOrigen, 0);
            pnlFormularioBase.Controls.SetChildIndex(txtNombreEditorial, 0);
            pnlFormularioBase.Controls.SetChildIndex(lblNombreEditorial, 0);
            pnlFormularioBase.Controls.SetChildIndex(txtId, 0);
            pnlFormularioBase.Controls.SetChildIndex(lblId, 0);
            // 
            // lblId
            // 
            lblId.Location = new Point(21, 26);
            // 
            // txtId
            // 
            txtId.Location = new Point(168, 18);
            // 
            // lblNombreEditorial
            // 
            lblNombreEditorial.AutoSize = true;
            lblNombreEditorial.Location = new Point(21, 64);
            lblNombreEditorial.Name = "lblNombreEditorial";
            lblNombreEditorial.Size = new Size(54, 15);
            lblNombreEditorial.TabIndex = 0;
            lblNombreEditorial.Text = "Nombre:";
            // 
            // lblPaisOrigen
            // 
            lblPaisOrigen.AutoSize = true;
            lblPaisOrigen.Location = new Point(21, 100);
            lblPaisOrigen.Name = "lblPaisOrigen";
            lblPaisOrigen.Size = new Size(84, 15);
            lblPaisOrigen.TabIndex = 1;
            lblPaisOrigen.Text = "Pais de origen:";
            // 
            // lblAnioFundacion
            // 
            lblAnioFundacion.AutoSize = true;
            lblAnioFundacion.Location = new Point(21, 137);
            lblAnioFundacion.Name = "lblAnioFundacion";
            lblAnioFundacion.Size = new Size(105, 15);
            lblAnioFundacion.TabIndex = 2;
            lblAnioFundacion.Text = "Año de fundación:";
            // 
            // txtNombreEditorial
            // 
            txtNombreEditorial.Location = new Point(168, 56);
            txtNombreEditorial.Margin = new Padding(3, 2, 3, 2);
            txtNombreEditorial.Name = "txtNombreEditorial";
            txtNombreEditorial.Size = new Size(162, 23);
            txtNombreEditorial.TabIndex = 3;
            // 
            // txtPaisOrigen
            // 
            txtPaisOrigen.Location = new Point(168, 92);
            txtPaisOrigen.Margin = new Padding(3, 2, 3, 2);
            txtPaisOrigen.Name = "txtPaisOrigen";
            txtPaisOrigen.Size = new Size(162, 23);
            txtPaisOrigen.TabIndex = 4;
            // 
            // txtAnioFundacion
            // 
            txtAnioFundacion.Location = new Point(168, 129);
            txtAnioFundacion.Margin = new Padding(3, 2, 3, 2);
            txtAnioFundacion.MaxLength = 4;
            txtAnioFundacion.Name = "txtAnioFundacion";
            txtAnioFundacion.PlaceholderText = "2007";
            txtAnioFundacion.Size = new Size(47, 23);
            txtAnioFundacion.TabIndex = 5;
            // 
            // chkEstadoEditorial
            // 
            chkEstadoEditorial.AutoSize = true;
            chkEstadoEditorial.Location = new Point(379, 58);
            chkEstadoEditorial.Margin = new Padding(3, 2, 3, 2);
            chkEstadoEditorial.Name = "chkEstadoEditorial";
            chkEstadoEditorial.Size = new Size(59, 19);
            chkEstadoEditorial.TabIndex = 6;
            chkEstadoEditorial.Text = "Activa";
            chkEstadoEditorial.UseVisualStyleBackColor = true;
            // 
            // FrmEditorialcs
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(544, 235);
            Name = "FrmEditorialcs";
            Text = "FrmEditorialcs";
            pnlFormularioBase.ResumeLayout(false);
            pnlFormularioBase.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)epValidaciones).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label lblNombreEditorial;
        private Label lblPaisOrigen;
        private Label lblAnioFundacion;
        private TextBox txtNombreEditorial;
        private TextBox txtPaisOrigen;
        private TextBox txtAnioFundacion;
        private CheckBox chkEstadoEditorial;
    }
}