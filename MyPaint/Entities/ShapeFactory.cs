using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPaint.Entities
{
    public sealed class ShapeFactory
    {
        public static ShapeFactory GetInstance { get; } = new ShapeFactory();
        private ShapeFactory() { }
        public MyPolygon GetShape(ShapeType type, Point sPoint, Point ePoint, int borderWidth, Color borderColor)
        {
            MyPolygon s;
            switch (type)
            {
                case ShapeType.Line:
                    s = new MyLineToPolygonAdapter(sPoint, ePoint, borderWidth, borderColor);
                    return s;
                case ShapeType.Circle:
                    s = new MyCircleToPolygonAdapter(sPoint, ePoint, borderWidth, borderColor);
                    return s;
                case ShapeType.Rectangle:
                    s = new MyPolygon(sPoint, ePoint, borderWidth, borderColor);
                    s.SetStrategy(new RectangleStrategy()); 
                    return s;
                case ShapeType.Square:
                    s = new MyPolygon(sPoint, ePoint, borderWidth, borderColor);
                    s.SetStrategy(new SquareStrategy());
                    return s;
                case ShapeType.Triangle:
                    s = new MyPolygon(sPoint, ePoint, borderWidth, borderColor);
                    s.SetStrategy(new TriangleStrategy());
                    return s;
                case ShapeType.RightTriangle:
                    s = new MyPolygon(sPoint, ePoint, borderWidth, borderColor);
                    s.SetStrategy(new RightTriangleStrategy());
                    return s;
                case ShapeType.Diamond:
                    s = new MyPolygon(sPoint, ePoint, borderWidth, borderColor);
                    s.SetStrategy(new DiamondStrategy());
                    return s;
                case ShapeType.Pentagon:
                    s = new MyPolygon(sPoint, ePoint, borderWidth, borderColor);
                    s.SetStrategy(new PentagonStrategy());
                    return s;
                case ShapeType.RightArrow:
                    s = new MyPolygon(sPoint, ePoint, borderWidth, borderColor);
                    s.SetStrategy(new RightArrowStrategy());
                    return s;
                case ShapeType.LeftArrow:
                    s = new MyPolygon(sPoint, ePoint, borderWidth, borderColor);
                    s.SetStrategy(new LeftArrowStrategy());
                    return s;
                case ShapeType.UpArrow:
                    s = new MyPolygon(sPoint, ePoint, borderWidth, borderColor);
                    s.SetStrategy(new UpArrowStrategy());
                    return s;
                case ShapeType.DownArrow:
                    s = new MyPolygon(sPoint, ePoint, borderWidth, borderColor);
                    s.SetStrategy(new DownArrowStrategy());
                    return s;
                default:
                    throw new NotSupportedException();
            }
        }
    }
}
