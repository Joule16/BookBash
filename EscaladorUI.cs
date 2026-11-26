//   Equipo 2
//   NUÑEZ Martinez Marco Antonio
//   SUÑIGA Maciel Joule Alexander
//   VILLA Olivarez Ariel
// =============================
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace SistemaBiblioteca1
{
    public static class DpiUI
    {
        public const float DpiBase = 96f;

        public static float Factor(Control c)
        {
            if (c == null || c.IsDisposed) return 1f;
            int dpi = c.DeviceDpi;
            return dpi > 0 ? dpi / DpiBase : 1f;
        }

        public static int Px(Control c, float pixelesA100)
        {
            return (int)Math.Round(pixelesA100 * Factor(c));
        }

        [Conditional("DEBUG")]
        public static void Diagnostico(Form f, string etiqueta)
        {
            SizeF diseno = f.AutoScaleDimensions;
            SizeF actual = f.CurrentAutoScaleDimensions;
            float fx = diseno.Width > 0 ? actual.Width / diseno.Width : 0f;
            float fy = diseno.Height > 0 ? actual.Height / diseno.Height : 0f;

            Debug.WriteLine("[DPI] " + etiqueta + " (" + f.GetType().Name + ")"
                + " DeviceDpi=" + f.DeviceDpi
                + " AutoScaleMode=" + f.AutoScaleMode
                + " Diseno=" + diseno.Width + "x" + diseno.Height
                + " Actual=" + actual.Width + "x" + actual.Height
                + " FactorFuente=" + fx.ToString("0.00") + "x" + fy.ToString("0.00")
                + " Client=" + f.ClientSize.Width + "x" + f.ClientSize.Height);
        }
    }

    public class EscaladorUI
    {
        private class Elemento
        {
            public Control Control;
            public Rectangle Original;
            public bool EscalarTamano;
            public bool EscalarFuente;
            public Font FuenteOriginal;
            public Font FuenteCreada;

            public int AltoEncabezado;
            public int AltoFila;
            public int[] Anchos;
            public Font FuenteEncabezadoOriginal;
            public Font FuenteEncabezadoCreada;
        }

        private readonly Control _raiz;
        private readonly Size _referencia;
        private readonly int _dpiBase;
        private readonly float _escalaMin;
        private readonly float _escalaMax;
        private readonly List<Elemento> _elementos = new List<Elemento>();
        private float _escalaActual = 1f;
        private float _kActual = 1f;

        public float Escala
        {
            get { return _escalaActual; }
        }

        public event EventHandler EscalaCambio;

        public static EscaladorUI Aplicar(Control raiz, float escalaMin = 0.85f, float escalaMax = 2.5f)
        {
            return new EscaladorUI(raiz, escalaMin, escalaMax);
        }

        private EscaladorUI(Control raiz, float escalaMin, float escalaMax)
        {
            _raiz = raiz;
            _referencia = raiz.ClientSize;
            _dpiBase = raiz.DeviceDpi > 0 ? raiz.DeviceDpi : 96;
            _escalaMin = escalaMin;
            _escalaMax = escalaMax;

            Registrar(raiz.Controls);

            raiz.Resize += (s, e) => Reescalar(false);
            raiz.Disposed += (s, e) => LiberarFuentes();

            Form formulario = raiz as Form;
            if (formulario != null)
                formulario.DpiChanged += (s, e) => ReescalarTrasCambioDpi();
            else
                raiz.DpiChangedAfterParent += (s, e) => ReescalarTrasCambioDpi();

            Reescalar(false);
        }

        private static int R(float valor)
        {
            return (int)Math.Round(valor);
        }

        private void ReescalarTrasCambioDpi()
        {
            if (_raiz.IsDisposed || !_raiz.IsHandleCreated) return;

            _raiz.BeginInvoke(new Action(() =>
            {
                if (!_raiz.IsDisposed) Reescalar(true);
            }));
        }

        private void Registrar(Control.ControlCollection controles)
        {
            foreach (Control c in controles)
            {
                if (c is Form) continue;

                if (c is StatusStrip) continue;

                if (c is MenuPersona3) continue;

                var el = new Elemento { Control = c, Original = c.Bounds };

                bool contenedor = c is Panel || c is GroupBox || c is Menup;
                el.EscalarFuente = !contenedor;
                el.FuenteOriginal = c.Font;

                bool seAjustaSolo = c.AutoSize && (c is Label || c is CheckBox || c is RadioButton);
                el.EscalarTamano = c.Dock == DockStyle.None && !seAjustaSolo;

                if (c.Dock == DockStyle.None)
                {
                    c.Anchor = AnchorStyles.Top | AnchorStyles.Left;
                }

                DataGridView g = c as DataGridView;
                if (g != null)
                {
                    el.AltoEncabezado = g.ColumnHeadersHeight;
                    el.AltoFila = g.RowTemplate.Height;
                    el.Anchos = new int[g.Columns.Count];
                    for (int i = 0; i < g.Columns.Count; i++)
                    {
                        el.Anchos[i] = g.Columns[i].Width;
                    }
                    el.FuenteEncabezadoOriginal = g.ColumnHeadersDefaultCellStyle.Font ?? g.Font;
                }

                _elementos.Add(el);

                if (c.HasChildren)
                {
                    Registrar(c.Controls);
                }
            }
        }

        private void Reescalar(bool forzar)
        {
            Size actual = _raiz.ClientSize;
            if (_referencia.Width <= 0 || _referencia.Height <= 0) return;
            if (actual.Width <= 0 || actual.Height <= 0) return;

            int dpi = _raiz.DeviceDpi > 0 ? _raiz.DeviceDpi : _dpiBase;
            float k = dpi / (float)_dpiBase;

            float s = Math.Min(
                actual.Width / (_referencia.Width * k),
                actual.Height / (_referencia.Height * k));

            s = Math.Max(_escalaMin, Math.Min(_escalaMax, s));
            s = (float)(Math.Round(s * 20.0) / 20.0);

            if (!forzar && Math.Abs(s - _escalaActual) < 0.001f && Math.Abs(k - _kActual) < 0.001f)
                return;
            _escalaActual = s;
            _kActual = k;

            _raiz.SuspendLayout();

            foreach (Elemento el in _elementos)
            {
                AplicarEscala(el, s, k);
            }

            _raiz.ResumeLayout(true);

            if (EscalaCambio != null)
            {
                EscalaCambio(this, EventArgs.Empty);
            }
        }

        private void AplicarEscala(Elemento el, float s, float k)
        {
            Control c = el.Control;
            Rectangle o = el.Original;
            float f = s * k;

            switch (c.Dock)
            {
                case DockStyle.None:
                    if (el.EscalarTamano)
                    {
                        c.SetBounds(R(o.X * f), R(o.Y * f), R(o.Width * f), R(o.Height * f));
                    }
                    else
                    {
                        c.Location = new Point(R(o.X * f), R(o.Y * f));
                    }
                    break;

                case DockStyle.Top:
                case DockStyle.Bottom:
                    c.Height = R(o.Height * f);
                    break;

                case DockStyle.Left:
                case DockStyle.Right:
                    c.Width = R(o.Width * f);
                    break;
            }

            if (el.EscalarFuente && el.FuenteOriginal != null)
            {
                Font nueva = new Font(
                    el.FuenteOriginal.FontFamily,
                    el.FuenteOriginal.SizeInPoints * s,
                    el.FuenteOriginal.Style,
                    GraphicsUnit.Point);

                Font anterior = el.FuenteCreada;
                c.Font = nueva;
                el.FuenteCreada = nueva;

                if (anterior != null) anterior.Dispose();
            }

            DataGridView g = c as DataGridView;
            if (g != null)
            {
                EscalarGrid(el, g, s, f);
            }
        }

        private void EscalarGrid(Elemento el, DataGridView g, float s, float f)
        {
            g.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            g.ColumnHeadersHeight = Math.Max(20, R(el.AltoEncabezado * f));

            int alto = Math.Max(18, R(el.AltoFila * f));
            g.RowTemplate.Height = alto;
            foreach (DataGridViewRow fila in g.Rows)
            {
                fila.Height = alto;
            }

            for (int i = 0; i < g.Columns.Count && i < el.Anchos.Length; i++)
            {
                DataGridViewColumn col = g.Columns[i];
                if (col.AutoSizeMode == DataGridViewAutoSizeColumnMode.NotSet ||
                    col.AutoSizeMode == DataGridViewAutoSizeColumnMode.None)
                {
                    col.Width = Math.Max(20, R(el.Anchos[i] * f));
                }
            }

            if (el.FuenteEncabezadoOriginal != null)
            {
                Font nueva = new Font(
                    el.FuenteEncabezadoOriginal.FontFamily,
                    el.FuenteEncabezadoOriginal.SizeInPoints * s,
                    el.FuenteEncabezadoOriginal.Style,
                    GraphicsUnit.Point);

                Font anterior = el.FuenteEncabezadoCreada;
                g.ColumnHeadersDefaultCellStyle.Font = nueva;
                el.FuenteEncabezadoCreada = nueva;

                if (anterior != null) anterior.Dispose();
            }
        }

        private void LiberarFuentes()
        {
            foreach (Elemento el in _elementos)
            {
                if (el.FuenteCreada != null) el.FuenteCreada.Dispose();
                if (el.FuenteEncabezadoCreada != null) el.FuenteEncabezadoCreada.Dispose();
            }
        }
    }
}
