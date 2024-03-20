using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPaint.Entities
{
    internal class RightTriangleStrategy : ICalPointStrategy
    {
        public Point[] CalculatePoints(Point sPoint, int width, int height)
        {
            Point[] points = new Point[]
            {
                new Point(sPoint.X , sPoint.Y), // Đỉnh trên cùng
                new Point(sPoint.X + width, sPoint.Y + height), // Đỉnh bên phải
                new Point(sPoint.X, sPoint.Y + height) // Đỉnh bên trái
            };
            return points;
        }
    }
}
