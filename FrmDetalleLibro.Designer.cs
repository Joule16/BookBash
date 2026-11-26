//   Equipo 2
//   NUÑEZ Martinez Marco Antonio
//   SUÑIGA Maciel Joule Alexander
//   VILLA Olivarez Ariel
// =============================
namespace SistemaBiblioteca1
{
    partial class FrmDetalleLibro
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
            lblEncabezado = new Label();
            lblId = new Label();
            txtId = new TextBox();
            lblTitulo = new Label();
            txtTitulo = new TextBox();
            lblIsbn = new Label();
            txtIsbn = new TextBox();
            lblAutor = new Label();
            txtAutor = new TextBox();
            lblCategoria = new Label();
            txtCategoria = new TextBox();
            lblEditorial = new Label();
            txtEditorial = new TextBox();
            lblAnio = new Label();
            txtAnio = new TextBox();
            lblPuntoEntrega = new Label();
            txtPuntoEntrega = new TextBox();
            lblEjemplares = new Label();
            txtEjemplares = new TextBox();
            lblActivo = new Label();
            chkActivo = new CheckBox();
            lblPortada = new Label();
            pbxPortada = new PictureBox();
            btnBajaLogica = new BotonPersona3();
            btnEliminarFisico = new BotonPersona3();
            btnCancelar = new BotonPersona3();
            lblAutoria = new Label();
            ((System.ComponentModel.ISupportInitialize)pbxPortada).BeginInit();
            SuspendLayout();
            // 
            // lblEncabezado
            // 
            lblEncabezado.AutoSize = true;
            lblEncabezado.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblEncabezado.Location = new Point(11, 16);
            lblEncabezado.Margin = new Padding(2, 0, 2, 0);
            lblEncabezado.Name = "lblEncabezado";
            lblEncabezado.Size = new Size(238, 21);
            lblEncabezado.TabIndex = 0;
            lblEncabezado.Text = "Detalle del libro (solo lectura)";
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(14, 64);
            lblId.Margin = new Padding(2, 0, 2, 0);
            lblId.Name = "lblId";
            lblId.Size = new Size(21, 15);
            lblId.TabIndex = 1;
            lblId.Text = "ID:";
            // 
            // txtId
            // 
            txtId.Location = new Point(149, 56);
            txtId.Margin = new Padding(2);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(219, 23);
            txtId.TabIndex = 2;
            txtId.TabStop = false;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Location = new Point(11, 101);
            lblTitulo.Margin = new Padding(2, 0, 2, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(40, 15);
            lblTitulo.TabIndex = 3;
            lblTitulo.Text = "Título:";
            // 
            // txtTitulo
            // 
            txtTitulo.Location = new Point(149, 93);
            txtTitulo.Margin = new Padding(2);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.ReadOnly = true;
            txtTitulo.Size = new Size(219, 23);
            txtTitulo.TabIndex = 4;
            txtTitulo.TabStop = false;
            // 
            // lblIsbn
            // 
            lblIsbn.AutoSize = true;
            lblIsbn.Location = new Point(11, 130);
            lblIsbn.Margin = new Padding(2, 0, 2, 0);
            lblIsbn.Name = "lblIsbn";
            lblIsbn.Size = new Size(35, 15);
            lblIsbn.TabIndex = 5;
            lblIsbn.Text = "ISBN:";
            // 
            // txtIsbn
            // 
            txtIsbn.Location = new Point(149, 122);
            txtIsbn.Margin = new Padding(2);
            txtIsbn.Name = "txtIsbn";
            txtIsbn.ReadOnly = true;
            txtIsbn.Size = new Size(219, 23);
            txtIsbn.TabIndex = 6;
            txtIsbn.TabStop = false;
            // 
            // lblAutor
            // 
            lblAutor.AutoSize = true;
            lblAutor.Location = new Point(14, 162);
            lblAutor.Margin = new Padding(2, 0, 2, 0);
            lblAutor.Name = "lblAutor";
            lblAutor.Size = new Size(40, 15);
            lblAutor.TabIndex = 7;
            lblAutor.Text = "Autor:";
            // 
            // txtAutor
            // 
            txtAutor.Location = new Point(149, 154);
            txtAutor.Margin = new Padding(2);
            txtAutor.Name = "txtAutor";
            txtAutor.ReadOnly = true;
            txtAutor.Size = new Size(219, 23);
            txtAutor.TabIndex = 8;
            txtAutor.TabStop = false;
            // 
            // lblCategoria
            // 
            lblCategoria.AutoSize = true;
            lblCategoria.Location = new Point(14, 193);
            lblCategoria.Margin = new Padding(2, 0, 2, 0);
            lblCategoria.Name = "lblCategoria";
            lblCategoria.Size = new Size(61, 15);
            lblCategoria.TabIndex = 9;
            lblCategoria.Text = "Categoría:";
            // 
            // txtCategoria
            // 
            txtCategoria.Location = new Point(149, 185);
            txtCategoria.Margin = new Padding(2);
            txtCategoria.Name = "txtCategoria";
            txtCategoria.ReadOnly = true;
            txtCategoria.Size = new Size(219, 23);
            txtCategoria.TabIndex = 10;
            txtCategoria.TabStop = false;
            // 
            // lblEditorial
            // 
            lblEditorial.AutoSize = true;
            lblEditorial.Location = new Point(14, 222);
            lblEditorial.Margin = new Padding(2, 0, 2, 0);
            lblEditorial.Name = "lblEditorial";
            lblEditorial.Size = new Size(53, 15);
            lblEditorial.TabIndex = 11;
            lblEditorial.Text = "Editorial:";
            // 
            // txtEditorial
            // 
            txtEditorial.Location = new Point(149, 214);
            txtEditorial.Margin = new Padding(2);
            txtEditorial.Name = "txtEditorial";
            txtEditorial.ReadOnly = true;
            txtEditorial.Size = new Size(219, 23);
            txtEditorial.TabIndex = 12;
            txtEditorial.TabStop = false;
            // 
            // lblAnio
            // 
            lblAnio.AutoSize = true;
            lblAnio.Location = new Point(14, 253);
            lblAnio.Margin = new Padding(2, 0, 2, 0);
            lblAnio.Name = "lblAnio";
            lblAnio.Size = new Size(113, 15);
            lblAnio.TabIndex = 13;
            lblAnio.Text = "Año de publicación:";
            // 
            // txtAnio
            // 
            txtAnio.Location = new Point(149, 245);
            txtAnio.Margin = new Padding(2);
            txtAnio.Name = "txtAnio";
            txtAnio.ReadOnly = true;
            txtAnio.Size = new Size(219, 23);
            txtAnio.TabIndex = 14;
            txtAnio.TabStop = false;
            // 
            // lblPuntoEntrega
            // 
            lblPuntoEntrega.AutoSize = true;
            lblPuntoEntrega.Location = new Point(14, 289);
            lblPuntoEntrega.Margin = new Padding(2, 0, 2, 0);
            lblPuntoEntrega.Name = "lblPuntoEntrega";
            lblPuntoEntrega.Size = new Size(101, 15);
            lblPuntoEntrega.TabIndex = 15;
            lblPuntoEntrega.Text = "Punto de entrega:";
            // 
            // txtPuntoEntrega
            // 
            txtPuntoEntrega.Location = new Point(149, 281);
            txtPuntoEntrega.Margin = new Padding(2);
            txtPuntoEntrega.Name = "txtPuntoEntrega";
            txtPuntoEntrega.ReadOnly = true;
            txtPuntoEntrega.Size = new Size(219, 23);
            txtPuntoEntrega.TabIndex = 16;
            txtPuntoEntrega.TabStop = false;
            // 
            // lblEjemplares
            // 
            lblEjemplares.AutoSize = true;
            lblEjemplares.Location = new Point(14, 320);
            lblEjemplares.Margin = new Padding(2, 0, 2, 0);
            lblEjemplares.Name = "lblEjemplares";
            lblEjemplares.Size = new Size(67, 15);
            lblEjemplares.TabIndex = 17;
            lblEjemplares.Text = "Ejemplares:";
            // 
            // txtEjemplares
            // 
            txtEjemplares.Location = new Point(149, 312);
            txtEjemplares.Margin = new Padding(2);
            txtEjemplares.Name = "txtEjemplares";
            txtEjemplares.ReadOnly = true;
            txtEjemplares.Size = new Size(219, 23);
            txtEjemplares.TabIndex = 18;
            txtEjemplares.TabStop = false;
            // 
            // lblActivo
            // 
            lblActivo.AutoSize = true;
            lblActivo.Location = new Point(396, 272);
            lblActivo.Margin = new Padding(2, 0, 2, 0);
            lblActivo.Name = "lblActivo";
            lblActivo.Size = new Size(66, 15);
            lblActivo.TabIndex = 30;
            lblActivo.Text = "Disponible:";
            // 
            // chkActivo
            // 
            chkActivo.AutoSize = true;
            chkActivo.Enabled = false;
            chkActivo.Location = new Point(505, 273);
            chkActivo.Margin = new Padding(2);
            chkActivo.Name = "chkActivo";
            chkActivo.Size = new Size(15, 14);
            chkActivo.TabIndex = 31;
            chkActivo.UseVisualStyleBackColor = true;
            // 
            // lblPortada
            // 
            lblPortada.AutoSize = true;
            lblPortada.Location = new Point(411, 16);
            lblPortada.Margin = new Padding(2, 0, 2, 0);
            lblPortada.Name = "lblPortada";
            lblPortada.Size = new Size(51, 15);
            lblPortada.TabIndex = 32;
            lblPortada.Text = "Portada:";
            // 
            // pbxPortada
            // 
            pbxPortada.BorderStyle = BorderStyle.FixedSingle;
            pbxPortada.Location = new Point(402, 45);
            pbxPortada.Margin = new Padding(2);
            pbxPortada.Name = "pbxPortada";
            pbxPortada.Size = new Size(149, 196);
            pbxPortada.SizeMode = PictureBoxSizeMode.StretchImage;
            pbxPortada.TabIndex = 33;
            pbxPortada.TabStop = false;
            // 
            // btnBajaLogica
            // 
            btnBajaLogica.FlatStyle = FlatStyle.Flat;
            btnBajaLogica.Font = new Font("Segoe UI", 11F, FontStyle.Bold | FontStyle.Italic);
            btnBajaLogica.Location = new Point(211, 342);
            btnBajaLogica.Margin = new Padding(2);
            btnBajaLogica.Name = "btnBajaLogica";
            btnBajaLogica.Size = new Size(131, 28);
            btnBajaLogica.TabIndex = 35;
            btnBajaLogica.Text = "Dar de baja";
            btnBajaLogica.UseVisualStyleBackColor = true;
            btnBajaLogica.Click += btnBajaLogica_Click;
            // 
            // btnEliminarFisico
            // 
            btnEliminarFisico.FlatStyle = FlatStyle.Flat;
            btnEliminarFisico.Font = new Font("Segoe UI", 11F, FontStyle.Bold | FontStyle.Italic);
            btnEliminarFisico.Location = new Point(357, 362);
            btnEliminarFisico.Margin = new Padding(2);
            btnEliminarFisico.Name = "btnEliminarFisico";
            btnEliminarFisico.Size = new Size(201, 30);
            btnEliminarFisico.TabIndex = 36;
            btnEliminarFisico.Text = "Eliminar definitivamente";
            btnEliminarFisico.UseVisualStyleBackColor = true;
            btnEliminarFisico.Click += btnEliminarFisico_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Segoe UI", 11F, FontStyle.Bold | FontStyle.Italic);
            btnCancelar.Location = new Point(211, 385);
            btnCancelar.Margin = new Padding(2);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(131, 28);
            btnCancelar.TabIndex = 37;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // lblAutoria
            // 
            lblAutoria.AutoSize = true;
            lblAutoria.Location = new Point(14, 350);
            lblAutoria.Margin = new Padding(2, 0, 2, 0);
            lblAutoria.Name = "lblAutoria";
            lblAutoria.Size = new Size(178, 60);
            lblAutoria.TabIndex = 34;
            lblAutoria.Text = "Equipo #2\r\nNUÑEZ Martinez Marco Antonio\r\nSUÑIGA Maciel Joule Alexander\r\nVILLA Olivares Ariel";
            // 
            // FrmDetalleLibro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnCancelar;
            ClientSize = new Size(569, 424);
            Controls.Add(lblEncabezado);
            Controls.Add(lblId);
            Controls.Add(txtId);
            Controls.Add(lblTitulo);
            Controls.Add(txtTitulo);
            Controls.Add(lblIsbn);
            Controls.Add(txtIsbn);
            Controls.Add(lblAutor);
            Controls.Add(txtAutor);
            Controls.Add(lblCategoria);
            Controls.Add(txtCategoria);
            Controls.Add(lblEditorial);
            Controls.Add(txtEditorial);
            Controls.Add(lblAnio);
            Controls.Add(txtAnio);
            Controls.Add(lblPuntoEntrega);
            Controls.Add(txtPuntoEntrega);
            Controls.Add(lblEjemplares);
            Controls.Add(txtEjemplares);
            Controls.Add(lblActivo);
            Controls.Add(chkActivo);
            Controls.Add(lblPortada);
            Controls.Add(pbxPortada);
            Controls.Add(lblAutoria);
            Controls.Add(btnBajaLogica);
            Controls.Add(btnEliminarFisico);
            Controls.Add(btnCancelar);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmDetalleLibro";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Detalle del libro";
            ((System.ComponentModel.ISupportInitialize)pbxPortada).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblEncabezado;
        private Label lblId;
        private TextBox txtId;
        private Label lblTitulo;
        private TextBox txtTitulo;
        private Label lblIsbn;
        private TextBox txtIsbn;
        private Label lblAutor;
        private TextBox txtAutor;
        private Label lblCategoria;
        private TextBox txtCategoria;
        private Label lblEditorial;
        private TextBox txtEditorial;
        private Label lblAnio;
        private TextBox txtAnio;
        private Label lblPuntoEntrega;
        private TextBox txtPuntoEntrega;
        private Label lblEjemplares;
        private TextBox txtEjemplares;
        private Label lblActivo;
        private CheckBox chkActivo;
        private Label lblPortada;
        private PictureBox pbxPortada;
        private BotonPersona3 btnBajaLogica;
        private BotonPersona3 btnEliminarFisico;
        private BotonPersona3 btnCancelar;
        private Label lblAutoria;
    }
}