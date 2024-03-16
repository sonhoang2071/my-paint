using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPaint.Entities
{
    internal class MyColorRightTriangle:MyRightTriangle
    {
        public Color brColor;
        public MyColorRightTriangle(Point spoint, Point ePoint, int borderWidth, Color borderColor, Color fillColor):base(spoint, ePoint, borderWidth, borderColor)
        {
            this.sPoint = spoint;
            this.ePoint = ePoint;
            this.borderColor = borderColor;
            this.borderWidth = borderWidth;
            brColor = fillColor;
        }
        public override void Draw(Graphics g)
        {
            Pen borderPen = new Pen(borderColor, borderWidth);
            Brush brush = new SolidBrush(brColor);
            Point bottomPoint = new Point(ePoint.X + (ePoint.Y - sPoint.Y),
                                          ePoint.Y + (sPoint.X - ePoint.X));
            Point[] triangle = { ePoint, sPoint, bottomPoint };
            g.DrawPolygon(borderPen, triangle);
            g.FillPolygon(brush, triangle);
        }
    }
}
