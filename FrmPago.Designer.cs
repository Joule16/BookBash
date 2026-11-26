//   Equipo 2
//   NUÑEZ Martinez Marco Antonio
//   SUÑIGA Maciel Joule Alexander
//   VILLA Olivarez Ariel
// =============================
namespace SistemaBiblioteca1
{
    partial class FrmPago
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
            lblIdSancion = new Label();
            lblMontoPago = new Label();
            lblFechaPago = new Label();
            lblMetodoPago = new Label();
            chkEstadoPago = new CheckBox();
            txtSancionPago = new TextBox();
            txtMontoPago = new TextBox();
            dtpFechaPago = new DateTimePicker();
            cmbMetodoPago = new ComboBox();
            pnlFormularioBase.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)epValidaciones).BeginInit();
            SuspendLayout();
            // 
            // pnlFormularioBase
            // 
            pnlFormularioBase.Controls.Add(dtpFechaPago);
            pnlFormularioBase.Controls.Add(cmbMetodoPago);
            pnlFormularioBase.Controls.Add(chkEstadoPago);
            pnlFormularioBase.Controls.Add(lblFechaPago);
            pnlFormularioBase.Controls.Add(lblMetodoPago);
            pnlFormularioBase.Controls.Add(txtMontoPago);
            pnlFormularioBase.Controls.Add(txtSancionPago);
            pnlFormularioBase.Controls.Add(lblIdSancion);
            pnlFormularioBase.Controls.Add(lblMontoPago);
            pnlFormularioBase.Size = new Size(579, 235);
            pnlFormularioBase.Controls.SetChildIndex(txtId, 0);
            pnlFormularioBase.Controls.SetChildIndex(lblId, 0);
            pnlFormularioBase.Controls.SetChildIndex(lblMontoPago, 0);
            pnlFormularioBase.Controls.SetChildIndex(lblIdSancion, 0);
            pnlFormularioBase.Controls.SetChildIndex(txtSancionPago, 0);
            pnlFormularioBase.Controls.SetChildIndex(txtMontoPago, 0);
            pnlFormularioBase.Controls.SetChildIndex(lblMetodoPago, 0);
            pnlFormularioBase.Controls.SetChildIndex(lblFechaPago, 0);
            pnlFormularioBase.Controls.SetChildIndex(chkEstadoPago, 0);
            pnlFormularioBase.Controls.SetChildIndex(cmbMetodoPago, 0);
            pnlFormularioBase.Controls.SetChildIndex(dtpFechaPago, 0);
            // 
            // txtId
            // 
            txtId.Location = new Point(161, 7);
            // 
            // lblIdSancion
            // 
            lblIdSancion.AutoSize = true;
            lblIdSancion.Location = new Point(14, 49);
            lblIdSancion.Name = "lblIdSancion";
            lblIdSancion.Size = new Size(66, 15);
            lblIdSancion.TabIndex = 0;
            lblIdSancion.Text = "ID Sanción:";
            // 
            // lblMontoPago
            // 
            lblMontoPago.AutoSize = true;
            lblMontoPago.Location = new Point(14, 88);
            lblMontoPago.Name = "lblMontoPago";
            lblMontoPago.Size = new Size(63, 15);
            lblMontoPago.TabIndex = 1;
            lblMontoPago.Text = "Monto ($):";
            // 
            // lblFechaPago
            // 
            lblFechaPago.AutoSize = true;
            lblFechaPago.Location = new Point(14, 126);
            lblFechaPago.Name = "lblFechaPago";
            lblFechaPago.Size = new Size(87, 15);
            lblFechaPago.TabIndex = 2;
            lblFechaPago.Text = "Fecha de pago:";
            // 
            // lblMetodoPago
            // 
            lblMetodoPago.AutoSize = true;
            lblMetodoPago.Location = new Point(14, 166);
            lblMetodoPago.Name = "lblMetodoPago";
            lblMetodoPago.Size = new Size(98, 15);
            lblMetodoPago.TabIndex = 3;
            lblMetodoPago.Text = "Método de pago:";
            // 
            // chkEstadoPago
            // 
            chkEstadoPago.AutoSize = true;
            chkEstadoPago.Location = new Point(161, 196);
            chkEstadoPago.Margin = new Padding(3, 2, 3, 2);
            chkEstadoPago.Name = "chkEstadoPago";
            chkEstadoPago.Size = new Size(60, 19);
            chkEstadoPago.TabIndex = 4;
            chkEstadoPago.Text = "Activo";
            chkEstadoPago.UseVisualStyleBackColor = true;
            // 
            // txtSancionPago
            // 
            txtSancionPago.Location = new Point(161, 41);
            txtSancionPago.Margin = new Padding(3, 2, 3, 2);
            txtSancionPago.Name = "txtSancionPago";
            txtSancionPago.Size = new Size(162, 23);
            txtSancionPago.TabIndex = 5;
            // 
            // txtMontoPago
            // 
            txtMontoPago.Location = new Point(161, 80);
            txtMontoPago.Margin = new Padding(3, 2, 3, 2);
            txtMontoPago.Name = "txtMontoPago";
            txtMontoPago.Size = new Size(162, 23);
            txtMontoPago.TabIndex = 6;
            // 
            // dtpFechaPago
            // 
            dtpFechaPago.Format = DateTimePickerFormat.Short;
            dtpFechaPago.Location = new Point(161, 120);
            dtpFechaPago.Margin = new Padding(3, 2, 3, 2);
            dtpFechaPago.Name = "dtpFechaPago";
            dtpFechaPago.Size = new Size(162, 23);
            dtpFechaPago.TabIndex = 7;
            // 
            // cmbMetodoPago
            // 
            cmbMetodoPago.FormattingEnabled = true;
            cmbMetodoPago.Items.AddRange(new object[] { "Efectivo", "Tarjeta", "Transferencia" });
            cmbMetodoPago.Location = new Point(161, 158);
            cmbMetodoPago.Margin = new Padding(3, 2, 3, 2);
            cmbMetodoPago.Name = "cmbMetodoPago";
            cmbMetodoPago.Size = new Size(162, 23);
            cmbMetodoPago.TabIndex = 8;
            // 
            // FrmPago
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(579, 235);
            Name = "FrmPago";
            Text = "FrmPago";
            pnlFormularioBase.ResumeLayout(false);
            pnlFormularioBase.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)epValidaciones).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label lblIdSancion;
        private Label lblMontoPago;
        private Label lblFechaPago;
        private Label lblMetodoPago;
        private CheckBox chkEstadoPago;
        private TextBox txtSancionPago;
        private TextBox txtMontoPago;
        private DateTimePicker dtpFechaPago;
        private ComboBox cmbMetodoPago;
    }
}