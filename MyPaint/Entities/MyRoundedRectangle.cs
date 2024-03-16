using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace MyPaint.Entities
{
    internal class MyRoundedRectangle:Shape
    {
        public Point ePoint;
        public MyRoundedRectangle(Point sPoint, Point ePoint, int borderWidth, Color borderColor)
        {
            this.sPoint = sPoint;
            this.ePoint = ePoint;
            this.borderWidth = borderWidth;
            this.borderColor = borderColor;
        }
        private static void DrawRoundedRectangle(Graphics graphics, Pen pen, int x, int y, int width, int height, int borderRadius)
        {
            Rectangle rectangle = new Rectangle(x, y, width, height);
            int diameter = borderRadius * 2;

            graphics.DrawArc(pen, rectangle.Left, rectangle.Top, diameter, diameter, 180, 90);
            graphics.DrawLine(pen, rectangle.Left + borderRadius, rectangle.Top, rectangle.Right - borderRadius, rectangle.Top);
            graphics.DrawArc(pen, rectangle.Right - diameter, rectangle.Top, diameter, diameter, 270, 90);
            graphics.DrawLine(pen, rectangle.Right, rectangle.Top + borderRadius, rectangle.Right, rectangle.Bottom - borderRadius);
            graphics.DrawArc(pen, rectangle.Right - diameter, rectangle.Bottom - diameter, diameter, diameter, 0, 90);
            graphics.DrawLine(pen, rectangle.Right - borderRadius, rectangle.Bottom, rectangle.Left + borderRadius, rectangle.Bottom);
            graphics.DrawArc(pen, rectangle.Left, rectangle.Bottom - diameter, diameter, diameter, 90, 90);
            graphics.DrawLine(pen, rectangle.Left, rectangle.Bottom - borderRadius, rectangle.Left, rectangle.Top + borderRadius);
        }
        public override void Draw(Graphics g)
        {
            Pen borderPen = new Pen(borderColor, borderWidth);
            int x = Math.Min(sPoint.X, ePoint.X);
            int y = Math.Min(sPoint.Y, ePoint.Y);
            int width = Math.Abs(sPoint.X - ePoint.X);
            int height = Math.Abs(sPoint.Y - ePoint.Y);

            // Vẽ hình chữ nhật với góc bo tròn
            DrawRoundedRectangle(g,borderPen, x, y, width, height, 20);
        }
    }
}
