//   Equipo 2
//   NUÑEZ Martinez Marco Antonio
//   SUÑIGA Maciel Joule Alexander
//   VILLA Olivarez Ariel
// =============================
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Text;
using System.Windows.Forms;
using SistemaBiblioteca1.Datos;
using SistemaBiblioteca1.Models;

namespace SistemaBiblioteca1
{
    public partial class FrmLibro : FrmBase, IPanelCRUD
    {
        private string rutaImagenOrigen = string.Empty;

        public FrmLibro()
        {
            InitializeComponent();

            ConfigurarCampoTexto(txtTituloLibro, "Título");
            ConfigurarCampoEntero(txtIsbn, "ISBN", t => (t.Length != 10 && t.Length != 13) ? "El ISBN debe tener 10 o 13 dígitos." : null);
            ConfigurarCampoLista(cmbAutorLibro, "Autor");
            ConfigurarCampoLista(cmbCategoriaLibro, "Categoría");
            ConfigurarCampoLista(cmbEditorialLibro, "Editorial");
            ConfigurarCampoEntero(txtAnioPublicacion, "Año de publicación", t => t.Length != 4 ? "El año debe tener 4 dígitos." : null);

            txtId.MaxLength = 9;
            txtTituloLibro.MaxLength = 200;
            txtIsbn.MaxLength = 13;
            txtAnioPublicacion.MaxLength = 4;
            txtPuntoEntrega.MaxLength = 100;

            ConfigurarStock();

            btnCargarPortada.Click += btnCargarPortada_Click;

            CargarCatalogos();
            VisibleChanged += (s, e) => { if (Visible) CargarCatalogos(); };
        }

        private bool IsbnDisponible(int? idPropio)
        {
            string isbn = txtIsbn.Text.Trim();

            Libro? repetido = Libro.ObtenerTodos()
                .FirstOrDefault(l => string.Equals(l.Isbn, isbn, StringComparison.OrdinalIgnoreCase) && l.Id != idPropio);

            if (repetido == null)
                return true;

            MostrarErrorCampo(txtIsbn, "El ISBN " + isbn + " ya está registrado en el libro #" + repetido.Id +
                                       " («" + repetido.Titulo + "»).");
            return false;
        }

        private static bool EsAdmin
        {
            get { return Sesion.EsAdministrador; }
        }

        private void ConfigurarStock()
        {
            lblStock.Visible = EsAdmin;
            txtStock.Visible = EsAdmin;
            txtStock.MaxLength = 3;

            lblPrecio.Visible = EsAdmin;
            txtPrecio.Visible = EsAdmin;
            txtPrecio.MaxLength = 11;

            txtPrecio.KeyPress += (s, e) =>
            {
                bool permitido = char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar);

                if (e.KeyChar == '.')
                    permitido = !txtPrecio.Text.Contains('.') || txtPrecio.SelectedText.Contains('.');

                if (!permitido)
                {
                    e.Handled = true;
                    System.Media.SystemSounds.Beep.Play();
                }
            };
            txtPrecio.TextChanged += (s, e) => epValidaciones.SetError(txtPrecio, string.Empty);

            txtStock.KeyPress += (s, e) =>
            {
                if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                {
                    e.Handled = true;
                    System.Media.SystemSounds.Beep.Play();
                }
            };
            txtStock.TextChanged += (s, e) => epValidaciones.SetError(txtStock, string.Empty);
        }

        private bool ValidarStock(out int stock)
        {
            stock = 0;
            string texto = txtStock.Text.Trim();

            if (texto.Length == 0)
            {
                MostrarErrorCampo(txtStock, "Escribe el stock del libro (0 si no hay ejemplares).");
                return false;
            }

            if (!int.TryParse(texto, out stock) || stock < 0)
            {
                MostrarErrorCampo(txtStock, "El stock debe ser un número entero, sin signo ni decimales.");
                return false;
            }

            if (stock > StockLibro.STOCK_MAXIMO)
            {
                MostrarErrorCampo(txtStock, "El stock máximo permitido es " + StockLibro.STOCK_MAXIMO + " ejemplares.");
                return false;
            }

            return true;
        }

        private bool ValidarPrecio(out decimal precio)
        {
            precio = 0m;
            string texto = txtPrecio.Text.Trim();

            if (texto.Length == 0)
            {
                MostrarErrorCampo(txtPrecio, "Escribe el precio del libro (por ejemplo 150.00).");
                return false;
            }

            if (!decimal.TryParse(texto, NumberStyles.AllowDecimalPoint, CultureInfo.InvariantCulture, out precio))
            {
                MostrarErrorCampo(txtPrecio, "El precio debe ser un número, por ejemplo 150 o 150.50.");
                return false;
            }

            if (precio <= 0)
            {
                MostrarErrorCampo(txtPrecio, "El precio debe ser mayor que 0 (con precio 0 el libro no se puede vender).");
                return false;
            }

            if (decimal.Round(precio, 2) != precio)
            {
                MostrarErrorCampo(txtPrecio, "El precio solo admite hasta 2 decimales.");
                return false;
            }

            if (precio > 99999999.99m)
            {
                MostrarErrorCampo(txtPrecio, "El precio máximo permitido es 99,999,999.99.");
                return false;
            }

            return true;
        }

        private bool ConfirmarReduccionStock(int nuevoStock)
        {
            if (!int.TryParse(txtId.Text, out int idLibro))
                return true;

            int actual = StockLibro.Contar(idLibro);
            if (nuevoStock >= actual)
                return true;

            DialogResult respuesta = MessageBox.Show(
                "El stock bajará de " + actual + " a " + nuevoStock + ".\n\n" +
                "Se darán de baja " + (actual - nuevoStock) + " ejemplar(es) disponible(s). " +
                "Los ejemplares que están prestados no se modifican.\n\n¿Deseas continuar?",
                "Confirmar reducción de stock", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            return respuesta == DialogResult.Yes;
        }

        private string AplicarStock(int idLibro, int stock)
        {
            try
            {
                int cambio = StockLibro.Ajustar(idLibro, stock);

                if (cambio > 0)
                    return "\nStock: se agregaron " + cambio + " ejemplar(es). Stock actual: " + stock + ".";
                if (cambio < 0)
                    return "\nStock: se dieron de baja " + (-cambio) + " ejemplar(es). Stock actual: " + stock + ".";
                return "\nEl stock se mantiene en " + stock + ".";
            }
            catch (Exception ex) when (ex is ArgumentException || ex is InvalidOperationException)
            {
                MessageBox.Show("El libro se guardó, pero no se pudo cambiar el stock:\n" + ex.Message,
                                "Stock no actualizado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return string.Empty;
            }
        }

        private void btnCargarPortada_Click(object? sender, EventArgs e)
        {
            string? ruta = GestorImagenes.SeleccionarImagen();
            if (ruta == null)
                return;

            if (GestorImagenes.MostrarVistaPrevia(pbxPortada, ruta))
            {
                rutaImagenOrigen = ruta;
                epValidaciones.SetError(pbxPortada, string.Empty);
            }
        }

        private void CargarCatalogos()
        {
            try
            {
                PoblarCombo(cmbAutorLibro, CatalogosBD.ObtenerAutores());
                PoblarCombo(cmbCategoriaLibro, CatalogosBD.ObtenerCategorias());
                PoblarCombo(cmbEditorialLibro, CatalogosBD.ObtenerEditoriales());
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message, "No se pudieron cargar los catálogos",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void PoblarCombo(ComboBox combo, List<ItemCatalogo> catalogo)
        {
            object? seleccionado = combo.SelectedValue;

            combo.DataSource = null;
            combo.DisplayMember = nameof(ItemCatalogo.Descripcion);
            combo.ValueMember = nameof(ItemCatalogo.Id);
            combo.DataSource = catalogo;

            combo.SelectedIndex = -1;

            if (seleccionado != null)
                combo.SelectedValue = seleccionado;
        }

        public void EjecutarGuardar()
        {
            if (!ValidarFormulario())
                return;

            if (string.IsNullOrEmpty(rutaImagenOrigen))
            {
                MostrarErrorCampo(pbxPortada, "Seleccione la portada del libro.");
                return;
            }

            if (!IsbnDisponible(null))
                return;

            int stock = 0;
            decimal precio = 0m;
            if (EsAdmin && (!ValidarStock(out stock) || !ValidarPrecio(out precio)))
                return;

            string? rutaGuardada = null;

            try
            {
                Libro libro = CrearLibroDesdeControles();
                libro.Precio = precio;

                if (Sesion.EsUsuario)
                {
                    Usuario? dueno = Sesion.UsuarioActual;
                    if (dueno == null)
                    {
                        MessageBox.Show("Tu sesión de demostración no tiene una cuenta registrada.\n" +
                                        "Entra con una cuenta creada en «Regístrate» para registrar libros.",
                                        "Registrar libro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    libro.IdPropietario = dueno.Id;
                }

                if (new Libro().ConsultarRegistro(txtId.Text) != null)
                    throw new InvalidOperationException("Ya existe un libro con el id " + libro.Id + ".");

                string nombreUnico = "Libro_" + libro.Id + "_" + Guid.NewGuid().ToString("N").Substring(0, 8);
                rutaGuardada = GestorImagenes.GuardarImagen(rutaImagenOrigen, nombreUnico);
                if (rutaGuardada == null)
                    return;

                libro.RutaImagen = rutaGuardada;

                libro.InsertarRegistro(libro);

                string avisoStock = EsAdmin ? AplicarStock(libro.Id, stock) : string.Empty;

                MessageBox.Show("Libro guardado correctamente." + avisoStock, "Guardar",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarControles();
            }
            catch (Exception ex) when (ex is ArgumentException || ex is InvalidOperationException || ex is FormatException)
            {
                if (rutaGuardada != null)
                    GestorImagenes.EliminarImagen(rutaGuardada);

                MessageBox.Show(ex.Message, "No se pudo guardar",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void EjecutarBuscar(string id, ErrorProvider alerta)
        {
            alerta.SetError(txtId, string.Empty);

            try
            {
                Libro libro = new Libro().ConsultarRegistro(id) as Libro;

                if (libro == null)
                {
                    MostrarErrorBusqueda(alerta, "No existe un libro con ese id.");
                    return;
                }

                txtId.Text = libro.Id.ToString();
                txtTituloLibro.Text = libro.Titulo;
                txtIsbn.Text = libro.Isbn;
                cmbAutorLibro.SelectedValue = libro.IdAutor;
                cmbCategoriaLibro.SelectedValue = libro.IdCategoria;
                cmbEditorialLibro.SelectedValue = libro.IdEditorial;
                txtAnioPublicacion.Text = libro.AnioPublicacion.ToString();
                txtPuntoEntrega.Text = libro.PuntoEntrega;
                chkEstadoLibro.Checked = libro.EsActivo;

                if (EsAdmin)
                {
                    txtStock.Text = StockLibro.Contar(libro.Id).ToString();
                    txtPrecio.Text = libro.Precio.ToString("0.00", CultureInfo.InvariantCulture);
                }

                rutaImagenOrigen = string.Empty;
                GestorImagenes.CargarGuardada(pbxPortada, libro.RutaImagen);
            }
            catch (ArgumentException ex)
            {
                MostrarErrorBusqueda(alerta, ex.Message);
            }
        }

        public void EjecutarActualizar()
        {
            if (!ValidarFormulario())
                return;

            int? idActual = int.TryParse(txtId.Text, out int idNumerico) ? idNumerico : (int?)null;
            if (!IsbnDisponible(idActual))
                return;

            int stock = 0;
            decimal precio = 0m;
            if (EsAdmin && (!ValidarStock(out stock) || !ValidarPrecio(out precio) || !ConfirmarReduccionStock(stock)))
                return;

            string? rutaNueva = null;

            try
            {
                Libro libro = CrearLibroDesdeControles();

                Libro? existente = new Libro().ConsultarRegistro(txtId.Text) as Libro;
                if (existente == null)
                    throw new InvalidOperationException("No existe un libro con el id " + libro.Id + ". Búscalo antes de actualizar.");

                if (Sesion.EsUsuario)
                {
                    int? miId = Sesion.UsuarioActual?.Id;
                    if (!miId.HasValue || existente.IdPropietario != miId)
                        throw new InvalidOperationException("Solo puedes actualizar los libros que registraste tú.");
                }

                libro.FechaRegistro = existente.FechaRegistro;
                libro.IdPropietario = existente.IdPropietario;
                libro.RutaImagen = existente.RutaImagen;
                libro.Precio = EsAdmin ? precio : existente.Precio;

                if (!string.IsNullOrEmpty(rutaImagenOrigen))
                {
                    string nombreUnico = "Libro_" + libro.Id + "_" + Guid.NewGuid().ToString("N").Substring(0, 8);
                    rutaNueva = GestorImagenes.GuardarImagen(rutaImagenOrigen, nombreUnico);
                    if (rutaNueva == null)
                        return;

                    libro.RutaImagen = rutaNueva;
                }

                libro.ActualizarRegistro(libro);

                if (rutaNueva != null)
                {
                    GestorImagenes.EliminarImagen(existente.RutaImagen);
                    rutaImagenOrigen = string.Empty;
                }

                string avisoStock = EsAdmin ? AplicarStock(libro.Id, stock) : string.Empty;

                MessageBox.Show("Libro actualizado correctamente." + avisoStock, "Actualizar",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex) when (ex is ArgumentException || ex is InvalidOperationException || ex is FormatException)
            {
                if (rutaNueva != null)
                    GestorImagenes.EliminarImagen(rutaNueva);

                MessageBox.Show(ex.Message, "No se pudo actualizar",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void EjecutarEliminar(StatusStrip barraEstado)
        {
            if (!ValidarIdObligatorio())
            {
                MostrarEstado(barraEstado, "Escribe o busca el ID del registro que deseas eliminar.");
                return;
            }

            try
            {
                Libro? libro = new Libro().ConsultarRegistro(txtId.Text) as Libro;
                if (libro == null)
                {
                    MessageBox.Show("No existe un libro con ese id.", "No se pudo eliminar",
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    MostrarEstado(barraEstado, "No existe un libro con ese id.");
                    return;
                }

                if (Sesion.EsUsuario)
                {
                    int? miId = Sesion.UsuarioActual?.Id;
                    if (!miId.HasValue || libro.IdPropietario != miId)
                        throw new InvalidOperationException("Solo puedes eliminar los libros que registraste tú.");
                }

                AccionBorrado accion;
                using (FrmDetalleLibro detalle = new FrmDetalleLibro(libro))
                {
                    if (detalle.ShowDialog(this) != DialogResult.OK)
                    {
                        MostrarEstado(barraEstado, "Eliminación cancelada.");
                        return;
                    }
                    accion = detalle.Accion;
                }

                if (accion == AccionBorrado.BorradoLogico)
                    EjecutarBorradoLogico(libro, barraEstado);
                else if (accion == AccionBorrado.BorradoFisico)
                    EjecutarBorradoFisico(libro, barraEstado);
            }
            catch (Exception ex) when (ex is ArgumentException || ex is InvalidOperationException)
            {
                MessageBox.Show(ex.Message, "No se pudo eliminar",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                MostrarEstado(barraEstado, "No se eliminó el libro.");
            }
        }

        private void EjecutarBorradoLogico(Libro libro, StatusStrip barraEstado)
        {
            DialogResult respuesta = MessageBox.Show(
                "¿Dar de baja el libro '" + libro.Titulo + "'?\n\n" +
                "Dejará de aparecer en el catálogo, pero su registro se conserva y se puede restaurar.",
                "Confirmar baja", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (respuesta != DialogResult.Yes)
            {
                MostrarEstado(barraEstado, "Baja cancelada.");
                return;
            }

            libro.DarDeBaja();
            chkEstadoLibro.Checked = false;
            MostrarEstado(barraEstado, "El libro '" + libro.Titulo + "' quedó dado de baja.");
        }

        private void EjecutarBorradoFisico(Libro libro, StatusStrip barraEstado)
        {
            DialogResult respuesta = MessageBox.Show(
                "¿Eliminar DEFINITIVAMENTE el libro '" + libro.Titulo + "'?\n\n" +
                "Se borrará de MariaDB y MongoDB junto con su portada. Esta acción no se puede deshacer.",
                "Confirmar eliminación permanente", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (respuesta != DialogResult.Yes)
            {
                MostrarEstado(barraEstado, "Eliminación cancelada.");
                return;
            }

            string rutaImagen = libro.RutaImagen;
            int id = libro.Id;
            string titulo = libro.Titulo;

            try
            {
                new Libro().EliminarRegistro(id.ToString());
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(
                    "No se puede eliminar físicamente el libro '" + titulo + "':\n" + ex.Message +
                    "\n\nSi otros registros dependen de él (ejemplares, préstamos, intercambios), " +
                    "usa «Dar de baja» para ocultarlo sin perder datos.",
                    "Eliminación no permitida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                MostrarEstado(barraEstado, "No se eliminó el libro: tiene registros relacionados.");
                return;
            }

            GestorImagenes.EliminarImagen(rutaImagen);

            LimpiarControles();
            MostrarEstado(barraEstado, "Libro '" + titulo + "' eliminado definitivamente.");
        }

        private Libro CrearLibroDesdeControles()
        {
            int id = LeerEntero(txtId.Text, "El id");
            int idAutor = LeerSeleccion(cmbAutorLibro, "El autor");
            int idCategoria = LeerSeleccion(cmbCategoriaLibro, "La categoría");
            int idEditorial = LeerSeleccion(cmbEditorialLibro, "La editorial");
            int anio = LeerEntero(txtAnioPublicacion.Text, "El año de publicación");

            return new Libro(id, txtTituloLibro.Text, txtIsbn.Text, idAutor, idCategoria,
                             idEditorial, anio, chkEstadoLibro.Checked, txtPuntoEntrega.Text);
        }

        private int LeerEntero(string texto, string nombreCampo)
        {
            if (!int.TryParse(texto, out int valor))
                throw new FormatException(nombreCampo + " debe ser un número entero.");
            return valor;
        }

        private int LeerSeleccion(ComboBox combo, string nombreCampo)
        {
            if (combo.SelectedValue == null || !int.TryParse(combo.SelectedValue.ToString(), out int valor))
                throw new FormatException(nombreCampo + " debe elegirse de la lista.");
            return valor;
        }

        private void LimpiarControles()
        {
            LimpiarErrores();
            txtId.Clear();
            txtTituloLibro.Clear();
            txtIsbn.Clear();
            cmbAutorLibro.SelectedIndex = -1;
            cmbCategoriaLibro.SelectedIndex = -1;
            cmbEditorialLibro.SelectedIndex = -1;
            txtAnioPublicacion.Clear();
            txtPuntoEntrega.Clear();
            txtStock.Clear();
            txtPrecio.Clear();
            chkEstadoLibro.Checked = false;

            rutaImagenOrigen = string.Empty;
            GestorImagenes.CargarGuardada(pbxPortada, string.Empty);
        }

        private void MostrarEstado(StatusStrip barraEstado, string mensaje)
        {
            if (barraEstado.Items.Count > 0)
                barraEstado.Items[0].Text = mensaje;
        }
    }
}