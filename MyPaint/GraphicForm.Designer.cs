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
            this.button26 = new System.Windows.Forms.Button();
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
            this.colorDialog = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.brush = new System.Windows.Forms.Button();
            this.brushColor = new System.Windows.Forms.ColorDialog();
            this.rdPatternFill = new System.Windows.Forms.RadioButton();
            this.rdNoFill = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rdFullFill = new System.Windows.Forms.RadioButton();
            this.button22 = new System.Windows.Forms.Button();
            this.button24 = new System.Windows.Forms.Button();
            this.button23 = new System.Windows.Forms.Button();
            this.button21 = new System.Windows.Forms.Button();
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
            this.btnSave.Location = new System.Drawing.Point(1167, 28);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 28);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // button26
            // 
            this.button26.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button26.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.button26.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button26.Location = new System.Drawing.Point(1167, 65);
            this.button26.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button26.Name = "button26";
            this.button26.Size = new System.Drawing.Size(100, 28);
            this.button26.TabIndex = 10;
            this.button26.Text = "Refresh";
            this.button26.UseVisualStyleBackColor = true;
            this.button26.Click += new System.EventHandler(this.button26_Click);
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
            this.panel2.Location = new System.Drawing.Point(102, 14);
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
            this.panel3.Location = new System.Drawing.Point(471, 14);
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
            this.panel4.Controls.Add(this.colorDialog);
            this.panel4.Location = new System.Drawing.Point(818, 14);
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
            // colorDialog
            // 
            this.colorDialog.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.colorDialog.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.colorDialog.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.colorDialog.Image = global::MyPaint.Properties.Resources.colors__1_;
            this.colorDialog.Location = new System.Drawing.Point(12, 2);
            this.colorDialog.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.colorDialog.Name = "colorDialog";
            this.colorDialog.Size = new System.Drawing.Size(69, 66);
            this.colorDialog.TabIndex = 9;
            this.colorDialog.UseVisualStyleBackColor = true;
            this.colorDialog.Click += new System.EventHandler(this.button25_Click);
            // 
            // panel5
            // 
            this.panel5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel5.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel5.Controls.Add(this.label5);
            this.panel5.Controls.Add(this.brush);
            this.panel5.Location = new System.Drawing.Point(688, 14);
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
            // rdPatternFill
            // 
            this.rdPatternFill.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rdPatternFill.AutoSize = true;
            this.rdPatternFill.Location = new System.Drawing.Point(27, 86);
            this.rdPatternFill.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdPatternFill.Name = "rdPatternFill";
            this.rdPatternFill.Size = new System.Drawing.Size(90, 20);
            this.rdPatternFill.TabIndex = 15;
            this.rdPatternFill.TabStop = true;
            this.rdPatternFill.Text = "Pattern Fill";
            this.rdPatternFill.UseVisualStyleBackColor = true;
            this.rdPatternFill.CheckedChanged += new System.EventHandler(this.rdPatternFill_CheckedChanged);
            // 
            // rdNoFill
            // 
            this.rdNoFill.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rdNoFill.AutoSize = true;
            this.rdNoFill.Checked = true;
            this.rdNoFill.Location = new System.Drawing.Point(27, 27);
            this.rdNoFill.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdNoFill.Name = "rdNoFill";
            this.rdNoFill.Size = new System.Drawing.Size(66, 20);
            this.rdNoFill.TabIndex = 16;
            this.rdNoFill.TabStop = true;
            this.rdNoFill.Text = "No Fill";
            this.rdNoFill.UseVisualStyleBackColor = true;
            this.rdNoFill.CheckedChanged += new System.EventHandler(this.rdNoFill_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.rdFullFill);
            this.groupBox3.Controls.Add(this.rdPatternFill);
            this.groupBox3.Controls.Add(this.rdNoFill);
            this.groupBox3.Location = new System.Drawing.Point(953, 14);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(0);
            this.groupBox3.Size = new System.Drawing.Size(147, 128);
            this.groupBox3.TabIndex = 17;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Type Fill";
            // 
            // rdFullFill
            // 
            this.rdFullFill.AutoSize = true;
            this.rdFullFill.Location = new System.Drawing.Point(27, 55);
            this.rdFullFill.Margin = new System.Windows.Forms.Padding(4);
            this.rdFullFill.Name = "rdFullFill";
            this.rdFullFill.Size = new System.Drawing.Size(69, 20);
            this.rdFullFill.TabIndex = 18;
            this.rdFullFill.TabStop = true;
            this.rdFullFill.Text = "Full Fill";
            this.rdFullFill.UseVisualStyleBackColor = true;
            this.rdFullFill.CheckedChanged += new System.EventHandler(this.rdFullFill_CheckedChanged);
            // 
            // button22
            // 
            this.button22.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button22.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.button22.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button22.Image = global::MyPaint.Properties.Resources.line__2_;
            this.button22.Location = new System.Drawing.Point(546, 25);
            this.button22.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.button24.Location = new System.Drawing.Point(546, 79);
            this.button24.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.button23.Location = new System.Drawing.Point(479, 79);
            this.button23.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.button21.Location = new System.Drawing.Point(479, 25);
            this.button21.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button21.Name = "button21";
            this.button21.Size = new System.Drawing.Size(60, 43);
            this.button21.TabIndex = 8;
            this.button21.Text = "1px";
            this.button21.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button21.UseVisualStyleBackColor = true;
            this.button21.Click += new System.EventHandler(this.button21_Click);
            // 
            // pic
            // 
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
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.button26);
            this.Controls.Add(this.button22);
            this.Controls.Add(this.button24);
            this.Controls.Add(this.button23);
            this.Controls.Add(this.button21);
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
        private System.Windows.Forms.Button button21;
        private System.Windows.Forms.Button button22;
        private System.Windows.Forms.Button button23;
        private System.Windows.Forms.Button button24;
        private System.Windows.Forms.ColorDialog borderColor;
        private System.Windows.Forms.Button colorDialog;
        private System.Windows.Forms.Button button26;
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
        private System.Windows.Forms.RadioButton rdPatternFill;
        private System.Windows.Forms.RadioButton rdNoFill;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rdFullFill;
        private System.Windows.Forms.Button rbRectangle;
    }
}

