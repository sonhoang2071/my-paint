using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPaint.Entities
{
    internal class LineStrategy : ICalPointStrategy
    {
        public Point[] CalculatePoints(Point sPoint, int width, int height)
        {
            Point[] points = new Point[]
            {
                new Point(sPoint.X , sPoint.Y),
                new Point(sPoint.X + width, sPoint.Y + height)            
            };
            return points;
        }
    }
}
