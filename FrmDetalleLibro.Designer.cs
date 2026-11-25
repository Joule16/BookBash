//   Equipo #2
//   SUÑIGA Maciel Joule Alexander
//   VILLA Olivares Ariel
//   NUÑEZ Martinez Marco Antonio
// ===============================
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

            lblEncabezado.AutoSize = true;
            lblEncabezado.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblEncabezado.Location = new Point(16, 14);
            lblEncabezado.Margin = new Padding(2, 0, 2, 0);
            lblEncabezado.Name = "lblEncabezado";
            lblEncabezado.Size = new Size(420, 28);
            lblEncabezado.TabIndex = 0;
            lblEncabezado.Text = "Detalle del libro (solo lectura)";

            lblId.AutoSize = true;
            lblId.Location = new Point(16, 60);
            lblId.Margin = new Padding(2, 0, 2, 0);
            lblId.Name = "lblId";
            lblId.Size = new Size(120, 20);
            lblId.TabIndex = 1;
            lblId.Text = "ID:";

            txtId.Location = new Point(170, 56);
            txtId.Margin = new Padding(2, 2, 2, 2);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(250, 27);
            txtId.TabIndex = 2;
            txtId.TabStop = false;

            lblTitulo.AutoSize = true;
            lblTitulo.Location = new Point(16, 100);
            lblTitulo.Margin = new Padding(2, 0, 2, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(120, 20);
            lblTitulo.TabIndex = 3;
            lblTitulo.Text = "Título:";

            txtTitulo.Location = new Point(170, 96);
            txtTitulo.Margin = new Padding(2, 2, 2, 2);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.ReadOnly = true;
            txtTitulo.Size = new Size(250, 27);
            txtTitulo.TabIndex = 4;
            txtTitulo.TabStop = false;

            lblIsbn.AutoSize = true;
            lblIsbn.Location = new Point(16, 140);
            lblIsbn.Margin = new Padding(2, 0, 2, 0);
            lblIsbn.Name = "lblIsbn";
            lblIsbn.Size = new Size(120, 20);
            lblIsbn.TabIndex = 5;
            lblIsbn.Text = "ISBN:";

            txtIsbn.Location = new Point(170, 136);
            txtIsbn.Margin = new Padding(2, 2, 2, 2);
            txtIsbn.Name = "txtIsbn";
            txtIsbn.ReadOnly = true;
            txtIsbn.Size = new Size(250, 27);
            txtIsbn.TabIndex = 6;
            txtIsbn.TabStop = false;

            lblAutor.AutoSize = true;
            lblAutor.Location = new Point(16, 180);
            lblAutor.Margin = new Padding(2, 0, 2, 0);
            lblAutor.Name = "lblAutor";
            lblAutor.Size = new Size(120, 20);
            lblAutor.TabIndex = 7;
            lblAutor.Text = "Autor:";

            txtAutor.Location = new Point(170, 176);
            txtAutor.Margin = new Padding(2, 2, 2, 2);
            txtAutor.Name = "txtAutor";
            txtAutor.ReadOnly = true;
            txtAutor.Size = new Size(250, 27);
            txtAutor.TabIndex = 8;
            txtAutor.TabStop = false;

            lblCategoria.AutoSize = true;
            lblCategoria.Location = new Point(16, 220);
            lblCategoria.Margin = new Padding(2, 0, 2, 0);
            lblCategoria.Name = "lblCategoria";
            lblCategoria.Size = new Size(120, 20);
            lblCategoria.TabIndex = 9;
            lblCategoria.Text = "Categoría:";

            txtCategoria.Location = new Point(170, 216);
            txtCategoria.Margin = new Padding(2, 2, 2, 2);
            txtCategoria.Name = "txtCategoria";
            txtCategoria.ReadOnly = true;
            txtCategoria.Size = new Size(250, 27);
            txtCategoria.TabIndex = 10;
            txtCategoria.TabStop = false;

            lblEditorial.AutoSize = true;
            lblEditorial.Location = new Point(16, 260);
            lblEditorial.Margin = new Padding(2, 0, 2, 0);
            lblEditorial.Name = "lblEditorial";
            lblEditorial.Size = new Size(120, 20);
            lblEditorial.TabIndex = 11;
            lblEditorial.Text = "Editorial:";

            txtEditorial.Location = new Point(170, 256);
            txtEditorial.Margin = new Padding(2, 2, 2, 2);
            txtEditorial.Name = "txtEditorial";
            txtEditorial.ReadOnly = true;
            txtEditorial.Size = new Size(250, 27);
            txtEditorial.TabIndex = 12;
            txtEditorial.TabStop = false;

            lblAnio.AutoSize = true;
            lblAnio.Location = new Point(16, 300);
            lblAnio.Margin = new Padding(2, 0, 2, 0);
            lblAnio.Name = "lblAnio";
            lblAnio.Size = new Size(120, 20);
            lblAnio.TabIndex = 13;
            lblAnio.Text = "Año de publicación:";

            txtAnio.Location = new Point(170, 296);
            txtAnio.Margin = new Padding(2, 2, 2, 2);
            txtAnio.Name = "txtAnio";
            txtAnio.ReadOnly = true;
            txtAnio.Size = new Size(250, 27);
            txtAnio.TabIndex = 14;
            txtAnio.TabStop = false;

            lblPuntoEntrega.AutoSize = true;
            lblPuntoEntrega.Location = new Point(16, 340);
            lblPuntoEntrega.Margin = new Padding(2, 0, 2, 0);
            lblPuntoEntrega.Name = "lblPuntoEntrega";
            lblPuntoEntrega.Size = new Size(120, 20);
            lblPuntoEntrega.TabIndex = 15;
            lblPuntoEntrega.Text = "Punto de entrega:";

            txtPuntoEntrega.Location = new Point(170, 336);
            txtPuntoEntrega.Margin = new Padding(2, 2, 2, 2);
            txtPuntoEntrega.Name = "txtPuntoEntrega";
            txtPuntoEntrega.ReadOnly = true;
            txtPuntoEntrega.Size = new Size(250, 27);
            txtPuntoEntrega.TabIndex = 16;
            txtPuntoEntrega.TabStop = false;

            lblEjemplares.AutoSize = true;
            lblEjemplares.Location = new Point(16, 380);
            lblEjemplares.Margin = new Padding(2, 0, 2, 0);
            lblEjemplares.Name = "lblEjemplares";
            lblEjemplares.Size = new Size(120, 20);
            lblEjemplares.TabIndex = 17;
            lblEjemplares.Text = "Ejemplares:";

            txtEjemplares.Location = new Point(170, 376);
            txtEjemplares.Margin = new Padding(2, 2, 2, 2);
            txtEjemplares.Name = "txtEjemplares";
            txtEjemplares.ReadOnly = true;
            txtEjemplares.Size = new Size(250, 27);
            txtEjemplares.TabIndex = 18;
            txtEjemplares.TabStop = false;

            lblActivo.AutoSize = true;
            lblActivo.Location = new Point(16, 420);
            lblActivo.Margin = new Padding(2, 0, 2, 0);
            lblActivo.Name = "lblActivo";
            lblActivo.Size = new Size(120, 20);
            lblActivo.TabIndex = 30;
            lblActivo.Text = "Disponible:";

            chkActivo.AutoSize = true;
            chkActivo.Enabled = false;
            chkActivo.Location = new Point(170, 420);
            chkActivo.Margin = new Padding(2, 2, 2, 2);
            chkActivo.Name = "chkActivo";
            chkActivo.Size = new Size(18, 17);
            chkActivo.TabIndex = 31;
            chkActivo.UseVisualStyleBackColor = true;

            lblPortada.AutoSize = true;
            lblPortada.Location = new Point(450, 60);
            lblPortada.Margin = new Padding(2, 0, 2, 0);
            lblPortada.Name = "lblPortada";
            lblPortada.Size = new Size(66, 20);
            lblPortada.TabIndex = 32;
            lblPortada.Text = "Portada:";

            pbxPortada.BorderStyle = BorderStyle.FixedSingle;
            pbxPortada.Location = new Point(450, 86);
            pbxPortada.Margin = new Padding(2, 2, 2, 2);
            pbxPortada.Name = "pbxPortada";
            pbxPortada.Size = new Size(160, 200);
            pbxPortada.SizeMode = PictureBoxSizeMode.StretchImage;
            pbxPortada.TabIndex = 33;
            pbxPortada.TabStop = false;

            lblAutoria.AutoSize = true;
            lblAutoria.Location = new Point(16, 456);
            lblAutoria.Margin = new Padding(2, 0, 2, 0);
            lblAutoria.Name = "lblAutoria";
            lblAutoria.Size = new Size(240, 80);
            lblAutoria.TabIndex = 34;
            lblAutoria.Text = "Equipo #2\r\nNUÑEZ Martinez Marco Antonio\r\nSUÑIGA Maciel Joule Alexander\r\nVILLA Olivares Ariel";

            btnBajaLogica.Location = new Point(300, 456);
            btnBajaLogica.Margin = new Padding(2, 2, 2, 2);
            btnBajaLogica.Name = "btnBajaLogica";
            btnBajaLogica.Size = new Size(150, 38);
            btnBajaLogica.TabIndex = 35;
            btnBajaLogica.Text = "Dar de baja";
            btnBajaLogica.UseVisualStyleBackColor = true;
            btnBajaLogica.Click += btnBajaLogica_Click;

            btnEliminarFisico.Location = new Point(460, 456);
            btnEliminarFisico.Margin = new Padding(2, 2, 2, 2);
            btnEliminarFisico.Name = "btnEliminarFisico";
            btnEliminarFisico.Size = new Size(170, 38);
            btnEliminarFisico.TabIndex = 36;
            btnEliminarFisico.Text = "Eliminar definitivamente";
            btnEliminarFisico.UseVisualStyleBackColor = true;
            btnEliminarFisico.Click += btnEliminarFisico_Click;

            btnCancelar.Location = new Point(300, 502);
            btnCancelar.Margin = new Padding(2, 2, 2, 2);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(150, 38);
            btnCancelar.TabIndex = 37;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;

            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnCancelar;
            ClientSize = new Size(650, 566);
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
            Margin = new Padding(2, 2, 2, 2);
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