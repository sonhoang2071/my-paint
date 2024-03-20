using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.LinkLabel;

namespace MyPaint.Entities
{
    public sealed class FillFactory
    {
        public static FillFactory GetInstance { get; } = new FillFactory();
        private FillFactory() { }
        public IDraw GetFill(ShapeType shapeType, FillType fillType, Point sPoint, Point ePoint, int borderWidth, Color borderColor, Color brushColor)
        {
            ShapeFactory factory = ShapeFactory.GetInstance;
            IDraw s;
            switch (fillType)
            {
                case FillType.NoFill:
                    s = factory.GetShape(shapeType, sPoint, ePoint, borderWidth, borderColor);
                    return s;
                case FillType.FullFill:
                    s = new FillDecorator(factory.GetShape(shapeType, sPoint, ePoint, borderWidth, borderColor), brushColor, new FullFillStrategy());
                    return s;
                case FillType.PatternFill:
                    s = new FillDecorator(factory.GetShape(shapeType, sPoint, ePoint, borderWidth, borderColor), brushColor, new PatternFillStrategy());
                    return s;              
                default:
                    throw new NotSupportedException();
            }
        }
    }
}
