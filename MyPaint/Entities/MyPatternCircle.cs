using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPaint.Entities
{
    internal class MyPatternCircle:MyCircle
    {
        public Color brColor;
        public MyPatternCircle(Point sPoint, Point ePoint, int boderWidth, Color borderColor, Color fillColor) : base(sPoint, ePoint, boderWidth, borderColor)
        {
            base.sPoint = CalMidPoint(sPoint, ePoint);
            base.rad = CalRadius(sPoint, ePoint);
            base.borderWidth = boderWidth;
            base.borderColor = borderColor;
            this.brColor = fillColor;
        }
        public override void Draw(Graphics g)
        {
            Pen pen = new Pen(borderColor, borderWidth);
            HatchBrush brush = new HatchBrush(HatchStyle.SmallGrid, borderColor, brColor);
            int centerX = (int)(sPoint.X - rad);
            int centerY = (int)(sPoint.Y - rad);
            Rectangle rect = new Rectangle(centerX, centerY, (int)(2 * rad), (int)(2 * rad));
            g.FillEllipse(brush, rect);
            g.DrawEllipse(pen, rect);
        }
    }
}
