//   Equipo 2
//   NUÑEZ Martinez Marco Antonio
//   SUÑIGA Maciel Joule Alexander
//   VILLA Olivarez Ariel
// =============================
using SistemaBiblioteca1.Datos;
using SistemaBiblioteca1.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace SistemaBiblioteca1
{
    public partial class FrmVentas : Form
    {
        private static readonly CultureInfo cultura = new CultureInfo("es-MX");

        private readonly List<DetallePedido> carrito = new List<DetallePedido>();

        public FrmVentas()
        {
            InitializeComponent();

            DataGridViewTextBoxColumn colResCondicion = new DataGridViewTextBoxColumn
            {
                Name = "colResCondicion", HeaderText = "Condición", FillWeight = 55F, ReadOnly = true
            };
            DataGridViewTextBoxColumn colResDescuento = new DataGridViewTextBoxColumn
            {
                Name = "colResDescuento", HeaderText = "Desc.", FillWeight = 40F, ReadOnly = true
            };
            dgvResultados.Columns.Insert(colResIsbn.Index + 1, colResCondicion);
            dgvResultados.Columns.Insert(colResIsbn.Index + 2, colResDescuento);

            colResPrecio.DefaultCellStyle.FormatProvider = cultura;
            colCarPrecio.DefaultCellStyle.FormatProvider = cultura;
            colCarSubtotal.DefaultCellStyle.FormatProvider = cultura;

            btnAnadir.LocationChanged += (s, e) => AlinearCantidad();
            btnAnadir.SizeChanged += (s, e) => AlinearCantidad();
            nudCantidad.LocationChanged += (s, e) => AlinearCantidad();
            nudCantidad.SizeChanged += (s, e) => AlinearCantidad();
            lblCantidad.LocationChanged += (s, e) => AlinearCantidad();
            lblCantidad.SizeChanged += (s, e) => AlinearCantidad();

            dgvResultados.SelectionChanged += (s, e) => ActualizarLimiteCantidad(true);

            if (Sesion.EsInvitado)
            {
                btnConfirmar.Enabled = false;
                btnConfirmar.Text = "Inicia sesión para comprar";
            }
        }

        private void ActualizarLimiteCantidad(bool avisar)
        {
            if (dgvResultados.CurrentRow?.Tag is not ProductoVenta producto)
            {
                nudCantidad.Maximum = 9999;
                return;
            }

            int enCarrito = carrito.Where(d => d.IdLibro == producto.IdLibro && d.Condicion == producto.Condicion).Sum(d => d.Cantidad);
            int libres = Math.Max(0, producto.Stock - enCarrito);

            nudCantidad.Maximum = Math.Max(1, libres);

            if (!avisar)
                return;

            if (producto.Stock <= 0)
                MostrarMensaje("«" + producto.Titulo + "» está agotado: no se puede añadir.", true);
            else if (libres == 0)
                MostrarMensaje("Ya tienes en el carrito todo el stock de «" + producto.Titulo + "» [" + producto.Condicion + "] (" + producto.Stock + ").", true);
            else if (producto.DescuentoPorcentaje > 0)
                MostrarMensaje("«" + producto.Titulo + "» [" + producto.Condicion + "]: " + libres + " disponible(s), " +
                               PoliticaDescuento.Etiqueta(producto.Condicion) + " por su condición.", false);
            else
                MostrarMensaje("«" + producto.Titulo + "» [" + producto.Condicion + "]: " + libres + " disponible(s) para añadir.", false);
        }

        private bool alineandoCantidad = false;

        private void AlinearCantidad()
        {
            if (alineandoCantidad)
                return;

            alineandoCantidad = true;
            try
            {
                int separacion = 8;
                int centro = btnAnadir.Top + btnAnadir.Height / 2;

                nudCantidad.Location = new Point(btnAnadir.Left - separacion - nudCantidad.Width,
                                                 centro - nudCantidad.Height / 2);
                lblCantidad.Location = new Point(nudCantidad.Left - separacion - lblCantidad.Width,
                                                 centro - lblCantidad.Height / 2);
            }
            finally
            {
                alineandoCantidad = false;
            }
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            lblTotalVenta.Font = new Font("Segoe UI", 20F, FontStyle.Bold | FontStyle.Italic);
            lblTotalVenta.ForeColor = TemaPersona3.Cian;

            ActualizarTotal();
            BuscarPorNombre();
        }

        private void BuscarPorId()
        {
            string texto = txtIdBuscar.Text.Trim();

            if (texto.Length == 0)
            {
                MostrarMensaje("Escribe el ID del libro que quieres buscar.", true);
                MessageBox.Show("Escribe el ID del libro que quieres buscar.", "Búsqueda por ID",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(texto, out int id) || id < 0)
            {
                MostrarMensaje("El ID debe ser un número entero no negativo.", true);
                MessageBox.Show("El ID debe ser un número entero no negativo.", "Búsqueda por ID",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!HayConexion())
                return;

            try
            {
                List<ProductoVenta> productos = VentasBD.BuscarPorId(id);

                if (productos.Count == 0)
                {
                    MostrarResultados(new List<ProductoVenta>());
                    MostrarMensaje("No existe un libro activo con el ID " + id + ".", true);
                    MessageBox.Show("No existe un libro activo con el ID " + id + ".", "Búsqueda por ID",
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                MostrarResultados(productos);
                MostrarMensaje("Libro encontrado: «" + productos[0].Titulo + "».", false);
            }
            catch (InvalidOperationException ex)
            {
                MostrarMensaje(ex.Message.Replace("\n", " "), true);
                MessageBox.Show(ex.Message, "Carrito de compras", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BuscarPorNombre()
        {
            if (!HayConexion())
                return;

            string texto = txtNombreBuscar.Text.Trim();

            try
            {
                List<ProductoVenta> encontrados = VentasBD.BuscarPorNombre(texto);
                MostrarResultados(encontrados);

                if (texto.Length == 0)
                    MostrarMensaje("Catálogo completo: " + encontrados.Select(p => p.IdLibro).Distinct().Count() + " libro(s).", false);
                else if (encontrados.Count == 0)
                    MostrarMensaje("Ningún libro coincide con «" + texto + "».", true);
                else
                    MostrarMensaje(encontrados.Select(p => p.IdLibro).Distinct().Count() + " libro(s) coinciden con «" + texto + "».", false);
            }
            catch (InvalidOperationException ex)
            {
                MostrarMensaje(ex.Message.Replace("\n", " "), true);
                MessageBox.Show(ex.Message, "Carrito de compras", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void MostrarResultados(List<ProductoVenta> productos)
        {
            dgvResultados.Rows.Clear();

            foreach (ProductoVenta p in productos)
            {
                int indice = dgvResultados.Rows.Add(p.IdLibro, p.Titulo, p.Autor, p.Isbn,
                                                    p.Condicion.Length > 0 ? p.Condicion : "Agotado",
                                                    PoliticaDescuento.Etiqueta(p.Condicion),
                                                    p.Precio, p.Stock);
                DataGridViewRow fila = dgvResultados.Rows[indice];
                fila.Tag = p;

                if (p.Stock <= 0)
                    fila.DefaultCellStyle.ForeColor = Color.FromArgb(255, 107, 107);
            }

            ActualizarLimiteCantidad(false);
        }

        private void AnadirAlCarrito()
        {
            try
            {
                if (dgvResultados.CurrentRow?.Tag is not ProductoVenta producto)
                {
                    MessageBox.Show("Selecciona un libro de la tabla de resultados.",
                                    "Carrito de compras", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                int cantidad = (int)nudCantidad.Value;
                if (cantidad <= 0)
                {
                    MessageBox.Show("La cantidad debe ser mayor a cero.",
                                    "Cantidad no válida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (producto.PrecioBase <= 0)
                {
                    MessageBox.Show("«" + producto.Titulo + "» no tiene precio asignado, no se puede vender.",
                                    "Sin precio", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int enCarrito = carrito.Where(d => d.IdLibro == producto.IdLibro && d.Condicion == producto.Condicion).Sum(d => d.Cantidad);

                if (!ValidarStock(producto.IdLibro, producto.Titulo, producto.Condicion, enCarrito + cantidad))
                    return;

                DetallePedido? existente = carrito.FirstOrDefault(d => d.IdLibro == producto.IdLibro && d.Condicion == producto.Condicion);
                if (existente != null)
                    existente.Cantidad = existente.Cantidad + cantidad;
                else
                    carrito.Add(new DetallePedido(producto.IdLibro, producto.Titulo, producto.Condicion, producto.PrecioBase, cantidad));

                RefrescarCarrito();
                nudCantidad.Value = 1;
                ActualizarLimiteCantidad(false);
                MostrarMensaje("Añadido: " + cantidad + " x «" + producto.Titulo + "» [" + producto.Condicion + "]" +
                               (producto.DescuentoPorcentaje > 0 ? " con " + PoliticaDescuento.Etiqueta(producto.Condicion) + "." : "."), false);
            }
            catch (Exception ex) when (ex is ArgumentException || ex is InvalidOperationException)
            {
                MessageBox.Show(ex.Message, "Carrito de compras", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private bool ValidarStock(int idLibro, string titulo, string condicion, int cantidadTotal)
        {
            if (!ConexionBD.Habilitada)
                throw new InvalidOperationException("Sin conexión con MariaDB: no se puede validar el stock.");

            int stock = VentasBD.ConsultarStock(idLibro, condicion);
            string sufijo = string.IsNullOrEmpty(condicion) ? string.Empty : " [" + condicion + "]";

            if (stock <= 0)
            {
                MessageBox.Show("«" + titulo + "»" + sufijo + " no tiene existencias disponibles.",
                                "Sin existencias", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (cantidadTotal > stock)
            {
                MessageBox.Show("No hay existencias suficientes de «" + titulo + "»" + sufijo + ".\n\n" +
                                "Cantidad solicitada: " + cantidadTotal + "\n" +
                                "Stock disponible: " + stock,
                                "Existencias insuficientes", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void RefrescarCarrito()
        {
            dgvCarrito.Rows.Clear();

            foreach (DetallePedido d in carrito)
            {
                int indice = dgvCarrito.Rows.Add(d.IdLibro, d.Descripcion, d.Cantidad, d.PrecioUnitario, d.CalcularSubtotal());
                dgvCarrito.Rows[indice].Tag = d;
            }

            ActualizarTotal();
        }
        private decimal CalcularTotal()
        {
            decimal total = 0m;

            foreach (DetallePedido d in carrito)
                total += d.CalcularSubtotal();

            return total;
        }

        private void ActualizarTotal()
        {
            lblTotalVenta.Text = CalcularTotal().ToString("C2", cultura);
        }

        private void dgvCarrito_CellEndEdit(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex != colCarCantidad.Index)
                return;

            DataGridViewRow fila = dgvCarrito.Rows[e.RowIndex];
            if (fila.Tag is not DetallePedido detalle)
                return;

            string texto = (Convert.ToString(fila.Cells[colCarCantidad.Index].Value) ?? string.Empty).Trim();

            try
            {
                if (!int.TryParse(texto, out int nueva) || nueva <= 0)
                {
                    MessageBox.Show("La cantidad debe ser un número entero mayor a cero.",
                                    "Cantidad no válida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    fila.Cells[colCarCantidad.Index].Value = detalle.Cantidad;
                    return;
                }

                if (!ValidarStock(detalle.IdLibro, detalle.Titulo, detalle.Condicion, nueva))
                {
                    fila.Cells[colCarCantidad.Index].Value = detalle.Cantidad;
                    return;
                }

                detalle.Cantidad = nueva;
                fila.Cells[colCarCantidad.Index].Value = detalle.Cantidad;
                fila.Cells[colCarSubtotal.Index].Value = detalle.CalcularSubtotal();
                ActualizarTotal();
                ActualizarLimiteCantidad(false);
            }
            catch (Exception ex) when (ex is ArgumentException || ex is InvalidOperationException)
            {
                MessageBox.Show(ex.Message, "Carrito de compras", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                fila.Cells[colCarCantidad.Index].Value = detalle.Cantidad;
            }
        }

        private void QuitarDelCarrito()
        {
            if (dgvCarrito.CurrentRow?.Tag is not DetallePedido detalle)
            {
                MessageBox.Show("Selecciona una línea del carrito para quitarla.",
                                "Carrito de compras", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            carrito.Remove(detalle);
            RefrescarCarrito();
            ActualizarLimiteCantidad(false);
            MostrarMensaje("«" + detalle.Titulo + "» se quitó del carrito.", false);
        }

        private void ConfirmarPedido()
        {
            if (Sesion.EsInvitado)
            {
                MessageBox.Show("Para confirmar una compra necesitas iniciar sesión con una cuenta de usuario.",
                                "Compra no permitida", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (carrito.Count == 0)
            {
                MessageBox.Show("El carrito está vacío. Añade al menos un libro antes de confirmar.",
                                "Pedido vacío", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                foreach (DetallePedido d in carrito)
                {
                    if (d.Cantidad <= 0 || d.PrecioUnitario <= 0)
                    {
                        MessageBox.Show("«" + d.Titulo + "» tiene una cantidad o un precio no válido.",
                                        "Datos inconsistentes", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    if (!ValidarStock(d.IdLibro, d.Titulo, d.Condicion, d.Cantidad))
                        return;
                }

                decimal totalLista = CalcularTotal();

                decimal totalCuadricula = 0m;
                foreach (DataGridViewRow fila in dgvCarrito.Rows)
                    totalCuadricula += Convert.ToDecimal(fila.Cells[colCarSubtotal.Index].Value);

                if (totalLista != totalCuadricula)
                {
                    MessageBox.Show("El total de la cuadrícula no coincide con el de la lista. Revisa el carrito.",
                                    "Datos inconsistentes", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int articulos = carrito.Sum(d => d.Cantidad);

                decimal ahorro = carrito.Sum(d => d.Ahorro);

                DialogResult confirmar = MessageBox.Show("¿Confirmar el pedido?\n\n" +
                                "Líneas: " + carrito.Count + "\n" +
                                "Artículos: " + articulos + "\n" +
                                (ahorro > 0 ? "Ahorro por condición: " + ahorro.ToString("C2", cultura) + "\n" : "") +
                                "Total: " + totalLista.ToString("C2", cultura),
                                "Confirmación de pedido", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (confirmar != DialogResult.Yes)
                    return;

                if (!HayConexion())
                    return;

                Usuario? cliente = Sesion.UsuarioActual;
                int? idUsuario = cliente?.Id;
                string nombreCliente = cliente != null ? cliente.Nombre + " " + cliente.Apellido : SesionSistema.UsuarioActivo;

                int folio = PedidosBD.Guardar(carrito, idUsuario, nombreCliente);

                MessageBox.Show("Pedido #" + folio + " guardado correctamente.\n\n" +
                                "Artículos: " + articulos + "\n" +
                                "Total: " + totalLista.ToString("C2", cultura) + "\n\n" +
                                "El stock se descontó y el pedido quedó en MariaDB y en MongoDB.",
                                "Pedido guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                carrito.Clear();
                RefrescarCarrito();
                BuscarPorNombre();
                ActualizarLimiteCantidad(false);
                MostrarMensaje("Pedido #" + folio + " guardado por " + totalLista.ToString("C2", cultura) + ".", false);
            }
            catch (Exception ex) when (ex is ArgumentException || ex is InvalidOperationException)
            {
                MessageBox.Show(ex.Message, "Confirmación de pedido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnBuscarId_Click(object? sender, EventArgs e)
        {
            BuscarPorId();
        }

        private void txtIdBuscar_KeyDown(object? sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                BuscarPorId();
            }
        }

        private void txtIdBuscar_KeyPress(object? sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void txtNombreBuscar_TextChanged(object? sender, EventArgs e)
        {
            BuscarPorNombre();
        }

        private void dgvResultados_CellDoubleClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
                AnadirAlCarrito();
        }

        private void btnAnadir_Click(object? sender, EventArgs e)
        {
            AnadirAlCarrito();
        }

        private void btnQuitar_Click(object? sender, EventArgs e)
        {
            QuitarDelCarrito();
        }

        private void btnConfirmar_Click(object? sender, EventArgs e)
        {
            ConfirmarPedido();
        }

        private bool HayConexion()
        {
            if (ConexionBD.Habilitada)
                return true;

            MostrarMensaje("Sin conexión con MariaDB (modo memoria): el carrito necesita la base de datos.", true);
            MessageBox.Show("Sin conexión con MariaDB (modo memoria): el carrito necesita la base de datos.",
                            "Sin conexión", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return false;
        }

        private void MostrarMensaje(string mensaje, bool esError)
        {
            lblMensaje.ForeColor = esError ? Color.FromArgb(255, 107, 107) : Color.FromArgb(0, 212, 255);
            lblMensaje.Text = mensaje;
        }
    }
}
