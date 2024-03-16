﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPaint.Entities
{
    internal class MyColorTriangle:MyTriangle
    {
        public Color brColor;
        public MyColorTriangle(Point spoint, Point ePoint, int borderWidth, Color borderColor, Color fillColor) : base(spoint, ePoint, borderWidth, borderColor)
        {
            this.brColor = fillColor;
        }
        public override void Draw(Graphics g)
        {
            Pen borderPen = new Pen(borderColor, borderWidth);
            Point[] triangle = { sPoint, ePoint, new Point(sPoint.X - (ePoint.X - sPoint.X), ePoint.Y) };
            Brush brush = new SolidBrush(brColor);
            g.DrawPolygon(borderPen, triangle);
            g.FillPolygon(brush, triangle);
        }
    }
}