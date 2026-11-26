//   Equipo 2
//   NUÑEZ Martinez Marco Antonio
//   SUÑIGA Maciel Joule Alexander
//   VILLA Olivarez Ariel
// =============================
namespace SistemaBiblioteca1
{
    partial class FrmAdminCuentas
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
            lblTituloCuentas = new Label();
            dgvCuentas = new DataGridView();
            lblResumenCuentas = new Label();
            lblMensajeCuentas = new Label();
            lblMotivoBaneo = new Label();
            txtMotivoBaneo = new TextBox();
            btnActivarCuenta = new BotonPersona3();
            btnDesactivarCuenta = new BotonPersona3();
            btnBanearCuenta = new BotonPersona3();
            btnQuitarBaneoCuenta = new BotonPersona3();
            btnRecargarCuentas = new BotonPersona3();
            ((System.ComponentModel.ISupportInitialize)dgvCuentas).BeginInit();
            SuspendLayout();
            // 
            // lblTituloCuentas
            // 
            lblTituloCuentas.AutoSize = true;
            lblTituloCuentas.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblTituloCuentas.Location = new Point(14, 9);
            lblTituloCuentas.Margin = new Padding(2, 0, 2, 0);
            lblTituloCuentas.Name = "lblTituloCuentas";
            lblTituloCuentas.Size = new Size(182, 25);
            lblTituloCuentas.TabIndex = 0;
            lblTituloCuentas.Text = "Cuentas de usuario";
            // 
            // dgvCuentas
            // 
            dgvCuentas.AllowUserToAddRows = false;
            dgvCuentas.AllowUserToDeleteRows = false;
            dgvCuentas.AllowUserToResizeRows = false;
            dgvCuentas.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvCuentas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCuentas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCuentas.Location = new Point(14, 42);
            dgvCuentas.Margin = new Padding(2);
            dgvCuentas.MultiSelect = false;
            dgvCuentas.Name = "dgvCuentas";
            dgvCuentas.ReadOnly = true;
            dgvCuentas.RowHeadersVisible = false;
            dgvCuentas.RowHeadersWidth = 51;
            dgvCuentas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCuentas.Size = new Size(724, 225);
            dgvCuentas.TabIndex = 1;
            // 
            // lblResumenCuentas
            // 
            lblResumenCuentas.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblResumenCuentas.AutoSize = true;
            lblResumenCuentas.Location = new Point(14, 274);
            lblResumenCuentas.Margin = new Padding(2, 0, 2, 0);
            lblResumenCuentas.Name = "lblResumenCuentas";
            lblResumenCuentas.Size = new Size(44, 15);
            lblResumenCuentas.TabIndex = 2;
            lblResumenCuentas.Text = "Total: 0";
            // 
            // lblMensajeCuentas
            // 
            lblMensajeCuentas.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblMensajeCuentas.Location = new Point(14, 294);
            lblMensajeCuentas.Margin = new Padding(2, 0, 2, 0);
            lblMensajeCuentas.Name = "lblMensajeCuentas";
            lblMensajeCuentas.Size = new Size(724, 18);
            lblMensajeCuentas.TabIndex = 3;
            // 
            // lblMotivoBaneo
            // 
            lblMotivoBaneo.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblMotivoBaneo.AutoSize = true;
            lblMotivoBaneo.Location = new Point(14, 322);
            lblMotivoBaneo.Margin = new Padding(2, 0, 2, 0);
            lblMotivoBaneo.Name = "lblMotivoBaneo";
            lblMotivoBaneo.Size = new Size(103, 15);
            lblMotivoBaneo.TabIndex = 4;
            lblMotivoBaneo.Text = "Motivo del baneo:";
            // 
            // txtMotivoBaneo
            // 
            txtMotivoBaneo.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtMotivoBaneo.Location = new Point(142, 314);
            txtMotivoBaneo.Margin = new Padding(2);
            txtMotivoBaneo.MaxLength = 200;
            txtMotivoBaneo.Name = "txtMotivoBaneo";
            txtMotivoBaneo.PlaceholderText = "Obligatorio para banear";
            txtMotivoBaneo.Size = new Size(599, 23);
            txtMotivoBaneo.TabIndex = 5;
            // 
            // btnActivarCuenta
            // 
            btnActivarCuenta.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnActivarCuenta.FlatStyle = FlatStyle.Flat;
            btnActivarCuenta.Font = new Font("Segoe UI", 11F, FontStyle.Bold | FontStyle.Italic);
            btnActivarCuenta.Location = new Point(14, 351);
            btnActivarCuenta.Margin = new Padding(2);
            btnActivarCuenta.Name = "btnActivarCuenta";
            btnActivarCuenta.Size = new Size(131, 28);
            btnActivarCuenta.TabIndex = 6;
            btnActivarCuenta.Text = "Activar";
            btnActivarCuenta.UseVisualStyleBackColor = true;
            btnActivarCuenta.Click += btnActivarCuenta_Click;
            // 
            // btnDesactivarCuenta
            // 
            btnDesactivarCuenta.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnDesactivarCuenta.FlatStyle = FlatStyle.Flat;
            btnDesactivarCuenta.Font = new Font("Segoe UI", 11F, FontStyle.Bold | FontStyle.Italic);
            btnDesactivarCuenta.Location = new Point(154, 351);
            btnDesactivarCuenta.Margin = new Padding(2);
            btnDesactivarCuenta.Name = "btnDesactivarCuenta";
            btnDesactivarCuenta.Size = new Size(131, 28);
            btnDesactivarCuenta.TabIndex = 7;
            btnDesactivarCuenta.Text = "Desactivar";
            btnDesactivarCuenta.UseVisualStyleBackColor = true;
            btnDesactivarCuenta.Click += btnDesactivarCuenta_Click;
            // 
            // btnBanearCuenta
            // 
            btnBanearCuenta.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnBanearCuenta.FlatStyle = FlatStyle.Flat;
            btnBanearCuenta.Font = new Font("Segoe UI", 11F, FontStyle.Bold | FontStyle.Italic);
            btnBanearCuenta.Location = new Point(294, 351);
            btnBanearCuenta.Margin = new Padding(2);
            btnBanearCuenta.Name = "btnBanearCuenta";
            btnBanearCuenta.Size = new Size(131, 28);
            btnBanearCuenta.TabIndex = 8;
            btnBanearCuenta.Text = "Banear";
            btnBanearCuenta.UseVisualStyleBackColor = true;
            btnBanearCuenta.Click += btnBanearCuenta_Click;
            // 
            // btnQuitarBaneoCuenta
            // 
            btnQuitarBaneoCuenta.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnQuitarBaneoCuenta.FlatStyle = FlatStyle.Flat;
            btnQuitarBaneoCuenta.Font = new Font("Segoe UI", 11F, FontStyle.Bold | FontStyle.Italic);
            btnQuitarBaneoCuenta.Location = new Point(434, 351);
            btnQuitarBaneoCuenta.Margin = new Padding(2);
            btnQuitarBaneoCuenta.Name = "btnQuitarBaneoCuenta";
            btnQuitarBaneoCuenta.Size = new Size(140, 28);
            btnQuitarBaneoCuenta.TabIndex = 9;
            btnQuitarBaneoCuenta.Text = "Quitar baneo";
            btnQuitarBaneoCuenta.UseVisualStyleBackColor = true;
            btnQuitarBaneoCuenta.Click += btnQuitarBaneoCuenta_Click;
            // 
            // btnRecargarCuentas
            // 
            btnRecargarCuentas.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnRecargarCuentas.FlatStyle = FlatStyle.Flat;
            btnRecargarCuentas.Font = new Font("Segoe UI", 11F, FontStyle.Bold | FontStyle.Italic);
            btnRecargarCuentas.Location = new Point(583, 351);
            btnRecargarCuentas.Margin = new Padding(2);
            btnRecargarCuentas.Name = "btnRecargarCuentas";
            btnRecargarCuentas.Size = new Size(149, 28);
            btnRecargarCuentas.TabIndex = 10;
            btnRecargarCuentas.Text = "Actualizar lista";
            btnRecargarCuentas.UseVisualStyleBackColor = true;
            btnRecargarCuentas.Click += btnRecargarCuentas_Click;
            // 
            // FrmAdminCuentas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(752, 393);
            Controls.Add(lblTituloCuentas);
            Controls.Add(dgvCuentas);
            Controls.Add(lblResumenCuentas);
            Controls.Add(lblMensajeCuentas);
            Controls.Add(lblMotivoBaneo);
            Controls.Add(txtMotivoBaneo);
            Controls.Add(btnActivarCuenta);
            Controls.Add(btnDesactivarCuenta);
            Controls.Add(btnBanearCuenta);
            Controls.Add(btnQuitarBaneoCuenta);
            Controls.Add(btnRecargarCuentas);
            Margin = new Padding(2);
            Name = "FrmAdminCuentas";
            Text = "Administración - Cuentas de usuario";
            ((System.ComponentModel.ISupportInitialize)dgvCuentas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTituloCuentas;
        private DataGridView dgvCuentas;
        private Label lblResumenCuentas;
        private Label lblMensajeCuentas;
        private Label lblMotivoBaneo;
        private TextBox txtMotivoBaneo;
        private BotonPersona3 btnActivarCuenta;
        private BotonPersona3 btnDesactivarCuenta;
        private BotonPersona3 btnBanearCuenta;
        private BotonPersona3 btnQuitarBaneoCuenta;
        private BotonPersona3 btnRecargarCuentas;
    }
}