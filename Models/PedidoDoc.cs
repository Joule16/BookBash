//   Equipo 2
//   NUÑEZ Martinez Marco Antonio
//   SUÑIGA Maciel Joule Alexander
//   VILLA Olivarez Ariel
// =============================
//   Actividad 4.8 - Persistencia transaccional de pedidos
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;

namespace SistemaBiblioteca1.Models
{
    public class DetallePedidoDoc
    {
        public int IdLibro { get; set; }

        public string Titulo { get; set; } = string.Empty;

        public string Condicion { get; set; } = string.Empty;

        public int Cantidad { get; set; }

        [BsonRepresentation(BsonType.Decimal128)]
        public decimal PrecioUnitario { get; set; }

        [BsonRepresentation(BsonType.Decimal128)]
        public decimal Subtotal { get; set; }
    }

    public class PedidoDoc
    {
        [BsonId]
        public ObjectId Id { get; set; }

        public int IdPedido { get; set; }

        [BsonDateTimeOptions(Kind = DateTimeKind.Local)]
        public DateTime Fecha { get; set; }

        public int? IdUsuario { get; set; }

        public string Cliente { get; set; } = string.Empty;

        [BsonRepresentation(BsonType.Decimal128)]
        public decimal Total { get; set; }

        public List<DetallePedidoDoc> Detalles { get; set; } = new List<DetallePedidoDoc>();
    }
}
