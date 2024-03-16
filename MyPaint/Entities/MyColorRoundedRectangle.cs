using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPaint.Entities
{
    internal class MyColorRoundedRectangle:MyRoundedRectangle
    {
        public Color brColor;
        public MyColorRoundedRectangle(Point sPoint, Point ePoint, int borderWidth, Color borderColor, Color fillColor):base(sPoint, ePoint, borderWidth, borderColor)
        {
            this.sPoint = sPoint;
            this.ePoint = ePoint;
            this.borderWidth = borderWidth;
            this.borderColor = borderColor;
            this.brColor = fillColor;
        }
        private static void DrawRoundedRectangle(Graphics graphics, Pen pen,Brush brush, int x, int y, int width, int height, int borderRadius)
        {
            Rectangle rectangle = new Rectangle(x, y, width, height);
            int diameter = borderRadius * 2;

            graphics.FillRectangle(brush, x + borderRadius, y, width - diameter, height);
            graphics.FillRectangle(brush, x, y + borderRadius, width, height - diameter);
            graphics.FillEllipse(brush, rectangle.Left, rectangle.Top, diameter, diameter);
            graphics.FillEllipse(brush, rectangle.Right - diameter, rectangle.Top, diameter, diameter);
            graphics.FillEllipse(brush, rectangle.Left, rectangle.Bottom - diameter, diameter, diameter);
            graphics.FillEllipse(brush, rectangle.Right - diameter, rectangle.Bottom - diameter, diameter, diameter);

            // Vẽ phần border
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
            Brush brush = new SolidBrush(brColor);
            int x = Math.Min(sPoint.X, ePoint.X);
            int y = Math.Min(sPoint.Y, ePoint.Y);
            int width = Math.Abs(sPoint.X - ePoint.X);
            int height = Math.Abs(sPoint.Y - ePoint.Y);

            // Vẽ hình chữ nhật với góc bo tròn
            DrawRoundedRectangle(g, borderPen,brush, x, y, width, height, 20);
        }
    }
}
