using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPaint.Entities
{
    internal abstract class Shape:IDraw
    {
        public Point sPoint {  get; set; }
        public int width { get; set; }
        public int height { get; set; }

        public Shape() { }

        public abstract void Draw(Graphics g);
    }
}
