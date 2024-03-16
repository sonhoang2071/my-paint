﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPaint.Entities
{
    internal class MyPatternDownArrow:MyDownArrow
    {
        public Color brColor;
        public MyPatternDownArrow(Point sPoint, Point ePoint, int borderWidth, Color borderColor, Color fillColor) : base(sPoint, ePoint, borderWidth, borderColor)
        {
            this.sPoint = sPoint;
            this.width = ePoint.X;
            this.height = ePoint.Y;
            this.borderWidth = borderWidth;
            this.borderColor = borderColor;
            brColor = fillColor;
        }

        public override void Draw(Graphics g)
        {
            Pen pen = new Pen(borderColor, borderWidth);
            HatchBrush brush = new HatchBrush(HatchStyle.SmallGrid, borderColor, brColor);
            Point[] points = new Point[7];
            points[0] = new Point(sPoint.X + width / 2, sPoint.Y + height);
            points[1] = new Point(sPoint.X + width, sPoint.Y + height / 2);
            points[2] = new Point(sPoint.X + 2 * width / 3, sPoint.Y + height / 2);
            points[3] = new Point(sPoint.X + 2 * width / 3, sPoint.Y);
            points[4] = new Point(sPoint.X + width / 3, sPoint.Y);
            points[5] = new Point(sPoint.X + width / 3, sPoint.Y + height / 2);
            points[6] = new Point(sPoint.X, sPoint.Y + height / 2);
            g.DrawPolygon(pen, points);
            g.FillPolygon(brush, points);
        }
    }
}