using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPaint.Entities
{
    internal class MyPoint
    {
        public int x { get; set; }
        public int y { get; set; }
        public int thickness { get; set; }

        public MyPoint(int x, int y, int thickness)
        {
            this.x = x;
            this.y = y;
            this.thickness = thickness;
        }
    }
}
