using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPaint.Entities
{
    internal class MyRectangle : Shape
    {
        public MyRectangle(Point sPoint, Point ePoint)
        {
            int x = sPoint.X < ePoint.X ? sPoint.X : ePoint.X;
            int y = sPoint.Y < ePoint.Y ? sPoint.Y : ePoint.Y;
            this.sPoint = new Point(x, y);
            this.width = Math.Abs(sPoint.X - ePoint.X);
            this.height = Math.Abs(sPoint.Y - ePoint.Y);

        }
        public override void Draw(Graphics g)
        {
            g.DrawRectangle(new Pen(Color.Black), sPoint.X, sPoint.Y, this.width, this.height);
        }
    }
}
