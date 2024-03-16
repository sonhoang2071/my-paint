using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPaint.Entities
{
    internal class MyDiamond:Shape
    {
        protected Point center;
        protected Point topPoint;

        public MyDiamond(Point center, Point topPoint, int borderWidth, Color borderColor)
        {
            this.center = center;
            this.topPoint = topPoint;
            base.borderWidth = borderWidth;
            base.borderColor = borderColor;
        }

        public override void Draw(Graphics g)
        {
            Pen pen = new Pen(borderColor, borderWidth);

            // Tính toán các điểm của hình diamond
            Point[] points = new Point[4];
            points[0] = new Point(center.X, topPoint.Y); // Đỉnh trên cùng
            points[1] = new Point(topPoint.X, center.Y); // Đỉnh bên phải
            points[2] = new Point(center.X, 2 * center.Y - topPoint.Y); // Đỉnh dưới cùng
            points[3] = new Point(2 * center.X - topPoint.X, center.Y); // Đỉnh bên trái

            g.DrawPolygon(pen, points);

        }
    }
}
