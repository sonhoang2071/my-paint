using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPaint.Entities
{
    internal class MyColorRectangle : MyRectangle
    {
        public Color fillColor;
        public MyColorRectangle(Point sPoint, Point ePoint, int borderWidth,Color borderColor,  Color fillColor) : base(sPoint, ePoint, borderWidth, borderColor)
        {
            this.fillColor = fillColor;
        }
        public override void Draw(Graphics g)
        {
            Brush brushColor = new SolidBrush(fillColor);
            int x = sPoint.X < width ? sPoint.X : width;
            int y = sPoint.Y < height ? sPoint.Y : height;
            int w = Math.Abs(sPoint.X - width);
            int h = Math.Abs(sPoint.Y - height);
            Rectangle rc = new Rectangle(x, y, w, h);
            g.DrawRectangle(new Pen(Color.Black), rc);
            g.FillRectangle(brushColor, rc);
        }
    }
}
