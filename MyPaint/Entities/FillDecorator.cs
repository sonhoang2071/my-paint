using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPaint.Entities
{
    public class FillDecorator :  IDraw
    {

        private readonly MyPolygon myPolygon;
        private readonly Color color;
        private IFillStrategy fillStrategy;
        public FillDecorator(MyPolygon myPolygon, Color color,  IFillStrategy fillStrategy)
        {
            this.myPolygon = myPolygon;
            this.color = color;
            this.fillStrategy = fillStrategy;
        }
        public void Draw(Graphics g)
        {
            this.myPolygon.Draw(g);
            this.fillStrategy.Fill(g, this.myPolygon, this.color);
        }
    }
}
