using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace MyPaint.Entities
{
    internal class MyLine : MyRectangle
    {
        public MyLine(Point sPoint, Point ePoint, int borderWidth, Color borderColor) : base(sPoint, ePoint, borderWidth, borderColor)
        {
            this.sPoint = sPoint;
            this.ePoint = ePoint;
        }
        public override void Draw(Graphics g)
        {
            g.DrawLine(this.pen , this.sPoint, this.ePoint);
        }
    }
}
