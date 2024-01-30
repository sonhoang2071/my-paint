using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPaint.Entities
{
    internal class MyCircle : Shape
    {
        public MyCircle(Point sPoint, Point ePoint)
        {
            int x = sPoint.X < ePoint.X ? sPoint.X : ePoint.X;
            int y = sPoint.Y < ePoint.Y ? sPoint.Y : ePoint.Y;
            this.sPoint = new Point(x, y);
            this.width = Math.Max(Math.Abs(sPoint.X - ePoint.X), Math.Abs(sPoint.Y - ePoint.Y));
            this.height = Math.Max(Math.Abs(sPoint.X - ePoint.X), Math.Abs(sPoint.Y - ePoint.Y));
        }
        public override void Draw(Graphics g)
        {
            g.DrawEllipse(new Pen(Color.Black), sPoint.X, sPoint.Y, this.width, this.height);
        }

    }
}
