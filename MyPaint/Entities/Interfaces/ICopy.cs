using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPaint.Entities.Interfaces
{
    public interface ICopy
    {
        ListState DeepCopy();
    }
}
