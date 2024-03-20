using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPaint.Entities
{
    public class MyCircleToPolygonAdapter : MyPolygon
    {
        private MyCircle circle;
        public MyCircleToPolygonAdapter(Point sPoint, Point ePoint, int borderWidth, Color borderColor) : base(sPoint, ePoint, borderWidth, borderColor)
        {
            circle = new MyCircle(sPoint, ePoint, borderWidth, borderColor);    
            this.width = circle.width;
            this.height = circle.height;
            
        }
        public override void Draw(Graphics g)
        {
            this.circle.Draw(g);
        }
        
    }
}
