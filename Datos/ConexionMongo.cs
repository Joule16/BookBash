//   Equipo 2
//   NUÑEZ Martinez Marco Antonio
//   SUÑIGA Maciel Joule Alexander
//   VILLA Olivares Ariel
// ===============================
using MongoDB.Bson;
using MongoDB.Driver;
using SistemaBiblioteca1.Models;
using System;
using System.IO;
using System.Text.Json;

namespace SistemaBiblioteca1.Datos
{
    public static class ConexionMongo
    {
        private const string ARCHIVO_CONFIGURACION = "appsettings.json";
        private const string COLECCION_LIBROS = "Libros";

        private static IMongoDatabase? baseDatos;

        public static bool Habilitada { get; private set; }

        public static string Destino { get; private set; } = string.Empty;

        public static bool Inicializar(out string mensaje)
        {
            Habilitada = false;
            baseDatos = null;

            try
            {
                string cadena = "mongodb://localhost:27017";
                string nombreBD = "Intercambio_libros";
                LeerConfiguracion(ref cadena, ref nombreBD);

                Destino = cadena + " / " + nombreBD;

                MongoClientSettings configuracion = MongoClientSettings.FromConnectionString(cadena);
                configuracion.ServerSelectionTimeout = TimeSpan.FromSeconds(3);

                MongoClient cliente = new MongoClient(configuracion);
                IMongoDatabase bd = cliente.GetDatabase(nombreBD);

                bd.RunCommand<BsonDocument>(new BsonDocument("ping", 1));

                IMongoCollection<BsonDocument> libros = bd.GetCollection<BsonDocument>(COLECCION_LIBROS);
                CreateIndexModel<BsonDocument> indice = new CreateIndexModel<BsonDocument>(
                    Builders<BsonDocument>.IndexKeys.Ascending("IdLibro"),
                    new CreateIndexOptions { Unique = true, Name = "UQ_Libros_IdLibro" });
                libros.Indexes.CreateOne(indice);

                baseDatos = bd;
                Habilitada = true;
                mensaje = "Conexión establecida con MongoDB (" + Destino + ").";
                return true;
            }
            catch (Exception ex)
            {
                mensaje = "No se pudo conectar con MongoDB (" + Destino + "):\n" + ex.Message;
                return false;
            }
        }

        private static void LeerConfiguracion(ref string cadena, ref string nombreBD)
        {
            string ruta = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, ARCHIVO_CONFIGURACION);

            if (!File.Exists(ruta))
                return;

            using (JsonDocument documento = JsonDocument.Parse(File.ReadAllText(ruta)))
            {
                if (!documento.RootElement.TryGetProperty("MongoDB", out JsonElement config))
                    return;

                if (config.TryGetProperty("Cadena", out JsonElement c) && c.ValueKind == JsonValueKind.String)
                    cadena = c.GetString() ?? cadena;

                if (config.TryGetProperty("NombreBD", out JsonElement n) && n.ValueKind == JsonValueKind.String)
                    nombreBD = n.GetString() ?? nombreBD;
            }
        }

        private static IMongoCollection<BsonDocument> ObtenerColeccionLibros()
        {
            if (!Habilitada || baseDatos == null)
            {
                if (!Inicializar(out string mensaje))
                    throw new InvalidOperationException(mensaje);
            }

            return baseDatos!.GetCollection<BsonDocument>(COLECCION_LIBROS);
        }

        private static BsonDocument ConstruirDocumento(Libro libro)
        {
            return new BsonDocument
            {
                { "IdLibro", libro.Id },
                { "Titulo", libro.Titulo },
                { "Isbn", libro.Isbn },
                { "IdAutor", libro.IdAutor },
                { "IdCategoria", libro.IdCategoria },
                { "IdEditorial", libro.IdEditorial },
                { "AnioPublicacion", libro.AnioPublicacion },
                { "PuntoEntrega", libro.PuntoEntrega },
                { "IdPropietario", libro.IdPropietario.HasValue ? (BsonValue)libro.IdPropietario.Value : BsonNull.Value },
                { "RutaImagen", libro.RutaImagen },
                { "FechaRegistro", new BsonDateTime(libro.FechaRegistro) },
                { "EsActivo", libro.EsActivo }
            };
        }

        public static void InsertarLibro(Libro libro)
        {
            if (libro == null)
                throw new ArgumentNullException(nameof(libro));

            BsonDocument documento = ConstruirDocumento(libro);

            try
            {
                ObtenerColeccionLibros().InsertOne(documento);
            }
            catch (MongoWriteException ex) when (ex.WriteError.Category == ServerErrorCategory.DuplicateKey)
            {
                throw new InvalidOperationException("Ya existe un libro con el id " + libro.Id + " en MongoDB.", ex);
            }
            catch (MongoException ex)
            {
                throw new InvalidOperationException("No se pudo guardar el libro en MongoDB:\n" + ex.Message, ex);
            }
        }

        public static void ActualizarLibro(Libro libro)
        {
            if (libro == null)
                throw new ArgumentNullException(nameof(libro));

            try
            {
                IMongoCollection<BsonDocument> coleccion = ObtenerColeccionLibros();

                BsonDocument? existente = coleccion
                    .Find(Builders<BsonDocument>.Filter.Eq("IdLibro", libro.Id))
                    .Project(Builders<BsonDocument>.Projection.Include("_id"))
                    .FirstOrDefault();

                if (existente == null)
                {
                    coleccion.InsertOne(ConstruirDocumento(libro));
                    return;
                }

                BsonValue idDocumento = existente["_id"];

                BsonDocument nuevo = ConstruirDocumento(libro);
                nuevo.InsertAt(0, new BsonElement("_id", idDocumento));

                FilterDefinition<BsonDocument> filtro = Builders<BsonDocument>.Filter.Eq("_id", idDocumento);

                ReplaceOneResult resultado = coleccion.ReplaceOneAsync(filtro, nuevo).GetAwaiter().GetResult();

                if (resultado.MatchedCount == 0)
                    throw new InvalidOperationException("No se encontró el libro " + libro.Id + " en MongoDB.");
            }
            catch (MongoException ex)
            {
                throw new InvalidOperationException("No se pudo actualizar el libro en MongoDB:\n" + ex.Message, ex);
            }
        }

        public static void CambiarEstadoLibro(Libro libro)
        {
            if (libro == null)
                throw new ArgumentNullException(nameof(libro));

            try
            {
                IMongoCollection<BsonDocument> coleccion = ObtenerColeccionLibros();

                BsonDocument? existente = coleccion
                    .Find(Builders<BsonDocument>.Filter.Eq("IdLibro", libro.Id))
                    .Project(Builders<BsonDocument>.Projection.Include("_id"))
                    .FirstOrDefault();

                if (existente == null)
                {
                    coleccion.InsertOne(ConstruirDocumento(libro));
                    return;
                }

                FilterDefinition<BsonDocument> filtro = Builders<BsonDocument>.Filter.Eq("_id", existente["_id"]);
                UpdateDefinition<BsonDocument> cambio = Builders<BsonDocument>.Update.Set("EsActivo", libro.EsActivo);

                UpdateResult resultado = coleccion.UpdateOneAsync(filtro, cambio).GetAwaiter().GetResult();

                if (resultado.MatchedCount == 0)
                    throw new InvalidOperationException("No se encontró el libro " + libro.Id + " en MongoDB.");
            }
            catch (MongoException ex)
            {
                throw new InvalidOperationException("No se pudo cambiar el estado del libro en MongoDB:\n" + ex.Message, ex);
            }
        }

        public static void EliminarLibro(int idLibro)
        {
            try
            {
                IMongoCollection<BsonDocument> coleccion = ObtenerColeccionLibros();

                BsonDocument? existente = coleccion
                    .Find(Builders<BsonDocument>.Filter.Eq("IdLibro", idLibro))
                    .Project(Builders<BsonDocument>.Projection.Include("_id"))
                    .FirstOrDefault();

                if (existente == null)
                    return;

                FilterDefinition<BsonDocument> filtro = Builders<BsonDocument>.Filter.Eq("_id", existente["_id"]);
                coleccion.DeleteOneAsync(filtro).GetAwaiter().GetResult();
            }
            catch (MongoException ex)
            {
                throw new InvalidOperationException("No se pudo eliminar el libro en MongoDB:\n" + ex.Message, ex);
            }
        }
    }
}