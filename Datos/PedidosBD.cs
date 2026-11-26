//   Equipo 2
//   NUÑEZ Martinez Marco Antonio
//   SUÑIGA Maciel Joule Alexander
//   VILLA Olivarez Ariel
// =============================
//   Actividad 4.8 - Persistencia transaccional de pedidos
using MySqlConnector;
using SistemaBiblioteca1.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SistemaBiblioteca1.Datos
{
    public static class PedidosBD
    {
        public static int Guardar(IReadOnlyList<DetallePedido> carrito, int? idUsuario, string cliente)
        {
            if (!ConexionBD.Habilitada)
                throw new InvalidOperationException("Sin conexión con MariaDB: no se puede guardar el pedido.");

            if (carrito == null || carrito.Count == 0)
                throw new InvalidOperationException("El carrito está vacío.");

            cliente = (cliente ?? string.Empty).Trim();
            if (cliente.Length == 0)
                cliente = "Cliente";
            if (cliente.Length > 121)
                cliente = cliente.Substring(0, 121);

            DateTime ahora = DateTime.Now;
            DateTime fecha = new DateTime(ahora.Ticks - ahora.Ticks % TimeSpan.TicksPerSecond, ahora.Kind);

            decimal total = carrito.Sum(d => d.CalcularSubtotal());

            int idPedido = 0;
            bool espejoInsertado = false;

            try
            {
                using (MySqlConnection conexion = ConexionBD.CrearConexion())
                {
                    conexion.Open();

                    using (MySqlTransaction transaccion = conexion.BeginTransaction())
                    {
                        try
                        {
                            ConexionBD.EjecutarComando(conexion, transaccion,
                                "INSERT INTO Pedidos (Fecha, IdUsuario, Cliente, Total) VALUES (@fecha, @usuario, @cliente, @total)",
                                ConexionBD.P("@fecha", fecha),
                                ConexionBD.P("@usuario", idUsuario),
                                ConexionBD.P("@cliente", cliente),
                                ConexionBD.P("@total", total));

                            using (MySqlCommand comandoId = new MySqlCommand("SELECT LAST_INSERT_ID();", conexion, transaccion))
                            {
                                idPedido = Convert.ToInt32(comandoId.ExecuteScalar());
                            }

                            PedidoDoc documento = new PedidoDoc
                            {
                                IdPedido = idPedido,
                                Fecha = fecha,
                                IdUsuario = idUsuario,
                                Cliente = cliente,
                                Total = total
                            };

                            foreach (DetallePedido d in carrito)
                            {
                                List<int> ejemplares = BloquearEjemplares(conexion, transaccion, d);

                                ConexionBD.EjecutarComando(conexion, transaccion,
                                    "INSERT INTO Detalles_Pedidos (IdPedido, IdLibro, Condicion, Cantidad, PrecioUnitario) " +
                                    "VALUES (@pedido, @libro, @condicion, @cantidad, @precio)",
                                    ConexionBD.P("@pedido", idPedido),
                                    ConexionBD.P("@libro", d.IdLibro),
                                    ConexionBD.P("@condicion", d.Condicion),
                                    ConexionBD.P("@cantidad", d.Cantidad),
                                    ConexionBD.P("@precio", d.PrecioUnitario));

                                DescontarStock(conexion, transaccion, ejemplares, d);

                                documento.Detalles.Add(new DetallePedidoDoc
                                {
                                    IdLibro = d.IdLibro,
                                    Titulo = d.Titulo,
                                    Condicion = d.Condicion,
                                    Cantidad = d.Cantidad,
                                    PrecioUnitario = d.PrecioUnitario,
                                    Subtotal = d.CalcularSubtotal()
                                });
                            }

                            ConexionMongo.InsertarPedido(documento);
                            espejoInsertado = true;

                            transaccion.Commit();
                        }
                        catch
                        {
                            try { transaccion.Rollback(); } catch { }

                            if (espejoInsertado)
                            {
                                try { ConexionMongo.EliminarPedido(idPedido); } catch { }
                            }

                            throw;
                        }
                    }
                }
            }
            catch (MySqlException ex)
            {
                throw new InvalidOperationException(ConexionBD.TraducirError(ex), ex);
            }

            try
            {
                RepositorioBD.RecargarEjemplares();
            }
            catch (InvalidOperationException)
            {
            }

            return idPedido;
        }

        private static List<int> BloquearEjemplares(MySqlConnection conexion, MySqlTransaction transaccion, DetallePedido d)
        {
            List<int> ids = new List<int>();

            using (MySqlCommand comando = new MySqlCommand(
                "SELECT e.IdEjemplar FROM Ejemplar e INNER JOIN Libro l ON l.IdLibro = e.IdLibro " +
                "WHERE e.IdLibro = @libro AND (@condicion = '' OR e.Condicion = @condicion) " +
                "AND l.EsActivo = 1 AND e.EsActivo = 1 AND e.Disponible = 1 " +
                "ORDER BY e.IdEjemplar LIMIT @cantidad FOR UPDATE", conexion, transaccion))
            {
                comando.Parameters.Add(ConexionBD.P("@libro", d.IdLibro));
                comando.Parameters.Add(ConexionBD.P("@condicion", d.Condicion));
                comando.Parameters.Add(ConexionBD.P("@cantidad", d.Cantidad));

                using (MySqlDataReader lector = comando.ExecuteReader())
                {
                    while (lector.Read())
                        ids.Add(Convert.ToInt32(lector.GetValue(0)));
                }
            }

            if (ids.Count < d.Cantidad)
            {
                throw new InvalidOperationException(
                    "Ya no hay stock suficiente de «" + d.Descripcion + "»: quedan " + ids.Count +
                    " y el pedido pide " + d.Cantidad + ". No se guardó ningún dato del pedido.");
            }

            return ids;
        }

        private static void DescontarStock(MySqlConnection conexion, MySqlTransaction transaccion,
                                           List<int> ejemplares, DetallePedido d)
        {
            int afectadas = ConexionBD.EjecutarComando(conexion, transaccion,
                "UPDATE Ejemplar SET EsActivo = 0 WHERE IdEjemplar IN (" + string.Join(",", ejemplares) + ")");

            if (afectadas != ejemplares.Count)
                throw new InvalidOperationException("No se pudo descontar el stock de «" + d.Descripcion + "».");
        }

        public static List<PedidoDoc> ListarEncabezados()
        {
            return ConexionBD.Leer(
                "SELECT IdPedido, Fecha, IdUsuario, Cliente, Total FROM Pedidos ORDER BY Fecha, IdPedido",
                r => new PedidoDoc
                {
                    IdPedido = ConexionBD.Entero(r, 0),
                    Fecha = ConexionBD.Fecha(r, 1),
                    IdUsuario = ConexionBD.EnteroNulo(r, 2),
                    Cliente = ConexionBD.Texto(r, 3),
                    Total = Convert.ToDecimal(r.GetValue(4))
                });
        }

        public static List<DetallePedidoDoc> ListarDetalles(int idPedido)
        {
            return ConexionBD.Leer(
                "SELECT d.IdLibro, l.Titulo, d.Condicion, d.Cantidad, d.PrecioUnitario, d.Cantidad * d.PrecioUnitario " +
                "FROM Detalles_Pedidos d INNER JOIN Libro l ON l.IdLibro = d.IdLibro " +
                "WHERE d.IdPedido = @id ORDER BY d.IdDetalle",
                r => new DetallePedidoDoc
                {
                    IdLibro = ConexionBD.Entero(r, 0),
                    Titulo = ConexionBD.Texto(r, 1),
                    Condicion = ConexionBD.Texto(r, 2),
                    Cantidad = ConexionBD.Entero(r, 3),
                    PrecioUnitario = Convert.ToDecimal(r.GetValue(4)),
                    Subtotal = Convert.ToDecimal(r.GetValue(5))
                },
                ConexionBD.P("@id", idPedido));
        }
    }
}
