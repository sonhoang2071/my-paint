using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPaint.Entities
{
    internal class PentagonStrategy : ICalPointStrategy
    {
        public Point[] CalculatePoints(Point sPoint, int width, int height)
        {
            Point[] points = new Point[]
            {
                new Point(sPoint.X + width / 2, sPoint.Y), // Đỉnh trên
                new Point(sPoint.X + width, sPoint.Y + (int)(height * 0.3)), // Đỉnh phải trên
                new Point(sPoint.X + (int)(width * 0.8), sPoint.Y + height), // Đỉnh phải dưới
                new Point(sPoint.X + (int)(width * 0.2), sPoint.Y + height), // Đỉnh trái dưới
                new Point(sPoint.X, sPoint.Y + (int)(height * 0.3)) // Đỉnh trái trên
            };
            return points;
        }
    }
}
