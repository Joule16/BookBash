//   Equipo 2
//   NUÑEZ Martinez Marco Antonio
//   SUÑIGA Maciel Joule Alexander
//   VILLA Olivarez Ariel
// =============================
// Actividad 4.7 - Carrito de compras
namespace SistemaBiblioteca1
{
    partial class FrmVentas
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
            DataGridViewCellStyle estiloPrecioRes = new DataGridViewCellStyle();
            DataGridViewCellStyle estiloPrecioCar = new DataGridViewCellStyle();
            DataGridViewCellStyle estiloSubtotalCar = new DataGridViewCellStyle();
            DataGridViewCellStyle estiloCantidadCar = new DataGridViewCellStyle();
            pnlEncabezado = new Panel();
            lblTitulo = new Label();
            lblEquipo = new Label();
            lblAutor1 = new Label();
            lblAutor2 = new Label();
            lblAutor3 = new Label();
            grpBusqueda = new GroupBox();
            lblBuscarId = new Label();
            txtIdBuscar = new TextBox();
            btnBuscarId = new Button();
            lblBuscarNombre = new Label();
            txtNombreBuscar = new TextBox();
            dgvResultados = new DataGridView();
            colResId = new DataGridViewTextBoxColumn();
            colResTitulo = new DataGridViewTextBoxColumn();
            colResAutor = new DataGridViewTextBoxColumn();
            colResIsbn = new DataGridViewTextBoxColumn();
            colResPrecio = new DataGridViewTextBoxColumn();
            colResStock = new DataGridViewTextBoxColumn();
            lblCantidad = new Label();
            nudCantidad = new NumericUpDown();
            btnAnadir = new Button();
            lblMensaje = new Label();
            dgvCarrito = new DataGridView();
            colCarId = new DataGridViewTextBoxColumn();
            colCarTitulo = new DataGridViewTextBoxColumn();
            colCarCantidad = new DataGridViewTextBoxColumn();
            colCarPrecio = new DataGridViewTextBoxColumn();
            colCarSubtotal = new DataGridViewTextBoxColumn();
            btnQuitar = new Button();
            lblTotalTitulo = new Label();
            lblTotalVenta = new Label();
            btnConfirmar = new Button();
            pnlEncabezado.SuspendLayout();
            grpBusqueda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvResultados).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudCantidad).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvCarrito).BeginInit();
            SuspendLayout();
            // 
            // pnlEncabezado
            // 
            pnlEncabezado.Controls.Add(lblAutor3);
            pnlEncabezado.Controls.Add(lblAutor2);
            pnlEncabezado.Controls.Add(lblAutor1);
            pnlEncabezado.Controls.Add(lblEquipo);
            pnlEncabezado.Controls.Add(lblTitulo);
            pnlEncabezado.Dock = DockStyle.Top;
            pnlEncabezado.Location = new Point(0, 0);
            pnlEncabezado.Name = "pnlEncabezado";
            pnlEncabezado.Size = new Size(1000, 80);
            pnlEncabezado.TabIndex = 0;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblTitulo.Location = new Point(14, 8);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(381, 32);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Terminal de ventas - Carrito de compras";
            // 
            // lblEquipo
            // 
            lblEquipo.AutoSize = true;
            lblEquipo.Location = new Point(14, 48);
            lblEquipo.Name = "lblEquipo";
            lblEquipo.Size = new Size(77, 20);
            lblEquipo.TabIndex = 1;
            lblEquipo.Text = "Equipo #2";
            // 
            // lblAutor1
            // 
            lblAutor1.AutoSize = true;
            lblAutor1.Location = new Point(130, 48);
            lblAutor1.Name = "lblAutor1";
            lblAutor1.Size = new Size(200, 20);
            lblAutor1.TabIndex = 2;
            lblAutor1.Text = "NUÑEZ Martinez Marco Antonio";
            // 
            // lblAutor2
            // 
            lblAutor2.AutoSize = true;
            lblAutor2.Location = new Point(400, 48);
            lblAutor2.Name = "lblAutor2";
            lblAutor2.Size = new Size(200, 20);
            lblAutor2.TabIndex = 3;
            lblAutor2.Text = "SUÑIGA Maciel Joule Alexander";
            // 
            // lblAutor3
            // 
            lblAutor3.AutoSize = true;
            lblAutor3.Location = new Point(670, 48);
            lblAutor3.Name = "lblAutor3";
            lblAutor3.Size = new Size(150, 20);
            lblAutor3.TabIndex = 4;
            lblAutor3.Text = "VILLA Olivares Ariel";
            // 
            // grpBusqueda
            // 
            grpBusqueda.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            grpBusqueda.Controls.Add(txtNombreBuscar);
            grpBusqueda.Controls.Add(lblBuscarNombre);
            grpBusqueda.Controls.Add(btnBuscarId);
            grpBusqueda.Controls.Add(txtIdBuscar);
            grpBusqueda.Controls.Add(lblBuscarId);
            grpBusqueda.Location = new Point(12, 88);
            grpBusqueda.Name = "grpBusqueda";
            grpBusqueda.Size = new Size(976, 74);
            grpBusqueda.TabIndex = 1;
            grpBusqueda.TabStop = false;
            grpBusqueda.Text = "Búsqueda de libros";
            // 
            // lblBuscarId
            // 
            lblBuscarId.AutoSize = true;
            lblBuscarId.Location = new Point(12, 36);
            lblBuscarId.Name = "lblBuscarId";
            lblBuscarId.Size = new Size(87, 20);
            lblBuscarId.TabIndex = 0;
            lblBuscarId.Text = "ID del libro:";
            // 
            // txtIdBuscar
            // 
            txtIdBuscar.Location = new Point(130, 33);
            txtIdBuscar.MaxLength = 9;
            txtIdBuscar.Name = "txtIdBuscar";
            txtIdBuscar.Size = new Size(90, 27);
            txtIdBuscar.TabIndex = 0;
            txtIdBuscar.KeyDown += txtIdBuscar_KeyDown;
            txtIdBuscar.KeyPress += txtIdBuscar_KeyPress;
            // 
            // btnBuscarId
            // 
            btnBuscarId.Location = new Point(240, 30);
            btnBuscarId.Name = "btnBuscarId";
            btnBuscarId.Size = new Size(150, 36);
            btnBuscarId.TabIndex = 1;
            btnBuscarId.Text = "Buscar ID";
            btnBuscarId.UseVisualStyleBackColor = true;
            btnBuscarId.Click += btnBuscarId_Click;
            // 
            // lblBuscarNombre
            // 
            lblBuscarNombre.AutoSize = true;
            lblBuscarNombre.Location = new Point(420, 36);
            lblBuscarNombre.Name = "lblBuscarNombre";
            lblBuscarNombre.Size = new Size(122, 20);
            lblBuscarNombre.TabIndex = 2;
            lblBuscarNombre.Text = "Nombre contiene:";
            // 
            // txtNombreBuscar
            // 
            txtNombreBuscar.Location = new Point(580, 33);
            txtNombreBuscar.MaxLength = 100;
            txtNombreBuscar.Name = "txtNombreBuscar";
            txtNombreBuscar.Size = new Size(300, 27);
            txtNombreBuscar.TabIndex = 3;
            txtNombreBuscar.TextChanged += txtNombreBuscar_TextChanged;
            // 
            // dgvResultados
            // 
            dgvResultados.AllowUserToAddRows = false;
            dgvResultados.AllowUserToDeleteRows = false;
            dgvResultados.AllowUserToResizeRows = false;
            dgvResultados.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dgvResultados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvResultados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvResultados.Columns.AddRange(new DataGridViewColumn[] { colResId, colResTitulo, colResAutor, colResIsbn, colResPrecio, colResStock });
            dgvResultados.Location = new Point(12, 170);
            dgvResultados.MultiSelect = false;
            dgvResultados.Name = "dgvResultados";
            dgvResultados.ReadOnly = true;
            dgvResultados.RowHeadersVisible = false;
            dgvResultados.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvResultados.Size = new Size(976, 158);
            dgvResultados.TabIndex = 2;
            dgvResultados.CellDoubleClick += dgvResultados_CellDoubleClick;
            // 
            // colResId
            // 
            colResId.FillWeight = 30F;
            colResId.HeaderText = "ID";
            colResId.Name = "colResId";
            colResId.ReadOnly = true;
            // 
            // colResTitulo
            // 
            colResTitulo.FillWeight = 160F;
            colResTitulo.HeaderText = "Título";
            colResTitulo.Name = "colResTitulo";
            colResTitulo.ReadOnly = true;
            // 
            // colResAutor
            // 
            colResAutor.FillWeight = 100F;
            colResAutor.HeaderText = "Autor";
            colResAutor.Name = "colResAutor";
            colResAutor.ReadOnly = true;
            // 
            // colResIsbn
            // 
            colResIsbn.FillWeight = 80F;
            colResIsbn.HeaderText = "ISBN";
            colResIsbn.Name = "colResIsbn";
            colResIsbn.ReadOnly = true;
            // 
            // colResPrecio
            // 
            estiloPrecioRes.Alignment = DataGridViewContentAlignment.MiddleRight;
            estiloPrecioRes.Format = "C2";
            colResPrecio.DefaultCellStyle = estiloPrecioRes;
            colResPrecio.FillWeight = 60F;
            colResPrecio.HeaderText = "Precio";
            colResPrecio.Name = "colResPrecio";
            colResPrecio.ReadOnly = true;
            // 
            // colResStock
            // 
            colResStock.FillWeight = 50F;
            colResStock.HeaderText = "Stock";
            colResStock.Name = "colResStock";
            colResStock.ReadOnly = true;
            // 
            // lblCantidad
            // 
            lblCantidad.AutoSize = true;
            lblCantidad.Location = new Point(14, 346);
            lblCantidad.Name = "lblCantidad";
            lblCantidad.Size = new Size(73, 20);
            lblCantidad.TabIndex = 3;
            lblCantidad.Text = "Cantidad:";
            // 
            // nudCantidad
            // 
            nudCantidad.Location = new Point(100, 342);
            nudCantidad.Maximum = new decimal(new int[] { 9999, 0, 0, 0 });
            nudCantidad.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudCantidad.Name = "nudCantidad";
            nudCantidad.Size = new Size(80, 27);
            nudCantidad.TabIndex = 4;
            nudCantidad.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // btnAnadir
            // 
            btnAnadir.Location = new Point(196, 336);
            btnAnadir.Name = "btnAnadir";
            btnAnadir.Size = new Size(250, 38);
            btnAnadir.TabIndex = 5;
            btnAnadir.Text = "Añadir al Carrito";
            btnAnadir.UseVisualStyleBackColor = true;
            btnAnadir.Click += btnAnadir_Click;
            // 
            // lblMensaje
            // 
            lblMensaje.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblMensaje.Location = new Point(464, 342);
            lblMensaje.Name = "lblMensaje";
            lblMensaje.Size = new Size(524, 28);
            lblMensaje.TabIndex = 6;
            lblMensaje.Text = "Busca un libro, selecciónalo y pulsa «Añadir al Carrito».";
            // 
            // dgvCarrito
            // 
            dgvCarrito.AllowUserToAddRows = false;
            dgvCarrito.AllowUserToDeleteRows = false;
            dgvCarrito.AllowUserToResizeRows = false;
            dgvCarrito.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvCarrito.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCarrito.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCarrito.Columns.AddRange(new DataGridViewColumn[] { colCarId, colCarTitulo, colCarCantidad, colCarPrecio, colCarSubtotal });
            dgvCarrito.Location = new Point(12, 382);
            dgvCarrito.MultiSelect = false;
            dgvCarrito.Name = "dgvCarrito";
            dgvCarrito.RowHeadersVisible = false;
            dgvCarrito.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCarrito.Size = new Size(976, 184);
            dgvCarrito.TabIndex = 7;
            dgvCarrito.CellEndEdit += dgvCarrito_CellEndEdit;
            // 
            // colCarId
            // 
            colCarId.FillWeight = 30F;
            colCarId.HeaderText = "ID";
            colCarId.Name = "colCarId";
            colCarId.ReadOnly = true;
            // 
            // colCarTitulo
            // 
            colCarTitulo.FillWeight = 200F;
            colCarTitulo.HeaderText = "Libro";
            colCarTitulo.Name = "colCarTitulo";
            colCarTitulo.ReadOnly = true;
            // 
            // colCarCantidad
            // 
            estiloCantidadCar.Alignment = DataGridViewContentAlignment.MiddleCenter;
            colCarCantidad.DefaultCellStyle = estiloCantidadCar;
            colCarCantidad.FillWeight = 50F;
            colCarCantidad.HeaderText = "Cantidad";
            colCarCantidad.Name = "colCarCantidad";
            // 
            // colCarPrecio
            // 
            estiloPrecioCar.Alignment = DataGridViewContentAlignment.MiddleRight;
            estiloPrecioCar.Format = "C2";
            colCarPrecio.DefaultCellStyle = estiloPrecioCar;
            colCarPrecio.FillWeight = 70F;
            colCarPrecio.HeaderText = "Precio unitario";
            colCarPrecio.Name = "colCarPrecio";
            colCarPrecio.ReadOnly = true;
            // 
            // colCarSubtotal
            // 
            estiloSubtotalCar.Alignment = DataGridViewContentAlignment.MiddleRight;
            estiloSubtotalCar.Format = "C2";
            colCarSubtotal.DefaultCellStyle = estiloSubtotalCar;
            colCarSubtotal.FillWeight = 70F;
            colCarSubtotal.HeaderText = "Subtotal";
            colCarSubtotal.Name = "colCarSubtotal";
            colCarSubtotal.ReadOnly = true;
            // 
            // btnQuitar
            // 
            btnQuitar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnQuitar.Location = new Point(12, 578);
            btnQuitar.Name = "btnQuitar";
            btnQuitar.Size = new Size(240, 44);
            btnQuitar.TabIndex = 8;
            btnQuitar.Text = "Quitar del carrito";
            btnQuitar.UseVisualStyleBackColor = true;
            btnQuitar.Click += btnQuitar_Click;
            // 
            // lblTotalTitulo
            // 
            lblTotalTitulo.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lblTotalTitulo.AutoSize = true;
            lblTotalTitulo.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblTotalTitulo.Location = new Point(340, 588);
            lblTotalTitulo.Name = "lblTotalTitulo";
            lblTotalTitulo.Size = new Size(120, 28);
            lblTotalTitulo.TabIndex = 9;
            lblTotalTitulo.Text = "TOTAL VENTA:";
            // 
            // lblTotalVenta
            // 
            lblTotalVenta.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lblTotalVenta.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblTotalVenta.Location = new Point(480, 578);
            lblTotalVenta.Name = "lblTotalVenta";
            lblTotalVenta.Size = new Size(210, 46);
            lblTotalVenta.TabIndex = 10;
            lblTotalVenta.Text = "$0.00";
            // 
            // btnConfirmar
            // 
            btnConfirmar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnConfirmar.Location = new Point(728, 576);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(260, 48);
            btnConfirmar.TabIndex = 11;
            btnConfirmar.Text = "Confirmar pedido";
            btnConfirmar.UseVisualStyleBackColor = true;
            btnConfirmar.Click += btnConfirmar_Click;
            // 
            // FrmVentas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 636);
            Controls.Add(btnConfirmar);
            Controls.Add(lblTotalVenta);
            Controls.Add(lblTotalTitulo);
            Controls.Add(btnQuitar);
            Controls.Add(dgvCarrito);
            Controls.Add(lblMensaje);
            Controls.Add(btnAnadir);
            Controls.Add(nudCantidad);
            Controls.Add(lblCantidad);
            Controls.Add(dgvResultados);
            Controls.Add(grpBusqueda);
            Controls.Add(pnlEncabezado);
            MinimumSize = new Size(900, 560);
            Name = "FrmVentas";
            Text = "Carrito de compras";
            pnlEncabezado.ResumeLayout(false);
            pnlEncabezado.PerformLayout();
            grpBusqueda.ResumeLayout(false);
            grpBusqueda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvResultados).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudCantidad).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvCarrito).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlEncabezado;
        private Label lblTitulo;
        private Label lblEquipo;
        private Label lblAutor1;
        private Label lblAutor2;
        private Label lblAutor3;
        private GroupBox grpBusqueda;
        private Label lblBuscarId;
        private TextBox txtIdBuscar;
        private Button btnBuscarId;
        private Label lblBuscarNombre;
        private TextBox txtNombreBuscar;
        private DataGridView dgvResultados;
        private DataGridViewTextBoxColumn colResId;
        private DataGridViewTextBoxColumn colResTitulo;
        private DataGridViewTextBoxColumn colResAutor;
        private DataGridViewTextBoxColumn colResIsbn;
        private DataGridViewTextBoxColumn colResPrecio;
        private DataGridViewTextBoxColumn colResStock;
        private Label lblCantidad;
        private NumericUpDown nudCantidad;
        private Button btnAnadir;
        private Label lblMensaje;
        private DataGridView dgvCarrito;
        private DataGridViewTextBoxColumn colCarId;
        private DataGridViewTextBoxColumn colCarTitulo;
        private DataGridViewTextBoxColumn colCarCantidad;
        private DataGridViewTextBoxColumn colCarPrecio;
        private DataGridViewTextBoxColumn colCarSubtotal;
        private Button btnQuitar;
        private Label lblTotalTitulo;
        private Label lblTotalVenta;
        private Button btnConfirmar;
    }
}