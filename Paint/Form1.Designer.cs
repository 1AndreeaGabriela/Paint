namespace Paint
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            BtnSave = new Button();
            BtnClear = new Button();
            BtnLine = new Button();
            BtnRentangle = new Button();
            BtnEllipse = new Button();
            BtnEraser = new Button();
            BtnPencil = new Button();
            BtnPaint = new Button();
            BtnColor = new Button();
            Pic = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Pic).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaptionText;
            panel1.Controls.Add(BtnSave);
            panel1.Controls.Add(BtnClear);
            panel1.Controls.Add(BtnLine);
            panel1.Controls.Add(BtnRentangle);
            panel1.Controls.Add(BtnEllipse);
            panel1.Controls.Add(BtnEraser);
            panel1.Controls.Add(BtnPencil);
            panel1.Controls.Add(BtnPaint);
            panel1.Controls.Add(BtnColor);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1213, 134);
            panel1.TabIndex = 0;
            // 
            // BtnSave
            // 
            BtnSave.Cursor = Cursors.Hand;
            BtnSave.FlatAppearance.MouseDownBackColor = Color.FromArgb(128, 128, 255);
            BtnSave.FlatAppearance.MouseOverBackColor = Color.Blue;
            BtnSave.FlatStyle = FlatStyle.Flat;
            BtnSave.ForeColor = SystemColors.ButtonHighlight;
            BtnSave.Location = new Point(1045, 12);
            BtnSave.Name = "BtnSave";
            BtnSave.Size = new Size(103, 49);
            BtnSave.TabIndex = 8;
            BtnSave.Text = "SAVE";
            BtnSave.UseVisualStyleBackColor = true;
            BtnSave.Click += BtnSave_Click;
            // 
            // BtnClear
            // 
            BtnClear.Cursor = Cursors.Hand;
            BtnClear.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 128, 128);
            BtnClear.FlatAppearance.MouseOverBackColor = Color.Red;
            BtnClear.FlatStyle = FlatStyle.Flat;
            BtnClear.ForeColor = SystemColors.ButtonHighlight;
            BtnClear.Location = new Point(1045, 67);
            BtnClear.Name = "BtnClear";
            BtnClear.Size = new Size(103, 43);
            BtnClear.TabIndex = 7;
            BtnClear.Text = "CLEAR";
            BtnClear.UseVisualStyleBackColor = true;
            BtnClear.Click += BtnClear_Click;
            // 
            // BtnLine
            // 
            BtnLine.BackgroundImage = Properties.Resources.Line_icon;
            BtnLine.BackgroundImageLayout = ImageLayout.Zoom;
            BtnLine.Cursor = Cursors.Hand;
            BtnLine.FlatAppearance.MouseDownBackColor = Color.FromArgb(128, 128, 255);
            BtnLine.FlatAppearance.MouseOverBackColor = Color.Blue;
            BtnLine.FlatStyle = FlatStyle.Flat;
            BtnLine.ForeColor = SystemColors.ButtonHighlight;
            BtnLine.Location = new Point(826, 12);
            BtnLine.Name = "BtnLine";
            BtnLine.Size = new Size(103, 98);
            BtnLine.TabIndex = 6;
            BtnLine.UseVisualStyleBackColor = true;
            BtnLine.Click += BtnLine_Click;
            // 
            // BtnRentangle
            // 
            BtnRentangle.BackgroundImage = Properties.Resources.rectangle_3;
            BtnRentangle.BackgroundImageLayout = ImageLayout.Zoom;
            BtnRentangle.Cursor = Cursors.Hand;
            BtnRentangle.FlatAppearance.MouseDownBackColor = Color.FromArgb(128, 128, 255);
            BtnRentangle.FlatAppearance.MouseOverBackColor = Color.Blue;
            BtnRentangle.FlatStyle = FlatStyle.Flat;
            BtnRentangle.ForeColor = SystemColors.ButtonHighlight;
            BtnRentangle.Location = new Point(707, 12);
            BtnRentangle.Name = "BtnRentangle";
            BtnRentangle.Size = new Size(103, 98);
            BtnRentangle.TabIndex = 5;
            BtnRentangle.UseVisualStyleBackColor = true;
            BtnRentangle.Click += BtnRentangle_Click;
            // 
            // BtnEllipse
            // 
            BtnEllipse.BackgroundImage = Properties.Resources.ellipse;
            BtnEllipse.BackgroundImageLayout = ImageLayout.Zoom;
            BtnEllipse.Cursor = Cursors.Hand;
            BtnEllipse.FlatAppearance.MouseDownBackColor = Color.FromArgb(128, 128, 255);
            BtnEllipse.FlatAppearance.MouseOverBackColor = Color.Blue;
            BtnEllipse.FlatStyle = FlatStyle.Flat;
            BtnEllipse.ForeColor = SystemColors.ButtonHighlight;
            BtnEllipse.Location = new Point(586, 12);
            BtnEllipse.Name = "BtnEllipse";
            BtnEllipse.Size = new Size(103, 98);
            BtnEllipse.TabIndex = 4;
            BtnEllipse.UseVisualStyleBackColor = true;
            BtnEllipse.Click += BtnEllipse_Click;
            // 
            // BtnEraser
            // 
            BtnEraser.BackgroundImage = Properties.Resources.paint_eraser;
            BtnEraser.BackgroundImageLayout = ImageLayout.Zoom;
            BtnEraser.Cursor = Cursors.Hand;
            BtnEraser.FlatAppearance.MouseDownBackColor = Color.FromArgb(128, 128, 255);
            BtnEraser.FlatAppearance.MouseOverBackColor = Color.Blue;
            BtnEraser.FlatStyle = FlatStyle.Flat;
            BtnEraser.ForeColor = SystemColors.ButtonHighlight;
            BtnEraser.Location = new Point(461, 12);
            BtnEraser.Name = "BtnEraser";
            BtnEraser.Size = new Size(103, 98);
            BtnEraser.TabIndex = 3;
            BtnEraser.UseVisualStyleBackColor = true;
            BtnEraser.Click += BtnEraser_Click;
            // 
            // BtnPencil
            // 
            BtnPencil.BackgroundImage = Properties.Resources.paint_pencil;
            BtnPencil.BackgroundImageLayout = ImageLayout.Zoom;
            BtnPencil.Cursor = Cursors.Hand;
            BtnPencil.FlatAppearance.MouseDownBackColor = Color.FromArgb(128, 128, 255);
            BtnPencil.FlatAppearance.MouseOverBackColor = Color.Blue;
            BtnPencil.FlatStyle = FlatStyle.Flat;
            BtnPencil.ForeColor = SystemColors.ButtonHighlight;
            BtnPencil.Location = new Point(334, 12);
            BtnPencil.Name = "BtnPencil";
            BtnPencil.Size = new Size(103, 98);
            BtnPencil.TabIndex = 2;
            BtnPencil.UseVisualStyleBackColor = true;
            BtnPencil.Click += BtnPencil_Click;
            // 
            // BtnPaint
            // 
            BtnPaint.BackgroundImage = Properties.Resources.paint_galeata;
            BtnPaint.BackgroundImageLayout = ImageLayout.Zoom;
            BtnPaint.Cursor = Cursors.Hand;
            BtnPaint.FlatAppearance.MouseDownBackColor = Color.FromArgb(128, 128, 255);
            BtnPaint.FlatAppearance.MouseOverBackColor = Color.Blue;
            BtnPaint.FlatStyle = FlatStyle.Flat;
            BtnPaint.ForeColor = SystemColors.ButtonHighlight;
            BtnPaint.Location = new Point(216, 12);
            BtnPaint.Name = "BtnPaint";
            BtnPaint.Size = new Size(103, 98);
            BtnPaint.TabIndex = 1;
            BtnPaint.UseVisualStyleBackColor = true;
            BtnPaint.Click += BtnPaint_Click;
            // 
            // BtnColor
            // 
            BtnColor.BackgroundImage = Properties.Resources.paint_culori1;
            BtnColor.BackgroundImageLayout = ImageLayout.Zoom;
            BtnColor.Cursor = Cursors.Hand;
            BtnColor.FlatAppearance.MouseDownBackColor = Color.FromArgb(128, 128, 255);
            BtnColor.FlatAppearance.MouseOverBackColor = Color.Blue;
            BtnColor.FlatStyle = FlatStyle.Flat;
            BtnColor.ForeColor = SystemColors.ButtonHighlight;
            BtnColor.Location = new Point(96, 12);
            BtnColor.Name = "BtnColor";
            BtnColor.Size = new Size(103, 98);
            BtnColor.TabIndex = 0;
            BtnColor.UseVisualStyleBackColor = true;
            BtnColor.Click += BtnColor_Click;
            // 
            // Pic
            // 
            Pic.Dock = DockStyle.Fill;
            Pic.Location = new Point(0, 134);
            Pic.Name = "Pic";
            Pic.Size = new Size(1213, 381);
            Pic.TabIndex = 1;
            Pic.TabStop = false;
            Pic.Paint += Pic_Paint;
            Pic.MouseClick += Pic_MouseClick;
            Pic.MouseDown += Pic_MouseDown;
            Pic.MouseMove += Pic_MouseMove;
            Pic.MouseUp += Pic_MouseUp;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1213, 515);
            Controls.Add(Pic);
            Controls.Add(panel1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Paint";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)Pic).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button BtnSave;
        private Button BtnClear;
        private Button BtnLine;
        private Button BtnRentangle;
        private Button BtnEllipse;
        private Button BtnEraser;
        private Button BtnPencil;
        private Button BtnPaint;
        private Button BtnColor;
        private PictureBox Pic;
    }
}