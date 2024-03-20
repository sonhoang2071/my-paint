using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPaint.Entities
{
    internal class SquareStrategy : ICalPointStrategy
    {
        public Point[] CalculatePoints(Point sPoint, int width, int height)
        {
            int edge = Math.Max(width, height); 
            Point[] points = new Point[]
            {
                new Point(sPoint.X, sPoint.Y),
                new Point(sPoint.X + edge, sPoint.Y),
                new Point(sPoint.X + edge, sPoint.Y + edge),
                new Point(sPoint.X, sPoint.Y + edge),
            };
            return points;
        }
    }
}
