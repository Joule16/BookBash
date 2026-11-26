//   Equipo 2
//   NUÑEZ Martinez Marco Antonio
//   SUÑIGA Maciel Joule Alexander
//   VILLA Olivarez Ariel
// =============================
// Actividad 2.4
namespace SistemaBiblioteca1
{
    partial class FrmSancion
    {

        private void InitializeComponent()
        {
            lblIdUsuarioSancion = new Label();
            txtIdUsuarioSancion = new TextBox();
            lblIdPrestamoSancion = new Label();
            txtIdPrestamoSancion = new TextBox();
            lblMotivoSancion = new Label();
            txtMotivoSancion = new TextBox();
            lblDiasRetraso = new Label();
            txtDiasRetraso = new TextBox();
            lblPorcentajePenalizacion = new Label();
            txtPorcentajePenalizacion = new TextBox();
            chkPagada = new CheckBox();
            chkEstadoSancion = new CheckBox();
            lblMontoSancion = new Label();
            pnlFormularioBase.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)epValidaciones).BeginInit();
            SuspendLayout();
            // 
            // pnlFormularioBase
            // 
            pnlFormularioBase.Controls.Add(lblIdUsuarioSancion);
            pnlFormularioBase.Controls.Add(txtIdUsuarioSancion);
            pnlFormularioBase.Controls.Add(lblIdPrestamoSancion);
            pnlFormularioBase.Controls.Add(txtIdPrestamoSancion);
            pnlFormularioBase.Controls.Add(lblMotivoSancion);
            pnlFormularioBase.Controls.Add(txtMotivoSancion);
            pnlFormularioBase.Controls.Add(lblDiasRetraso);
            pnlFormularioBase.Controls.Add(txtDiasRetraso);
            pnlFormularioBase.Controls.Add(lblPorcentajePenalizacion);
            pnlFormularioBase.Controls.Add(txtPorcentajePenalizacion);
            pnlFormularioBase.Controls.Add(chkPagada);
            pnlFormularioBase.Controls.Add(chkEstadoSancion);
            pnlFormularioBase.Controls.Add(lblMontoSancion);
            pnlFormularioBase.Controls.SetChildIndex(lblId, 0);
            pnlFormularioBase.Controls.SetChildIndex(lblMontoSancion, 0);
            pnlFormularioBase.Controls.SetChildIndex(chkEstadoSancion, 0);
            pnlFormularioBase.Controls.SetChildIndex(chkPagada, 0);
            pnlFormularioBase.Controls.SetChildIndex(txtPorcentajePenalizacion, 0);
            pnlFormularioBase.Controls.SetChildIndex(lblPorcentajePenalizacion, 0);
            pnlFormularioBase.Controls.SetChildIndex(txtDiasRetraso, 0);
            pnlFormularioBase.Controls.SetChildIndex(lblDiasRetraso, 0);
            pnlFormularioBase.Controls.SetChildIndex(txtMotivoSancion, 0);
            pnlFormularioBase.Controls.SetChildIndex(lblMotivoSancion, 0);
            pnlFormularioBase.Controls.SetChildIndex(txtIdPrestamoSancion, 0);
            pnlFormularioBase.Controls.SetChildIndex(lblIdPrestamoSancion, 0);
            pnlFormularioBase.Controls.SetChildIndex(txtIdUsuarioSancion, 0);
            pnlFormularioBase.Controls.SetChildIndex(lblIdUsuarioSancion, 0);
            pnlFormularioBase.Controls.SetChildIndex(txtId, 0);
            // 
            // lblId
            // 
            lblId.Location = new Point(11, 12);
            // 
            // txtId
            // 
            txtId.Location = new Point(196, 8);
            // 
            // lblIdUsuarioSancion
            // 
            lblIdUsuarioSancion.AutoSize = true;
            lblIdUsuarioSancion.Location = new Point(14, 45);
            lblIdUsuarioSancion.Margin = new Padding(2, 0, 2, 0);
            lblIdUsuarioSancion.Name = "lblIdUsuarioSancion";
            lblIdUsuarioSancion.Size = new Size(64, 15);
            lblIdUsuarioSancion.TabIndex = 2;
            lblIdUsuarioSancion.Text = "ID Usuario:";
            // 
            // txtIdUsuarioSancion
            // 
            txtIdUsuarioSancion.Location = new Point(196, 44);
            txtIdUsuarioSancion.Margin = new Padding(2);
            txtIdUsuarioSancion.Name = "txtIdUsuarioSancion";
            txtIdUsuarioSancion.Size = new Size(162, 23);
            txtIdUsuarioSancion.TabIndex = 3;
            // 
            // lblIdPrestamoSancion
            // 
            lblIdPrestamoSancion.AutoSize = true;
            lblIdPrestamoSancion.Location = new Point(16, 90);
            lblIdPrestamoSancion.Margin = new Padding(2, 0, 2, 0);
            lblIdPrestamoSancion.Name = "lblIdPrestamoSancion";
            lblIdPrestamoSancion.Size = new Size(74, 15);
            lblIdPrestamoSancion.TabIndex = 4;
            lblIdPrestamoSancion.Text = "ID Préstamo:";
            // 
            // txtIdPrestamoSancion
            // 
            txtIdPrestamoSancion.Location = new Point(196, 82);
            txtIdPrestamoSancion.Margin = new Padding(2);
            txtIdPrestamoSancion.Name = "txtIdPrestamoSancion";
            txtIdPrestamoSancion.Size = new Size(162, 23);
            txtIdPrestamoSancion.TabIndex = 5;
            // 
            // lblMotivoSancion
            // 
            lblMotivoSancion.AutoSize = true;
            lblMotivoSancion.Location = new Point(14, 124);
            lblMotivoSancion.Margin = new Padding(2, 0, 2, 0);
            lblMotivoSancion.Name = "lblMotivoSancion";
            lblMotivoSancion.Size = new Size(48, 15);
            lblMotivoSancion.TabIndex = 6;
            lblMotivoSancion.Text = "Motivo:";
            // 
            // txtMotivoSancion
            // 
            txtMotivoSancion.Location = new Point(196, 116);
            txtMotivoSancion.Margin = new Padding(2);
            txtMotivoSancion.Name = "txtMotivoSancion";
            txtMotivoSancion.Size = new Size(162, 23);
            txtMotivoSancion.TabIndex = 7;
            // 
            // lblDiasRetraso
            // 
            lblDiasRetraso.AutoSize = true;
            lblDiasRetraso.Location = new Point(14, 161);
            lblDiasRetraso.Margin = new Padding(2, 0, 2, 0);
            lblDiasRetraso.Name = "lblDiasRetraso";
            lblDiasRetraso.Size = new Size(87, 15);
            lblDiasRetraso.TabIndex = 8;
            lblDiasRetraso.Text = "Días de retraso:";
            // 
            // txtDiasRetraso
            // 
            txtDiasRetraso.Location = new Point(196, 153);
            txtDiasRetraso.Margin = new Padding(2);
            txtDiasRetraso.Name = "txtDiasRetraso";
            txtDiasRetraso.Size = new Size(162, 23);
            txtDiasRetraso.TabIndex = 9;
            // 
            // lblPorcentajePenalizacion
            // 
            lblPorcentajePenalizacion.AutoSize = true;
            lblPorcentajePenalizacion.Location = new Point(11, 202);
            lblPorcentajePenalizacion.Margin = new Padding(2, 0, 2, 0);
            lblPorcentajePenalizacion.Name = "lblPorcentajePenalizacion";
            lblPorcentajePenalizacion.Size = new Size(146, 15);
            lblPorcentajePenalizacion.TabIndex = 10;
            lblPorcentajePenalizacion.Text = "Porcentaje Recargo (0 - 1):";
            // 
            // txtPorcentajePenalizacion
            // 
            txtPorcentajePenalizacion.Location = new Point(196, 194);
            txtPorcentajePenalizacion.Margin = new Padding(2);
            txtPorcentajePenalizacion.Name = "txtPorcentajePenalizacion";
            txtPorcentajePenalizacion.PlaceholderText = "0.20";
            txtPorcentajePenalizacion.Size = new Size(162, 23);
            txtPorcentajePenalizacion.TabIndex = 11;
            // 
            // chkPagada
            // 
            chkPagada.AutoSize = true;
            chkPagada.Location = new Point(196, 230);
            chkPagada.Margin = new Padding(2);
            chkPagada.Name = "chkPagada";
            chkPagada.Size = new Size(65, 19);
            chkPagada.TabIndex = 12;
            chkPagada.Text = "Pagada";
            chkPagada.UseVisualStyleBackColor = true;
            // 
            // chkEstadoSancion
            // 
            chkEstadoSancion.AutoSize = true;
            chkEstadoSancion.Location = new Point(285, 230);
            chkEstadoSancion.Margin = new Padding(2);
            chkEstadoSancion.Name = "chkEstadoSancion";
            chkEstadoSancion.Size = new Size(59, 19);
            chkEstadoSancion.TabIndex = 13;
            chkEstadoSancion.Text = "Activa";
            chkEstadoSancion.UseVisualStyleBackColor = true;
            // 
            // lblMontoSancion
            // 
            lblMontoSancion.AutoSize = true;
            lblMontoSancion.Location = new Point(14, 234);
            lblMontoSancion.Margin = new Padding(2, 0, 2, 0);
            lblMontoSancion.Name = "lblMontoSancion";
            lblMontoSancion.Size = new Size(76, 15);
            lblMontoSancion.TabIndex = 14;
            lblMontoSancion.Text = "Monto: $0.00";
            // 
            // FrmSancion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(560, 270);
            Name = "FrmSancion";
            Text = "FrmSancion";
            pnlFormularioBase.ResumeLayout(false);
            pnlFormularioBase.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)epValidaciones).EndInit();
            ResumeLayout(false);
        }

        private Label lblIdUsuarioSancion;
        private TextBox txtIdUsuarioSancion;
        private Label lblIdPrestamoSancion;
        private TextBox txtIdPrestamoSancion;
        private Label lblMotivoSancion;
        private TextBox txtMotivoSancion;
        private Label lblDiasRetraso;
        private TextBox txtDiasRetraso;
        private Label lblPorcentajePenalizacion;
        private TextBox txtPorcentajePenalizacion;
        private CheckBox chkPagada;
        private CheckBox chkEstadoSancion;
        private Label lblMontoSancion;
    }
}