using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPaint.Entities
{
    internal class MyPatternDiamond:MyDiamond
    {
        private Color brColor;
        public MyPatternDiamond(Point center, Point topPoint, int borderWidth, Color borderColor, Color fillColor) : base(center, topPoint, borderWidth, borderColor)
        {
            this.center = center;
            this.topPoint = topPoint;
            base.borderWidth = borderWidth;
            base.borderColor = borderColor;
            brColor = fillColor;
        }
        public override void Draw(Graphics g)
        {
            Pen pen = new Pen(borderColor, borderWidth);
            HatchBrush brush = new HatchBrush(HatchStyle.SmallGrid, borderColor, brColor);
            Point[] points = new Point[4];
            points[0] = new Point(center.X, topPoint.Y); 
            points[1] = new Point(topPoint.X, center.Y); 
            points[2] = new Point(center.X, 2 * center.Y - topPoint.Y); 
            points[3] = new Point(2 * center.X - topPoint.X, center.Y); 
            g.DrawPolygon(pen, points);
            g.FillPolygon(brush, points);
        }
    }
}
