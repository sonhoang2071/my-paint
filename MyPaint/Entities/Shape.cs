using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPaint.Entities
{
    public abstract class Shape : IDraw
    {
        public Point sPoint { get; set; }
        public Point ePoint { get; set; }
        public int width { get; set; }
        public int height { get; set; }
        public Pen pen { get; set; }
        public Shape() { }

        //Templates Method
        public Point CalculateSPoint(Point sPoint, Point ePoint)
        {
            int x = sPoint.X < ePoint.X ? sPoint.X : ePoint.X;
            int y = sPoint.Y < ePoint.Y ? sPoint.Y : ePoint.Y;
            return new Point(x, y);
        }
        public Point CalculateEPoint(Point sPoint, Point ePoint)
        {
            int x = sPoint.X > ePoint.X ? sPoint.X : ePoint.X;
            int y = sPoint.Y > ePoint.Y ? sPoint.Y : ePoint.Y;
            return new Point(x, y);
        }
        public int CalculateHeight(Point sPoint, Point ePoint)
        {
            return Math.Abs(this.sPoint.Y - this.ePoint.Y);
        }

        public int CalculateWidth(Point sPoint, Point ePoint)
        {
            return Math.Abs(this.sPoint.X - this.ePoint.X);
        }

        public abstract void Draw(Graphics g);
    }
}
