using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPaint.Entities
{
    public interface ICalPointStrategy
    {
        Point[] CalculatePoints(Point sPoint, int width, int height);
    }
}
