using System.Collections.Generic;
using System.Drawing.Printing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using System.Drawing;
using System.Linq;
using System.Text;
using System;

namespace Cliente
{
    public class areaCelda
    {
        private int inicioColumna = 0;
        private int finColumna = 0;
        private int inicioFila = 0;
        private int finFila = 0;

        public areaCelda(int ini_inicioColumna, int ini_inicioFila, int ini_finColumna, int ini_finFila)
        {
            inicioColumna = ini_inicioColumna;
            inicioFila = ini_inicioFila;
            finColumna = ini_finColumna;
            finFila = ini_finFila;
        }

        public int InicioColumna
        {
            get
            {
                return inicioColumna;
            }
        }

        public int InicioFila
        {
            get
            {
                return inicioFila;
            }
        }

        public int FinColumna
        {
            get
            {
                return finColumna;
            }
        }

        public int FinFila
        {
            get
            {
                return finFila;
            }
        }
    }

    public class ImprimirPrueba : PrintDocument
    {
        protected DataGridView cuadriculaAdjunta = null;
        private areaCelda areaSeleccionada = null;
        private int indiceFila = 0;
        private int inidiceColumna = 0;
        private int inidiceColumna_Previa = 0;
        private Font fuente = null;
        private bool primeraPagina = false;
        private bool impresionEncabezado = false;
        private bool dibujarCelda = false;

        public ImprimirPrueba(DataGridView finColumnas, Font tipoLetra, bool tipoEncabezado)
        {
            cuadriculaAdjunta = finColumnas;
            fuente = tipoLetra;
            impresionEncabezado = tipoEncabezado;
            areaSeleccionada = new areaCelda(3, 0, finColumnas.ColumnCount - 2, finColumnas.RowCount - 1);
        }

        protected override void OnBeginPrint(PrintEventArgs e)
        {
            indiceFila = areaSeleccionada.InicioFila;
            inidiceColumna = areaSeleccionada.InicioColumna;
            inidiceColumna_Previa = areaSeleccionada.InicioColumna;
            primeraPagina = true;
        }

        protected virtual void onPrepareDrawCell(Graphics g, DataGridViewCell cell, string s, RectangleF layoutRect, Font font)
        {
            StringFormat format = new StringFormat();
            SolidBrush brush = null;
            bool disposeBrush = false;
            if (cell.Style.ForeColor.ToArgb() == Color.FromArgb(0, 0, 0, 0).ToArgb())
            {
                brush = (SolidBrush)Brushes.Black;
            }
            else
            {
                if (cell.Style.ForeColor.IsNamedColor)
                {
                }
                else
                {
                    brush = new SolidBrush(cell.Style.ForeColor);
                    disposeBrush = true;
                }
            }
            SolidBrush brushBack = null;
            bool disposeBrushBack = false;
            if (cell.Style.BackColor.ToArgb() == Color.FromArgb(0, 0, 0, 0).ToArgb())
            {
                brushBack = (SolidBrush)Brushes.White;
            }
            else
            {
                if (cell.Style.BackColor.IsNamedColor)
                {
                }
                else
                {
                    brushBack = new SolidBrush(cell.Style.BackColor);
                    disposeBrushBack = true;
                }
            }
            Font f = (cell.Style.Font != null) ? cell.Style.Font : font;
            DataGridViewAdvancedBorderStyle borderStyle = new DataGridViewAdvancedBorderStyle();
            if (dibujarCelda)
            {
                borderStyle.All = DataGridViewAdvancedCellBorderStyle.Single;
            }
            onDrawCell(g, s, layoutRect, format, f, brush, brushBack, borderStyle);
            if (disposeBrush)
            {
                brush.Dispose();
            }
            if (disposeBrushBack)
            {
                brushBack.Dispose();
            }
        }

        protected virtual void onDrawCell(Graphics g, string s, RectangleF layoutRect, StringFormat format, Font font, Brush brush, Brush brushBack, DataGridViewAdvancedBorderStyle borderStyle)
        {
            g.FillRectangle(brushBack, layoutRect);
            g.DrawString(s, font, brush, layoutRect, format);
            dibujarRecuadro(g, layoutRect, borderStyle);
        }

        protected virtual float onMeasureColumnHeaderHeight(Graphics g, Font font)
        {
            float maxH = 0;

            for (int i = areaSeleccionada.InicioColumna; i <= areaSeleccionada.FinColumna; i++)
            {
                string s = cuadriculaAdjunta.Columns[i].HeaderText;
                float w = cuadriculaAdjunta.Columns[i].Width;
                SizeF sizeF = g.MeasureString(s, font);
                if (sizeF.Height > maxH)
                {
                    maxH = sizeF.Height;
                }
            }
            return maxH;
        }

        protected virtual void onPrepareColumnHeader(Graphics g, float x, float y, int colStart, int colEnd, Font font)
        {
            StringFormat f = new StringFormat();
            f.Alignment = StringAlignment.Center;
            f.LineAlignment = StringAlignment.Center;
            float maxY = 0;

            for (int i = colStart; i <= colEnd; i++)
            {
                string s = cuadriculaAdjunta.Columns[i].HeaderText;
                float w = cuadriculaAdjunta.Columns[i].Width;
                SizeF sizeF = g.MeasureString(s, font);
                RectangleF layoutRect = new RectangleF(x, y, w, sizeF.Height);
                DataGridViewAdvancedBorderStyle borderStyle = new DataGridViewAdvancedBorderStyle();
                if (dibujarCelda)
                {
                    borderStyle.All = DataGridViewAdvancedCellBorderStyle.Single;
                }
                escribirEncabezado(g, s, layoutRect, f, font, borderStyle);
                if (sizeF.Height > maxY)
                {
                    maxY = sizeF.Height;
                }
                x += w;
            }
        }

        protected virtual void escribirEncabezado(Graphics g, string s, RectangleF rectangulo, StringFormat formato, Font font, DataGridViewAdvancedBorderStyle estilo_de_Borde)
        {
            g.DrawString(s, font, Brushes.Black, rectangulo, formato);
            dibujarRecuadro(g, rectangulo, estilo_de_Borde);
        }

        private void dibujarRecuadro(Graphics g, RectangleF layoutRect, DataGridViewAdvancedBorderStyle borderStyle)
        {
            g.DrawRectangle(Pens.Black, layoutRect.Left, layoutRect.Top, layoutRect.Width, layoutRect.Height);
        }

        protected override void OnPrintPage(PrintPageEventArgs e)
        {
            int maximodeColumnas = 0;
            Matrix myMatrixInv = new Matrix();
            PointF scaleMarginRB = Matrix_Presentacion.Transform(myMatrixInv, e.MarginBounds.Right, e.MarginBounds.Bottom);
            PointF scaleMarginLT = Matrix_Presentacion.Transform(myMatrixInv, e.MarginBounds.Left, e.MarginBounds.Top);
            float y = scaleMarginLT.Y;
            float x = scaleMarginLT.X;
            SizeF sizeF = SizeF.Empty;
            SizeF cellSize = SizeF.Empty;
            float maxX = 0;
            y += onMeasureColumnHeaderHeight(e.Graphics, fuente);
            while (indiceFila <= areaSeleccionada.FinFila)
            {
                while (inidiceColumna <= areaSeleccionada.FinColumna)
                {
                    DataGridViewCell cell = cuadriculaAdjunta[inidiceColumna, indiceFila];
                    string s = cell.FormattedValue.ToString();
                    cellSize = cell.Size;
                    RectangleF layoutRect = new RectangleF(new PointF(x, y), cellSize);
                    onPrepareDrawCell(e.Graphics, cell, s, layoutRect, fuente);
                    x += cellSize.Width;
                    inidiceColumna++;
                }
                maxX = x;
                y += cellSize.Height;
                x = scaleMarginLT.X;
                inidiceColumna = inidiceColumna_Previa;
                indiceFila++;
            }
            if (primeraPagina)
            {
                int maxc = (maximodeColumnas == 0) ? areaSeleccionada.FinColumna : maximodeColumnas - 1;
                onPrepareColumnHeader(e.Graphics, scaleMarginLT.X, scaleMarginLT.Y, inidiceColumna_Previa, maxc, fuente);
            }
        }
    }
}