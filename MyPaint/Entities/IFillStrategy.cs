using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPaint.Entities
{
    public interface IFillStrategy
    {
        void Fill(Graphics g, MyPolygon polygon, Color color);
    }
}
