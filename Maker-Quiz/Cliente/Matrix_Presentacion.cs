using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Drawing;
using System.Linq;
using System.Text;
using System;

namespace Cliente
{
    public class Matrix_Presentacion
    {
        public static PointF Transform(Matrix matrix, float x, float y)
        {
            PointF[] pts = new PointF[] { new PointF(x, y) };
            matrix.TransformPoints(pts);
            return pts[0];
        }
    }
}