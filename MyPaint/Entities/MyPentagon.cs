﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPaint.Entities
{
    internal class MyPentagon:Shape 
    {
        public Point[] PentagonPoints { get; set; }

        public MyPentagon(Point startPoint, Point endPoint, int borderWidth, Color borderColor)
        {
            this.PentagonPoints = CalculatePentagonPoints(startPoint, endPoint);
            base.borderWidth = borderWidth;
            base.borderColor = borderColor;
        }
        private Point[] CalculatePentagonPoints(Point startPoint, Point endPoint)
        {
            Point[] points = new Point[5];
            int width = Math.Abs(endPoint.X - startPoint.X);
            int height = Math.Abs(endPoint.Y - startPoint.Y);
            int centerX = startPoint.X + width / 2;
            int centerY = startPoint.Y + height / 2;
            double radius = Math.Min(width, height) / 2.0;
            double angle = 90 * Math.PI / 180; 

            for (int i = 0; i < 5; i++)
            {
                int x = (int)(centerX + radius * Math.Cos(angle));
                int y = (int)(centerY - radius * Math.Sin(angle));
                points[i] = new Point(x, y);
                angle += 72 * Math.PI / 180;
            }
            return points;
        }
        public override void Draw(Graphics g)
        {
            Pen pen = new Pen(borderColor, borderWidth);
            g.DrawPolygon(pen, PentagonPoints);
        }
    }
}
