using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPaint.Entities
{
    internal class MyPatternRectangle:MyRectangle
    {
        public Color brColor;
        public MyPatternRectangle(Point sPoint, Point ePoint, int borderWidth, Color borderColor, Color fillColor) : base(sPoint, ePoint, borderWidth, borderColor)
        {
            base.width = ePoint.X;
            base.height = ePoint.Y;
            this.brColor = fillColor;
        }
        public override void Draw(Graphics g)
        {
            Pen pen = new Pen(borderColor, borderWidth);
            HatchBrush brush = new HatchBrush(HatchStyle.SmallGrid, borderColor, brColor);
            int x = sPoint.X < width ? sPoint.X : width;
            int y = sPoint.Y < height ? sPoint.Y : height;
            int w = Math.Abs(sPoint.X - width);
            int h = Math.Abs(sPoint.Y - height);
            Rectangle rect = new Rectangle(x, y, w, h);
            g.DrawRectangle(pen, rect);
            g.FillRectangle(brush, rect);
        }
    }
}
