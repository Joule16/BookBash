using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace SistemaBiblioteca1
{
    public static class GestorImagenes
    {
        public const string NombreCarpeta = "ImagenesDatos";

        public const string FiltroImagenes =
            "Archivos de imagen (*.jpg;*.jpeg;*.png;*.bmp)|*.jpg;*.jpeg;*.png;*.bmp";

        public static string ObtenerCarpetaDestino()
        {
            return Path.Combine(AppDomain.CurrentDomain.BaseDirectory, NombreCarpeta);
        }

        public static string ObtenerRutaCompleta(string rutaRelativa)
        {
            return Path.Combine(AppDomain.CurrentDomain.BaseDirectory, rutaRelativa);
        }

        public static bool AsegurarCarpeta()
        {
            try
            {
                string carpeta = ObtenerCarpetaDestino();
                if (!Directory.Exists(carpeta))
                    Directory.CreateDirectory(carpeta);
                return true;
            }
            catch (UnauthorizedAccessException)
            {
                MessageBox.Show("No hay permisos para crear la carpeta de imágenes en el disco.",
                    "Permisos insuficientes", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            catch (IOException ex)
            {
                MessageBox.Show("No se pudo crear la carpeta de imágenes:\n" + ex.Message,
                    "Error de entrada/salida", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public static string? SeleccionarImagen()
        {
            using (OpenFileDialog dialogo = new OpenFileDialog())
            {
                dialogo.Title = "Seleccionar fotografía";
                dialogo.Filter = FiltroImagenes;
                dialogo.Multiselect = false;
                dialogo.CheckFileExists = true;

                if (dialogo.ShowDialog() == DialogResult.OK)
                    return dialogo.FileName;
            }
            return null;
        }

        public static bool MostrarVistaPrevia(PictureBox pbx, string rutaCompleta)
        {
            try
            {
                Image nueva;
                using (Image original = Image.FromFile(rutaCompleta))
                {
                    nueva = new Bitmap(original);
                }

                Image? anterior = pbx.Image;
                pbx.SizeMode = PictureBoxSizeMode.StretchImage;
                pbx.Image = nueva;
                if (anterior != null)
                    anterior.Dispose();
                return true;
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("No se encontró el archivo de imagen seleccionado.",
                    "Archivo no encontrado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (UnauthorizedAccessException)
            {
                MessageBox.Show("No hay permisos para leer el archivo seleccionado.",
                    "Permisos insuficientes", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (IOException ex)
            {
                MessageBox.Show("El archivo está bloqueado o no se puede leer:\n" + ex.Message,
                    "Error de entrada/salida", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex) when (ex is OutOfMemoryException || ex is ArgumentException ||
                                       ex is System.Runtime.InteropServices.ExternalException)
            {
                MessageBox.Show("El archivo seleccionado no es una imagen válida.",
                    "Imagen inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            return false;
        }

        public static void CargarGuardada(PictureBox pbx, string rutaRelativa)
        {
            Image? anterior = pbx.Image;
            pbx.Image = null;
            if (anterior != null)
                anterior.Dispose();

            if (string.IsNullOrWhiteSpace(rutaRelativa))
                return;

            string rutaCompleta = ObtenerRutaCompleta(rutaRelativa);
            if (File.Exists(rutaCompleta))
                MostrarVistaPrevia(pbx, rutaCompleta);
        }

        public static string? GuardarImagen(string rutaOrigen, string? nombreBase = null, string rutaAnterior = "")
        {
            if (string.IsNullOrWhiteSpace(rutaOrigen))
                return null;

            try
            {
                if (!AsegurarCarpeta())
                    return null;

                string extension = Path.GetExtension(rutaOrigen).ToLowerInvariant();
                string nombre = string.IsNullOrWhiteSpace(nombreBase) ? Guid.NewGuid().ToString() : nombreBase;
                string nombreFinal = nombre + extension;

                string rutaRelativa = Path.Combine(NombreCarpeta, nombreFinal);
                string rutaDestino = ObtenerRutaCompleta(rutaRelativa);

                if (!string.Equals(Path.GetFullPath(rutaOrigen), Path.GetFullPath(rutaDestino),
                        StringComparison.OrdinalIgnoreCase))
                {
                    File.Copy(rutaOrigen, rutaDestino, true);
                }

                if (!string.IsNullOrWhiteSpace(rutaAnterior) &&
                    !string.Equals(rutaAnterior, rutaRelativa, StringComparison.OrdinalIgnoreCase))
                {
                    EliminarImagen(rutaAnterior);
                }

                return rutaRelativa;
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("La imagen seleccionada ya no existe en su ubicación original.",
                    "Archivo no encontrado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (UnauthorizedAccessException)
            {
                MessageBox.Show("No hay permisos para guardar la imagen en el disco.",
                    "Permisos insuficientes", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (IOException ex)
            {
                MessageBox.Show("El archivo está bloqueado por el sistema o no se pudo copiar:\n" + ex.Message,
                    "Error de entrada/salida", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return null;
        }
        public static void EliminarImagen(string rutaRelativa)
        {
            if (string.IsNullOrWhiteSpace(rutaRelativa))
                return;

            try
            {
                string rutaCompleta = ObtenerRutaCompleta(rutaRelativa);
                if (!File.Exists(rutaCompleta))
                    return;

                if (ArchivoEnUso(rutaCompleta))
                {
                    MessageBox.Show("La imagen está siendo utilizada por otro proceso y no se pudo borrar:\n" + rutaRelativa,
                        "Imagen en uso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                File.Delete(rutaCompleta);
            }
            catch (UnauthorizedAccessException)
            {
                MessageBox.Show("No hay permisos para borrar el archivo de imagen anterior.",
                    "Imagen", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (IOException ex)
            {
                MessageBox.Show("No se pudo borrar el archivo de imagen anterior (puede estar bloqueado):\n" + ex.Message,
                    "Imagen", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private static bool ArchivoEnUso(string rutaCompleta)
        {
            try
            {
                using (FileStream flujo = new FileStream(rutaCompleta, FileMode.Open, FileAccess.ReadWrite, FileShare.None))
                {
                    return false;
                }
            }
            catch (IOException)
            {
                return true;
            }
        }
    }
}