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
        //public MyCircle(Point sPoint, Point ePoint)
        //{
        //    int x = sPoint.X < ePoint.X ? sPoint.X : ePoint.X;
        //    int y = sPoint.Y < ePoint.Y ? sPoint.Y : ePoint.Y;
        //    this.sPoint = new Point(x, y);
        //    this.width = Math.Max(Math.Abs(sPoint.X - ePoint.X), Math.Abs(sPoint.Y - ePoint.Y));
        //    this.height = Math.Max(Math.Abs(sPoint.X - ePoint.X), Math.Abs(sPoint.Y - ePoint.Y));
        //}
        //public override void Draw(Graphics g)
        //{
        //    g.DrawEllipse(new Pen(Color.Black), sPoint.X, sPoint.Y, this.width, this.height);
        //}


        public double rad;
        public Point center;
        public MyCircle(Point sPoint, Point ePoint, int boderWidth, Color borderColor)
        {
            this.center = CalMidPoint(sPoint, ePoint);
            this.rad = CalRadius(sPoint, ePoint);
            base.borderWidth = boderWidth;
            base.borderColor = borderColor;
        }

        public double CalRadius(Point sPoint, Point ePoint)
        {
            double distance = Math.Sqrt(Math.Pow(ePoint.X - sPoint.X, 2) + Math.Pow(ePoint.Y - sPoint.Y, 2));
            return distance;
        }

        public Point CalMidPoint(Point sPoint, Point ePoint)
        {
            return new Point((sPoint.X + ePoint.X) / 2, (sPoint.Y + ePoint.Y) / 2);
        }

        public override void Draw(Graphics g)
        {
            Pen pen = new Pen(borderColor, borderWidth);
            int centerX = (int)(center.X - rad);
            int centerY = (int)(center.Y - rad);
            Rectangle rect = new Rectangle(centerX, centerY, (int)(1 * rad), (int)(1 * rad));
            g.DrawEllipse(pen, rect);
        }
    }
}
