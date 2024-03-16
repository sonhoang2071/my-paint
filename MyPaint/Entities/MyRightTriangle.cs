using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace MyPaint.Entities
{
    internal class MyRightTriangle:Shape
    {
        public Point ePoint;
        public MyRightTriangle(Point spoint, Point ePoint, int borderWidth, Color borderColor)
        {
            this.sPoint = spoint;
            this.ePoint = ePoint;
            this.borderColor = borderColor;
            this.borderWidth = borderWidth;
        }
        public override void Draw(Graphics g)
        {
            Pen borderPen = new Pen(borderColor, borderWidth);
            Point bottomPoint = new Point(ePoint.X + (ePoint.Y - sPoint.Y),
                                         ePoint.Y + (sPoint.X - ePoint.X));

            Point[] triangle = {ePoint, sPoint, bottomPoint };


            g.DrawPolygon(borderPen, triangle);
        }
    }
}
