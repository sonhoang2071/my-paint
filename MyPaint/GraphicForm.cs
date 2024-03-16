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
        int caseShape = 0;
        int caseLine = 0;
        int caseBrush;
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
            Pen pen1 = new Pen(colorDialog1.Color);
            int line = caseLine;
            Shape s;
            //if (rbRectangle.Checked)
            //{
            //    s = new MyRectangle(sPoint, e);
            //    s.Draw(g);
            //} 
            //else if (rbCircle.Checked)
            //{
            //    s= new MyCircle(sPoint, e);
            //    s.Draw(g);
            //}
            switch (caseLine)
            {
                case 1:
                    line = 1;
                    break;
                case 2:
                    line = 2;
                    break;
                case 3:
                    line = 3;
                    break;
                case 4:
                    line = 4;
                    break;
            }
            switch (caseShape)
            {
                case 1:
                    s = new MyTriangle(sPoint, e, line, pen1.Color);
                    s.Draw(g);
                    break;
            }
        }
            public void HandleAdd(Point e)
        {
            //Shape s;
            //if (rbRectangle.Checked)
            //{
            //    s = new MyRectangle(sPoint, e);
            //    shapes.AddLast(s);
            //} 
            //else if ( rbCircle.Checked)
            //{
            //    s = new MyCircle(sPoint, e);
            //    shapes.AddLast(s);
            //}
            int line = caseLine;
            Shape s;
            Pen pen1 = new Pen(colorDialog1.Color);
            Pen pen2 = new Pen(colorDialog2.Color);
            switch (caseLine)
            {
                case 1:
                    line = 1;
                    break;
                case 2:
                    line = 2;
                    break;
                case 3:
                    line = 3;
                    break;
                case 4:
                    line = 4;
                    break;
            }
            if (rdpattern.Checked)
            {
                switch (caseShape)
                {
                    case 1:
                        if (caseBrush == 1)
                        {
                            s = new MyPatternTriangle(sPoint, e, line, pen1.Color, pen2.Color);
                        }
                        else
                        {
                            s = new MyPatternTriangle(sPoint, e, line, pen1.Color, Color.White);
                        }
                        s.Draw(g);
                        shapes.AddLast(s);
                        break;
                    case 2:
                        if (caseBrush == 1)
                        {
                            s = new MyPatternRectangle(sPoint, e, line, pen1.Color, pen2.Color);
                        }
                        else
                        {
                            s = new MyPatternRectangle (sPoint, e, line, pen1.Color, Color.White);
                        }
                        s.Draw(g);
                        shapes.AddLast(s);
                        break;
                    case 3:
                        if (caseBrush == 1)
                        {
                            s = new MyPatternCircle(sPoint, e, line, pen1.Color, pen2.Color);
                        }
                        else
                        {
                            s = new MyPatternCircle(sPoint, e, line, pen1.Color, Color.White);
                        }
                        s.Draw(g);
                        shapes.AddLast(s);
                        break;
                    case 4:
                        if (caseBrush == 1)
                        {
                            s = new MyPatternDiamond(sPoint, e, line, pen1.Color, pen2.Color);
                        }
                        else
                        {
                            s = new MyPatternDiamond(sPoint, e, line, pen1.Color, Color.White);
                        }
                        s.Draw(g);
                        shapes.AddLast(s);
                        break;
                    case 5:
                        if (caseBrush == 1)
                        {
                            s = new MyPatternPentagon(sPoint, e, line, pen1.Color, pen2.Color);
                        }
                        else
                        {
                            s = new MyPatternPentagon(sPoint, e, line, pen1.Color, Color.White);
                        }
                        s.Draw(g);
                        shapes.AddLast(s);
                        break;
                    case 6:
                        if (caseBrush == 1)
                        {
                            s = new MyPatternLeftArround(sPoint, e, line, pen1.Color, pen2.Color);
                        }
                        else
                        {
                            s = new MyPatternLeftArround(sPoint, e, line, pen1.Color, Color.White);
                        }
                        s.Draw(g);
                        shapes.AddLast(s);
                        break;
                    case 7:
                        if (caseBrush == 1)
                        {
                            s = new MyPatternRightArround(sPoint, e, line, pen1.Color, pen2.Color);
                        }
                        else
                        {
                            s = new MyPatternRightArround(sPoint, e, line, pen1.Color, Color.White);
                        }
                        s.Draw(g);
                        shapes.AddLast(s);
                        break;
                    case 8:
                        if (caseBrush == 1)
                        {
                            s = new MyPatternUpArrow(sPoint, e, line, pen1.Color, pen2.Color);
                        }
                        else
                        {
                            s = new MyPatternUpArrow(sPoint, e, line, pen1.Color, Color.White);
                        }
                        s.Draw(g);
                        shapes.AddLast(s);
                        break;
                    case 9:
                        if (caseBrush == 1)
                        {
                            s = new MyPatternDownArrow(sPoint, e, line, pen1.Color, pen2.Color);
                        }
                        else
                        {
                            s = new MyPatternDownArrow(sPoint, e, line, pen1.Color, Color.White);
                        }
                        s.Draw(g);
                        shapes.AddLast(s);
                        break;
                    case 10:
                        if (caseBrush == 1)
                        {
                            s = new MyPatternRightTriangle(sPoint, e, line, pen1.Color, pen2.Color);
                        }
                        else
                        {
                            s = new MyPatternRightTriangle(sPoint, e, line, pen1.Color, Color.White);
                        }
                        s.Draw(g);
                        shapes.AddLast(s);
                        break;
                    case 11:
                        if (caseBrush == 1)
                        {
                            s = new MyLine(sPoint, e, line, pen1.Color);
                        }
                        else
                        {
                            s = new MyLine(sPoint, e, line, pen1.Color);
                        }
                        s.Draw(g);
                        shapes.AddLast(s);
                        break;
                    case 12:
                        if (caseBrush == 1)
                        {
                            s = new MyPatternRoundedRectangle(sPoint, e, line, pen1.Color, pen2.Color);
                        }
                        else
                        {
                            s = new MyPatternRoundedRectangle(sPoint, e, line, pen1.Color, Color.White);
                        }
                        s.Draw(g);
                        shapes.AddLast(s);
                        break;
                }
            }
            if (rdNoPattern.Checked)
            {
                switch (caseShape)
                {
                    case 1:
                        if (caseBrush == 1)
                        {
                            s = new MyColorTriangle(sPoint, e, line, pen1.Color, pen2.Color);
                        }
                        else
                        {
                            s = new MyTriangle(sPoint, e, line, pen1.Color);
                        }
                        s.Draw(g);
                        shapes.AddLast(s);
                        break;
                    case 2:
                        if (caseBrush == 1)
                        {
                            s = new MyColorRectangle(sPoint, e, line, pen1.Color, pen2.Color);
                        }
                        else
                        {
                            s = new MyRectangle(sPoint, e, line, pen1.Color);
                        }
                        s.Draw(g);
                        shapes.AddLast(s);
                        break;
                    case 3:
                        if(caseBrush == 1)
                        {
                            s = new MyColorCircle(sPoint, e, line, pen1.Color, pen2.Color);
                        }
                        else
                        {
                            s = new MyCircle(sPoint, e, line, pen1.Color);
                        }
                          s.Draw(g);
                        shapes.AddLast(s);
                        break;
                    case 4:
                        if (caseBrush == 1)
                        {
                            s = new MyColorDiamond(sPoint, e, line, pen1.Color, pen2.Color);
                        }
                        else
                        {
                            s = new MyDiamond(sPoint, e, line, pen1.Color);
                        }
                        s.Draw(g);
                        shapes.AddLast(s);
                        break;
                    case 5:
                        if(caseBrush == 1)
                        {
                            s = new MyColorPentagon(sPoint, e, line, pen1.Color, pen2.Color);
                        }
                        else
                        {                                                                                 
                            s = new MyPentagon(sPoint, e, line, pen1.Color);
                        }
                        s.Draw(g);
                        shapes.AddLast(s);
                        break;
                    case 6:
                        if (caseBrush == 1)
                        {
                            s = new MyColorLeftArround(sPoint, e, line, pen1.Color, pen2.Color);
                        }
                        else
                        {
                            s = new MyLeftArround(sPoint, e, line, pen1.Color);
                        }
                        s.Draw(g);
                        shapes.AddLast(s);
                        break;
                    case 7:
                        if (caseBrush == 1)
                        {
                            s = new MyColorRightArround(sPoint, e, line, pen1.Color, pen2.Color);
                        }
                        else
                        {
                            s = new MyRightArround(sPoint, e, line, pen1.Color);
                        }
                        s.Draw(g);
                        shapes.AddLast(s);
                        break;
                    case 8:
                        if (caseBrush == 1)
                        {
                            s = new MyColorUpArrow(sPoint, e, line, pen1.Color, pen2.Color);
                        }
                        else
                        {
                            s = new MyUpArrow(sPoint, e, line, pen1.Color);
                        }
                        s.Draw(g);
                        shapes.AddLast(s);
                        break;
                    case 9:
                        if (caseBrush == 1)
                        {
                            s = new MyColorDownArrow(sPoint, e, line, pen1.Color, pen2.Color);
                        }
                        else
                        {
                            s = new MyDownArrow(sPoint, e, line, pen1.Color);
                        }
                        s.Draw(g);
                        shapes.AddLast(s);
                        break;
                    case 10:
                        if (caseBrush == 1)
                        {
                            s = new MyColorRightTriangle(sPoint, e, line, pen1.Color, pen2.Color);
                        }
                        else
                        {
                            s = new MyRightTriangle(sPoint, e, line, pen1.Color);
                        }
                        s.Draw(g);
                        shapes.AddLast(s);
                        break;
                    case 11:
                        if (caseBrush == 1)
                        {
                            s = new MyLine(sPoint, e, line, pen1.Color);
                        }
                        else
                        {
                            s = new MyLine(sPoint, e, line, pen1.Color);
                        }
                        s.Draw(g);
                        shapes.AddLast(s);
                        break;
                    case 12:
                        if (caseBrush == 1)
                        {
                            s = new MyColorRoundedRectangle(sPoint, e, line, pen1.Color,pen2.Color);
                        }
                        else
                        {
                            s = new MyRoundedRectangle(sPoint, e, line, pen1.Color);
                        }
                        s.Draw(g);
                        shapes.AddLast(s);
                        break;
                }
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
        private void button21_Click(object sender, EventArgs e)
        {
            caseLine = 1;
        }
        private void button25_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
        }
        private void label4_Click(object sender, EventArgs e)
        {

        }
        private void GraphicForm_Load(object sender, EventArgs e)
        {

        }

        private void rbRectangle2_Click(object sender, EventArgs e)
        {
            caseShape = 2;
        }

        private void rbTriangle_Click(object sender, EventArgs e)
        {
            caseShape = 1;
        }

        private void GraphicForm_Click(object sender, EventArgs e)
        {

        }

        private void button24_Click(object sender, EventArgs e)
        {
            caseLine = 4;
        }

        private void button23_Click(object sender, EventArgs e)
        {
            //caseLine = 3;
        }

        private void button22_Click(object sender, EventArgs e)
        {
            //caseLine = 2;
        }

        private void brush_Click(object sender, EventArgs e)
        {
            caseBrush = 1;
            colorDialog2.ShowDialog();
        }

        private void rdCircle_Click(object sender, EventArgs e)
        {
            caseShape = 3;
        }

        private void btndiamond_Click(object sender, EventArgs e)
        {
            caseShape = 4;
        }

        private void btnPentagon_Click(object sender, EventArgs e)
        {
            caseShape = 5;
        }
        private void btnRightArround_Click(object sender, EventArgs e)
        {
            caseShape = 7;
        }

        private void btnLeftArround_Click(object sender, EventArgs e)
        {
            caseShape = 6;
        }

        private void btnUpArrow_Click(object sender, EventArgs e)
        {
            caseShape = 8;
        }

        private void btnDownArrow_Click(object sender, EventArgs e)
        {
            caseShape = 9;
        }

        private void btnRightTriangle_Click(object sender, EventArgs e)
        {
            caseShape = 10;
        }

        private void btnLine_Click(object sender, EventArgs e)
        {
            caseShape = 11;
        }

        private void btnRoundedRect_Click(object sender, EventArgs e)
        {
            caseShape = 12;
        }
    }
}
