namespace MyPaint
{
    partial class GraphicForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.rbRectangle = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbCircle = new System.Windows.Forms.RadioButton();
            this.rbVector = new System.Windows.Forms.RadioButton();
            this.rbPoint = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.colorDialog = new System.Windows.Forms.Button();
            this.button22 = new System.Windows.Forms.Button();
            this.button24 = new System.Windows.Forms.Button();
            this.button23 = new System.Windows.Forms.Button();
            this.button21 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btnRightTriangle = new System.Windows.Forms.Button();
            this.rbTriangle = new System.Windows.Forms.Button();
            this.btnRoundedRect = new System.Windows.Forms.Button();
            this.rbRectangle2 = new System.Windows.Forms.Button();
            this.rdCircle = new System.Windows.Forms.Button();
            this.btnRightArround = new System.Windows.Forms.Button();
            this.btnDownArrow = new System.Windows.Forms.Button();
            this.btnUpArrow = new System.Windows.Forms.Button();
            this.btnLeftArround = new System.Windows.Forms.Button();
            this.btnPentagon = new System.Windows.Forms.Button();
            this.btndiamond = new System.Windows.Forms.Button();
            this.btnLine = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pic = new System.Windows.Forms.PictureBox();
            this.button26 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.brush = new System.Windows.Forms.Button();
            this.colorDialog2 = new System.Windows.Forms.ColorDialog();
            this.rdpattern = new System.Windows.Forms.RadioButton();
            this.rdNoPattern = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // rbRectangle
            // 
            this.rbRectangle.AutoSize = true;
            this.rbRectangle.Location = new System.Drawing.Point(5, 21);
            this.rbRectangle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbRectangle.Name = "rbRectangle";
            this.rbRectangle.Size = new System.Drawing.Size(90, 20);
            this.rbRectangle.TabIndex = 1;
            this.rbRectangle.TabStop = true;
            this.rbRectangle.Text = "Rectangle";
            this.rbRectangle.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox1.Controls.Add(this.rbCircle);
            this.groupBox1.Controls.Add(this.rbRectangle);
            this.groupBox1.Location = new System.Drawing.Point(723, 11);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(111, 93);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Shapes";
            // 
            // rbCircle
            // 
            this.rbCircle.AutoSize = true;
            this.rbCircle.Location = new System.Drawing.Point(5, 47);
            this.rbCircle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbCircle.Name = "rbCircle";
            this.rbCircle.Size = new System.Drawing.Size(62, 20);
            this.rbCircle.TabIndex = 2;
            this.rbCircle.TabStop = true;
            this.rbCircle.Text = "Circle";
            this.rbCircle.UseVisualStyleBackColor = true;
            // 
            // rbVector
            // 
            this.rbVector.AutoSize = true;
            this.rbVector.Checked = true;
            this.rbVector.Location = new System.Drawing.Point(5, 21);
            this.rbVector.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbVector.Name = "rbVector";
            this.rbVector.Size = new System.Drawing.Size(67, 20);
            this.rbVector.TabIndex = 1;
            this.rbVector.TabStop = true;
            this.rbVector.Text = "Vector";
            this.rbVector.UseVisualStyleBackColor = true;
            // 
            // rbPoint
            // 
            this.rbPoint.AutoSize = true;
            this.rbPoint.Location = new System.Drawing.Point(5, 47);
            this.rbPoint.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbPoint.Name = "rbPoint";
            this.rbPoint.Size = new System.Drawing.Size(58, 20);
            this.rbPoint.TabIndex = 4;
            this.rbPoint.Text = "Point";
            this.rbPoint.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox2.Controls.Add(this.rbPoint);
            this.groupBox2.Controls.Add(this.rbVector);
            this.groupBox2.Location = new System.Drawing.Point(840, 12);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(111, 103);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSave.Location = new System.Drawing.Point(723, 113);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 28);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // colorDialog
            // 
            this.colorDialog.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.colorDialog.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.colorDialog.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.colorDialog.Image = global::MyPaint.Properties.Resources.colors__1_;
            this.colorDialog.Location = new System.Drawing.Point(12, 3);
            this.colorDialog.Name = "colorDialog";
            this.colorDialog.Size = new System.Drawing.Size(69, 66);
            this.colorDialog.TabIndex = 9;
            this.colorDialog.UseVisualStyleBackColor = true;
            this.colorDialog.Click += new System.EventHandler(this.button25_Click);
            // 
            // button22
            // 
            this.button22.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button22.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.button22.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button22.Image = global::MyPaint.Properties.Resources.line__2_;
            this.button22.Location = new System.Drawing.Point(637, 23);
            this.button22.Name = "button22";
            this.button22.Size = new System.Drawing.Size(60, 43);
            this.button22.TabIndex = 8;
            this.button22.Text = "2px";
            this.button22.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button22.UseVisualStyleBackColor = true;
            this.button22.Click += new System.EventHandler(this.button22_Click);
            // 
            // button24
            // 
            this.button24.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button24.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.button24.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button24.Image = global::MyPaint.Properties.Resources.line__2_;
            this.button24.Location = new System.Drawing.Point(637, 78);
            this.button24.Name = "button24";
            this.button24.Size = new System.Drawing.Size(60, 43);
            this.button24.TabIndex = 8;
            this.button24.Text = "4px";
            this.button24.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button24.UseVisualStyleBackColor = true;
            this.button24.Click += new System.EventHandler(this.button24_Click);
            // 
            // button23
            // 
            this.button23.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button23.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.button23.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button23.Image = global::MyPaint.Properties.Resources.line__2_;
            this.button23.Location = new System.Drawing.Point(571, 78);
            this.button23.Name = "button23";
            this.button23.Size = new System.Drawing.Size(60, 43);
            this.button23.TabIndex = 8;
            this.button23.Text = "3px";
            this.button23.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button23.UseVisualStyleBackColor = true;
            this.button23.Click += new System.EventHandler(this.button23_Click);
            // 
            // button21
            // 
            this.button21.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button21.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.button21.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button21.Image = global::MyPaint.Properties.Resources.line__2_;
            this.button21.Location = new System.Drawing.Point(571, 23);
            this.button21.Name = "button21";
            this.button21.Size = new System.Drawing.Size(60, 43);
            this.button21.TabIndex = 8;
            this.button21.Text = "1px";
            this.button21.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button21.UseVisualStyleBackColor = true;
            this.button21.Click += new System.EventHandler(this.button21_Click);
            // 
            // button6
            // 
            this.button6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button6.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.button6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button6.Image = global::MyPaint.Properties.Resources.magnifier;
            this.button6.Location = new System.Drawing.Point(122, 74);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(43, 46);
            this.button6.TabIndex = 7;
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button5.Image = global::MyPaint.Properties.Resources.color_picker;
            this.button5.Location = new System.Drawing.Point(73, 74);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(43, 46);
            this.button5.TabIndex = 7;
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button4.Image = global::MyPaint.Properties.Resources.eraser;
            this.button4.Location = new System.Drawing.Point(24, 74);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(43, 46);
            this.button4.TabIndex = 7;
            this.button4.UseVisualStyleBackColor = true;
            // 
            // btnRightTriangle
            // 
            this.btnRightTriangle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnRightTriangle.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnRightTriangle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnRightTriangle.Image = global::MyPaint.Properties.Resources.triangle__3_;
            this.btnRightTriangle.Location = new System.Drawing.Point(285, 11);
            this.btnRightTriangle.Name = "btnRightTriangle";
            this.btnRightTriangle.Size = new System.Drawing.Size(43, 46);
            this.btnRightTriangle.TabIndex = 7;
            this.btnRightTriangle.UseVisualStyleBackColor = true;
            this.btnRightTriangle.Click += new System.EventHandler(this.btnRightTriangle_Click);
            // 
            // rbTriangle
            // 
            this.rbTriangle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.rbTriangle.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.rbTriangle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.rbTriangle.Image = global::MyPaint.Properties.Resources.triangle__2_;
            this.rbTriangle.Location = new System.Drawing.Point(236, 11);
            this.rbTriangle.Name = "rbTriangle";
            this.rbTriangle.Size = new System.Drawing.Size(43, 46);
            this.rbTriangle.TabIndex = 7;
            this.rbTriangle.UseVisualStyleBackColor = true;
            this.rbTriangle.Click += new System.EventHandler(this.rbTriangle_Click);
            // 
            // btnRoundedRect
            // 
            this.btnRoundedRect.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnRoundedRect.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnRoundedRect.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnRoundedRect.Image = global::MyPaint.Properties.Resources.rounded_rectangle;
            this.btnRoundedRect.Location = new System.Drawing.Point(187, 11);
            this.btnRoundedRect.Name = "btnRoundedRect";
            this.btnRoundedRect.Size = new System.Drawing.Size(43, 46);
            this.btnRoundedRect.TabIndex = 7;
            this.btnRoundedRect.UseVisualStyleBackColor = true;
            this.btnRoundedRect.Click += new System.EventHandler(this.btnRoundedRect_Click);
            // 
            // rbRectangle2
            // 
            this.rbRectangle2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.rbRectangle2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.rbRectangle2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.rbRectangle2.Image = global::MyPaint.Properties.Resources.rectangle;
            this.rbRectangle2.Location = new System.Drawing.Point(138, 11);
            this.rbRectangle2.Name = "rbRectangle2";
            this.rbRectangle2.Size = new System.Drawing.Size(43, 46);
            this.rbRectangle2.TabIndex = 7;
            this.rbRectangle2.UseVisualStyleBackColor = true;
            this.rbRectangle2.Click += new System.EventHandler(this.rbRectangle2_Click);
            // 
            // rdCircle
            // 
            this.rdCircle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.rdCircle.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.rdCircle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.rdCircle.Image = global::MyPaint.Properties.Resources.circle;
            this.rdCircle.Location = new System.Drawing.Point(89, 10);
            this.rdCircle.Name = "rdCircle";
            this.rdCircle.Size = new System.Drawing.Size(43, 46);
            this.rdCircle.TabIndex = 7;
            this.rdCircle.UseVisualStyleBackColor = true;
            this.rdCircle.Click += new System.EventHandler(this.rdCircle_Click);
            // 
            // btnRightArround
            // 
            this.btnRightArround.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnRightArround.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnRightArround.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnRightArround.Image = global::MyPaint.Properties.Resources.right_arrow;
            this.btnRightArround.Location = new System.Drawing.Point(138, 62);
            this.btnRightArround.Name = "btnRightArround";
            this.btnRightArround.Size = new System.Drawing.Size(43, 46);
            this.btnRightArround.TabIndex = 7;
            this.btnRightArround.UseVisualStyleBackColor = true;
            this.btnRightArround.Click += new System.EventHandler(this.btnRightArround_Click);
            // 
            // btnDownArrow
            // 
            this.btnDownArrow.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnDownArrow.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnDownArrow.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnDownArrow.Image = global::MyPaint.Properties.Resources.down_arrow;
            this.btnDownArrow.Location = new System.Drawing.Point(285, 60);
            this.btnDownArrow.Name = "btnDownArrow";
            this.btnDownArrow.Size = new System.Drawing.Size(43, 46);
            this.btnDownArrow.TabIndex = 7;
            this.btnDownArrow.UseVisualStyleBackColor = true;
            this.btnDownArrow.Click += new System.EventHandler(this.btnDownArrow_Click);
            // 
            // btnUpArrow
            // 
            this.btnUpArrow.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnUpArrow.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnUpArrow.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnUpArrow.Image = global::MyPaint.Properties.Resources.up_arrow;
            this.btnUpArrow.Location = new System.Drawing.Point(236, 62);
            this.btnUpArrow.Name = "btnUpArrow";
            this.btnUpArrow.Size = new System.Drawing.Size(43, 46);
            this.btnUpArrow.TabIndex = 7;
            this.btnUpArrow.UseVisualStyleBackColor = true;
            this.btnUpArrow.Click += new System.EventHandler(this.btnUpArrow_Click);
            // 
            // btnLeftArround
            // 
            this.btnLeftArround.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnLeftArround.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnLeftArround.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnLeftArround.Image = global::MyPaint.Properties.Resources.left_arrow;
            this.btnLeftArround.Location = new System.Drawing.Point(187, 63);
            this.btnLeftArround.Name = "btnLeftArround";
            this.btnLeftArround.Size = new System.Drawing.Size(43, 46);
            this.btnLeftArround.TabIndex = 7;
            this.btnLeftArround.UseVisualStyleBackColor = true;
            this.btnLeftArround.Click += new System.EventHandler(this.btnLeftArround_Click);
            // 
            // btnPentagon
            // 
            this.btnPentagon.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnPentagon.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnPentagon.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnPentagon.Image = global::MyPaint.Properties.Resources.shape;
            this.btnPentagon.Location = new System.Drawing.Point(89, 62);
            this.btnPentagon.Name = "btnPentagon";
            this.btnPentagon.Size = new System.Drawing.Size(43, 46);
            this.btnPentagon.TabIndex = 7;
            this.btnPentagon.UseVisualStyleBackColor = true;
            this.btnPentagon.Click += new System.EventHandler(this.btnPentagon_Click);
            // 
            // btndiamond
            // 
            this.btndiamond.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btndiamond.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btndiamond.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btndiamond.Image = global::MyPaint.Properties.Resources.diamond__2_;
            this.btndiamond.Location = new System.Drawing.Point(40, 60);
            this.btndiamond.Name = "btndiamond";
            this.btndiamond.Size = new System.Drawing.Size(43, 46);
            this.btndiamond.TabIndex = 7;
            this.btndiamond.UseVisualStyleBackColor = true;
            this.btndiamond.Click += new System.EventHandler(this.btndiamond_Click);
            // 
            // btnLine
            // 
            this.btnLine.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnLine.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnLine.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnLine.Image = global::MyPaint.Properties.Resources.line;
            this.btnLine.Location = new System.Drawing.Point(40, 10);
            this.btnLine.Name = "btnLine";
            this.btnLine.Size = new System.Drawing.Size(43, 46);
            this.btnLine.TabIndex = 7;
            this.btnLine.UseVisualStyleBackColor = true;
            this.btnLine.Click += new System.EventHandler(this.btnLine_Click);
            // 
            // button3
            // 
            this.button3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button3.Image = global::MyPaint.Properties.Resources.a;
            this.button3.Location = new System.Drawing.Point(122, 22);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(43, 46);
            this.button3.TabIndex = 7;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button2.Image = global::MyPaint.Properties.Resources.pen;
            this.button2.Location = new System.Drawing.Point(73, 22);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(43, 46);
            this.button2.TabIndex = 7;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button1.Image = global::MyPaint.Properties.Resources.pen;
            this.button1.Location = new System.Drawing.Point(24, 22);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(43, 46);
            this.button1.TabIndex = 7;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // pic
            // 
            this.pic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pic.Location = new System.Drawing.Point(-68, 214);
            this.pic.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pic.Name = "pic";
            this.pic.Size = new System.Drawing.Size(2366, 746);
            this.pic.TabIndex = 0;
            this.pic.TabStop = false;
            this.pic.MouseDown += new System.Windows.Forms.MouseEventHandler(this.drawing_MouseDown);
            this.pic.MouseMove += new System.Windows.Forms.MouseEventHandler(this.drawing_MouseMove);
            this.pic.MouseUp += new System.Windows.Forms.MouseEventHandler(this.drawing_MouseUp);
            // 
            // button26
            // 
            this.button26.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button26.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.button26.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button26.Location = new System.Drawing.Point(723, 148);
            this.button26.Name = "button26";
            this.button26.Size = new System.Drawing.Size(100, 28);
            this.button26.TabIndex = 10;
            this.button26.Text = "New";
            this.button26.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(13, 11);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(165, 138);
            this.panel1.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(56, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "Tools";
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.btnDownArrow);
            this.panel2.Controls.Add(this.rdCircle);
            this.panel2.Controls.Add(this.rbRectangle2);
            this.panel2.Controls.Add(this.btnRoundedRect);
            this.panel2.Controls.Add(this.rbTriangle);
            this.panel2.Controls.Add(this.btnRightTriangle);
            this.panel2.Controls.Add(this.btnUpArrow);
            this.panel2.Controls.Add(this.btnLeftArround);
            this.panel2.Controls.Add(this.btnLine);
            this.panel2.Controls.Add(this.btndiamond);
            this.panel2.Controls.Add(this.btnPentagon);
            this.panel2.Controls.Add(this.btnRightArround);
            this.panel2.Location = new System.Drawing.Point(193, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(364, 137);
            this.panel2.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(152, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "Shapes";
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(563, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(142, 138);
            this.panel3.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(46, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 20);
            this.label3.TabIndex = 14;
            this.label3.Text = "Size";
            // 
            // panel4
            // 
            this.panel4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel4.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.colorDialog);
            this.panel4.Location = new System.Drawing.Point(1087, 97);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(96, 102);
            this.panel4.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(23, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 20);
            this.label4.TabIndex = 15;
            this.label4.Text = "Color";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // panel5
            // 
            this.panel5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel5.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel5.Controls.Add(this.label5);
            this.panel5.Controls.Add(this.brush);
            this.panel5.Location = new System.Drawing.Point(957, 97);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(113, 102);
            this.panel5.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(8, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 20);
            this.label5.TabIndex = 15;
            this.label5.Text = "Brush Color";
            this.label5.Click += new System.EventHandler(this.label4_Click);
            // 
            // brush
            // 
            this.brush.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.brush.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.brush.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.brush.Image = global::MyPaint.Properties.Resources.colors__1_;
            this.brush.Location = new System.Drawing.Point(12, 4);
            this.brush.Name = "brush";
            this.brush.Size = new System.Drawing.Size(86, 66);
            this.brush.TabIndex = 9;
            this.brush.UseVisualStyleBackColor = true;
            this.brush.Click += new System.EventHandler(this.brush_Click);
            // 
            // rdpattern
            // 
            this.rdpattern.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rdpattern.AutoSize = true;
            this.rdpattern.Location = new System.Drawing.Point(30, 23);
            this.rdpattern.Name = "rdpattern";
            this.rdpattern.Size = new System.Drawing.Size(70, 20);
            this.rdpattern.TabIndex = 15;
            this.rdpattern.TabStop = true;
            this.rdpattern.Text = "Pattern";
            this.rdpattern.UseVisualStyleBackColor = true;
            // 
            // rdNoPattern
            // 
            this.rdNoPattern.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rdNoPattern.AutoSize = true;
            this.rdNoPattern.Location = new System.Drawing.Point(30, 54);
            this.rdNoPattern.Name = "rdNoPattern";
            this.rdNoPattern.Size = new System.Drawing.Size(91, 20);
            this.rdNoPattern.TabIndex = 16;
            this.rdNoPattern.TabStop = true;
            this.rdNoPattern.Text = "No Pattern";
            this.rdNoPattern.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.rdpattern);
            this.groupBox3.Controls.Add(this.rdNoPattern);
            this.groupBox3.Location = new System.Drawing.Point(957, 14);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(0);
            this.groupBox3.Size = new System.Drawing.Size(131, 77);
            this.groupBox3.TabIndex = 17;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Pattern";
            // 
            // GraphicForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1220, 614);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.button26);
            this.Controls.Add(this.button22);
            this.Controls.Add(this.button24);
            this.Controls.Add(this.button23);
            this.Controls.Add(this.button21);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pic);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "GraphicForm";
            this.Text = " ";
            this.Load += new System.EventHandler(this.GraphicForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pic;
        private System.Windows.Forms.RadioButton rbRectangle;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbCircle;
        private System.Windows.Forms.RadioButton rbVector;
        private System.Windows.Forms.RadioButton rbPoint;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button btnLine;
        private System.Windows.Forms.Button rdCircle;
        private System.Windows.Forms.Button rbRectangle2;
        private System.Windows.Forms.Button btnRoundedRect;
        private System.Windows.Forms.Button rbTriangle;
        private System.Windows.Forms.Button btnRightTriangle;
        private System.Windows.Forms.Button btndiamond;
        private System.Windows.Forms.Button btnPentagon;
        private System.Windows.Forms.Button btnLeftArround;
        private System.Windows.Forms.Button btnRightArround;
        private System.Windows.Forms.Button btnUpArrow;
        private System.Windows.Forms.Button btnDownArrow;
        private System.Windows.Forms.Button button21;
        private System.Windows.Forms.Button button22;
        private System.Windows.Forms.Button button23;
        private System.Windows.Forms.Button button24;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button colorDialog;
        private System.Windows.Forms.Button button26;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button brush;
        private System.Windows.Forms.ColorDialog colorDialog2;
        private System.Windows.Forms.RadioButton rdpattern;
        private System.Windows.Forms.RadioButton rdNoPattern;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}

