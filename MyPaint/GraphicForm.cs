using MyPaint.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyPaint
{
    public partial class GraphicForm : Form
    {
        Bitmap bm;
        Graphics ga;
        Graphics g;
        Point sPoint;
        bool moving;
        LinkedList<Shape> shapes;
        int clickNum;
        public GraphicForm()
        {
            InitializeComponent();
            
            bm = new Bitmap(pic.Width, pic.Height);
            ga = Graphics.FromImage(bm);
            pic.DrawToBitmap(bm, pic.ClientRectangle);
            pic.Image = bm;
            g = pic.CreateGraphics();
            sPoint = new Point(0, 0);
            moving = false;
            shapes = new LinkedList<Shape>();
            clickNum = 1;
        }
        private void drawing_MouseDown(object sender, MouseEventArgs e)
        {   if(rbPoint.Checked)
            {
                switch(clickNum)
                {
                    case 1:
                        sPoint = e.Location;
                        DrawPoint(sPoint);
                        clickNum++;
                        break;
                    case 2:
                        HandleAdd(e.Location);
                        DrawPoint(e.Location);
                        clickNum = 1;
                        break;
                }
            }
            else
            {
                sPoint = e.Location;
                moving = true;
            }
                  
        }

        private void drawing_MouseMove(object sender, MouseEventArgs e)
        {
            if (moving)
            {
                RefreshPicture();
                HandleDraw(e.Location);
            }
        }       
        private void drawing_MouseUp(object sender, MouseEventArgs e)
        {
            HandleAdd(e.Location);
            RefreshPicture();    
            moving = false;
        }
        public void HandleDraw(Point e)
        {
            Shape s;
            if (rbRectangle.Checked)
            {
                s = new MyRectangle(sPoint, e);
                s.Draw(g);
            } 
            else if (rbCircle.Checked)
            {
                s= new MyCircle(sPoint, e);
                s.Draw(g);
            }
        }
        public void HandleAdd(Point e)
        {
            Shape s;
            if (rbRectangle.Checked)
            {
                s = new MyRectangle(sPoint, e);
                shapes.AddLast(s);
            } 
            else if ( rbCircle.Checked)
            {
                s = new MyCircle(sPoint, e);
                shapes.AddLast(s);
            }
        }
        public void DrawPoint(Point e)
        {
            g.DrawEllipse(new Pen(Color.Black, 2), e.X -2, e.Y - 2, 4, 4);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string  pathSave= @"C:\Users\Admin\Documents\example_image.png";
            bm.Save(pathSave, System.Drawing.Imaging.ImageFormat.Png);
        }
        private void RefreshPicture()
        {
            g.Clear(Color.White);
            foreach (Shape s in shapes)
            {
                s.Draw(g);
            }
            foreach (Shape s in shapes)
            {
                s.Draw(ga);
            }
        }


    }
}
