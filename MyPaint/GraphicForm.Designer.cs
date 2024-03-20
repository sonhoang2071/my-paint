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
            this.btnSave = new System.Windows.Forms.Button();
            this.borderColor = new System.Windows.Forms.ColorDialog();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rbRectangle = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDownArrow = new System.Windows.Forms.Button();
            this.rdCircle = new System.Windows.Forms.Button();
            this.rbRectangle2 = new System.Windows.Forms.Button();
            this.rbTriangle = new System.Windows.Forms.Button();
            this.btnRightTriangle = new System.Windows.Forms.Button();
            this.btnUpArrow = new System.Windows.Forms.Button();
            this.btnLeftArround = new System.Windows.Forms.Button();
            this.btnLine = new System.Windows.Forms.Button();
            this.btndiamond = new System.Windows.Forms.Button();
            this.btnPentagon = new System.Windows.Forms.Button();
            this.btnRightArround = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.border = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.brush = new System.Windows.Forms.Button();
            this.brushColor = new System.Windows.Forms.ColorDialog();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rdPatternFill = new System.Windows.Forms.RadioButton();
            this.rdFullFill = new System.Windows.Forms.RadioButton();
            this.rdNoFill = new System.Windows.Forms.RadioButton();
            this.btnRedo = new System.Windows.Forms.Button();
            this.btnUndo = new System.Windows.Forms.Button();
            this.btnSize2 = new System.Windows.Forms.Button();
            this.btnSize4 = new System.Windows.Forms.Button();
            this.btnSize3 = new System.Windows.Forms.Button();
            this.btnSize1 = new System.Windows.Forms.Button();
            this.pic = new System.Windows.Forms.PictureBox();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSave.Location = new System.Drawing.Point(1176, 16);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 28);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnRefresh.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnRefresh.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnRefresh.Location = new System.Drawing.Point(1176, 53);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(100, 28);
            this.btnRefresh.TabIndex = 10;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel2.Controls.Add(this.rbRectangle);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.btnDownArrow);
            this.panel2.Controls.Add(this.rdCircle);
            this.panel2.Controls.Add(this.rbRectangle2);
            this.panel2.Controls.Add(this.rbTriangle);
            this.panel2.Controls.Add(this.btnRightTriangle);
            this.panel2.Controls.Add(this.btnUpArrow);
            this.panel2.Controls.Add(this.btnLeftArround);
            this.panel2.Controls.Add(this.btnLine);
            this.panel2.Controls.Add(this.btndiamond);
            this.panel2.Controls.Add(this.btnPentagon);
            this.panel2.Controls.Add(this.btnRightArround);
            this.panel2.Location = new System.Drawing.Point(172, 16);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(364, 137);
            this.panel2.TabIndex = 12;
            // 
            // rbRectangle
            // 
            this.rbRectangle.Image = global::MyPaint.Properties.Resources.square;
            this.rbRectangle.Location = new System.Drawing.Point(188, 10);
            this.rbRectangle.Margin = new System.Windows.Forms.Padding(4);
            this.rbRectangle.Name = "rbRectangle";
            this.rbRectangle.Size = new System.Drawing.Size(43, 48);
            this.rbRectangle.TabIndex = 14;
            this.rbRectangle.UseVisualStyleBackColor = true;
            this.rbRectangle.Click += new System.EventHandler(this.rbRectangle_Click);
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
            // btnDownArrow
            // 
            this.btnDownArrow.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnDownArrow.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnDownArrow.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnDownArrow.Image = global::MyPaint.Properties.Resources.down_arrow;
            this.btnDownArrow.Location = new System.Drawing.Point(285, 60);
            this.btnDownArrow.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDownArrow.Name = "btnDownArrow";
            this.btnDownArrow.Size = new System.Drawing.Size(43, 46);
            this.btnDownArrow.TabIndex = 7;
            this.btnDownArrow.UseVisualStyleBackColor = true;
            this.btnDownArrow.Click += new System.EventHandler(this.btnDownArrow_Click);
            // 
            // rdCircle
            // 
            this.rdCircle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.rdCircle.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.rdCircle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.rdCircle.Image = global::MyPaint.Properties.Resources.circle;
            this.rdCircle.Location = new System.Drawing.Point(89, 10);
            this.rdCircle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdCircle.Name = "rdCircle";
            this.rdCircle.Size = new System.Drawing.Size(43, 46);
            this.rdCircle.TabIndex = 7;
            this.rdCircle.UseVisualStyleBackColor = true;
            this.rdCircle.Click += new System.EventHandler(this.rdCircle_Click);
            // 
            // rbRectangle2
            // 
            this.rbRectangle2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.rbRectangle2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.rbRectangle2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.rbRectangle2.Image = global::MyPaint.Properties.Resources.rectangle;
            this.rbRectangle2.Location = new System.Drawing.Point(139, 11);
            this.rbRectangle2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbRectangle2.Name = "rbRectangle2";
            this.rbRectangle2.Size = new System.Drawing.Size(43, 46);
            this.rbRectangle2.TabIndex = 7;
            this.rbRectangle2.UseVisualStyleBackColor = true;
            this.rbRectangle2.Click += new System.EventHandler(this.rbRectangle2_Click);
            // 
            // rbTriangle
            // 
            this.rbTriangle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.rbTriangle.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.rbTriangle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.rbTriangle.Image = global::MyPaint.Properties.Resources.triangle__2_;
            this.rbTriangle.Location = new System.Drawing.Point(236, 9);
            this.rbTriangle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbTriangle.Name = "rbTriangle";
            this.rbTriangle.Size = new System.Drawing.Size(43, 46);
            this.rbTriangle.TabIndex = 7;
            this.rbTriangle.UseVisualStyleBackColor = true;
            this.rbTriangle.Click += new System.EventHandler(this.rbTriangle_Click);
            // 
            // btnRightTriangle
            // 
            this.btnRightTriangle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnRightTriangle.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnRightTriangle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnRightTriangle.Image = global::MyPaint.Properties.Resources.right_triangle;
            this.btnRightTriangle.Location = new System.Drawing.Point(284, 9);
            this.btnRightTriangle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRightTriangle.Name = "btnRightTriangle";
            this.btnRightTriangle.Size = new System.Drawing.Size(43, 46);
            this.btnRightTriangle.TabIndex = 7;
            this.btnRightTriangle.UseVisualStyleBackColor = true;
            this.btnRightTriangle.Click += new System.EventHandler(this.btnRightTriangle_Click);
            // 
            // btnUpArrow
            // 
            this.btnUpArrow.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnUpArrow.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnUpArrow.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnUpArrow.Image = global::MyPaint.Properties.Resources.up_arrow;
            this.btnUpArrow.Location = new System.Drawing.Point(236, 62);
            this.btnUpArrow.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.btnLeftArround.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLeftArround.Name = "btnLeftArround";
            this.btnLeftArround.Size = new System.Drawing.Size(43, 46);
            this.btnLeftArround.TabIndex = 7;
            this.btnLeftArround.UseVisualStyleBackColor = true;
            this.btnLeftArround.Click += new System.EventHandler(this.btnLeftArround_Click);
            // 
            // btnLine
            // 
            this.btnLine.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnLine.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnLine.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnLine.Image = global::MyPaint.Properties.Resources.line;
            this.btnLine.Location = new System.Drawing.Point(40, 10);
            this.btnLine.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLine.Name = "btnLine";
            this.btnLine.Size = new System.Drawing.Size(43, 46);
            this.btnLine.TabIndex = 7;
            this.btnLine.UseVisualStyleBackColor = true;
            this.btnLine.Click += new System.EventHandler(this.btnLine_Click);
            // 
            // btndiamond
            // 
            this.btndiamond.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btndiamond.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btndiamond.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btndiamond.Image = global::MyPaint.Properties.Resources.diamond__2_;
            this.btndiamond.Location = new System.Drawing.Point(40, 60);
            this.btndiamond.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btndiamond.Name = "btndiamond";
            this.btndiamond.Size = new System.Drawing.Size(43, 46);
            this.btndiamond.TabIndex = 7;
            this.btndiamond.UseVisualStyleBackColor = true;
            this.btndiamond.Click += new System.EventHandler(this.btndiamond_Click);
            // 
            // btnPentagon
            // 
            this.btnPentagon.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnPentagon.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnPentagon.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnPentagon.Image = global::MyPaint.Properties.Resources.shape;
            this.btnPentagon.Location = new System.Drawing.Point(89, 62);
            this.btnPentagon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPentagon.Name = "btnPentagon";
            this.btnPentagon.Size = new System.Drawing.Size(43, 46);
            this.btnPentagon.TabIndex = 7;
            this.btnPentagon.UseVisualStyleBackColor = true;
            this.btnPentagon.Click += new System.EventHandler(this.btnPentagon_Click);
            // 
            // btnRightArround
            // 
            this.btnRightArround.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnRightArround.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnRightArround.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnRightArround.Image = global::MyPaint.Properties.Resources.right_arrow;
            this.btnRightArround.Location = new System.Drawing.Point(139, 62);
            this.btnRightArround.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRightArround.Name = "btnRightArround";
            this.btnRightArround.Size = new System.Drawing.Size(43, 46);
            this.btnRightArround.TabIndex = 7;
            this.btnRightArround.UseVisualStyleBackColor = true;
            this.btnRightArround.Click += new System.EventHandler(this.btnRightArround_Click);
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(570, 16);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(141, 138);
            this.panel3.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(45, 112);
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
            this.panel4.Controls.Add(this.border);
            this.panel4.Location = new System.Drawing.Point(871, 16);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.label4.Location = new System.Drawing.Point(13, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 20);
            this.label4.TabIndex = 15;
            this.label4.Text = "Border";
            // 
            // border
            // 
            this.border.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.border.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.border.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.border.Image = global::MyPaint.Properties.Resources.colors__1_;
            this.border.Location = new System.Drawing.Point(12, 2);
            this.border.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.border.Name = "border";
            this.border.Size = new System.Drawing.Size(69, 66);
            this.border.TabIndex = 9;
            this.border.UseVisualStyleBackColor = true;
            this.border.Click += new System.EventHandler(this.border_Click);
            // 
            // panel5
            // 
            this.panel5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel5.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel5.Controls.Add(this.label5);
            this.panel5.Controls.Add(this.brush);
            this.panel5.Location = new System.Drawing.Point(741, 16);
            this.panel5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.label5.Location = new System.Drawing.Point(25, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 20);
            this.label5.TabIndex = 15;
            this.label5.Text = "Brush";
            // 
            // brush
            // 
            this.brush.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.brush.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.brush.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.brush.Image = global::MyPaint.Properties.Resources.colors__1_;
            this.brush.Location = new System.Drawing.Point(12, 4);
            this.brush.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.brush.Name = "brush";
            this.brush.Size = new System.Drawing.Size(85, 66);
            this.brush.TabIndex = 9;
            this.brush.UseVisualStyleBackColor = true;
            this.brush.Click += new System.EventHandler(this.brush_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.rdPatternFill);
            this.groupBox3.Controls.Add(this.rdFullFill);
            this.groupBox3.Controls.Add(this.rdNoFill);
            this.groupBox3.Location = new System.Drawing.Point(999, 11);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(0);
            this.groupBox3.Size = new System.Drawing.Size(139, 128);
            this.groupBox3.TabIndex = 17;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Type Fill";
            // 
            // rdPatternFill
            // 
            this.rdPatternFill.AutoSize = true;
            this.rdPatternFill.Location = new System.Drawing.Point(15, 77);
            this.rdPatternFill.Name = "rdPatternFill";
            this.rdPatternFill.Size = new System.Drawing.Size(90, 20);
            this.rdPatternFill.TabIndex = 2;
            this.rdPatternFill.Text = "Pattern Fill";
            this.rdPatternFill.UseVisualStyleBackColor = true;
            this.rdPatternFill.CheckedChanged += new System.EventHandler(this.rdPatternFill_CheckedChanged);
            // 
            // rdFullFill
            // 
            this.rdFullFill.AutoSize = true;
            this.rdFullFill.Location = new System.Drawing.Point(15, 51);
            this.rdFullFill.Name = "rdFullFill";
            this.rdFullFill.Size = new System.Drawing.Size(66, 20);
            this.rdFullFill.TabIndex = 1;
            this.rdFullFill.Text = "FullFill";
            this.rdFullFill.UseVisualStyleBackColor = true;
            this.rdFullFill.CheckedChanged += new System.EventHandler(this.rdFullFill_CheckedChanged);
            // 
            // rdNoFill
            // 
            this.rdNoFill.AutoSize = true;
            this.rdNoFill.Checked = true;
            this.rdNoFill.Location = new System.Drawing.Point(15, 25);
            this.rdNoFill.Name = "rdNoFill";
            this.rdNoFill.Size = new System.Drawing.Size(63, 20);
            this.rdNoFill.TabIndex = 0;
            this.rdNoFill.TabStop = true;
            this.rdNoFill.Text = "NoFill";
            this.rdNoFill.UseVisualStyleBackColor = true;
            this.rdNoFill.CheckedChanged += new System.EventHandler(this.rdNoFill_CheckedChanged);
            // 
            // btnRedo
            // 
            this.btnRedo.BackColor = System.Drawing.SystemColors.Window;
            this.btnRedo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnRedo.Image = global::MyPaint.Properties.Resources.redo;
            this.btnRedo.Location = new System.Drawing.Point(107, 47);
            this.btnRedo.Name = "btnRedo";
            this.btnRedo.Size = new System.Drawing.Size(39, 39);
            this.btnRedo.TabIndex = 19;
            this.btnRedo.UseVisualStyleBackColor = false;
            this.btnRedo.Click += new System.EventHandler(this.btnRedo_Click);
            // 
            // btnUndo
            // 
            this.btnUndo.Image = global::MyPaint.Properties.Resources.undo;
            this.btnUndo.Location = new System.Drawing.Point(53, 47);
            this.btnUndo.Name = "btnUndo";
            this.btnUndo.Size = new System.Drawing.Size(39, 39);
            this.btnUndo.TabIndex = 18;
            this.btnUndo.UseVisualStyleBackColor = true;
            this.btnUndo.Click += new System.EventHandler(this.btnUndo_Click);
            // 
            // btnSize2
            // 
            this.btnSize2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSize2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnSize2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnSize2.Image = global::MyPaint.Properties.Resources.line__2_;
            this.btnSize2.Location = new System.Drawing.Point(645, 27);
            this.btnSize2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSize2.Name = "btnSize2";
            this.btnSize2.Size = new System.Drawing.Size(60, 43);
            this.btnSize2.TabIndex = 8;
            this.btnSize2.Text = "2px";
            this.btnSize2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSize2.UseVisualStyleBackColor = true;
            this.btnSize2.Click += new System.EventHandler(this.btnSize2_Click);
            // 
            // btnSize4
            // 
            this.btnSize4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSize4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnSize4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnSize4.Image = global::MyPaint.Properties.Resources.line__2_;
            this.btnSize4.Location = new System.Drawing.Point(645, 81);
            this.btnSize4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSize4.Name = "btnSize4";
            this.btnSize4.Size = new System.Drawing.Size(60, 43);
            this.btnSize4.TabIndex = 8;
            this.btnSize4.Text = "4px";
            this.btnSize4.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSize4.UseVisualStyleBackColor = true;
            this.btnSize4.Click += new System.EventHandler(this.btnSize4_Click);
            // 
            // btnSize3
            // 
            this.btnSize3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSize3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnSize3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnSize3.Image = global::MyPaint.Properties.Resources.line__2_;
            this.btnSize3.Location = new System.Drawing.Point(578, 81);
            this.btnSize3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSize3.Name = "btnSize3";
            this.btnSize3.Size = new System.Drawing.Size(60, 43);
            this.btnSize3.TabIndex = 8;
            this.btnSize3.Text = "3px";
            this.btnSize3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSize3.UseVisualStyleBackColor = true;
            this.btnSize3.Click += new System.EventHandler(this.btnSize3_Click);
            // 
            // btnSize1
            // 
            this.btnSize1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSize1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnSize1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnSize1.Image = global::MyPaint.Properties.Resources.line__2_;
            this.btnSize1.Location = new System.Drawing.Point(578, 27);
            this.btnSize1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSize1.Name = "btnSize1";
            this.btnSize1.Size = new System.Drawing.Size(60, 43);
            this.btnSize1.TabIndex = 8;
            this.btnSize1.Text = "1px";
            this.btnSize1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSize1.UseVisualStyleBackColor = true;
            this.btnSize1.Click += new System.EventHandler(this.btnSize1_Click);
            // 
            // pic
            // 
            this.pic.BackColor = System.Drawing.SystemColors.Window;
            this.pic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pic.Location = new System.Drawing.Point(12, 157);
            this.pic.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pic.Name = "pic";
            this.pic.Size = new System.Drawing.Size(1312, 593);
            this.pic.TabIndex = 0;
            this.pic.TabStop = false;
            this.pic.MouseDown += new System.Windows.Forms.MouseEventHandler(this.drawing_MouseDown);
            this.pic.MouseMove += new System.Windows.Forms.MouseEventHandler(this.drawing_MouseMove);
            this.pic.MouseUp += new System.Windows.Forms.MouseEventHandler(this.drawing_MouseUp);
            // 
            // GraphicForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1336, 761);
            this.Controls.Add(this.btnRedo);
            this.Controls.Add(this.btnUndo);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnSize2);
            this.Controls.Add(this.btnSize4);
            this.Controls.Add(this.btnSize3);
            this.Controls.Add(this.btnSize1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.pic);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "GraphicForm";
            this.Text = " ";
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
            ((System.ComponentModel.ISupportInitialize)(this.pic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pic;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnLine;
        private System.Windows.Forms.Button rdCircle;
        private System.Windows.Forms.Button rbRectangle2;
        private System.Windows.Forms.Button rbTriangle;
        private System.Windows.Forms.Button btnRightTriangle;
        private System.Windows.Forms.Button btndiamond;
        private System.Windows.Forms.Button btnPentagon;
        private System.Windows.Forms.Button btnLeftArround;
        private System.Windows.Forms.Button btnRightArround;
        private System.Windows.Forms.Button btnUpArrow;
        private System.Windows.Forms.Button btnDownArrow;
        private System.Windows.Forms.Button btnSize1;
        private System.Windows.Forms.Button btnSize2;
        private System.Windows.Forms.Button btnSize3;
        private System.Windows.Forms.Button btnSize4;
        private System.Windows.Forms.ColorDialog borderColor;
        private System.Windows.Forms.Button border;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button brush;
        private System.Windows.Forms.ColorDialog brushColor;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button rbRectangle;
        private System.Windows.Forms.Button btnUndo;
        private System.Windows.Forms.Button btnRedo;
        private System.Windows.Forms.RadioButton rdPatternFill;
        private System.Windows.Forms.RadioButton rdFullFill;
        private System.Windows.Forms.RadioButton rdNoFill;
    }
}

