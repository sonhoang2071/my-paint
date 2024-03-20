using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPaint.Entities.Interfaces
{
    public interface IListState
    {
        void Add(IDraw draw);
        void Remove();
        void Draw(Graphics g, Graphics ga);
    }
}
