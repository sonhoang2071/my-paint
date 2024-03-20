using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPaint.Entities
{
    public class MyPolygon : MyRectangle
    {
        public Point[] points { get; set; }
        private ICalPointStrategy calPointStrategy;
        public MyPolygon(Point sPoint, Point ePoint, int borderWidth, Color borderColor) : base(sPoint, ePoint, borderWidth, borderColor)
        {
        }
        public void SetStrategy(ICalPointStrategy calPointStrategy)
        {
            this.calPointStrategy = calPointStrategy;
            this.points = this.calPointStrategy.CalculatePoints(this.sPoint, this.width, this.height);
        }
        public override void Draw(Graphics g)
        {
            g.DrawPolygon(this.pen, points);
        }

    }
}
