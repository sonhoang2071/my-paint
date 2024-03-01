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
            this.button25 = new System.Windows.Forms.Button();
            this.button22 = new System.Windows.Forms.Button();
            this.button24 = new System.Windows.Forms.Button();
            this.button23 = new System.Windows.Forms.Button();
            this.button21 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.button20 = new System.Windows.Forms.Button();
            this.button19 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
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
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
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
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.rbCircle);
            this.groupBox1.Controls.Add(this.rbRectangle);
            this.groupBox1.Location = new System.Drawing.Point(1058, 11);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(111, 174);
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
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.rbPoint);
            this.groupBox2.Controls.Add(this.rbVector);
            this.groupBox2.Location = new System.Drawing.Point(939, 22);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(111, 103);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Location = new System.Drawing.Point(833, 43);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 28);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // button25
            // 
            this.button25.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button25.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.button25.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button25.Image = global::MyPaint.Properties.Resources.colors__1_;
            this.button25.Location = new System.Drawing.Point(12, 3);
            this.button25.Name = "button25";
            this.button25.Size = new System.Drawing.Size(69, 66);
            this.button25.TabIndex = 9;
            this.button25.UseVisualStyleBackColor = true;
            this.button25.Click += new System.EventHandler(this.button25_Click);
            // 
            // button22
            // 
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
            this.button22.Click += new System.EventHandler(this.button21_Click);
            // 
            // button24
            // 
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
            this.button24.Click += new System.EventHandler(this.button21_Click);
            // 
            // button23
            // 
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
            this.button23.Click += new System.EventHandler(this.button21_Click);
            // 
            // button21
            // 
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
            this.button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button4.Image = global::MyPaint.Properties.Resources.eraser;
            this.button4.Location = new System.Drawing.Point(24, 74);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(43, 46);
            this.button4.TabIndex = 7;
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.button8.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button8.Image = global::MyPaint.Properties.Resources.curve;
            this.button8.Location = new System.Drawing.Point(251, 22);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(43, 46);
            this.button8.TabIndex = 7;
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button14
            // 
            this.button14.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.button14.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button14.Image = global::MyPaint.Properties.Resources.triangle__3_;
            this.button14.Location = new System.Drawing.Point(496, 74);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(43, 46);
            this.button14.TabIndex = 7;
            this.button14.UseVisualStyleBackColor = true;
            // 
            // button13
            // 
            this.button13.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.button13.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button13.Image = global::MyPaint.Properties.Resources.triangle__2_;
            this.button13.Location = new System.Drawing.Point(496, 22);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(43, 46);
            this.button13.TabIndex = 7;
            this.button13.UseVisualStyleBackColor = true;
            // 
            // button12
            // 
            this.button12.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.button12.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button12.Image = global::MyPaint.Properties.Resources.polygon;
            this.button12.Location = new System.Drawing.Point(447, 22);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(43, 46);
            this.button12.TabIndex = 7;
            this.button12.UseVisualStyleBackColor = true;
            // 
            // button11
            // 
            this.button11.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.button11.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button11.Image = global::MyPaint.Properties.Resources.rounded_rectangle;
            this.button11.Location = new System.Drawing.Point(398, 22);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(43, 46);
            this.button11.TabIndex = 7;
            this.button11.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            this.button10.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.button10.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button10.Image = global::MyPaint.Properties.Resources.rectangle;
            this.button10.Location = new System.Drawing.Point(349, 22);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(43, 46);
            this.button10.TabIndex = 7;
            this.button10.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            this.button9.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.button9.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button9.Image = global::MyPaint.Properties.Resources.circle;
            this.button9.Location = new System.Drawing.Point(300, 22);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(43, 46);
            this.button9.TabIndex = 7;
            this.button9.UseVisualStyleBackColor = true;
            // 
            // button18
            // 
            this.button18.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.button18.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button18.Image = global::MyPaint.Properties.Resources.right_arrow;
            this.button18.Location = new System.Drawing.Point(300, 74);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(43, 46);
            this.button18.TabIndex = 7;
            this.button18.UseVisualStyleBackColor = true;
            // 
            // button20
            // 
            this.button20.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.button20.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button20.Image = global::MyPaint.Properties.Resources.down_arrow;
            this.button20.Location = new System.Drawing.Point(447, 74);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(43, 46);
            this.button20.TabIndex = 7;
            this.button20.UseVisualStyleBackColor = true;
            // 
            // button19
            // 
            this.button19.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.button19.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button19.Image = global::MyPaint.Properties.Resources.up_arrow;
            this.button19.Location = new System.Drawing.Point(398, 74);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(43, 46);
            this.button19.TabIndex = 7;
            this.button19.UseVisualStyleBackColor = true;
            // 
            // button17
            // 
            this.button17.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.button17.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button17.Image = global::MyPaint.Properties.Resources.left_arrow;
            this.button17.Location = new System.Drawing.Point(349, 74);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(43, 46);
            this.button17.TabIndex = 7;
            this.button17.UseVisualStyleBackColor = true;
            // 
            // button16
            // 
            this.button16.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.button16.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button16.Image = global::MyPaint.Properties.Resources.shape;
            this.button16.Location = new System.Drawing.Point(251, 74);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(43, 46);
            this.button16.TabIndex = 7;
            this.button16.UseVisualStyleBackColor = true;
            // 
            // button15
            // 
            this.button15.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.button15.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button15.Image = global::MyPaint.Properties.Resources.diamond__2_;
            this.button15.Location = new System.Drawing.Point(202, 74);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(43, 46);
            this.button15.TabIndex = 7;
            this.button15.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.button7.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button7.Image = global::MyPaint.Properties.Resources.line;
            this.button7.Location = new System.Drawing.Point(202, 22);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(43, 46);
            this.button7.TabIndex = 7;
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
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
            this.pic.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pic.Location = new System.Drawing.Point(0, 166);
            this.pic.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pic.Name = "pic";
            this.pic.Size = new System.Drawing.Size(1476, 525);
            this.pic.TabIndex = 0;
            this.pic.TabStop = false;
            this.pic.MouseDown += new System.Windows.Forms.MouseEventHandler(this.drawing_MouseDown);
            this.pic.MouseMove += new System.Windows.Forms.MouseEventHandler(this.drawing_MouseMove);
            this.pic.MouseUp += new System.Windows.Forms.MouseEventHandler(this.drawing_MouseUp);
            // 
            // button26
            // 
            this.button26.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button26.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.button26.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button26.Location = new System.Drawing.Point(833, 83);
            this.button26.Name = "button26";
            this.button26.Size = new System.Drawing.Size(100, 28);
            this.button26.TabIndex = 10;
            this.button26.Text = "New";
            this.button26.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
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
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(193, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(354, 137);
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
            this.panel4.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.button25);
            this.panel4.Location = new System.Drawing.Point(721, 32);
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
            this.label4.Size = new System.Drawing.Size(61, 25);
            this.label4.TabIndex = 15;
            this.label4.Text = "Color";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // GraphicForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1181, 553);
            this.Controls.Add(this.button26);
            this.Controls.Add(this.button22);
            this.Controls.Add(this.button24);
            this.Controls.Add(this.button23);
            this.Controls.Add(this.button21);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button18);
            this.Controls.Add(this.button20);
            this.Controls.Add(this.button19);
            this.Controls.Add(this.button17);
            this.Controls.Add(this.button16);
            this.Controls.Add(this.button15);
            this.Controls.Add(this.button7);
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
            this.Controls.Add(this.panel4);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "GraphicForm";
            this.Text = "GraphicForm";
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
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.Button button19;
        private System.Windows.Forms.Button button20;
        private System.Windows.Forms.Button button21;
        private System.Windows.Forms.Button button22;
        private System.Windows.Forms.Button button23;
        private System.Windows.Forms.Button button24;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button button25;
        private System.Windows.Forms.Button button26;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label4;
    }
}

