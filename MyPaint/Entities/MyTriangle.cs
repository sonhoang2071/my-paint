using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPaint.Entities
{
    internal class MyTriangle : Shape
    {
        public Point ePoint;
        public MyTriangle(Point spoint, Point ePoint, int borderWidth, Color borderColor)
        {
            this.sPoint = spoint;
            this.ePoint = ePoint;
            this.borderColor = borderColor;
            this.borderWidth = borderWidth;
        }
        public override void Draw(Graphics g)
        {
            Pen borderPen = new Pen(borderColor, borderWidth);
            Point[] triangle = { sPoint, ePoint, new Point(sPoint.X - (ePoint.X - sPoint.X), ePoint.Y) };
            g.DrawPolygon(borderPen, triangle);
        }
    }
}
