using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPaint.Entities
{
    internal class MyRightArround:Shape
    {
        public MyRightArround(Point sPoint, Point ePoint, int borderWidth, Color borderColor)
        {
            this.sPoint = sPoint;
            this.width = ePoint.X;
            this.height = ePoint.Y;
            this.borderWidth = borderWidth;
            this.borderColor = borderColor;
        }

        public override void Draw(Graphics g)
        {
            Pen pen = new Pen(borderColor, borderWidth);
            // Tính toán các điểm của hình mũi tên
            Point[] points = new Point[7];
            points[0] = new Point(sPoint.X, sPoint.Y + height / 2);
            points[1] = new Point(sPoint.X + width / 2, sPoint.Y);
            points[2] = new Point(sPoint.X + width / 2, sPoint.Y + height / 3);
            points[3] = new Point(sPoint.X + width, sPoint.Y + height / 3);
            points[4] = new Point(sPoint.X + width, sPoint.Y + 2 * height / 3);
            points[5] = new Point(sPoint.X + width / 2, sPoint.Y + 2 * height / 3);
            points[6] = new Point(sPoint.X + width / 2, sPoint.Y + height);
            g.DrawPolygon(pen, points);
        }
    }
}
