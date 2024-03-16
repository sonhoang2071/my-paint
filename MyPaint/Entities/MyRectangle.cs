﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPaint.Entities
{
    internal class MyRectangle : Shape
    {
        public MyRectangle(Point sPoint, Point ePoint, int borderWidth, Color borderColor)
        {
            this.sPoint = sPoint;
            this.width = ePoint.X;
            this.height = ePoint.Y;
            this.borderWidth = borderWidth;
            this.borderColor = borderColor;
        }
        public override void Draw(Graphics g)
        {
            Pen borderPen = new Pen(borderColor, borderWidth);
            int x = sPoint.X < width ? sPoint.X : width;
            int y = sPoint.Y < height ? sPoint.Y : height;
            int w = Math.Abs(sPoint.X - width);
            int h = Math.Abs(sPoint.Y - height);
            Rectangle rc = new Rectangle(x, y, w, h);
            g.DrawRectangle(borderPen, rc);
        }
    }
}
