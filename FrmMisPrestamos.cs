//   Equipo 2
//   NUÑEZ Martinez Marco Antonio
//   SUÑIGA Maciel Joule Alexander
//   VILLA Olivarez Ariel
// =============================
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using SistemaBiblioteca1.Models;

namespace SistemaBiblioteca1
{
    public class FrmMisPrestamos : Form
    {
        private const int DIAS_AVISO = 2;

        private enum EstadoPrestamo
        {
            EnCurso,
            PorVencer,
            Vencido,
            Devuelto,
            Cancelado,
            Inactivo
        }

        private static readonly Color ColorCian = Color.FromArgb(0, 212, 255);
        private static readonly Color ColorAmbar = Color.FromArgb(255, 193, 7);
        private static readonly Color ColorRojo = Color.FromArgb(255, 107, 107);
        private static readonly Color ColorVerde = Color.FromArgb(120, 220, 140);
        private static readonly Color ColorGris = Color.FromArgb(150, 160, 180);

        private readonly Label lblTitulo = new Label();
        private readonly DataGridView dgvPrestamos = new DataGridView();
        private readonly BotonPersona3 btnDevolver = new BotonPersona3();
        private readonly BotonPersona3 btnCancelar = new BotonPersona3();
        private readonly BotonPersona3 btnBorrarHistorial = new BotonPersona3();
        private readonly Label lblMensaje = new Label();

        private readonly Panel pnlTiempo = new Panel();
        private readonly Label lblTiempoTitulo = new Label();
        private readonly Label lblCuenta = new Label();
        private readonly Label lblVence = new Label();
        private readonly ProgressBar prgTiempo = new ProgressBar();
        private readonly Label lblTranscurrido = new Label();
        private readonly Label lblAviso = new Label();

        private readonly Panel pnlHistorial = new Panel();
        private readonly Label lblHistorialTitulo = new Label();
        private readonly Label lblLibro = new Label();
        private readonly Label lblPropietario = new Label();
        private readonly Label lblPoseedor = new Label();
        private readonly DataGridView dgvHistorial = new DataGridView();

        private readonly System.Windows.Forms.Timer tmrCuenta = new System.Windows.Forms.Timer();

        private bool cargando;

        public FrmMisPrestamos()
        {
            Text = "Mis préstamos";
            ClientSize = new Size(980, 660);
            Font = new Font("Segoe UI", 10F);

            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblTitulo.Location = new Point(16, 12);
            lblTitulo.Text = "Mis préstamos";

            ConfigurarTablaPrestamos();

            btnDevolver.Location = new Point(24, 288);
            btnDevolver.Size = new Size(190, 40);
            btnDevolver.Text = "Devolver libro";
            btnDevolver.Click += btnDevolver_Click;

            btnCancelar.Location = new Point(222, 288);
            btnCancelar.Size = new Size(190, 40);
            btnCancelar.Text = "Cancelar préstamo";
            btnCancelar.Click += btnCancelar_Click;

            btnBorrarHistorial.Location = new Point(420, 288);
            btnBorrarHistorial.Size = new Size(190, 40);
            btnBorrarHistorial.Text = "Borrar historial";
            btnBorrarHistorial.Click += btnBorrarHistorial_Click;

            lblMensaje.AutoSize = false;
            lblMensaje.Location = new Point(622, 284);
            lblMensaje.Size = new Size(334, 48);

            ConfigurarPanelTiempo();
            ConfigurarPanelHistorial();

            Controls.AddRange(new Control[]
            {
                lblTitulo, dgvPrestamos, btnDevolver, btnCancelar, btnBorrarHistorial, lblMensaje,
                pnlTiempo, pnlHistorial
            });

            foreach (Control c in Controls)
                c.Anchor = AnchorStyles.Top | AnchorStyles.Left;

            dgvPrestamos.SelectionChanged += (s, e) =>
            {
                if (!cargando)
                    MostrarDetalle();
            };

            tmrCuenta.Interval = 1000;
            tmrCuenta.Tick += (s, e) => ActualizarCuentaRegresiva();

            FormClosed += (s, e) =>
            {
                tmrCuenta.Stop();
                tmrCuenta.Dispose();
            };
        }

        private void ConfigurarTablaPrestamos()
        {
            dgvPrestamos.Location = new Point(24, 84);
            dgvPrestamos.Size = new Size(932, 190);
            ConfigurarTablaBase(dgvPrestamos);

            dgvPrestamos.Columns.Add("IdPrestamo", "N.º");
            dgvPrestamos.Columns.Add("Libro", "Libro");
            dgvPrestamos.Columns.Add("Ejemplar", "Ejemplar");
            dgvPrestamos.Columns.Add("FechaPrestamo", "Pedido el");
            dgvPrestamos.Columns.Add("FechaLimite", "Fecha límite");
            dgvPrestamos.Columns.Add("Restante", "Tiempo restante");
            dgvPrestamos.Columns.Add("Estado", "Estado");
            dgvPrestamos.Columns["IdPrestamo"].FillWeight = 30;
            dgvPrestamos.Columns["Libro"].FillWeight = 150;
            dgvPrestamos.Columns["Ejemplar"].FillWeight = 60;
            dgvPrestamos.Columns["Restante"].FillWeight = 100;
        }

        private void ConfigurarPanelTiempo()
        {
            pnlTiempo.Location = new Point(24, 344);
            pnlTiempo.Size = new Size(420, 290);

            ConfigurarEtiqueta(lblTiempoTitulo, 12, 10, 396, 26, "Tiempo restante del préstamo", true);

            ConfigurarEtiqueta(lblCuenta, 12, 44, 396, 64, "—", true);
            lblCuenta.Font = new Font("Segoe UI", 24F, FontStyle.Bold);

            ConfigurarEtiqueta(lblVence, 12, 116, 396, 26, "Selecciona un préstamo de la tabla.", false);

            prgTiempo.Location = new Point(12, 152);
            prgTiempo.Size = new Size(396, 22);
            prgTiempo.Minimum = 0;
            prgTiempo.Maximum = 100;
            prgTiempo.Style = ProgressBarStyle.Continuous;

            ConfigurarEtiqueta(lblTranscurrido, 12, 180, 396, 26, string.Empty, false);
            ConfigurarEtiqueta(lblAviso, 12, 214, 396, 62, string.Empty, false);

            pnlTiempo.Controls.AddRange(new Control[]
            {
                lblTiempoTitulo, lblCuenta, lblVence, prgTiempo, lblTranscurrido, lblAviso
            });
        }

        private void ConfigurarPanelHistorial()
        {
            pnlHistorial.Location = new Point(460, 344);
            pnlHistorial.Size = new Size(496, 290);

            ConfigurarEtiqueta(lblHistorialTitulo, 12, 10, 472, 26, "Historial del libro", true);
            ConfigurarEtiqueta(lblLibro, 12, 40, 472, 24, "Libro: —", false);
            ConfigurarEtiqueta(lblPropietario, 12, 66, 472, 24, "Propietario: —", false);
            ConfigurarEtiqueta(lblPoseedor, 12, 92, 472, 24, "Lo tiene ahora: —", false);

            dgvHistorial.Location = new Point(12, 124);
            dgvHistorial.Size = new Size(472, 154);
            ConfigurarTablaBase(dgvHistorial);

            dgvHistorial.Columns.Add("Usuario", "Usuario");
            dgvHistorial.Columns.Add("Desde", "Desde");
            dgvHistorial.Columns.Add("Limite", "Límite");
            dgvHistorial.Columns.Add("Devolucion", "Devolución");
            dgvHistorial.Columns.Add("Estado", "Estado");
            dgvHistorial.Columns["Usuario"].FillWeight = 140;

            pnlHistorial.Controls.AddRange(new Control[]
            {
                lblHistorialTitulo, lblLibro, lblPropietario, lblPoseedor, dgvHistorial
            });
        }

        private static void ConfigurarEtiqueta(Label etiqueta, int x, int y, int ancho, int alto,
                                               string texto, bool negrita)
        {
            etiqueta.AutoSize = false;
            etiqueta.Location = new Point(x, y);
            etiqueta.Size = new Size(ancho, alto);
            etiqueta.Text = texto;
            if (negrita)
                etiqueta.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
        }

        private static void ConfigurarTablaBase(DataGridView tabla)
        {
            tabla.ReadOnly = true;
            tabla.AllowUserToAddRows = false;
            tabla.AllowUserToDeleteRows = false;
            tabla.AllowUserToResizeRows = false;
            tabla.MultiSelect = false;
            tabla.RowHeadersVisible = false;
            tabla.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            tabla.BackgroundColor = Color.FromArgb(14, 28, 64);
            tabla.GridColor = Color.FromArgb(40, 70, 130);
            tabla.EnableHeadersVisualStyles = false;
            tabla.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(8, 24, 60);
            tabla.ColumnHeadersDefaultCellStyle.ForeColor = ColorCian;
            tabla.DefaultCellStyle.BackColor = Color.FromArgb(14, 28, 64);
            tabla.DefaultCellStyle.ForeColor = Color.White;
            tabla.DefaultCellStyle.SelectionBackColor = Color.FromArgb(0, 120, 170);
            tabla.DefaultCellStyle.SelectionForeColor = Color.White;
            tabla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            if (Sesion.UsuarioActual == null)
            {
                btnDevolver.Enabled = false;
                btnCancelar.Enabled = false;
                btnBorrarHistorial.Enabled = false;
                MostrarMensaje("Tu sesión de demostración no tiene una cuenta registrada.\n" +
                               "Entra con una cuenta creada en «Regístrate» para ver tus préstamos.", true);
                return;
            }

            CargarPrestamos(null);
            tmrCuenta.Start();
        }

        private void CargarPrestamos(int? idASeleccionar)
        {
            Usuario? yo = Sesion.UsuarioActual;
            if (yo == null)
                return;

            int? idPrevio = idASeleccionar ?? PrestamoSeleccionado()?.Id;

            cargando = true;
            dgvPrestamos.Rows.Clear();

            List<Prestamo> mios = Prestamo.ObtenerTodos()
                .Where(p => p.IdUsuario == yo.Id)
                .OrderByDescending(p => p.FechaPrestamo)
                .ThenByDescending(p => p.Id)
                .ToList();

            foreach (Prestamo p in mios)
            {
                int indice = dgvPrestamos.Rows.Add(
                    p.Id,
                    TituloDelEjemplar(p.IdEjemplar),
                    CodigoDelEjemplar(p.IdEjemplar),
                    p.FechaPrestamo.ToString("dd/MM/yyyy"),
                    p.FechaLimite.ToString("dd/MM/yyyy"),
                    string.Empty,
                    string.Empty);

                dgvPrestamos.Rows[indice].Tag = p;
                PintarFila(dgvPrestamos.Rows[indice]);
            }

            AyudaTablas.Ajustar(dgvPrestamos);

            btnBorrarHistorial.Enabled = mios.Any(x => x.Devuelto);

            dgvPrestamos.ClearSelection();
            if (idPrevio.HasValue)
            {
                foreach (DataGridViewRow fila in dgvPrestamos.Rows)
                {
                    if (fila.Tag is Prestamo p && p.Id == idPrevio.Value)
                    {
                        fila.Selected = true;
                        dgvPrestamos.CurrentCell = fila.Cells["Libro"];
                        break;
                    }
                }
            }

            cargando = false;

            if (dgvPrestamos.SelectedRows.Count == 0 && dgvPrestamos.Rows.Count > 0)
            {
                dgvPrestamos.Rows[0].Selected = true;
                dgvPrestamos.CurrentCell = dgvPrestamos.Rows[0].Cells["Libro"];
            }

            MostrarDetalle();

            if (dgvPrestamos.Rows.Count == 0)
                MostrarMensaje("Todavía no tienes préstamos. Pide un libro desde el Catálogo.", false);
        }

        private Prestamo? PrestamoSeleccionado()
        {
            if (dgvPrestamos.CurrentRow == null || !dgvPrestamos.CurrentRow.Selected)
                return null;
            return dgvPrestamos.CurrentRow.Tag as Prestamo;
        }

        private static DateTime MomentoDeVencimiento(Prestamo p)
        {
            return p.FechaLimite.Date.AddDays(1).AddSeconds(-1);
        }

        private static EstadoPrestamo Clasificar(Prestamo p)
        {
            if (p.Devuelto)
                return p.EsActivo ? EstadoPrestamo.Devuelto : EstadoPrestamo.Cancelado;

            if (!p.EsActivo)
                return EstadoPrestamo.Inactivo;

            TimeSpan restante = MomentoDeVencimiento(p) - DateTime.Now;
            if (restante <= TimeSpan.Zero)
                return EstadoPrestamo.Vencido;
            if (restante <= TimeSpan.FromDays(DIAS_AVISO))
                return EstadoPrestamo.PorVencer;
            return EstadoPrestamo.EnCurso;
        }

        private static bool EstaVigente(Prestamo p)
        {
            return p.EsActivo && !p.Devuelto;
        }

        private static string TextoEstado(EstadoPrestamo estado)
        {
            switch (estado)
            {
                case EstadoPrestamo.EnCurso: return "En curso";
                case EstadoPrestamo.PorVencer: return "Por vencer";
                case EstadoPrestamo.Vencido: return "Vencido";
                case EstadoPrestamo.Devuelto: return "Devuelto";
                case EstadoPrestamo.Cancelado: return "Cancelado";
                default: return "Inactivo";
            }
        }

        private static Color ColorEstado(EstadoPrestamo estado)
        {
            switch (estado)
            {
                case EstadoPrestamo.EnCurso: return ColorCian;
                case EstadoPrestamo.PorVencer: return ColorAmbar;
                case EstadoPrestamo.Vencido: return ColorRojo;
                case EstadoPrestamo.Devuelto: return ColorVerde;
                default: return ColorGris;
            }
        }

        private static string FormatearRestante(TimeSpan t)
        {
            return string.Format("{0} d  {1:00} h  {2:00} m  {3:00} s",
                                 (int)t.TotalDays, t.Hours, t.Minutes, t.Seconds);
        }

        private static string FormatearRestanteCorto(TimeSpan t)
        {
            if (t.TotalDays >= 1)
                return string.Format("{0} d {1} h", (int)t.TotalDays, t.Hours);
            return string.Format("{0:00}:{1:00}:{2:00}", t.Hours, t.Minutes, t.Seconds);
        }

        private void PintarFila(DataGridViewRow fila)
        {
            Prestamo? p = fila.Tag as Prestamo;
            if (p == null)
                return;

            EstadoPrestamo estado = Clasificar(p);
            string restante;

            if (EstaVigente(p))
            {
                TimeSpan t = MomentoDeVencimiento(p) - DateTime.Now;
                restante = t > TimeSpan.Zero
                    ? FormatearRestanteCorto(t)
                    : "Vencido hace " + FormatearRestanteCorto(-t);
            }
            else
            {
                restante = "—";
            }

            AsignarSiCambia(fila.Cells["Restante"], restante);
            AsignarSiCambia(fila.Cells["Estado"], TextoEstado(estado));

            fila.Cells["Estado"].Style.ForeColor = ColorEstado(estado);
            fila.Cells["Restante"].Style.ForeColor = EstaVigente(p) ? ColorEstado(estado) : ColorGris;
        }

        private static void AsignarSiCambia(DataGridViewCell celda, string valor)
        {
            if (!Equals(celda.Value, valor))
                celda.Value = valor;
        }

        private void ActualizarCuentaRegresiva()
        {
            foreach (DataGridViewRow fila in dgvPrestamos.Rows)
                PintarFila(fila);

            MostrarCuentaRegresiva(PrestamoSeleccionado());
        }

        private void MostrarCuentaRegresiva(Prestamo? p)
        {
            if (p == null)
            {
                lblCuenta.Text = "—";
                lblCuenta.ForeColor = ColorGris;
                lblVence.Text = "Selecciona un préstamo de la tabla.";
                lblTranscurrido.Text = string.Empty;
                lblAviso.Text = string.Empty;
                prgTiempo.Value = 0;
                return;
            }

            EstadoPrestamo estado = Clasificar(p);
            DateTime vence = MomentoDeVencimiento(p);
            Color color = ColorEstado(estado);

            lblVence.Text = "Vence el " + vence.ToString("dd/MM/yyyy") + " a las 23:59";
            lblCuenta.ForeColor = color;
            lblAviso.ForeColor = color;

            double totalSegundos = (vence - p.FechaPrestamo.Date).TotalSeconds;
            double pasadoSegundos = (DateTime.Now - p.FechaPrestamo.Date).TotalSeconds;
            int porcentaje = totalSegundos <= 0
                ? 100
                : (int)Math.Max(0, Math.Min(100, pasadoSegundos / totalSegundos * 100));

            switch (estado)
            {
                case EstadoPrestamo.EnCurso:
                case EstadoPrestamo.PorVencer:
                    lblCuenta.Text = FormatearRestante(vence - DateTime.Now);
                    prgTiempo.Value = porcentaje;
                    lblTranscurrido.Text = "Ha transcurrido el " + porcentaje + " % del plazo.";
                    lblAviso.Text = estado == EstadoPrestamo.PorVencer
                        ? "¡Está por vencer! Devuélvelo pronto para evitar una sanción."
                        : "Vas bien de tiempo. Recuerda devolverlo antes de la fecha límite.";
                    break;

                case EstadoPrestamo.Vencido:
                    TimeSpan atraso = DateTime.Now - vence;
                    lblCuenta.Text = "Vencido hace " + (int)atraso.TotalDays + " d  " + atraso.Hours.ToString("00") + " h";
                    prgTiempo.Value = 100;
                    lblTranscurrido.Text = "Plazo agotado: " + p.CalcularDiasRetraso() + " día(s) de retraso.";
                    lblAviso.Text = "El préstamo está vencido. El retraso puede generar una sanción: devuélvelo cuanto antes.";
                    break;

                case EstadoPrestamo.Devuelto:
                    lblCuenta.Text = "Devuelto";
                    prgTiempo.Value = 100;
                    DateTime entrega = p.FechaDevolucionReal ?? p.FechaLimite;
                    int dias = p.CalcularDiasRetraso(entrega);
                    lblTranscurrido.Text = "Devuelto el " + entrega.ToString("dd/MM/yyyy") + ".";
                    lblAviso.Text = dias > 0
                        ? "Se entregó con " + dias + " día(s) de retraso."
                        : "Se entregó a tiempo. ¡Gracias!";
                    lblAviso.ForeColor = dias > 0 ? ColorAmbar : ColorVerde;
                    break;

                case EstadoPrestamo.Cancelado:
                    lblCuenta.Text = "Cancelado";
                    prgTiempo.Value = 0;
                    lblTranscurrido.Text = "Este préstamo se canceló; el libro volvió a estar disponible.";
                    lblAviso.Text = string.Empty;
                    break;

                default:
                    lblCuenta.Text = "Inactivo";
                    prgTiempo.Value = 0;
                    lblTranscurrido.Text = "Este préstamo está desactivado.";
                    lblAviso.Text = "Consulta con la biblioteca si crees que es un error.";
                    break;
            }
        }

        private void MostrarDetalle()
        {
            Prestamo? p = PrestamoSeleccionado();

            MostrarCuentaRegresiva(p);
            MostrarHistorial(p);

            btnDevolver.Enabled = p != null && EstaVigente(p);
            btnCancelar.Enabled = p != null && EstaVigente(p) && Clasificar(p) != EstadoPrestamo.Vencido;
        }

        private void MostrarHistorial(Prestamo? p)
        {
            dgvHistorial.Rows.Clear();

            if (p == null)
            {
                lblLibro.Text = "Libro: —";
                lblPropietario.Text = "Propietario: —";
                lblPoseedor.Text = "Lo tiene ahora: —";
                lblPoseedor.ForeColor = Color.White;
                return;
            }

            Usuario? yo = Sesion.UsuarioActual;
            int idYo = yo == null ? -1 : yo.Id;

            Ejemplar? ejemplar = Ejemplar.ObtenerTodos().FirstOrDefault(x => x.Id == p.IdEjemplar);
            Libro? libro = ejemplar == null
                ? null
                : Libro.ObtenerTodos().FirstOrDefault(x => x.Id == ejemplar.IdLibro);

            string titulo = libro == null ? "(libro no encontrado)" : libro.Titulo;
            string codigo = ejemplar == null ? "#" + p.IdEjemplar : ejemplar.CodigoInventario;
            lblLibro.Text = "Libro: " + titulo + "  [" + codigo + "]";

            if (libro != null && libro.IdPropietario.HasValue)
                lblPropietario.Text = "Propietario: " + NombreUsuario(libro.IdPropietario.Value, idYo);
            else
                lblPropietario.Text = "Propietario: Biblioteca (sin propietario asignado)";

            Prestamo? vigente = Prestamo.ObtenerTodos()
                .FirstOrDefault(x => x.IdEjemplar == p.IdEjemplar && EstaVigente(x));

            if (vigente == null)
            {
                lblPoseedor.Text = "Lo tiene ahora: nadie (disponible)";
                lblPoseedor.ForeColor = ColorVerde;
            }
            else
            {
                lblPoseedor.Text = "Lo tiene ahora: " + NombreUsuario(vigente.IdUsuario, idYo) +
                                   "  (desde " + vigente.FechaPrestamo.ToString("dd/MM/yyyy") + ")";
                lblPoseedor.ForeColor = vigente.IdUsuario == idYo ? ColorCian : ColorAmbar;
            }

            List<Prestamo> historial = Prestamo.ObtenerTodos()
                .Where(x => x.IdEjemplar == p.IdEjemplar)
                .OrderByDescending(x => x.FechaPrestamo)
                .ThenByDescending(x => x.Id)
                .ToList();

            foreach (Prestamo h in historial)
            {
                EstadoPrestamo estado = Clasificar(h);
                bool cancelado = estado == EstadoPrestamo.Cancelado;

                int indice = dgvHistorial.Rows.Add(
                    NombreUsuario(h.IdUsuario, idYo),
                    h.FechaPrestamo.ToString("dd/MM/yyyy"),
                    h.FechaLimite.ToString("dd/MM/yyyy"),
                    h.Devuelto && !cancelado && h.FechaDevolucionReal.HasValue
                        ? h.FechaDevolucionReal.Value.ToString("dd/MM/yyyy")
                        : "—",
                    TextoEstado(estado));

                DataGridViewRow fila = dgvHistorial.Rows[indice];
                fila.Cells["Estado"].Style.ForeColor = ColorEstado(estado);
                if (h.Id == p.Id)
                    fila.DefaultCellStyle.Font = new Font(dgvHistorial.Font, FontStyle.Bold);
            }

            dgvHistorial.ClearSelection();
            AyudaTablas.Ajustar(dgvHistorial);
        }

        private void btnDevolver_Click(object? sender, EventArgs e)
        {
            try
            {
                Prestamo p = ExigirPrestamoVigente();
                string titulo = TituloDelEjemplar(p.IdEjemplar);

                DialogResult respuesta = MessageBox.Show(
                    "¿Devolver «" + titulo + "» ahora?",
                    "Devolver libro", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (respuesta != DialogResult.Yes)
                    return;

                DateTime ahora = DateTime.Now;
                int retraso = p.CalcularDiasRetraso(ahora);

                p.RegistrarDevolucion(ahora);
                p.ActualizarRegistro(p);
                LiberarEjemplar(p.IdEjemplar);

                CargarPrestamos(p.Id);

                MostrarMensaje(retraso > 0
                    ? "Libro devuelto con " + retraso + " día(s) de retraso."
                    : "Libro devuelto a tiempo. ¡Gracias!", retraso > 0);
            }
            catch (Exception ex) when (ex is ArgumentException || ex is InvalidOperationException)
            {
                MostrarMensaje(ex.Message.Replace("\n", " "), true);
            }
        }

        private void btnCancelar_Click(object? sender, EventArgs e)
        {
            try
            {
                Prestamo p = ExigirPrestamoVigente();

                if (Clasificar(p) == EstadoPrestamo.Vencido)
                    throw new InvalidOperationException(
                        "Un préstamo vencido ya no se puede cancelar: debes devolver el libro.");

                string titulo = TituloDelEjemplar(p.IdEjemplar);

                DialogResult respuesta = MessageBox.Show(
                    "¿Cancelar el préstamo de «" + titulo + "»?\nEl libro quedará disponible para otros usuarios.",
                    "Cancelar préstamo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (respuesta != DialogResult.Yes)
                    return;

                p.RegistrarDevolucion(p.FechaPrestamo);
                p.Estado = false;
                p.ActualizarRegistro(p);
                LiberarEjemplar(p.IdEjemplar);

                CargarPrestamos(p.Id);

                MostrarMensaje("Préstamo cancelado. El libro volvió a estar disponible.", false);
            }
            catch (Exception ex) when (ex is ArgumentException || ex is InvalidOperationException)
            {
                MostrarMensaje(ex.Message.Replace("\n", " "), true);
            }
        }

        private void btnBorrarHistorial_Click(object? sender, EventArgs e)
        {
            Usuario? yo = Sesion.UsuarioActual;
            if (yo == null)
                return;

            List<Prestamo> cerrados = Prestamo.ObtenerTodos()
                .Where(x => x.IdUsuario == yo.Id && x.Devuelto)
                .ToList();

            if (cerrados.Count == 0)
            {
                MostrarMensaje("No tienes préstamos devueltos o cancelados que borrar.", false);
                return;
            }

            DialogResult respuesta = MessageBox.Show(
                "Se borrarán " + cerrados.Count + " préstamo(s) devuelto(s) o cancelado(s) de tu historial.\n" +
                "Los préstamos que tienes vigentes no se tocan.\n\n" +
                "Esta acción no se puede deshacer. ¿Continuar?",
                "Borrar historial", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (respuesta != DialogResult.Yes)
                return;

            int borrados = 0;
            int omitidos = 0;
            foreach (Prestamo p in cerrados)
            {
                try
                {
                    new Prestamo().EliminarRegistro(p.Id.ToString());
                    borrados++;
                }
                catch (Exception ex) when (ex is ArgumentException || ex is InvalidOperationException)
                {
                    omitidos++;
                }
            }

            CargarPrestamos(null);

            if (omitidos == 0)
                MostrarMensaje("Historial borrado: " + borrados + " préstamo(s) eliminado(s).", false);
            else
                MostrarMensaje("Se borraron " + borrados + " préstamo(s). " + omitidos +
                               " no se pudo/pudieron borrar (probablemente tienen una sanción asociada).", true);
        }

        private Prestamo ExigirPrestamoVigente()
        {
            Prestamo? p = PrestamoSeleccionado();
            if (p == null)
                throw new InvalidOperationException("Selecciona un préstamo de la tabla.");
            if (!EstaVigente(p))
                throw new InvalidOperationException("Ese préstamo ya no está vigente.");
            return p;
        }

        private static void LiberarEjemplar(int idEjemplar)
        {
            bool otroLoTiene = Prestamo.ObtenerTodos().Any(x => x.IdEjemplar == idEjemplar && EstaVigente(x));
            if (otroLoTiene)
                return;

            Ejemplar? actual = Ejemplar.ObtenerTodos().FirstOrDefault(x => x.Id == idEjemplar);
            if (actual == null || actual.Disponible)
                return;

            Ejemplar libre = new Ejemplar(actual.Id, actual.IdLibro, actual.CodigoInventario,
                                          actual.Condicion, true, actual.EsActivo);
            libre.FechaRegistro = actual.FechaRegistro;
            libre.ActualizarRegistro(libre);
        }

        private static string TituloDelEjemplar(int idEjemplar)
        {
            Ejemplar? ej = Ejemplar.ObtenerTodos().FirstOrDefault(x => x.Id == idEjemplar);
            if (ej == null)
                return "(ejemplar #" + idEjemplar + ")";

            Libro? libro = Libro.ObtenerTodos().FirstOrDefault(x => x.Id == ej.IdLibro);
            return libro == null ? "(libro #" + ej.IdLibro + ")" : libro.Titulo;
        }

        private static string CodigoDelEjemplar(int idEjemplar)
        {
            Ejemplar? ej = Ejemplar.ObtenerTodos().FirstOrDefault(x => x.Id == idEjemplar);
            return ej == null ? "#" + idEjemplar : ej.CodigoInventario;
        }

        private static string NombreUsuario(int idUsuario, int idYo)
        {
            if (idUsuario == idYo)
            {
                Usuario? yo = Sesion.UsuarioActual;
                return yo == null ? "Tú" : (yo.Nombre + " " + yo.Apellido).Trim() + " (tú)";
            }

            Usuario? u = Usuario.ObtenerTodos().FirstOrDefault(x => x.Id == idUsuario);
            return u == null ? "Usuario #" + idUsuario : (u.Nombre + " " + u.Apellido).Trim();
        }

        private void InitializeComponent()
        {

        }

        private void MostrarMensaje(string mensaje, bool esError)
        {
            lblMensaje.ForeColor = esError ? ColorRojo : ColorCian;
            lblMensaje.Text = mensaje;

            if (esError)
                MessageBox.Show(mensaje, "Mis préstamos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
