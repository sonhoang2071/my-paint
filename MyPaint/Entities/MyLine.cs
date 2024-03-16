using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace MyPaint.Entities
{
    internal class MyLine:Shape
    {
        public Point ePoint;
        public MyLine(Point sPoint, Point ePoint, int borderWidth, Color borderColor)
        {
            this.sPoint = sPoint;
            this.ePoint = ePoint;
            base.borderWidth = borderWidth;
            base.borderColor = borderColor;
        }

        public override void Draw(Graphics g)
        {
            Pen pen = new Pen(borderColor, borderWidth);
            g.DrawLine(pen, sPoint, ePoint);
        }
    }
}
