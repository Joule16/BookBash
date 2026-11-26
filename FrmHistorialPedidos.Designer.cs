//   Equipo 2
//   NUÑEZ Martinez Marco Antonio
//   SUÑIGA Maciel Joule Alexander
//   VILLA Olivarez Ariel
// =============================
// Actividad 4.8 - Historial de pedidos y comprobantes
namespace SistemaBiblioteca1
{
    partial class FrmHistorialPedidos
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
            DataGridViewCellStyle estiloFecha = new DataGridViewCellStyle();
            DataGridViewCellStyle estiloDinero = new DataGridViewCellStyle();
            DataGridViewCellStyle estiloDineroDet = new DataGridViewCellStyle();
            DataGridViewCellStyle estiloSubtotalDet = new DataGridViewCellStyle();
            pnlEncabezado = new Panel();
            lblTitulo = new Label();
            lblEquipo = new Label();
            lblAutor1 = new Label();
            lblAutor2 = new Label();
            lblAutor3 = new Label();
            lblOrigen = new Label();
            cmbOrigen = new ComboBox();
            btnActualizar = new Button();
            dgvPedidos = new DataGridView();
            colPedFolio = new DataGridViewTextBoxColumn();
            colPedFecha = new DataGridViewTextBoxColumn();
            colPedCliente = new DataGridViewTextBoxColumn();
            colPedTotal = new DataGridViewTextBoxColumn();
            lblDetalle = new Label();
            dgvDetalles = new DataGridView();
            colDetId = new DataGridViewTextBoxColumn();
            colDetTitulo = new DataGridViewTextBoxColumn();
            colDetCondicion = new DataGridViewTextBoxColumn();
            colDetCantidad = new DataGridViewTextBoxColumn();
            colDetPrecio = new DataGridViewTextBoxColumn();
            colDetSubtotal = new DataGridViewTextBoxColumn();
            lblMensaje = new Label();
            pnlEncabezado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPedidos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvDetalles).BeginInit();
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
            lblTitulo.Text = "Historial de pedidos y comprobantes";
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
            // lblOrigen
            // 
            lblOrigen.AutoSize = true;
            lblOrigen.Location = new Point(14, 98);
            lblOrigen.Name = "lblOrigen";
            lblOrigen.Size = new Size(110, 20);
            lblOrigen.TabIndex = 1;
            lblOrigen.Text = "Consultar en:";
            // 
            // cmbOrigen
            // 
            cmbOrigen.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbOrigen.FormattingEnabled = true;
            cmbOrigen.Location = new Point(130, 94);
            cmbOrigen.Name = "cmbOrigen";
            cmbOrigen.Size = new Size(300, 28);
            cmbOrigen.TabIndex = 2;
            cmbOrigen.SelectedIndexChanged += cmbOrigen_SelectedIndexChanged;
            // 
            // btnActualizar
            // 
            btnActualizar.Location = new Point(448, 92);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(120, 32);
            btnActualizar.TabIndex = 3;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // dgvPedidos
            // 
            dgvPedidos.AllowUserToAddRows = false;
            dgvPedidos.AllowUserToDeleteRows = false;
            dgvPedidos.AllowUserToResizeRows = false;
            dgvPedidos.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dgvPedidos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPedidos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPedidos.Columns.AddRange(new DataGridViewColumn[] { colPedFolio, colPedFecha, colPedCliente, colPedTotal });
            dgvPedidos.Location = new Point(14, 136);
            dgvPedidos.MultiSelect = false;
            dgvPedidos.Name = "dgvPedidos";
            dgvPedidos.ReadOnly = true;
            dgvPedidos.RowHeadersVisible = false;
            dgvPedidos.RowHeadersWidth = 51;
            dgvPedidos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPedidos.Size = new Size(972, 190);
            dgvPedidos.TabIndex = 4;
            dgvPedidos.SelectionChanged += dgvPedidos_SelectionChanged;
            // 
            // colPedFolio
            // 
            colPedFolio.FillWeight = 20F;
            colPedFolio.HeaderText = "Folio";
            colPedFolio.MinimumWidth = 6;
            colPedFolio.Name = "colPedFolio";
            colPedFolio.ReadOnly = true;
            // 
            // colPedFecha
            // 
            estiloFecha.Format = "dd/MM/yyyy HH:mm:ss";
            colPedFecha.DefaultCellStyle = estiloFecha;
            colPedFecha.FillWeight = 45F;
            colPedFecha.HeaderText = "Fecha";
            colPedFecha.MinimumWidth = 6;
            colPedFecha.Name = "colPedFecha";
            colPedFecha.ReadOnly = true;
            // 
            // colPedCliente
            // 
            colPedCliente.FillWeight = 90F;
            colPedCliente.HeaderText = "Cliente";
            colPedCliente.MinimumWidth = 6;
            colPedCliente.Name = "colPedCliente";
            colPedCliente.ReadOnly = true;
            // 
            // colPedTotal
            // 
            estiloDinero.Alignment = DataGridViewContentAlignment.MiddleRight;
            estiloDinero.Format = "C2";
            colPedTotal.DefaultCellStyle = estiloDinero;
            colPedTotal.FillWeight = 40F;
            colPedTotal.HeaderText = "Total";
            colPedTotal.MinimumWidth = 6;
            colPedTotal.Name = "colPedTotal";
            colPedTotal.ReadOnly = true;
            // 
            // lblDetalle
            // 
            lblDetalle.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblDetalle.AutoSize = true;
            lblDetalle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblDetalle.Location = new Point(14, 338);
            lblDetalle.Name = "lblDetalle";
            lblDetalle.Size = new Size(300, 23);
            lblDetalle.TabIndex = 5;
            lblDetalle.Text = "Artículos del comprobante";
            // 
            // dgvDetalles
            // 
            dgvDetalles.AllowUserToAddRows = false;
            dgvDetalles.AllowUserToDeleteRows = false;
            dgvDetalles.AllowUserToResizeRows = false;
            dgvDetalles.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvDetalles.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDetalles.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDetalles.Columns.AddRange(new DataGridViewColumn[] { colDetId, colDetTitulo, colDetCondicion, colDetCantidad, colDetPrecio, colDetSubtotal });
            dgvDetalles.Location = new Point(14, 368);
            dgvDetalles.MultiSelect = false;
            dgvDetalles.Name = "dgvDetalles";
            dgvDetalles.ReadOnly = true;
            dgvDetalles.RowHeadersVisible = false;
            dgvDetalles.RowHeadersWidth = 51;
            dgvDetalles.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDetalles.Size = new Size(972, 220);
            dgvDetalles.TabIndex = 6;
            // 
            // colDetId
            // 
            colDetId.FillWeight = 20F;
            colDetId.HeaderText = "ID libro";
            colDetId.MinimumWidth = 6;
            colDetId.Name = "colDetId";
            colDetId.ReadOnly = true;
            // 
            // colDetTitulo
            // 
            colDetTitulo.FillWeight = 120F;
            colDetTitulo.HeaderText = "Título";
            colDetTitulo.MinimumWidth = 6;
            colDetTitulo.Name = "colDetTitulo";
            colDetTitulo.ReadOnly = true;
            // 
            // colDetCondicion
            // 
            colDetCondicion.FillWeight = 40F;
            colDetCondicion.HeaderText = "Condición";
            colDetCondicion.MinimumWidth = 6;
            colDetCondicion.Name = "colDetCondicion";
            colDetCondicion.ReadOnly = true;
            // 
            // colDetCantidad
            // 
            colDetCantidad.FillWeight = 30F;
            colDetCantidad.HeaderText = "Cantidad";
            colDetCantidad.MinimumWidth = 6;
            colDetCantidad.Name = "colDetCantidad";
            colDetCantidad.ReadOnly = true;
            // 
            // colDetPrecio
            // 
            estiloDineroDet.Alignment = DataGridViewContentAlignment.MiddleRight;
            estiloDineroDet.Format = "C2";
            colDetPrecio.DefaultCellStyle = estiloDineroDet;
            colDetPrecio.FillWeight = 40F;
            colDetPrecio.HeaderText = "Precio unitario";
            colDetPrecio.MinimumWidth = 6;
            colDetPrecio.Name = "colDetPrecio";
            colDetPrecio.ReadOnly = true;
            // 
            // colDetSubtotal
            // 
            estiloSubtotalDet.Alignment = DataGridViewContentAlignment.MiddleRight;
            estiloSubtotalDet.Format = "C2";
            colDetSubtotal.DefaultCellStyle = estiloSubtotalDet;
            colDetSubtotal.FillWeight = 40F;
            colDetSubtotal.HeaderText = "Subtotal";
            colDetSubtotal.MinimumWidth = 6;
            colDetSubtotal.Name = "colDetSubtotal";
            colDetSubtotal.ReadOnly = true;
            // 
            // lblMensaje
            // 
            lblMensaje.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblMensaje.AutoSize = true;
            lblMensaje.Location = new Point(14, 600);
            lblMensaje.Name = "lblMensaje";
            lblMensaje.Size = new Size(0, 20);
            lblMensaje.TabIndex = 7;
            // 
            // FrmHistorialPedidos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 636);
            Controls.Add(lblMensaje);
            Controls.Add(dgvDetalles);
            Controls.Add(lblDetalle);
            Controls.Add(dgvPedidos);
            Controls.Add(btnActualizar);
            Controls.Add(cmbOrigen);
            Controls.Add(lblOrigen);
            Controls.Add(pnlEncabezado);
            MinimumSize = new Size(900, 560);
            Name = "FrmHistorialPedidos";
            Text = "Historial de pedidos";
            Load += FrmHistorialPedidos_Load;
            pnlEncabezado.ResumeLayout(false);
            pnlEncabezado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPedidos).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvDetalles).EndInit();
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
        private Label lblOrigen;
        private ComboBox cmbOrigen;
        private Button btnActualizar;
        private DataGridView dgvPedidos;
        private DataGridViewTextBoxColumn colPedFolio;
        private DataGridViewTextBoxColumn colPedFecha;
        private DataGridViewTextBoxColumn colPedCliente;
        private DataGridViewTextBoxColumn colPedTotal;
        private Label lblDetalle;
        private DataGridView dgvDetalles;
        private DataGridViewTextBoxColumn colDetId;
        private DataGridViewTextBoxColumn colDetTitulo;
        private DataGridViewTextBoxColumn colDetCondicion;
        private DataGridViewTextBoxColumn colDetCantidad;
        private DataGridViewTextBoxColumn colDetPrecio;
        private DataGridViewTextBoxColumn colDetSubtotal;
        private Label lblMensaje;
    }
}
