//   Equipo 2
//   NUÑEZ Martinez Marco Antonio
//   SUÑIGA Maciel Joule Alexander
//   VILLA Olivarez Ariel
// =============================
// Actividad 2.4
namespace SistemaBiblioteca1
{
    partial class FrmMaestro
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


        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            pnlContenedorVistas = new Panel();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            pnlSuperior = new Panel();
            lblModulo = new Label();
            cmbModulo = new ComboBox();
            lblIdBusqueda = new Label();
            txtIdBusqueda = new TextBox();
            btnMasterBuscar = new BotonPersona3();
            pnlInferior = new Panel();
            btnMasterGuardar = new BotonPersona3();
            btnMasterActualizar = new BotonPersona3();
            btnMasterEliminar = new BotonPersona3();
            statusStrip1 = new StatusStrip();
            tsslEstado = new ToolStripStatusLabel();
            errorProvider1 = new ErrorProvider(components);
            pnlContenedorVistas.SuspendLayout();
            pnlSuperior.SuspendLayout();
            pnlInferior.SuspendLayout();
            statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // pnlContenedorVistas
            // 
            pnlContenedorVistas.Controls.Add(label4);
            pnlContenedorVistas.Controls.Add(label3);
            pnlContenedorVistas.Controls.Add(label2);
            pnlContenedorVistas.Controls.Add(label1);
            pnlContenedorVistas.Dock = DockStyle.Fill;
            pnlContenedorVistas.Location = new Point(0, 42);
            pnlContenedorVistas.Margin = new Padding(2);
            pnlContenedorVistas.Name = "pnlContenedorVistas";
            pnlContenedorVistas.Size = new Size(630, 254);
            pnlContenedorVistas.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(436, 91);
            label4.Name = "label4";
            label4.Size = new Size(173, 15);
            label4.TabIndex = 3;
            label4.Text = "Nuñez Martinez Marco Antonio";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(440, 63);
            label3.Name = "label3";
            label3.Size = new Size(167, 15);
            label3.TabIndex = 2;
            label3.Text = "Suñiga Macile Joule Alexander";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(479, 39);
            label2.Name = "label2";
            label2.Size = new Size(101, 15);
            label2.TabIndex = 1;
            label2.Text = "Villa Olivarez Ariel";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(497, 13);
            label1.Name = "label1";
            label1.Size = new Size(60, 15);
            label1.TabIndex = 0;
            label1.Text = "Equipo #2";
            // 
            // pnlSuperior
            // 
            pnlSuperior.Controls.Add(lblModulo);
            pnlSuperior.Controls.Add(cmbModulo);
            pnlSuperior.Controls.Add(lblIdBusqueda);
            pnlSuperior.Controls.Add(txtIdBusqueda);
            pnlSuperior.Controls.Add(btnMasterBuscar);
            pnlSuperior.Dock = DockStyle.Top;
            pnlSuperior.Location = new Point(0, 0);
            pnlSuperior.Margin = new Padding(2);
            pnlSuperior.Name = "pnlSuperior";
            pnlSuperior.Size = new Size(630, 42);
            pnlSuperior.TabIndex = 0;
            // 
            // lblModulo
            // 
            lblModulo.AutoSize = true;
            lblModulo.Location = new Point(10, 14);
            lblModulo.Margin = new Padding(2, 0, 2, 0);
            lblModulo.Name = "lblModulo";
            lblModulo.Size = new Size(52, 15);
            lblModulo.TabIndex = 0;
            lblModulo.Text = "Módulo:";
            // 
            // cmbModulo
            // 
            cmbModulo.CausesValidation = false;
            cmbModulo.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbModulo.FormattingEnabled = true;
            cmbModulo.Location = new Point(70, 10);
            cmbModulo.Margin = new Padding(2);
            cmbModulo.Name = "cmbModulo";
            cmbModulo.Size = new Size(155, 23);
            cmbModulo.TabIndex = 1;
            cmbModulo.SelectedIndexChanged += cmbModulo_SelectedIndexChanged;
            // 
            // lblIdBusqueda
            // 
            lblIdBusqueda.AutoSize = true;
            lblIdBusqueda.Location = new Point(238, 14);
            lblIdBusqueda.Margin = new Padding(2, 0, 2, 0);
            lblIdBusqueda.Name = "lblIdBusqueda";
            lblIdBusqueda.Size = new Size(68, 15);
            lblIdBusqueda.TabIndex = 2;
            lblIdBusqueda.Text = "ID a buscar:";
            // 
            // txtIdBusqueda
            // 
            txtIdBusqueda.CausesValidation = false;
            txtIdBusqueda.Location = new Point(318, 10);
            txtIdBusqueda.Margin = new Padding(2);
            txtIdBusqueda.MaxLength = 9;
            txtIdBusqueda.Name = "txtIdBusqueda";
            txtIdBusqueda.Size = new Size(85, 23);
            txtIdBusqueda.TabIndex = 3;
            txtIdBusqueda.TextChanged += txtIdBusqueda_TextChanged;
            // 
            // btnMasterBuscar
            // 
            btnMasterBuscar.CausesValidation = false;
            btnMasterBuscar.FlatStyle = FlatStyle.Flat;
            btnMasterBuscar.Font = new Font("Segoe UI", 11F, FontStyle.Bold | FontStyle.Italic);
            btnMasterBuscar.Location = new Point(416, 9);
            btnMasterBuscar.Margin = new Padding(2);
            btnMasterBuscar.Name = "btnMasterBuscar";
            btnMasterBuscar.Size = new Size(84, 24);
            btnMasterBuscar.TabIndex = 4;
            btnMasterBuscar.Text = "Buscar";
            btnMasterBuscar.UseVisualStyleBackColor = true;
            btnMasterBuscar.Click += btnMasterBuscar_Click;
            // 
            // pnlInferior
            // 
            pnlInferior.Controls.Add(btnMasterGuardar);
            pnlInferior.Controls.Add(btnMasterActualizar);
            pnlInferior.Controls.Add(btnMasterEliminar);
            pnlInferior.Dock = DockStyle.Bottom;
            pnlInferior.Location = new Point(0, 296);
            pnlInferior.Margin = new Padding(2);
            pnlInferior.Name = "pnlInferior";
            pnlInferior.Size = new Size(630, 42);
            pnlInferior.TabIndex = 2;
            // 
            // btnMasterGuardar
            // 
            btnMasterGuardar.FlatStyle = FlatStyle.Flat;
            btnMasterGuardar.Font = new Font("Segoe UI", 11F, FontStyle.Bold | FontStyle.Italic);
            btnMasterGuardar.Location = new Point(10, 9);
            btnMasterGuardar.Margin = new Padding(2);
            btnMasterGuardar.Name = "btnMasterGuardar";
            btnMasterGuardar.Size = new Size(105, 24);
            btnMasterGuardar.TabIndex = 0;
            btnMasterGuardar.Text = "Guardar";
            btnMasterGuardar.UseVisualStyleBackColor = true;
            btnMasterGuardar.Click += btnMasterGuardar_Click;
            // 
            // btnMasterActualizar
            // 
            btnMasterActualizar.FlatStyle = FlatStyle.Flat;
            btnMasterActualizar.Font = new Font("Segoe UI", 11F, FontStyle.Bold | FontStyle.Italic);
            btnMasterActualizar.Location = new Point(126, 9);
            btnMasterActualizar.Margin = new Padding(2);
            btnMasterActualizar.Name = "btnMasterActualizar";
            btnMasterActualizar.Size = new Size(105, 24);
            btnMasterActualizar.TabIndex = 1;
            btnMasterActualizar.Text = "Actualizar";
            btnMasterActualizar.UseVisualStyleBackColor = true;
            btnMasterActualizar.Click += btnMasterActualizar_Click;
            // 
            // btnMasterEliminar
            // 
            btnMasterEliminar.CausesValidation = false;
            btnMasterEliminar.FlatStyle = FlatStyle.Flat;
            btnMasterEliminar.Font = new Font("Segoe UI", 11F, FontStyle.Bold | FontStyle.Italic);
            btnMasterEliminar.Location = new Point(242, 9);
            btnMasterEliminar.Margin = new Padding(2);
            btnMasterEliminar.Name = "btnMasterEliminar";
            btnMasterEliminar.Size = new Size(105, 24);
            btnMasterEliminar.TabIndex = 2;
            btnMasterEliminar.Text = "Eliminar";
            btnMasterEliminar.UseVisualStyleBackColor = true;
            btnMasterEliminar.Click += btnMasterEliminar_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(24, 24);
            statusStrip1.Items.AddRange(new ToolStripItem[] { tsslEstado });
            statusStrip1.Location = new Point(0, 338);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Padding = new Padding(1, 0, 10, 0);
            statusStrip1.Size = new Size(630, 22);
            statusStrip1.TabIndex = 3;
            statusStrip1.Text = "statusStrip1";
            // 
            // tsslEstado
            // 
            tsslEstado.Name = "tsslEstado";
            tsslEstado.Size = new Size(128, 17);
            tsslEstado.Text = "Listo. Elige un módulo.";
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // FrmMaestro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(630, 360);
            Controls.Add(pnlContenedorVistas);
            Controls.Add(pnlInferior);
            Controls.Add(pnlSuperior);
            Controls.Add(statusStrip1);
            Margin = new Padding(2);
            Name = "FrmMaestro";
            Text = "Sistema de Biblioteca";
            pnlContenedorVistas.ResumeLayout(false);
            pnlContenedorVistas.PerformLayout();
            pnlSuperior.ResumeLayout(false);
            pnlSuperior.PerformLayout();
            pnlInferior.ResumeLayout(false);
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }


        private Panel pnlContenedorVistas;
        private Panel pnlSuperior;
        private Label lblModulo;
        private ComboBox cmbModulo;
        private Label lblIdBusqueda;
        private TextBox txtIdBusqueda;
        private BotonPersona3 btnMasterBuscar;
        private Panel pnlInferior;
        private BotonPersona3 btnMasterGuardar;
        private BotonPersona3 btnMasterActualizar;
        private BotonPersona3 btnMasterEliminar;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel tsslEstado;
        private ErrorProvider errorProvider1;
        private Label label2;
        private Label label1;
        private Label label4;
        private Label label3;
    }
}