//   Equipo 2
//   NUÑEZ Martinez Marco Antonio
//   SUÑIGA Maciel Joule Alexander
//   VILLA Olivarez Ariel
// =============================
// Actividad 2.4
namespace SistemaBiblioteca1
{
    partial class FrmAutor
    {

        private void InitializeComponent()
        {
            lblNombreAutor = new Label();
            txtNombreAutor = new TextBox();
            lblApellidoAutor = new Label();
            txtApellidoAutor = new TextBox();
            lblNacionalidadAutor = new Label();
            txtNacionalidadAutor = new TextBox();
            lblFechaNacimientoAutor = new Label();
            dtpFechaNacimientoAutor = new DateTimePicker();
            chkEstadoAutor = new CheckBox();
            pbxFotografia = new PictureBox();
            btnCargarImagen = new Button();
            pnlFormularioBase.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)epValidaciones).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbxFotografia).BeginInit();
            SuspendLayout();
            // 
            // pnlFormularioBase
            // 
            pnlFormularioBase.Controls.Add(lblNombreAutor);
            pnlFormularioBase.Controls.Add(txtNombreAutor);
            pnlFormularioBase.Controls.Add(lblApellidoAutor);
            pnlFormularioBase.Controls.Add(txtApellidoAutor);
            pnlFormularioBase.Controls.Add(lblNacionalidadAutor);
            pnlFormularioBase.Controls.Add(txtNacionalidadAutor);
            pnlFormularioBase.Controls.Add(lblFechaNacimientoAutor);
            pnlFormularioBase.Controls.Add(dtpFechaNacimientoAutor);
            pnlFormularioBase.Controls.Add(chkEstadoAutor);
            pnlFormularioBase.Controls.Add(pbxFotografia);
            pnlFormularioBase.Controls.Add(btnCargarImagen);
            pnlFormularioBase.Controls.SetChildIndex(btnCargarImagen, 0);
            pnlFormularioBase.Controls.SetChildIndex(pbxFotografia, 0);
            pnlFormularioBase.Controls.SetChildIndex(lblId, 0);
            pnlFormularioBase.Controls.SetChildIndex(chkEstadoAutor, 0);
            pnlFormularioBase.Controls.SetChildIndex(dtpFechaNacimientoAutor, 0);
            pnlFormularioBase.Controls.SetChildIndex(lblFechaNacimientoAutor, 0);
            pnlFormularioBase.Controls.SetChildIndex(txtNacionalidadAutor, 0);
            pnlFormularioBase.Controls.SetChildIndex(lblNacionalidadAutor, 0);
            pnlFormularioBase.Controls.SetChildIndex(txtApellidoAutor, 0);
            pnlFormularioBase.Controls.SetChildIndex(lblApellidoAutor, 0);
            pnlFormularioBase.Controls.SetChildIndex(txtNombreAutor, 0);
            pnlFormularioBase.Controls.SetChildIndex(lblNombreAutor, 0);
            pnlFormularioBase.Controls.SetChildIndex(txtId, 0);
            // 
            // lblId
            // 
            lblId.Location = new Point(29, 12);
            // 
            // txtId
            // 
            txtId.Location = new Point(161, 12);
            // 
            // lblNombreAutor
            // 
            lblNombreAutor.AutoSize = true;
            lblNombreAutor.Location = new Point(14, 58);
            lblNombreAutor.Margin = new Padding(2, 0, 2, 0);
            lblNombreAutor.Name = "lblNombreAutor";
            lblNombreAutor.Size = new Size(106, 15);
            lblNombreAutor.TabIndex = 2;
            lblNombreAutor.Text = "Nombre del Autor:";
            // 
            // txtNombreAutor
            // 
            txtNombreAutor.Location = new Point(161, 55);
            txtNombreAutor.Margin = new Padding(2);
            txtNombreAutor.Name = "txtNombreAutor";
            txtNombreAutor.Size = new Size(162, 23);
            txtNombreAutor.TabIndex = 3;
            // 
            // lblApellidoAutor
            // 
            lblApellidoAutor.AutoSize = true;
            lblApellidoAutor.Location = new Point(14, 94);
            lblApellidoAutor.Margin = new Padding(2, 0, 2, 0);
            lblApellidoAutor.Name = "lblApellidoAutor";
            lblApellidoAutor.Size = new Size(106, 15);
            lblApellidoAutor.TabIndex = 4;
            lblApellidoAutor.Text = "Apellido del Autor:";
            // 
            // txtApellidoAutor
            // 
            txtApellidoAutor.Location = new Point(161, 91);
            txtApellidoAutor.Margin = new Padding(2);
            txtApellidoAutor.Name = "txtApellidoAutor";
            txtApellidoAutor.Size = new Size(162, 23);
            txtApellidoAutor.TabIndex = 5;
            // 
            // lblNacionalidadAutor
            // 
            lblNacionalidadAutor.AutoSize = true;
            lblNacionalidadAutor.Location = new Point(14, 126);
            lblNacionalidadAutor.Margin = new Padding(2, 0, 2, 0);
            lblNacionalidadAutor.Name = "lblNacionalidadAutor";
            lblNacionalidadAutor.Size = new Size(80, 15);
            lblNacionalidadAutor.TabIndex = 6;
            lblNacionalidadAutor.Text = "Nacionalidad:";
            // 
            // txtNacionalidadAutor
            // 
            txtNacionalidadAutor.Location = new Point(161, 123);
            txtNacionalidadAutor.Margin = new Padding(2);
            txtNacionalidadAutor.Name = "txtNacionalidadAutor";
            txtNacionalidadAutor.Size = new Size(162, 23);
            txtNacionalidadAutor.TabIndex = 7;
            // 
            // lblFechaNacimientoAutor
            // 
            lblFechaNacimientoAutor.AutoSize = true;
            lblFechaNacimientoAutor.Location = new Point(14, 164);
            lblFechaNacimientoAutor.Margin = new Padding(2, 0, 2, 0);
            lblFechaNacimientoAutor.Name = "lblFechaNacimientoAutor";
            lblFechaNacimientoAutor.Size = new Size(120, 15);
            lblFechaNacimientoAutor.TabIndex = 8;
            lblFechaNacimientoAutor.Text = "Fecha de nacimiento:";
            // 
            // dtpFechaNacimientoAutor
            // 
            dtpFechaNacimientoAutor.Format = DateTimePickerFormat.Short;
            dtpFechaNacimientoAutor.Location = new Point(161, 158);
            dtpFechaNacimientoAutor.Margin = new Padding(2);
            dtpFechaNacimientoAutor.Name = "dtpFechaNacimientoAutor";
            dtpFechaNacimientoAutor.Size = new Size(162, 23);
            dtpFechaNacimientoAutor.TabIndex = 9;
            // 
            // chkEstadoAutor
            // 
            chkEstadoAutor.AutoSize = true;
            chkEstadoAutor.Location = new Point(207, 206);
            chkEstadoAutor.Margin = new Padding(2);
            chkEstadoAutor.Name = "chkEstadoAutor";
            chkEstadoAutor.Size = new Size(60, 19);
            chkEstadoAutor.TabIndex = 10;
            chkEstadoAutor.Text = "Activo";
            chkEstadoAutor.UseVisualStyleBackColor = true;
            // 
            // pbxFotografia
            // 
            pbxFotografia.BorderStyle = BorderStyle.FixedSingle;
            pbxFotografia.Location = new Point(350, 29);
            pbxFotografia.Margin = new Padding(3, 2, 3, 2);
            pbxFotografia.Name = "pbxFotografia";
            pbxFotografia.Size = new Size(175, 150);
            pbxFotografia.SizeMode = PictureBoxSizeMode.StretchImage;
            pbxFotografia.TabIndex = 11;
            pbxFotografia.TabStop = false;
            // 
            // btnCargarImagen
            // 
            btnCargarImagen.CausesValidation = false;
            btnCargarImagen.Location = new Point(350, 201);
            btnCargarImagen.Margin = new Padding(3, 2, 3, 2);
            btnCargarImagen.Name = "btnCargarImagen";
            btnCargarImagen.Size = new Size(175, 26);
            btnCargarImagen.TabIndex = 12;
            btnCargarImagen.Text = "Cargar Imagen";
            btnCargarImagen.UseVisualStyleBackColor = true;
            btnCargarImagen.Click += btnCargarImagen_Click;
            // 
            // FrmAutor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(560, 270);
            Name = "FrmAutor";
            Text = "FrmAutor";
            pnlFormularioBase.ResumeLayout(false);
            pnlFormularioBase.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)epValidaciones).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbxFotografia).EndInit();
            ResumeLayout(false);
        }

        private Label lblNombreAutor;
        private TextBox txtNombreAutor;
        private Label lblApellidoAutor;
        private TextBox txtApellidoAutor;
        private Label lblNacionalidadAutor;
        private TextBox txtNacionalidadAutor;
        private Label lblFechaNacimientoAutor;
        private DateTimePicker dtpFechaNacimientoAutor;
        private CheckBox chkEstadoAutor;
        private PictureBox pbxFotografia;
        private Button btnCargarImagen;
    }
}