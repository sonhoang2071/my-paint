using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPaint.Entities
{
    internal class LeftArrowStrategy : ICalPointStrategy
    {
        public Point[] CalculatePoints(Point sPoint, int width, int height)
        {
            Point[] points = new Point[]
            {
                new Point(sPoint.X + width, sPoint.Y + height / 4),
                new Point(sPoint.X + width / 2, sPoint.Y + height / 4),
                new Point(sPoint.X + width / 2, sPoint.Y),
                new Point(sPoint.X, sPoint.Y + height / 2),
                new Point(sPoint.X + width / 2, sPoint.Y + height),
                new Point(sPoint.X + width / 2, sPoint.Y + (height * 3) / 4),
                new Point(sPoint.X + width, sPoint.Y + (height * 3) / 4)
            };
            return points;
        }
    }
}
