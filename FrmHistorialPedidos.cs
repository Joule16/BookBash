//   Equipo 2
//   NUÑEZ Martinez Marco Antonio
//   SUÑIGA Maciel Joule Alexander
//   VILLA Olivarez Ariel
// =============================
//   Actividad 4.8 - Historial de pedidos y comprobantes
using SistemaBiblioteca1.Datos;
using SistemaBiblioteca1.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace SistemaBiblioteca1
{
    public partial class FrmHistorialPedidos : Form
    {
        private static readonly CultureInfo cultura = new CultureInfo("es-MX");

        public FrmHistorialPedidos()
        {
            InitializeComponent();

            cmbOrigen.Items.Add("MariaDB (INNER JOIN por IdPedido)");
            cmbOrigen.Items.Add("MongoDB (arreglo embebido)");

            colPedTotal.DefaultCellStyle.FormatProvider = cultura;
            colDetPrecio.DefaultCellStyle.FormatProvider = cultura;
            colDetSubtotal.DefaultCellStyle.FormatProvider = cultura;
        }

        private bool UsaMongo
        {
            get { return cmbOrigen.SelectedIndex == 1; }
        }

        private void FrmHistorialPedidos_Load(object? sender, EventArgs e)
        {
            cmbOrigen.SelectedIndex = 0;
        }

        private void cmbOrigen_SelectedIndexChanged(object? sender, EventArgs e)
        {
            CargarPedidos();
        }

        private void btnActualizar_Click(object? sender, EventArgs e)
        {
            CargarPedidos();
        }

        private void CargarPedidos()
        {
            dgvPedidos.Rows.Clear();
            dgvDetalles.Rows.Clear();
            lblDetalle.Text = "Artículos del comprobante: selecciona un pedido.";

            try
            {
                List<PedidoDoc> pedidos;

                if (UsaMongo)
                {
                    pedidos = ConexionMongo.ObtenerPedidos();
                }
                else
                {
                    if (!ConexionBD.Habilitada)
                    {
                        MostrarMensaje("Sin conexión con MariaDB (modo memoria): no hay historial que mostrar.", true);
                        return;
                    }

                    pedidos = PedidosBD.ListarEncabezados();
                }

                foreach (PedidoDoc p in pedidos)
                {
                    int indice = dgvPedidos.Rows.Add(p.IdPedido, p.Fecha, p.Cliente, p.Total);
                    dgvPedidos.Rows[indice].Tag = p;
                }

                decimal sumaTotal = pedidos.Sum(p => p.Total);
                MostrarMensaje(pedidos.Count + " pedido(s) en " + (UsaMongo ? "MongoDB" : "MariaDB") +
                               ", en orden cronológico. Total vendido: " + sumaTotal.ToString("C2", cultura) + ".", false);

                if (pedidos.Count == 0)
                    lblDetalle.Text = "Artículos del comprobante: todavía no hay pedidos registrados.";
            }
            catch (InvalidOperationException ex)
            {
                MostrarMensaje(ex.Message.Replace("\n", " "), true);
                MessageBox.Show(ex.Message, "Historial de pedidos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dgvPedidos_SelectionChanged(object? sender, EventArgs e)
        {
            CargarDetalles();
        }

        private void CargarDetalles()
        {
            dgvDetalles.Rows.Clear();

            if (dgvPedidos.CurrentRow?.Tag is not PedidoDoc pedido)
                return;

            try
            {
                List<DetallePedidoDoc> detalles = UsaMongo
                    ? pedido.Detalles
                    : PedidosBD.ListarDetalles(pedido.IdPedido);

                foreach (DetallePedidoDoc d in detalles)
                {
                    dgvDetalles.Rows.Add(d.IdLibro, d.Titulo, d.Condicion.Length > 0 ? d.Condicion : "-",
                                         d.Cantidad, d.PrecioUnitario, d.Subtotal);
                }

                lblDetalle.Text = "Comprobante #" + pedido.IdPedido + " - " + pedido.Cliente + " - " +
                                  detalles.Sum(d => d.Cantidad) + " artículo(s) - Total " +
                                  pedido.Total.ToString("C2", cultura);
            }
            catch (InvalidOperationException ex)
            {
                MostrarMensaje(ex.Message.Replace("\n", " "), true);
                MessageBox.Show(ex.Message, "Historial de pedidos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void MostrarMensaje(string texto, bool esError)
        {
            lblMensaje.Text = texto;
            lblMensaje.ForeColor = esError ? Color.Firebrick : Color.DarkGreen;
        }
    }
}
