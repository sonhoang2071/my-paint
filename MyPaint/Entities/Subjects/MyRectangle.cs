using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPaint.Entities
{
    public class MyRectangle : Shape
    {
        public MyRectangle(Point sPoint, Point ePoint, int borderWidth, Color borderColor)
        {
            this.sPoint = CalculateSPoint(sPoint, ePoint);
            this.ePoint = CalculateEPoint(sPoint, ePoint);
            this.width = CalculateWidth(this.sPoint, this.ePoint);
            this.height = CalculateHeight(this.sPoint, this.ePoint);
            this.pen = new Pen(borderColor, borderWidth);
        }

        public override void Draw(Graphics g)
        {
            throw new NotImplementedException();
        }
    }
}
