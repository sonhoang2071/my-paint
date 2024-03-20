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
        ShapeType typeShape;
        FillType fillType;
        FillFactory factory = FillFactory.GetInstance;
        int line;
        LinkedList<IDraw> shapes;
        IDraw p;
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
            shapes = new LinkedList<IDraw>();
            line = 2;
        }
        private void drawing_MouseDown(object sender, MouseEventArgs e)
        {
            sPoint = e.Location;
            moving = true;
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
            moving = false;
        }
        public void HandleDraw(Point e)
        {
            p = factory.GetFill(typeShape, fillType, sPoint, e, line, borderColor.Color, brushColor.Color);
            p.Draw(g);
        }
        public void HandleAdd(Point e)
        {
            HandleDraw(e);
            shapes.AddLast(p);
        }
        private void RefreshPicture()
        {
            g.Clear(Color.White);
            foreach (IDraw s in shapes)
            {
                s.Draw(g);
            }
            foreach (IDraw s in shapes)
            {
                s.Draw(ga);
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            string  pathSave= @"C:\Users\Admin\Documents\image.png";
            bm.Save(pathSave, System.Drawing.Imaging.ImageFormat.Png);
        }
        private void button26_Click(object sender, EventArgs e)
        {
            g.Clear(Color.White);
            shapes = new LinkedList<IDraw>();
        }
        private void button21_Click(object sender, EventArgs e)
        {
            line = 2;
        }
        private void button22_Click(object sender, EventArgs e)
        {
            line = 4;
        }
        private void button23_Click(object sender, EventArgs e)
        {
            line = 6;
        }
        private void button24_Click(object sender, EventArgs e)
        {
            line = 8;
        }
        private void button25_Click(object sender, EventArgs e)
        {
            borderColor.ShowDialog();
        }
        private void brush_Click(object sender, EventArgs e)
        {
            brushColor.ShowDialog();
        }
        private void rbRectangle2_Click(object sender, EventArgs e)
        {
            typeShape = ShapeType.Rectangle;
        }
        private void rbTriangle_Click(object sender, EventArgs e)
        {
            typeShape = ShapeType.Triangle;
        } 
        private void rdCircle_Click(object sender, EventArgs e)
        {
            typeShape = ShapeType.Circle;
        }
        private void btndiamond_Click(object sender, EventArgs e)
        {
            typeShape = ShapeType.Diamond;
        }
        private void btnPentagon_Click(object sender, EventArgs e)
        {
            typeShape = ShapeType.Pentagon;
        }
        private void btnRightArround_Click(object sender, EventArgs e)
        {
            typeShape = ShapeType.RightArrow;
        }
        private void btnLeftArround_Click(object sender, EventArgs e)
        {
            typeShape = ShapeType.LeftArrow;
        }
        private void btnUpArrow_Click(object sender, EventArgs e)
        {
            typeShape = ShapeType.UpArrow;
        }
        private void btnDownArrow_Click(object sender, EventArgs e)
        {
            typeShape = ShapeType.DownArrow;
        }
        private void btnRightTriangle_Click(object sender, EventArgs e)
        {
            typeShape = ShapeType.RightTriangle;
        }
        private void btnLine_Click(object sender, EventArgs e)
        {
            typeShape = ShapeType.Line;
        }
        private void rbRectangle_Click(object sender, EventArgs e)
        {
            typeShape = ShapeType.Square;
        }
        private void rdNoFill_CheckedChanged(object sender, EventArgs e)
        {
            if(rdNoFill.Checked)
            {
                fillType = FillType.NoFill;
            }
        }
        private void rdFullFill_CheckedChanged(object sender, EventArgs e)
        {
            if( rdFullFill.Checked)
            {
                fillType = FillType.FullFill;
            }
        }
        private void rdPatternFill_CheckedChanged(object sender, EventArgs e)
        {
            if(rdPatternFill.Checked)
            {
                fillType = FillType.PatternFill;
            }
        }
    }
}
