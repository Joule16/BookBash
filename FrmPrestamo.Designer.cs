//   Equipo 2
//   NUÑEZ Martinez Marco Antonio
//   SUÑIGA Maciel Joule Alexander
//   VILLA Olivarez Ariel
// =============================
// Actividad 2.5
namespace SistemaBiblioteca1
{
    partial class FrmPrestamo
    {

        private void InitializeComponent()
        {
            lblIdUsuarioPrestamo = new Label();
            txtIdEjemplarAgregar = new TextBox();
            lblIdEjemplarPrestamo = new Label();
            txtIdEjemplarPrestamo = new TextBox();
            lblFechaPrestamo = new Label();
            dtpFechaPrestamo = new DateTimePicker();
            lblFechaLimite = new Label();
            dtpFechaLimite = new DateTimePicker();
            chkDevuelto = new CheckBox();
            chkEstadoPrestamo = new CheckBox();
            btnAgregarDetalle = new Button();
            dgvEjemplares = new DataGridView();
            btnEliminarDetalle = new Button();
            btnVaciarDetalle = new Button();
            label1 = new Label();
            lblContadorDetalle = new Label();
            btnExportar = new Button();
            btnImportar = new Button();
            btnVisor = new Button();
            btnRegistrarEstado = new Button();
            btnDeshacer = new Button();
            lblCima = new Label();
            lblContadorHistorial = new Label();
            lstHistorial = new ListBox();
            pnlFormularioBase.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)epValidaciones).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvEjemplares).BeginInit();
            SuspendLayout();
            // 
            // pnlFormularioBase
            // 
            pnlFormularioBase.Controls.Add(lstHistorial);
            pnlFormularioBase.Controls.Add(lblContadorHistorial);
            pnlFormularioBase.Controls.Add(lblCima);
            pnlFormularioBase.Controls.Add(btnDeshacer);
            pnlFormularioBase.Controls.Add(btnRegistrarEstado);
            pnlFormularioBase.Controls.Add(btnVisor);
            pnlFormularioBase.Controls.Add(btnImportar);
            pnlFormularioBase.Controls.Add(btnExportar);
            pnlFormularioBase.Controls.Add(lblContadorDetalle);
            pnlFormularioBase.Controls.Add(label1);
            pnlFormularioBase.Controls.Add(btnVaciarDetalle);
            pnlFormularioBase.Controls.Add(btnEliminarDetalle);
            pnlFormularioBase.Controls.Add(dgvEjemplares);
            pnlFormularioBase.Controls.Add(btnAgregarDetalle);
            pnlFormularioBase.Controls.Add(lblIdUsuarioPrestamo);
            pnlFormularioBase.Controls.Add(txtIdEjemplarAgregar);
            pnlFormularioBase.Controls.Add(lblIdEjemplarPrestamo);
            pnlFormularioBase.Controls.Add(txtIdEjemplarPrestamo);
            pnlFormularioBase.Controls.Add(lblFechaPrestamo);
            pnlFormularioBase.Controls.Add(dtpFechaPrestamo);
            pnlFormularioBase.Controls.Add(lblFechaLimite);
            pnlFormularioBase.Controls.Add(dtpFechaLimite);
            pnlFormularioBase.Controls.Add(chkDevuelto);
            pnlFormularioBase.Controls.Add(chkEstadoPrestamo);
            pnlFormularioBase.Size = new Size(930, 559);
            pnlFormularioBase.Paint += pnlFormularioBase_Paint;
            pnlFormularioBase.Controls.SetChildIndex(chkEstadoPrestamo, 0);
            pnlFormularioBase.Controls.SetChildIndex(chkDevuelto, 0);
            pnlFormularioBase.Controls.SetChildIndex(dtpFechaLimite, 0);
            pnlFormularioBase.Controls.SetChildIndex(lblFechaLimite, 0);
            pnlFormularioBase.Controls.SetChildIndex(dtpFechaPrestamo, 0);
            pnlFormularioBase.Controls.SetChildIndex(lblFechaPrestamo, 0);
            pnlFormularioBase.Controls.SetChildIndex(txtIdEjemplarPrestamo, 0);
            pnlFormularioBase.Controls.SetChildIndex(lblIdEjemplarPrestamo, 0);
            pnlFormularioBase.Controls.SetChildIndex(txtIdEjemplarAgregar, 0);
            pnlFormularioBase.Controls.SetChildIndex(lblIdUsuarioPrestamo, 0);
            pnlFormularioBase.Controls.SetChildIndex(txtId, 0);
            pnlFormularioBase.Controls.SetChildIndex(lblId, 0);
            pnlFormularioBase.Controls.SetChildIndex(btnAgregarDetalle, 0);
            pnlFormularioBase.Controls.SetChildIndex(dgvEjemplares, 0);
            pnlFormularioBase.Controls.SetChildIndex(btnEliminarDetalle, 0);
            pnlFormularioBase.Controls.SetChildIndex(btnVaciarDetalle, 0);
            pnlFormularioBase.Controls.SetChildIndex(label1, 0);
            pnlFormularioBase.Controls.SetChildIndex(lblContadorDetalle, 0);
            pnlFormularioBase.Controls.SetChildIndex(btnExportar, 0);
            pnlFormularioBase.Controls.SetChildIndex(btnImportar, 0);
            pnlFormularioBase.Controls.SetChildIndex(btnVisor, 0);
            pnlFormularioBase.Controls.SetChildIndex(btnRegistrarEstado, 0);
            pnlFormularioBase.Controls.SetChildIndex(btnDeshacer, 0);
            pnlFormularioBase.Controls.SetChildIndex(lblCima, 0);
            pnlFormularioBase.Controls.SetChildIndex(lblContadorHistorial, 0);
            pnlFormularioBase.Controls.SetChildIndex(lstHistorial, 0);
            // 
            // lblId
            // 
            lblId.Location = new Point(13, 23);
            lblId.Margin = new Padding(1, 0, 1, 0);
            // 
            // txtId
            // 
            txtId.Location = new Point(158, 15);
            txtId.Margin = new Padding(1);
            txtId.Size = new Size(127, 23);
            // 
            // lblIdUsuarioPrestamo
            // 
            lblIdUsuarioPrestamo.AutoSize = true;
            lblIdUsuarioPrestamo.Location = new Point(11, 84);
            lblIdUsuarioPrestamo.Margin = new Padding(1, 0, 1, 0);
            lblIdUsuarioPrestamo.Name = "lblIdUsuarioPrestamo";
            lblIdUsuarioPrestamo.Size = new Size(64, 15);
            lblIdUsuarioPrestamo.TabIndex = 2;
            lblIdUsuarioPrestamo.Text = "ID Usuario:";
            // 
            // txtIdEjemplarAgregar
            // 
            txtIdEjemplarAgregar.Location = new Point(158, 123);
            txtIdEjemplarAgregar.Margin = new Padding(1);
            txtIdEjemplarAgregar.Name = "txtIdEjemplarAgregar";
            txtIdEjemplarAgregar.Size = new Size(127, 23);
            txtIdEjemplarAgregar.TabIndex = 3;
            txtIdEjemplarAgregar.TextChanged += txtIdEjemplarAgregar_TextChanged;
            // 
            // lblIdEjemplarPrestamo
            // 
            lblIdEjemplarPrestamo.AutoSize = true;
            lblIdEjemplarPrestamo.Location = new Point(8, 126);
            lblIdEjemplarPrestamo.Margin = new Padding(1, 0, 1, 0);
            lblIdEjemplarPrestamo.Name = "lblIdEjemplarPrestamo";
            lblIdEjemplarPrestamo.Size = new Size(70, 15);
            lblIdEjemplarPrestamo.TabIndex = 4;
            lblIdEjemplarPrestamo.Text = "ID Ejemplar:";
            // 
            // txtIdEjemplarPrestamo
            // 
            txtIdEjemplarPrestamo.Location = new Point(158, 76);
            txtIdEjemplarPrestamo.Margin = new Padding(1);
            txtIdEjemplarPrestamo.Name = "txtIdEjemplarPrestamo";
            txtIdEjemplarPrestamo.Size = new Size(127, 23);
            txtIdEjemplarPrestamo.TabIndex = 5;
            // 
            // lblFechaPrestamo
            // 
            lblFechaPrestamo.AutoSize = true;
            lblFechaPrestamo.Location = new Point(298, 12);
            lblFechaPrestamo.Margin = new Padding(1, 0, 1, 0);
            lblFechaPrestamo.Name = "lblFechaPrestamo";
            lblFechaPrestamo.Size = new Size(110, 15);
            lblFechaPrestamo.TabIndex = 6;
            lblFechaPrestamo.Text = "Fecha de préstamo:";
            // 
            // dtpFechaPrestamo
            // 
            dtpFechaPrestamo.Format = DateTimePickerFormat.Short;
            dtpFechaPrestamo.Location = new Point(421, 12);
            dtpFechaPrestamo.Margin = new Padding(1);
            dtpFechaPrestamo.Name = "dtpFechaPrestamo";
            dtpFechaPrestamo.Size = new Size(138, 23);
            dtpFechaPrestamo.TabIndex = 7;
            // 
            // lblFechaLimite
            // 
            lblFechaLimite.AutoSize = true;
            lblFechaLimite.Location = new Point(308, 69);
            lblFechaLimite.Margin = new Padding(1, 0, 1, 0);
            lblFechaLimite.Name = "lblFechaLimite";
            lblFechaLimite.Size = new Size(74, 15);
            lblFechaLimite.TabIndex = 8;
            lblFechaLimite.Text = "Fecha límite:";
            // 
            // dtpFechaLimite
            // 
            dtpFechaLimite.Format = DateTimePickerFormat.Short;
            dtpFechaLimite.Location = new Point(421, 61);
            dtpFechaLimite.Margin = new Padding(1);
            dtpFechaLimite.Name = "dtpFechaLimite";
            dtpFechaLimite.Size = new Size(138, 23);
            dtpFechaLimite.TabIndex = 9;
            // 
            // chkDevuelto
            // 
            chkDevuelto.AutoSize = true;
            chkDevuelto.Location = new Point(346, 109);
            chkDevuelto.Margin = new Padding(1);
            chkDevuelto.Name = "chkDevuelto";
            chkDevuelto.Size = new Size(73, 19);
            chkDevuelto.TabIndex = 10;
            chkDevuelto.Text = "Devuelto";
            chkDevuelto.UseVisualStyleBackColor = true;
            // 
            // chkEstadoPrestamo
            // 
            chkEstadoPrestamo.AutoSize = true;
            chkEstadoPrestamo.Location = new Point(444, 109);
            chkEstadoPrestamo.Margin = new Padding(1);
            chkEstadoPrestamo.Name = "chkEstadoPrestamo";
            chkEstadoPrestamo.Size = new Size(60, 19);
            chkEstadoPrestamo.TabIndex = 11;
            chkEstadoPrestamo.Text = "Activo";
            chkEstadoPrestamo.UseVisualStyleBackColor = true;
            // 
            // btnAgregarDetalle
            // 
            btnAgregarDetalle.Location = new Point(346, 151);
            btnAgregarDetalle.Margin = new Padding(3, 2, 3, 2);
            btnAgregarDetalle.Name = "btnAgregarDetalle";
            btnAgregarDetalle.Size = new Size(132, 22);
            btnAgregarDetalle.TabIndex = 14;
            btnAgregarDetalle.Text = "Agregar";
            btnAgregarDetalle.UseVisualStyleBackColor = true;
            btnAgregarDetalle.Click += btnAgregarDetalle_Click;
            // 
            // dgvEjemplares
            // 
            dgvEjemplares.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEjemplares.Location = new Point(3, 186);
            dgvEjemplares.Margin = new Padding(3, 2, 3, 2);
            dgvEjemplares.Name = "dgvEjemplares";
            dgvEjemplares.RowHeadersWidth = 51;
            dgvEjemplares.Size = new Size(554, 71);
            dgvEjemplares.TabIndex = 16;
            // 
            // btnEliminarDetalle
            // 
            btnEliminarDetalle.Location = new Point(376, 300);
            btnEliminarDetalle.Margin = new Padding(3, 2, 3, 2);
            btnEliminarDetalle.Name = "btnEliminarDetalle";
            btnEliminarDetalle.Size = new Size(83, 22);
            btnEliminarDetalle.TabIndex = 17;
            btnEliminarDetalle.Text = "Eliminar";
            btnEliminarDetalle.UseVisualStyleBackColor = true;
            btnEliminarDetalle.Click += btnEliminarDetalle_Click;
            // 
            // btnVaciarDetalle
            // 
            btnVaciarDetalle.Location = new Point(476, 300);
            btnVaciarDetalle.Margin = new Padding(3, 2, 3, 2);
            btnVaciarDetalle.Name = "btnVaciarDetalle";
            btnVaciarDetalle.Size = new Size(83, 22);
            btnVaciarDetalle.TabIndex = 18;
            btnVaciarDetalle.Text = "Vaciar";
            btnVaciarDetalle.UseVisualStyleBackColor = true;
            btnVaciarDetalle.Click += btnVaciarDetalle_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 304);
            label1.Name = "label1";
            label1.Size = new Size(67, 15);
            label1.TabIndex = 19;
            label1.Text = "Total ítems:";
            // 
            // lblContadorDetalle
            // 
            lblContadorDetalle.AutoSize = true;
            lblContadorDetalle.Location = new Point(93, 304);
            lblContadorDetalle.Name = "lblContadorDetalle";
            lblContadorDetalle.Size = new Size(0, 15);
            lblContadorDetalle.TabIndex = 20;
            // 
            // btnExportar
            // 
            btnExportar.CausesValidation = false;
            btnExportar.Location = new Point(122, 300);
            btnExportar.Margin = new Padding(3, 2, 3, 2);
            btnExportar.Name = "btnExportar";
            btnExportar.Size = new Size(66, 22);
            btnExportar.TabIndex = 22;
            btnExportar.Text = "Exportar";
            btnExportar.UseVisualStyleBackColor = true;
            btnExportar.Click += btnExportar_Click;
            // 
            // btnImportar
            // 
            btnImportar.CausesValidation = false;
            btnImportar.Location = new Point(205, 300);
            btnImportar.Margin = new Padding(3, 2, 3, 2);
            btnImportar.Name = "btnImportar";
            btnImportar.Size = new Size(66, 22);
            btnImportar.TabIndex = 23;
            btnImportar.Text = "Importar";
            btnImportar.UseVisualStyleBackColor = true;
            btnImportar.Click += btnImportar_Click;
            // 
            // btnVisor
            // 
            btnVisor.CausesValidation = false;
            btnVisor.Location = new Point(292, 300);
            btnVisor.Margin = new Padding(3, 2, 3, 2);
            btnVisor.Name = "btnVisor";
            btnVisor.Size = new Size(66, 22);
            btnVisor.TabIndex = 24;
            btnVisor.Text = "Visor";
            btnVisor.UseVisualStyleBackColor = true;
            btnVisor.Click += btnVisor_Click;
            // 
            // btnRegistrarEstado
            // 
            btnRegistrarEstado.CausesValidation = false;
            btnRegistrarEstado.Location = new Point(38, 343);
            btnRegistrarEstado.Margin = new Padding(3, 2, 3, 2);
            btnRegistrarEstado.Name = "btnRegistrarEstado";
            btnRegistrarEstado.Size = new Size(132, 22);
            btnRegistrarEstado.TabIndex = 25;
            btnRegistrarEstado.Text = "Registrar Estado";
            btnRegistrarEstado.UseVisualStyleBackColor = true;
            btnRegistrarEstado.Click += btnRegistrarEstado_Click;
            // 
            // btnDeshacer
            // 
            btnDeshacer.CausesValidation = false;
            btnDeshacer.Location = new Point(229, 343);
            btnDeshacer.Margin = new Padding(3, 2, 3, 2);
            btnDeshacer.Name = "btnDeshacer";
            btnDeshacer.Size = new Size(132, 22);
            btnDeshacer.TabIndex = 26;
            btnDeshacer.Text = "Deshacer Último";
            btnDeshacer.UseVisualStyleBackColor = true;
            btnDeshacer.Click += btnDeshacer_Click;
            // 
            // lblCima
            // 
            lblCima.AutoSize = true;
            lblCima.Location = new Point(13, 367);
            lblCima.Name = "lblCima";
            lblCima.Size = new Size(201, 15);
            lblCima.TabIndex = 28;
            lblCima.Text = "Siguiente acción a revertir: (ninguna)";
            // 
            // lblContadorHistorial
            // 
            lblContadorHistorial.AutoSize = true;
            lblContadorHistorial.Location = new Point(391, 350);
            lblContadorHistorial.Name = "lblContadorHistorial";
            lblContadorHistorial.Size = new Size(128, 15);
            lblContadorHistorial.TabIndex = 27;
            lblContadorHistorial.Text = "Acciones en historial: 0";
            // 
            // lstHistorial
            // 
            lstHistorial.FormattingEnabled = true;
            lstHistorial.HorizontalScrollbar = true;
            lstHistorial.Location = new Point(3, 412);
            lstHistorial.Margin = new Padding(3, 2, 3, 2);
            lstHistorial.Name = "lstHistorial";
            lstHistorial.Size = new Size(556, 79);
            lstHistorial.TabIndex = 29;
            // 
            // FrmPrestamo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(930, 559);
            Margin = new Padding(1);
            Name = "FrmPrestamo";
            Text = "FrmPrestamo";
            pnlFormularioBase.ResumeLayout(false);
            pnlFormularioBase.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)epValidaciones).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvEjemplares).EndInit();
            ResumeLayout(false);
        }



        private Label lblIdUsuarioPrestamo;
        private TextBox txtIdEjemplarAgregar;
        private Label lblIdEjemplarPrestamo;
        private TextBox txtIdEjemplarPrestamo;
        private Label lblFechaPrestamo;
        private DateTimePicker dtpFechaPrestamo;
        private Label lblFechaLimite;
        private DateTimePicker dtpFechaLimite;
        private CheckBox chkDevuelto;
        private CheckBox chkEstadoPrestamo;
        private Button btnAgregarDetalle;
        private DataGridView dgvEjemplares;
        private Label lblContadorDetalle;
        private Label label1;
        private Button btnVaciarDetalle;
        private Button btnEliminarDetalle;
        private Button btnExportar;
        private Button btnImportar;
        private Button btnVisor;
        private Button btnRegistrarEstado;
        private Button btnDeshacer;
        private Label lblCima;
        private Label lblContadorHistorial;
        private ListBox lstHistorial;
    }
}