using MyPaint.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPaint.Entities
{
    public class ListState : IListState, ICopy
    {
        private List<IDraw> list;
        public ListState()
        {
            list = new List<IDraw>();
        }
        public ListState(ListState listState)
        {
            list = listState.list;
        }
        public void Add(IDraw draw)
        {
            list.Add(draw);
        }  
        public void Remove()
        {
            if (list.Count > 0)
            {
                list.RemoveAt(list.Count - 1);
            }            
        }
        public void Draw(Graphics g, Graphics ga)
        {
            foreach (IDraw s in list)
            {
                s.Draw(g);
            }
            foreach (IDraw s in list)
            {
                s.Draw(ga);
            }
        }
        public ListState DeepCopy()
        {
            ListState copy = new ListState();
            foreach (var sv in list)
            {
                copy.Add(sv);
            }
            return copy;
        }
    }
}
