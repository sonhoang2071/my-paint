using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPaint.Entities
{
    internal class PatternFillStrategy : IFillStrategy
    {
        public void Fill(Graphics g, MyPolygon polygon, Color color)
        {
            HatchBrush brush = new HatchBrush(HatchStyle.SmallGrid,polygon.pen.Color, color);
            if (polygon.points != null && polygon.points.Length != 2)
            {
                g.FillPolygon(brush, polygon.points);
            }
            else if (polygon.points == null)
            {
                g.FillEllipse(brush, polygon.sPoint.X, polygon.sPoint.Y, polygon.width, polygon.height);
            }
        }
    }
}
