//   Equipo 2
//   NUÑEZ Martinez Marco Antonio
//   SUÑIGA Maciel Joule Alexander
//   VILLA Olivarez Ariel
// =============================
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
            lblStock = new Label();
            txtStock = new TextBox();
            lblPrecio = new Label();
            txtPrecio = new TextBox();
            lblPortada = new Label();
            pbxPortada = new PictureBox();
            btnCargarPortada = new Button();
            pnlFormularioBase.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)epValidaciones).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbxPortada).BeginInit();
            SuspendLayout();
            // 
            // pnlFormularioBase
            // 
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
            pnlFormularioBase.Controls.Add(lblStock);
            pnlFormularioBase.Controls.Add(txtStock);
            pnlFormularioBase.Controls.Add(lblPrecio);
            pnlFormularioBase.Controls.Add(txtPrecio);
            pnlFormularioBase.Controls.Add(chkEstadoLibro);
            pnlFormularioBase.Controls.Add(lblPortada);
            pnlFormularioBase.Controls.Add(pbxPortada);
            pnlFormularioBase.Controls.Add(btnCargarPortada);
            pnlFormularioBase.Size = new Size(620, 315);
            pnlFormularioBase.Controls.SetChildIndex(btnCargarPortada, 0);
            pnlFormularioBase.Controls.SetChildIndex(pbxPortada, 0);
            pnlFormularioBase.Controls.SetChildIndex(lblPortada, 0);
            pnlFormularioBase.Controls.SetChildIndex(chkEstadoLibro, 0);
            pnlFormularioBase.Controls.SetChildIndex(txtPrecio, 0);
            pnlFormularioBase.Controls.SetChildIndex(lblPrecio, 0);
            pnlFormularioBase.Controls.SetChildIndex(txtStock, 0);
            pnlFormularioBase.Controls.SetChildIndex(lblStock, 0);
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
            // 
            // lblId
            // 
            lblId.Location = new Point(14, 7);
            // 
            // txtId
            // 
            txtId.Location = new Point(146, 4);
            // 
            // lblTituloLibro
            // 
            lblTituloLibro.AutoSize = true;
            lblTituloLibro.Location = new Point(14, 45);
            lblTituloLibro.Margin = new Padding(2, 0, 2, 0);
            lblTituloLibro.Name = "lblTituloLibro";
            lblTituloLibro.Size = new Size(40, 15);
            lblTituloLibro.TabIndex = 2;
            lblTituloLibro.Text = "Título:";
            // 
            // txtTituloLibro
            // 
            txtTituloLibro.Location = new Point(146, 37);
            txtTituloLibro.Margin = new Padding(2);
            txtTituloLibro.Name = "txtTituloLibro";
            txtTituloLibro.Size = new Size(162, 23);
            txtTituloLibro.TabIndex = 3;
            // 
            // lblIsbn
            // 
            lblIsbn.AutoSize = true;
            lblIsbn.Location = new Point(14, 85);
            lblIsbn.Margin = new Padding(2, 0, 2, 0);
            lblIsbn.Name = "lblIsbn";
            lblIsbn.Size = new Size(35, 15);
            lblIsbn.TabIndex = 4;
            lblIsbn.Text = "ISBN:";
            // 
            // txtIsbn
            // 
            txtIsbn.Location = new Point(146, 77);
            txtIsbn.Margin = new Padding(2);
            txtIsbn.MaxLength = 13;
            txtIsbn.Name = "txtIsbn";
            txtIsbn.Size = new Size(162, 23);
            txtIsbn.TabIndex = 5;
            // 
            // lblIdAutorLibro
            // 
            lblIdAutorLibro.AutoSize = true;
            lblIdAutorLibro.Location = new Point(14, 121);
            lblIdAutorLibro.Margin = new Padding(2, 0, 2, 0);
            lblIdAutorLibro.Name = "lblIdAutorLibro";
            lblIdAutorLibro.Size = new Size(40, 15);
            lblIdAutorLibro.TabIndex = 6;
            lblIdAutorLibro.Text = "Autor:";
            // 
            // cmbAutorLibro
            // 
            cmbAutorLibro.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbAutorLibro.FormattingEnabled = true;
            cmbAutorLibro.Location = new Point(146, 113);
            cmbAutorLibro.Margin = new Padding(2);
            cmbAutorLibro.Name = "cmbAutorLibro";
            cmbAutorLibro.Size = new Size(162, 23);
            cmbAutorLibro.TabIndex = 7;
            // 
            // lblIdCategoriaLibro
            // 
            lblIdCategoriaLibro.AutoSize = true;
            lblIdCategoriaLibro.Location = new Point(14, 160);
            lblIdCategoriaLibro.Margin = new Padding(2, 0, 2, 0);
            lblIdCategoriaLibro.Name = "lblIdCategoriaLibro";
            lblIdCategoriaLibro.Size = new Size(61, 15);
            lblIdCategoriaLibro.TabIndex = 8;
            lblIdCategoriaLibro.Text = "Categoría:";
            // 
            // cmbCategoriaLibro
            // 
            cmbCategoriaLibro.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCategoriaLibro.FormattingEnabled = true;
            cmbCategoriaLibro.Location = new Point(146, 152);
            cmbCategoriaLibro.Margin = new Padding(2);
            cmbCategoriaLibro.Name = "cmbCategoriaLibro";
            cmbCategoriaLibro.Size = new Size(162, 23);
            cmbCategoriaLibro.TabIndex = 9;
            // 
            // lblIdEditorialLibro
            // 
            lblIdEditorialLibro.AutoSize = true;
            lblIdEditorialLibro.Location = new Point(14, 199);
            lblIdEditorialLibro.Margin = new Padding(2, 0, 2, 0);
            lblIdEditorialLibro.Name = "lblIdEditorialLibro";
            lblIdEditorialLibro.Size = new Size(53, 15);
            lblIdEditorialLibro.TabIndex = 10;
            lblIdEditorialLibro.Text = "Editorial:";
            // 
            // cmbEditorialLibro
            // 
            cmbEditorialLibro.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbEditorialLibro.FormattingEnabled = true;
            cmbEditorialLibro.Location = new Point(146, 191);
            cmbEditorialLibro.Margin = new Padding(2);
            cmbEditorialLibro.Name = "cmbEditorialLibro";
            cmbEditorialLibro.Size = new Size(162, 23);
            cmbEditorialLibro.TabIndex = 11;
            // 
            // lblAnioPublicacion
            // 
            lblAnioPublicacion.AutoSize = true;
            lblAnioPublicacion.Location = new Point(14, 236);
            lblAnioPublicacion.Margin = new Padding(2, 0, 2, 0);
            lblAnioPublicacion.Name = "lblAnioPublicacion";
            lblAnioPublicacion.Size = new Size(113, 15);
            lblAnioPublicacion.TabIndex = 12;
            lblAnioPublicacion.Text = "Año de publicación:";
            // 
            // txtAnioPublicacion
            // 
            txtAnioPublicacion.Location = new Point(146, 228);
            txtAnioPublicacion.Margin = new Padding(2);
            txtAnioPublicacion.MaxLength = 4;
            txtAnioPublicacion.Name = "txtAnioPublicacion";
            txtAnioPublicacion.Size = new Size(71, 23);
            txtAnioPublicacion.TabIndex = 13;
            // 
            // lblPuntoEntrega
            // 
            lblPuntoEntrega.AutoSize = true;
            lblPuntoEntrega.Location = new Point(14, 276);
            lblPuntoEntrega.Margin = new Padding(2, 0, 2, 0);
            lblPuntoEntrega.Name = "lblPuntoEntrega";
            lblPuntoEntrega.Size = new Size(101, 15);
            lblPuntoEntrega.TabIndex = 14;
            lblPuntoEntrega.Text = "Punto de entrega:";
            // 
            // txtPuntoEntrega
            // 
            txtPuntoEntrega.Location = new Point(146, 268);
            txtPuntoEntrega.Margin = new Padding(2);
            txtPuntoEntrega.MaxLength = 100;
            txtPuntoEntrega.Name = "txtPuntoEntrega";
            txtPuntoEntrega.PlaceholderText = "Opcional";
            txtPuntoEntrega.Size = new Size(162, 23);
            txtPuntoEntrega.TabIndex = 15;
            // 
            // chkEstadoLibro
            // 
            chkEstadoLibro.AutoSize = true;
            chkEstadoLibro.Location = new Point(418, 285);
            chkEstadoLibro.Margin = new Padding(2);
            chkEstadoLibro.Name = "chkEstadoLibro";
            chkEstadoLibro.Size = new Size(82, 19);
            chkEstadoLibro.TabIndex = 16;
            chkEstadoLibro.Text = "Disponible";
            chkEstadoLibro.UseVisualStyleBackColor = true;
            // 
            // lblStock
            // 
            lblStock.AutoSize = true;
            lblStock.Location = new Point(372, 257);
            lblStock.Margin = new Padding(2, 0, 2, 0);
            lblStock.Name = "lblStock";
            lblStock.Size = new Size(39, 15);
            lblStock.TabIndex = 20;
            lblStock.Text = "Stock:";
            lblStock.Visible = false;
            // 
            // txtStock
            // 
            txtStock.Location = new Point(414, 249);
            txtStock.Margin = new Padding(2);
            txtStock.MaxLength = 3;
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(56, 23);
            txtStock.TabIndex = 17;
            txtStock.Visible = false;
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Location = new Point(480, 257);
            lblPrecio.Margin = new Padding(2, 0, 2, 0);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(43, 15);
            lblPrecio.TabIndex = 22;
            lblPrecio.Text = "Precio:";
            lblPrecio.Visible = false;
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(526, 249);
            txtPrecio.Margin = new Padding(2);
            txtPrecio.MaxLength = 11;
            txtPrecio.Name = "txtPrecio";
            txtPrecio.PlaceholderText = "0.00";
            txtPrecio.Size = new Size(80, 23);
            txtPrecio.TabIndex = 21;
            txtPrecio.Visible = false;
            // 
            // lblPortada
            // 
            lblPortada.AutoSize = true;
            lblPortada.Location = new Point(405, 13);
            lblPortada.Margin = new Padding(2, 0, 2, 0);
            lblPortada.Name = "lblPortada";
            lblPortada.Size = new Size(51, 15);
            lblPortada.TabIndex = 17;
            lblPortada.Text = "Portada:";
            // 
            // pbxPortada
            // 
            pbxPortada.BorderStyle = BorderStyle.FixedSingle;
            pbxPortada.Location = new Point(405, 39);
            pbxPortada.Margin = new Padding(2);
            pbxPortada.Name = "pbxPortada";
            pbxPortada.Size = new Size(130, 153);
            pbxPortada.SizeMode = PictureBoxSizeMode.StretchImage;
            pbxPortada.TabIndex = 18;
            pbxPortada.TabStop = false;
            // 
            // btnCargarPortada
            // 
            btnCargarPortada.Location = new Point(372, 210);
            btnCargarPortada.Margin = new Padding(2);
            btnCargarPortada.Name = "btnCargarPortada";
            btnCargarPortada.Size = new Size(186, 24);
            btnCargarPortada.TabIndex = 19;
            btnCargarPortada.Text = "Cargar portada";
            btnCargarPortada.UseVisualStyleBackColor = true;
            // 
            // FrmLibro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(620, 315);
            Name = "FrmLibro";
            Text = "FrmLibro";
            pnlFormularioBase.ResumeLayout(false);
            pnlFormularioBase.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)epValidaciones).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbxPortada).EndInit();
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
        private Label lblStock;
        private TextBox txtStock;
        private Label lblPrecio;
        private TextBox txtPrecio;
        private Label lblPortada;
        private PictureBox pbxPortada;
        private Button btnCargarPortada;
    }
}