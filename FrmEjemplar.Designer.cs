//   Equipo 2
//   NUÑEZ Martinez Marco Antonio
//   SUÑIGA Maciel Joule Alexander
//   VILLA Olivarez Ariel
// =============================
namespace SistemaBiblioteca1
{
    partial class FrmEjemplar
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
            lblIdLibroEjemplar = new Label();
            lblCodigoInventario = new Label();
            txtIdLIbroEjemplar = new TextBox();
            txtCodigoInventario = new TextBox();
            lblCondicion = new Label();
            chkDisponible = new CheckBox();
            chkEstadoEjemplar = new CheckBox();
            cmbCondicion = new ComboBox();
            pnlFormularioBase.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)epValidaciones).BeginInit();
            SuspendLayout();
            // 
            // pnlFormularioBase
            // 
            pnlFormularioBase.Controls.Add(cmbCondicion);
            pnlFormularioBase.Controls.Add(txtCodigoInventario);
            pnlFormularioBase.Controls.Add(chkDisponible);
            pnlFormularioBase.Controls.Add(lblCondicion);
            pnlFormularioBase.Controls.Add(chkEstadoEjemplar);
            pnlFormularioBase.Controls.Add(txtIdLIbroEjemplar);
            pnlFormularioBase.Controls.Add(lblCodigoInventario);
            pnlFormularioBase.Controls.Add(lblIdLibroEjemplar);
            pnlFormularioBase.Size = new Size(544, 235);
            pnlFormularioBase.Controls.SetChildIndex(txtId, 0);
            pnlFormularioBase.Controls.SetChildIndex(lblId, 0);
            pnlFormularioBase.Controls.SetChildIndex(lblIdLibroEjemplar, 0);
            pnlFormularioBase.Controls.SetChildIndex(lblCodigoInventario, 0);
            pnlFormularioBase.Controls.SetChildIndex(txtIdLIbroEjemplar, 0);
            pnlFormularioBase.Controls.SetChildIndex(chkEstadoEjemplar, 0);
            pnlFormularioBase.Controls.SetChildIndex(lblCondicion, 0);
            pnlFormularioBase.Controls.SetChildIndex(chkDisponible, 0);
            pnlFormularioBase.Controls.SetChildIndex(txtCodigoInventario, 0);
            pnlFormularioBase.Controls.SetChildIndex(cmbCondicion, 0);
            // 
            // lblId
            // 
            lblId.Location = new Point(14, 36);
            // 
            // txtId
            // 
            txtId.Location = new Point(149, 28);
            // 
            // lblIdLibroEjemplar
            // 
            lblIdLibroEjemplar.AutoSize = true;
            lblIdLibroEjemplar.Location = new Point(14, 74);
            lblIdLibroEjemplar.Name = "lblIdLibroEjemplar";
            lblIdLibroEjemplar.Size = new Size(51, 15);
            lblIdLibroEjemplar.TabIndex = 0;
            lblIdLibroEjemplar.Text = "ID Libro:";
            // 
            // lblCodigoInventario
            // 
            lblCodigoInventario.AutoSize = true;
            lblCodigoInventario.Location = new Point(10, 105);
            lblCodigoInventario.Name = "lblCodigoInventario";
            lblCodigoInventario.Size = new Size(105, 15);
            lblCodigoInventario.TabIndex = 1;
            lblCodigoInventario.Text = "Codigo Inventario:";
            // 
            // txtIdLIbroEjemplar
            // 
            txtIdLIbroEjemplar.Location = new Point(149, 66);
            txtIdLIbroEjemplar.Margin = new Padding(3, 2, 3, 2);
            txtIdLIbroEjemplar.Name = "txtIdLIbroEjemplar";
            txtIdLIbroEjemplar.Size = new Size(162, 23);
            txtIdLIbroEjemplar.TabIndex = 2;
            // 
            // txtCodigoInventario
            // 
            txtCodigoInventario.Location = new Point(149, 97);
            txtCodigoInventario.Margin = new Padding(3, 2, 3, 2);
            txtCodigoInventario.Name = "txtCodigoInventario";
            txtCodigoInventario.Size = new Size(162, 23);
            txtCodigoInventario.TabIndex = 3;
            // 
            // lblCondicion
            // 
            lblCondicion.AutoSize = true;
            lblCondicion.Location = new Point(10, 140);
            lblCondicion.Name = "lblCondicion";
            lblCondicion.Size = new Size(65, 15);
            lblCondicion.TabIndex = 4;
            lblCondicion.Text = "Condición:";
            // 
            // chkDisponible
            // 
            chkDisponible.AutoSize = true;
            chkDisponible.Location = new Point(149, 169);
            chkDisponible.Margin = new Padding(3, 2, 3, 2);
            chkDisponible.Name = "chkDisponible";
            chkDisponible.Size = new Size(82, 19);
            chkDisponible.TabIndex = 6;
            chkDisponible.Text = "Disponible";
            chkDisponible.UseVisualStyleBackColor = true;
            // 
            // chkEstadoEjemplar
            // 
            chkEstadoEjemplar.AutoSize = true;
            chkEstadoEjemplar.Location = new Point(251, 169);
            chkEstadoEjemplar.Margin = new Padding(3, 2, 3, 2);
            chkEstadoEjemplar.Name = "chkEstadoEjemplar";
            chkEstadoEjemplar.RightToLeft = RightToLeft.No;
            chkEstadoEjemplar.Size = new Size(60, 19);
            chkEstadoEjemplar.TabIndex = 7;
            chkEstadoEjemplar.Text = "Activo";
            chkEstadoEjemplar.UseVisualStyleBackColor = true;
            // 
            // cmbCondicion
            // 
            cmbCondicion.FormattingEnabled = true;
            cmbCondicion.Items.AddRange(new object[] { "Nuevo", "Bueno", "Regular", "Dañado" });
            cmbCondicion.Location = new Point(149, 132);
            cmbCondicion.Margin = new Padding(3, 2, 3, 2);
            cmbCondicion.Name = "cmbCondicion";
            cmbCondicion.Size = new Size(162, 23);
            cmbCondicion.TabIndex = 8;
            // 
            // FrmEjemplar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(544, 235);
            Name = "FrmEjemplar";
            Text = "FrmEjemplar";
            Load += FrmEjemplar_Load;
            pnlFormularioBase.ResumeLayout(false);
            pnlFormularioBase.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)epValidaciones).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label lblIdLibroEjemplar;
        private Label lblCodigoInventario;
        private TextBox txtIdLIbroEjemplar;
        private TextBox txtCodigoInventario;
        private Label lblCondicion;
        private CheckBox chkDisponible;
        private CheckBox chkEstadoEjemplar;
        private ComboBox cmbCondicion;
    }
}