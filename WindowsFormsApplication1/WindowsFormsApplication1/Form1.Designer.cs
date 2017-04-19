namespace WindowsFormsApplication1
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.Linebtn = new System.Windows.Forms.Button();
            this.PictureBox = new System.Windows.Forms.PictureBox();
            this.Rectanglebtn = new System.Windows.Forms.Button();
            this.Square = new System.Windows.Forms.Button();
            this.Circle = new System.Windows.Forms.Button();
            this.Ellipse = new System.Windows.Forms.Button();
            this.Clearbtn = new System.Windows.Forms.Button();
            this.Triangle = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // Linebtn
            // 
            this.Linebtn.Location = new System.Drawing.Point(3, 3);
            this.Linebtn.Name = "Linebtn";
            this.Linebtn.Size = new System.Drawing.Size(75, 45);
            this.Linebtn.TabIndex = 0;
            this.Linebtn.Text = "Line";
            this.Linebtn.UseVisualStyleBackColor = true;
            this.Linebtn.Click += new System.EventHandler(this.OnClick);
            // 
            // PictureBox
            // 
            this.PictureBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.PictureBox.Location = new System.Drawing.Point(3, 62);
            this.PictureBox.Name = "PictureBox";
            this.PictureBox.Size = new System.Drawing.Size(391, 302);
            this.PictureBox.TabIndex = 1;
            this.PictureBox.TabStop = false;
            this.PictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            // 
            // Rectanglebtn
            // 
            this.Rectanglebtn.Location = new System.Drawing.Point(408, 3);
            this.Rectanglebtn.Name = "Rectanglebtn";
            this.Rectanglebtn.Size = new System.Drawing.Size(75, 45);
            this.Rectanglebtn.TabIndex = 2;
            this.Rectanglebtn.Text = "Rectangle";
            this.Rectanglebtn.UseVisualStyleBackColor = true;
            this.Rectanglebtn.Click += new System.EventHandler(this.Rectangle_Click);
            // 
            // Square
            // 
            this.Square.Location = new System.Drawing.Point(327, 3);
            this.Square.Name = "Square";
            this.Square.Size = new System.Drawing.Size(75, 45);
            this.Square.TabIndex = 3;
            this.Square.Text = "Square";
            this.Square.UseVisualStyleBackColor = true;
            this.Square.Click += new System.EventHandler(this.Square_Click);
            // 
            // Circle
            // 
            this.Circle.Location = new System.Drawing.Point(246, 3);
            this.Circle.Name = "Circle";
            this.Circle.Size = new System.Drawing.Size(75, 45);
            this.Circle.TabIndex = 4;
            this.Circle.Text = "Circle";
            this.Circle.UseVisualStyleBackColor = true;
            this.Circle.Click += new System.EventHandler(this.Circle_Click);
            // 
            // Ellipse
            // 
            this.Ellipse.Location = new System.Drawing.Point(84, 3);
            this.Ellipse.Name = "Ellipse";
            this.Ellipse.Size = new System.Drawing.Size(75, 45);
            this.Ellipse.TabIndex = 5;
            this.Ellipse.Text = "Ellipse";
            this.Ellipse.UseVisualStyleBackColor = true;
            this.Ellipse.Click += new System.EventHandler(this.Ellipse_Click);
            // 
            // Clearbtn
            // 
            this.Clearbtn.Location = new System.Drawing.Point(434, 138);
            this.Clearbtn.Name = "Clearbtn";
            this.Clearbtn.Size = new System.Drawing.Size(75, 37);
            this.Clearbtn.TabIndex = 8;
            this.Clearbtn.Text = "Clear";
            this.Clearbtn.UseVisualStyleBackColor = true;
            this.Clearbtn.Click += new System.EventHandler(this.Clearbtn_Click);
            // 
            // Triangle
            // 
            this.Triangle.Location = new System.Drawing.Point(165, 3);
            this.Triangle.Name = "Triangle";
            this.Triangle.Size = new System.Drawing.Size(75, 45);
            this.Triangle.TabIndex = 10;
            this.Triangle.Text = "Triangle";
            this.Triangle.UseVisualStyleBackColor = true;
            this.Triangle.Click += new System.EventHandler(this.Triangle_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(462, 261);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(67, 20);
            this.textBox1.TabIndex = 11;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(580, 376);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Triangle);
            this.Controls.Add(this.Clearbtn);
            this.Controls.Add(this.Ellipse);
            this.Controls.Add(this.Circle);
            this.Controls.Add(this.Square);
            this.Controls.Add(this.Rectanglebtn);
            this.Controls.Add(this.PictureBox);
            this.Controls.Add(this.Linebtn);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "MainForm";
            this.Text = "Лабораторная 2";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Linebtn;
        private System.Windows.Forms.PictureBox PictureBox;
        private System.Windows.Forms.Button Rectanglebtn;
        private System.Windows.Forms.Button Square;
        private System.Windows.Forms.Button Circle;
        private System.Windows.Forms.Button Ellipse;
        private System.Windows.Forms.Button Clearbtn;
        private System.Windows.Forms.Button Triangle;
        private System.Windows.Forms.TextBox textBox1;
    }
}

