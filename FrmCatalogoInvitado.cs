//   Equipo #2
//   NUÑEZ Martinez Marco Antonio
//   SUÑIGA Maciel Joule Alexander
//   VILLA Olivarez Ariel
// ===============================
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using SistemaBiblioteca1.Models;

namespace SistemaBiblioteca1
{
    public class FrmCatalogoInvitado : Form
    {
        private const int DIAS_DE_PRESTAMO = 7;

        private readonly Label lblTitulo = new Label();
        private readonly Label lblBuscar = new Label();
        private readonly TextBox txtBuscar = new TextBox();
        private readonly DataGridView dgvCatalogo = new DataGridView();
        private readonly BotonPersona3 btnPedirPrestamo = new BotonPersona3();
        private readonly Label lblMensaje = new Label();

        public FrmCatalogoInvitado()
        {
            Text = "Catálogo de libros";
            ClientSize = new Size(860, 480);
            Font = new Font("Segoe UI", 10F);

            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblTitulo.Location = new Point(16, 12);
            lblTitulo.Text = "Catálogo de libros";

            lblBuscar.AutoSize = true;
            lblBuscar.Location = new Point(24, 58);
            lblBuscar.Text = "Buscar (título, autor, ISBN o ID):";

            txtBuscar.Location = new Point(290, 54);
            txtBuscar.Size = new Size(300, 27);
            txtBuscar.TextChanged += (s, e) => CargarCatalogo();

            ConfigurarTabla();

            btnPedirPrestamo.Location = new Point(24, 408);
            btnPedirPrestamo.Size = new Size(220, 40);
            btnPedirPrestamo.Text = "Pedir prestado";
            btnPedirPrestamo.Click += btnPedirPrestamo_Click;

            lblMensaje.Location = new Point(260, 416);
            lblMensaje.Size = new Size(580, 28);

            Controls.AddRange(new Control[]
            {
                lblTitulo, lblBuscar, txtBuscar, dgvCatalogo, btnPedirPrestamo, lblMensaje
            });

            foreach (Control c in Controls)
                c.Anchor = AnchorStyles.Top | AnchorStyles.Left;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            CargarCatalogo();
        }

        private void ConfigurarTabla()
        {
            dgvCatalogo.Location = new Point(24, 94);
            dgvCatalogo.Size = new Size(812, 298);
            dgvCatalogo.ReadOnly = true;
            dgvCatalogo.AllowUserToAddRows = false;
            dgvCatalogo.AllowUserToDeleteRows = false;
            dgvCatalogo.AllowUserToResizeRows = false;
            dgvCatalogo.MultiSelect = false;
            dgvCatalogo.RowHeadersVisible = false;
            dgvCatalogo.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCatalogo.BackgroundColor = Color.FromArgb(14, 28, 64);
            dgvCatalogo.GridColor = Color.FromArgb(40, 70, 130);
            dgvCatalogo.EnableHeadersVisualStyles = false;
            dgvCatalogo.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(8, 24, 60);
            dgvCatalogo.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(0, 212, 255);
            dgvCatalogo.DefaultCellStyle.BackColor = Color.FromArgb(14, 28, 64);
            dgvCatalogo.DefaultCellStyle.ForeColor = Color.White;
            dgvCatalogo.DefaultCellStyle.SelectionBackColor = Color.FromArgb(0, 120, 170);
            dgvCatalogo.DefaultCellStyle.SelectionForeColor = Color.White;

            dgvCatalogo.Columns.Add("IdLibro", "ID");
            dgvCatalogo.Columns.Add("Titulo", "Título");
            dgvCatalogo.Columns.Add("Autor", "Autor");
            dgvCatalogo.Columns.Add("Categoria", "Categoría");
            dgvCatalogo.Columns.Add("Editorial", "Editorial");
            dgvCatalogo.Columns.Add("Anio", "Año");
            dgvCatalogo.Columns.Add("Disponibles", "Disponibles");
            dgvCatalogo.Columns["IdLibro"].FillWeight = 30;
            dgvCatalogo.Columns["Titulo"].FillWeight = 150;
            dgvCatalogo.Columns["Anio"].FillWeight = 40;
            dgvCatalogo.Columns["Disponibles"].FillWeight = 60;
            dgvCatalogo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void CargarCatalogo()
        {
            string filtro = txtBuscar.Text.Trim().ToLowerInvariant();

            Dictionary<int, int> disponibles = Ejemplar.ObtenerTodos()
                .Where(ej => ej.EsActivo && ej.Disponible)
                .GroupBy(ej => ej.IdLibro)
                .ToDictionary(g => g.Key, g => g.Count());

            dgvCatalogo.Rows.Clear();

            foreach (Libro libro in Libro.ObtenerActivos())
            {

                string autor = NombreAutor(libro.IdAutor);

                if (filtro.Length > 0 &&
                    !libro.Titulo.ToLowerInvariant().Contains(filtro) &&
                    !autor.ToLowerInvariant().Contains(filtro) &&
                    !libro.Isbn.ToLowerInvariant().Contains(filtro) &&
                    libro.Id.ToString() != filtro)
                {
                    continue;
                }

                disponibles.TryGetValue(libro.Id, out int libres);

                dgvCatalogo.Rows.Add(libro.Id, libro.Titulo, autor,
                                     NombreCategoria(libro.IdCategoria),
                                     NombreEditorial(libro.IdEditorial),
                                     libro.AnioPublicacion, libres);
            }

            AyudaTablas.Ajustar(dgvCatalogo);
        }

        private static string NombreAutor(int id)
        {
            try
            {
                Autor? a = new Autor().ConsultarRegistro(id.ToString()) as Autor;
                return a == null ? "—" : (a.Nombre + " " + a.Apellido).Trim();
            }
            catch (Exception ex) when (ex is ArgumentException || ex is InvalidOperationException)
            {
                return "—";
            }
        }

        private static string NombreCategoria(int id)
        {
            try
            {
                Categoria? c = new Categoria().ConsultarRegistro(id.ToString()) as Categoria;
                return c == null ? "—" : c.Nombre;
            }
            catch (Exception ex) when (ex is ArgumentException || ex is InvalidOperationException)
            {
                return "—";
            }
        }

        private static string NombreEditorial(int id)
        {
            try
            {
                Editorial? ed = new Editorial().ConsultarRegistro(id.ToString()) as Editorial;
                return ed == null ? "—" : ed.Nombre;
            }
            catch (Exception ex) when (ex is ArgumentException || ex is InvalidOperationException)
            {
                return "—";
            }
        }

        private void btnPedirPrestamo_Click(object? sender, EventArgs e)
        {
            try
            {
                Usuario? yo = Sesion.UsuarioActual;
                if (yo == null)
                    throw new InvalidOperationException(
                        "Tu sesión de demostración no tiene una cuenta registrada.\n" +
                        "Entra con una cuenta creada en «Regístrate» para pedir libros.");

                if (dgvCatalogo.CurrentRow == null)
                    throw new InvalidOperationException("Selecciona un libro de la tabla.");

                int idLibro = Convert.ToInt32(dgvCatalogo.CurrentRow.Cells["IdLibro"].Value);
                string titulo = Convert.ToString(dgvCatalogo.CurrentRow.Cells["Titulo"].Value) ?? string.Empty;

                List<Ejemplar> delLibro = Ejemplar.ObtenerTodos()
                    .Where(ej => ej.IdLibro == idLibro && ej.EsActivo).ToList();

                Ejemplar? libre = delLibro.FirstOrDefault(ej => ej.Disponible);
                if (libre == null)
                    throw new InvalidOperationException("No hay ejemplares disponibles de «" + titulo + "» por ahora.");

                HashSet<int> idsEjemplares = new HashSet<int>(delLibro.Select(ej => ej.Id));
                if (Prestamo.ObtenerTodos().Any(p => p.IdUsuario == yo.Id && !p.Devuelto &&
                                                     idsEjemplares.Contains(p.IdEjemplar)))
                    throw new InvalidOperationException("Ya tienes prestado un ejemplar de «" + titulo + "».");

                DialogResult confirmar = MessageBox.Show(
                    "¿Pedir prestado «" + titulo + "»?\nTendrás " + DIAS_DE_PRESTAMO + " días para devolverlo.",
                    "Pedir prestado", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirmar != DialogResult.Yes)
                    return;

                int siguienteId = Prestamo.ObtenerTodos().Select(p => p.Id).DefaultIfEmpty(0).Max() + 1;
                DateTime hoy = DateTime.Now;

                Prestamo prestamo = new Prestamo(siguienteId, yo.Id, libre.Id, hoy,
                                                 hoy.AddDays(DIAS_DE_PRESTAMO), true);
                prestamo.InsertarRegistro(prestamo);

                Ejemplar ocupado = new Ejemplar(libre.Id, libre.IdLibro, libre.CodigoInventario,
                                                libre.Condicion, false, libre.EsActivo);
                ocupado.FechaRegistro = libre.FechaRegistro;
                ocupado.ActualizarRegistro(ocupado);

                MostrarMensaje("Préstamo registrado. Fecha límite: " +
                               prestamo.FechaLimite.ToString("dd/MM/yyyy") + ".", false);
                CargarCatalogo();
            }
            catch (Exception ex) when (ex is ArgumentException || ex is InvalidOperationException)
            {
                MostrarMensaje(ex.Message.Replace("\n", " "), true);
            }
        }

        private void MostrarMensaje(string mensaje, bool esError)
        {
            lblMensaje.ForeColor = esError ? Color.FromArgb(255, 107, 107) : Color.FromArgb(0, 212, 255);
            lblMensaje.Text = mensaje;
        }
    }
}