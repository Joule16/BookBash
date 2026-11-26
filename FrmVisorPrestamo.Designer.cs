//   Equipo 2
//   NUÑEZ Martinez Marco Antonio
//   SUÑIGA Maciel Joule Alexander
//   VILLA Olivarez Ariel
// =============================
namespace SistemaBiblioteca1
{
    partial class FrmVisorPrestamo
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
            txtVisor = new TextBox();
            btnActualizarVisor = new Button();
            btnCerrarVisor = new Button();
            SuspendLayout();
            // 
            // txtVisor
            // 
            txtVisor.Location = new Point(8, 7);
            txtVisor.Margin = new Padding(2, 2, 2, 2);
            txtVisor.Multiline = true;
            txtVisor.Name = "txtVisor";
            txtVisor.ReadOnly = true;
            txtVisor.ScrollBars = ScrollBars.Vertical;
            txtVisor.Size = new Size(267, 110);
            txtVisor.TabIndex = 0;
            // 
            // btnActualizarVisor
            // 
            btnActualizarVisor.Location = new Point(22, 125);
            btnActualizarVisor.Margin = new Padding(2, 2, 2, 2);
            btnActualizarVisor.Name = "btnActualizarVisor";
            btnActualizarVisor.Size = new Size(78, 20);
            btnActualizarVisor.TabIndex = 1;
            btnActualizarVisor.Text = "Actualizar";
            btnActualizarVisor.UseVisualStyleBackColor = true;
            btnActualizarVisor.Click += btnActualizarVisor_Click;
            // 
            // btnCerrarVisor
            // 
            btnCerrarVisor.Location = new Point(166, 125);
            btnCerrarVisor.Margin = new Padding(2, 2, 2, 2);
            btnCerrarVisor.Name = "btnCerrarVisor";
            btnCerrarVisor.Size = new Size(78, 20);
            btnCerrarVisor.TabIndex = 2;
            btnCerrarVisor.Text = "Cerrar";
            btnCerrarVisor.UseVisualStyleBackColor = true;
            btnCerrarVisor.Click += btnCerrarVisor_Click;
            // 
            // FrmVisorPrestamo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(303, 162);
            Controls.Add(btnCerrarVisor);
            Controls.Add(btnActualizarVisor);
            Controls.Add(txtVisor);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(2, 2, 2, 2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmVisorPrestamo";
            StartPosition = FormStartPosition.Manual;
            Text = "Visor de prestamo";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtVisor;
        private Button btnActualizarVisor;
        private Button btnCerrarVisor;
    }
}