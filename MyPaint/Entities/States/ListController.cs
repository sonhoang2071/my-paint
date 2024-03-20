using MyPaint.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPaint.Entities
{
    public sealed class ListController
    {
        private Stack<ListState> undoStack;
        private Stack<ListState> redoStack;
        private ListState currentState;
        public static ListController GetListController { get; } = new ListController();
        private ListController()
        {
            undoStack = new Stack<ListState>();
            redoStack = new Stack<ListState>();
            currentState = new ListState();
        }

        public void Add(IDraw draw)
        {
            undoStack.Push(currentState.DeepCopy());
            currentState.Add(draw);
            redoStack.Clear();
        }

        public void Refresh()
        {
            undoStack = new Stack<ListState>();
            redoStack = new Stack<ListState>();
            currentState = new ListState();
        }

        public void Undo()
        {
            if (undoStack.Count > 0)
            {
                redoStack.Push(currentState);
                this.currentState = undoStack.Pop();
            }
        }
        public void Redo()
        {
            if (redoStack.Count > 0)
            {
                undoStack.Push(currentState);
                this.currentState = redoStack.Pop();
            }
        }
        public void Draw(Graphics g, Graphics ga)
        {
            currentState.Draw(g, ga);
        }
    }
}
