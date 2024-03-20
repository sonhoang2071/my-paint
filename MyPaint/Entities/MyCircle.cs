using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPaint.Entities
{
    internal class MyCircle : MyRectangle
    {
        public MyCircle(Point sPoint, Point ePoint, int borderWidth, Color borderColor) : base(sPoint, ePoint, borderWidth, borderColor)
        {
            this.width = Math.Max(CalculateWidth(this.sPoint, this.ePoint), CalculateHeight(this.sPoint, this.ePoint));
            this.height = Math.Max(CalculateWidth(this.sPoint, this.ePoint), CalculateHeight(this.sPoint, this.ePoint));
        }

        public override void Draw(Graphics g)
        {
            g.DrawEllipse(this.pen, this.sPoint.X, this.sPoint.Y, this.width, this.height);
            
        }

    }
}
