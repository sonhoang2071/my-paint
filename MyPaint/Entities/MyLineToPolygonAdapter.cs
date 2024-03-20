using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPaint.Entities
{
    internal class MyLineToPolygonAdapter : MyPolygon
    {
        private MyLine line;
        public MyLineToPolygonAdapter(Point sPoint, Point ePoint, int borderWidth, Color borderColor) : base(sPoint, ePoint, borderWidth, borderColor)
        {
            line = new MyLine(sPoint, ePoint, borderWidth, borderColor);
            this.points = new Point[] { sPoint, ePoint };
        }
        public override void Draw(Graphics g)
        {
            line.Draw(g);
        }
    }
}
