using MyPaint.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
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
        IDraw p;
        ShapeType typeShape;
        FillType fillType; 
        FillFactory factory = FillFactory.GetInstance;
        ListController controller = ListController.GetListController;
        int line;
        bool moving;
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
            RefreshPicture();
        }
        public void HandleDraw(Point e)
        {
            p = factory.GetFill(typeShape, fillType, sPoint, e, line, borderColor.Color, brushColor.Color);
            p.Draw(g);
        }
        public void HandleAdd(Point e)
        {
            HandleDraw(e);
            controller.Add(p);
        }
        private void RefreshPicture()
        {
            g.Clear(Color.White);
            ga.Clear(Color.White);
            controller.Draw(g, ga);
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "PNG files|*.png";
            saveFileDialog.Title = "Save an Image File";
            saveFileDialog.ShowDialog();

            if (saveFileDialog.FileName != "")
            { 
                bm.Save(saveFileDialog.FileName, System.Drawing.Imaging.ImageFormat.Png);
                MessageBox.Show("Saved Successfully", "Notify", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            g.Clear(Color.White);
            ga.Clear(Color.White); 
            controller.Refresh();
        }
        private void btnSize1_Click(object sender, EventArgs e)
        {
            line = 2;
        }
        private void btnSize2_Click(object sender, EventArgs e)
        {
            line = 4;
        }
        private void btnSize3_Click(object sender, EventArgs e)
        {
            line = 6;
        }
        private void btnSize4_Click(object sender, EventArgs e)
        {
            line = 8;
        }
        private void brush_Click(object sender, EventArgs e)
        {
            brushColor.ShowDialog();
        }
        private void border_Click(object sender, EventArgs e)
        {
            borderColor.ShowDialog();
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
            if (rdFullFill.Checked)
            {
                fillType = FillType.FullFill;
            }
        }
        private void rdPatternFill_CheckedChanged(object sender, EventArgs e)
        {
            if (rdPatternFill.Checked)
            {
                fillType = FillType.PatternFill;
            }
        }
        private void btnRedo_Click(object sender, EventArgs e)
        {
            controller.Redo();
            RefreshPicture();
        }
        private void btnUndo_Click(object sender, EventArgs e)
        {
            controller.Undo();
            RefreshPicture();
        }
    }
}
