//   Equipo #2
//   SUÑIGA Maciel Joule Alexander
//   VILLA Olivares Ariel
//   NUÑEZ Martinez Marco Antonio
// ===============================
namespace SistemaBiblioteca1
{
    partial class FrmLibro
    {
        private void InitializeComponent()
        {
            lblTituloLibro = new Label();
            txtTituloLibro = new TextBox();
            lblIsbn = new Label();
            txtIsbn = new TextBox();
            lblIdAutorLibro = new Label();
            cmbAutorLibro = new ComboBox();
            lblIdCategoriaLibro = new Label();
            cmbCategoriaLibro = new ComboBox();
            lblIdEditorialLibro = new Label();
            cmbEditorialLibro = new ComboBox();
            lblAnioPublicacion = new Label();
            txtAnioPublicacion = new TextBox();
            lblPuntoEntrega = new Label();
            txtPuntoEntrega = new TextBox();
            chkEstadoLibro = new CheckBox();
            lblPortada = new Label();
            pbxPortada = new PictureBox();
            btnCargarPortada = new Button();
            lblAutoria = new Label();
            pnlFormularioBase.SuspendLayout();
            SuspendLayout();

            pnlFormularioBase.Controls.Add(lblTituloLibro);
            pnlFormularioBase.Controls.Add(txtTituloLibro);
            pnlFormularioBase.Controls.Add(lblIsbn);
            pnlFormularioBase.Controls.Add(txtIsbn);
            pnlFormularioBase.Controls.Add(lblIdAutorLibro);
            pnlFormularioBase.Controls.Add(cmbAutorLibro);
            pnlFormularioBase.Controls.Add(lblIdCategoriaLibro);
            pnlFormularioBase.Controls.Add(cmbCategoriaLibro);
            pnlFormularioBase.Controls.Add(lblIdEditorialLibro);
            pnlFormularioBase.Controls.Add(cmbEditorialLibro);
            pnlFormularioBase.Controls.Add(lblAnioPublicacion);
            pnlFormularioBase.Controls.Add(txtAnioPublicacion);
            pnlFormularioBase.Controls.Add(lblPuntoEntrega);
            pnlFormularioBase.Controls.Add(txtPuntoEntrega);
            pnlFormularioBase.Controls.Add(chkEstadoLibro);
            pnlFormularioBase.Controls.Add(lblPortada);
            pnlFormularioBase.Controls.Add(pbxPortada);
            pnlFormularioBase.Controls.Add(btnCargarPortada);
            pnlFormularioBase.Controls.Add(lblAutoria);
            pnlFormularioBase.Controls.SetChildIndex(chkEstadoLibro, 0);
            pnlFormularioBase.Controls.SetChildIndex(txtPuntoEntrega, 0);
            pnlFormularioBase.Controls.SetChildIndex(lblPuntoEntrega, 0);
            pnlFormularioBase.Controls.SetChildIndex(txtAnioPublicacion, 0);
            pnlFormularioBase.Controls.SetChildIndex(lblAnioPublicacion, 0);
            pnlFormularioBase.Controls.SetChildIndex(cmbEditorialLibro, 0);
            pnlFormularioBase.Controls.SetChildIndex(lblIdEditorialLibro, 0);
            pnlFormularioBase.Controls.SetChildIndex(cmbCategoriaLibro, 0);
            pnlFormularioBase.Controls.SetChildIndex(lblIdCategoriaLibro, 0);
            pnlFormularioBase.Controls.SetChildIndex(cmbAutorLibro, 0);
            pnlFormularioBase.Controls.SetChildIndex(lblIdAutorLibro, 0);
            pnlFormularioBase.Controls.SetChildIndex(txtIsbn, 0);
            pnlFormularioBase.Controls.SetChildIndex(lblIsbn, 0);
            pnlFormularioBase.Controls.SetChildIndex(txtTituloLibro, 0);
            pnlFormularioBase.Controls.SetChildIndex(lblTituloLibro, 0);
            pnlFormularioBase.Controls.SetChildIndex(txtId, 0);
            pnlFormularioBase.Controls.SetChildIndex(lblId, 0);

            lblId.Location = new Point(13, 16);

            txtId.Location = new Point(184, 13);

            lblTituloLibro.AutoSize = true;
            lblTituloLibro.Location = new Point(16, 58);
            lblTituloLibro.Margin = new Padding(2, 0, 2, 0);
            lblTituloLibro.Name = "lblTituloLibro";
            lblTituloLibro.Size = new Size(50, 20);
            lblTituloLibro.TabIndex = 2;
            lblTituloLibro.Text = "Título:";

            txtTituloLibro.Location = new Point(184, 56);
            txtTituloLibro.Margin = new Padding(2, 2, 2, 2);
            txtTituloLibro.Name = "txtTituloLibro";
            txtTituloLibro.Size = new Size(185, 27);
            txtTituloLibro.TabIndex = 3;

            lblIsbn.AutoSize = true;
            lblIsbn.Location = new Point(16, 90);
            lblIsbn.Margin = new Padding(2, 0, 2, 0);
            lblIsbn.Name = "lblIsbn";
            lblIsbn.Size = new Size(44, 20);
            lblIsbn.TabIndex = 4;
            lblIsbn.Text = "ISBN:";

            txtIsbn.Location = new Point(184, 88);
            txtIsbn.Margin = new Padding(2, 2, 2, 2);
            txtIsbn.MaxLength = 13;
            txtIsbn.Name = "txtIsbn";
            txtIsbn.Size = new Size(185, 27);
            txtIsbn.TabIndex = 5;

            lblIdAutorLibro.AutoSize = true;
            lblIdAutorLibro.Location = new Point(16, 122);
            lblIdAutorLibro.Margin = new Padding(2, 0, 2, 0);
            lblIdAutorLibro.Name = "lblIdAutorLibro";
            lblIdAutorLibro.Size = new Size(68, 20);
            lblIdAutorLibro.TabIndex = 6;
            lblIdAutorLibro.Text = "Autor:";

            cmbAutorLibro.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbAutorLibro.FormattingEnabled = true;
            cmbAutorLibro.Location = new Point(184, 120);
            cmbAutorLibro.Margin = new Padding(2, 2, 2, 2);
            cmbAutorLibro.Name = "cmbAutorLibro";
            cmbAutorLibro.Size = new Size(185, 27);
            cmbAutorLibro.TabIndex = 7;

            lblIdCategoriaLibro.AutoSize = true;
            lblIdCategoriaLibro.Location = new Point(16, 154);
            lblIdCategoriaLibro.Margin = new Padding(2, 0, 2, 0);
            lblIdCategoriaLibro.Name = "lblIdCategoriaLibro";
            lblIdCategoriaLibro.Size = new Size(96, 20);
            lblIdCategoriaLibro.TabIndex = 8;
            lblIdCategoriaLibro.Text = "Categoría:";

            cmbCategoriaLibro.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCategoriaLibro.FormattingEnabled = true;
            cmbCategoriaLibro.Location = new Point(184, 152);
            cmbCategoriaLibro.Margin = new Padding(2, 2, 2, 2);
            cmbCategoriaLibro.Name = "cmbCategoriaLibro";
            cmbCategoriaLibro.Size = new Size(185, 27);
            cmbCategoriaLibro.TabIndex = 9;

            lblIdEditorialLibro.AutoSize = true;
            lblIdEditorialLibro.Location = new Point(16, 186);
            lblIdEditorialLibro.Margin = new Padding(2, 0, 2, 0);
            lblIdEditorialLibro.Name = "lblIdEditorialLibro";
            lblIdEditorialLibro.Size = new Size(87, 20);
            lblIdEditorialLibro.TabIndex = 10;
            lblIdEditorialLibro.Text = "Editorial:";

            cmbEditorialLibro.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbEditorialLibro.FormattingEnabled = true;
            cmbEditorialLibro.Location = new Point(184, 184);
            cmbEditorialLibro.Margin = new Padding(2, 2, 2, 2);
            cmbEditorialLibro.Name = "cmbEditorialLibro";
            cmbEditorialLibro.Size = new Size(185, 27);
            cmbEditorialLibro.TabIndex = 11;

            lblAnioPublicacion.AutoSize = true;
            lblAnioPublicacion.Location = new Point(16, 218);
            lblAnioPublicacion.Margin = new Padding(2, 0, 2, 0);
            lblAnioPublicacion.Name = "lblAnioPublicacion";
            lblAnioPublicacion.Size = new Size(141, 20);
            lblAnioPublicacion.TabIndex = 12;
            lblAnioPublicacion.Text = "Año de publicación:";

            txtAnioPublicacion.Location = new Point(184, 216);
            txtAnioPublicacion.Margin = new Padding(2, 2, 2, 2);
            txtAnioPublicacion.MaxLength = 4;
            txtAnioPublicacion.Name = "txtAnioPublicacion";
            txtAnioPublicacion.Size = new Size(81, 27);
            txtAnioPublicacion.TabIndex = 13;

            lblPuntoEntrega.AutoSize = true;
            lblPuntoEntrega.Location = new Point(16, 250);
            lblPuntoEntrega.Margin = new Padding(2, 0, 2, 0);
            lblPuntoEntrega.Name = "lblPuntoEntrega";
            lblPuntoEntrega.Size = new Size(130, 20);
            lblPuntoEntrega.TabIndex = 14;
            lblPuntoEntrega.Text = "Punto de entrega:";

            txtPuntoEntrega.Location = new Point(184, 248);
            txtPuntoEntrega.Margin = new Padding(2, 2, 2, 2);
            txtPuntoEntrega.MaxLength = 100;
            txtPuntoEntrega.Name = "txtPuntoEntrega";
            txtPuntoEntrega.PlaceholderText = "Opcional";
            txtPuntoEntrega.Size = new Size(185, 27);
            txtPuntoEntrega.TabIndex = 15;

            chkEstadoLibro.AutoSize = true;
            chkEstadoLibro.Location = new Point(184, 286);
            chkEstadoLibro.Margin = new Padding(2, 2, 2, 2);
            chkEstadoLibro.Name = "chkEstadoLibro";
            chkEstadoLibro.Size = new Size(103, 24);
            chkEstadoLibro.TabIndex = 16;
            chkEstadoLibro.Text = "Disponible";
            chkEstadoLibro.UseVisualStyleBackColor = true;

            lblPortada.AutoSize = true;
            lblPortada.Location = new Point(400, 30);
            lblPortada.Margin = new Padding(2, 0, 2, 0);
            lblPortada.Name = "lblPortada";
            lblPortada.Size = new Size(66, 20);
            lblPortada.TabIndex = 17;
            lblPortada.Text = "Portada:";

            pbxPortada.BorderStyle = BorderStyle.FixedSingle;
            pbxPortada.Location = new Point(400, 56);
            pbxPortada.Margin = new Padding(2, 2, 2, 2);
            pbxPortada.Name = "pbxPortada";
            pbxPortada.Size = new Size(160, 200);
            pbxPortada.SizeMode = PictureBoxSizeMode.StretchImage;
            pbxPortada.TabIndex = 18;
            pbxPortada.TabStop = false;

            btnCargarPortada.Location = new Point(400, 264);
            btnCargarPortada.Margin = new Padding(2, 2, 2, 2);
            btnCargarPortada.Name = "btnCargarPortada";
            btnCargarPortada.Size = new Size(160, 32);
            btnCargarPortada.TabIndex = 19;
            btnCargarPortada.Text = "Cargar portada";
            btnCargarPortada.UseVisualStyleBackColor = true;

            lblAutoria.AutoSize = true;
            lblAutoria.Location = new Point(16, 322);
            lblAutoria.Margin = new Padding(2, 0, 2, 0);
            lblAutoria.Name = "lblAutoria";
            lblAutoria.Size = new Size(240, 80);
            lblAutoria.TabIndex = 20;
            lblAutoria.Text = "Equipo #2\r\nNUÑEZ Martinez Marco Antonio\r\nSUÑIGA Maciel Joule Alexander\r\nVILLA Olivares Ariel";

            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(640, 420);
            Name = "FrmLibro";
            Text = "FrmLibro";
            pnlFormularioBase.ResumeLayout(false);
            pnlFormularioBase.PerformLayout();
            ResumeLayout(false);
        }

        private Label lblTituloLibro;
        private TextBox txtTituloLibro;
        private Label lblIsbn;
        private TextBox txtIsbn;
        private Label lblIdAutorLibro;
        private ComboBox cmbAutorLibro;
        private Label lblIdCategoriaLibro;
        private ComboBox cmbCategoriaLibro;
        private Label lblIdEditorialLibro;
        private ComboBox cmbEditorialLibro;
        private Label lblAnioPublicacion;
        private TextBox txtAnioPublicacion;
        private Label lblPuntoEntrega;
        private TextBox txtPuntoEntrega;
        private CheckBox chkEstadoLibro;
        private Label lblPortada;
        private PictureBox pbxPortada;
        private Button btnCargarPortada;
        private Label lblAutoria;
    }
}