namespace oop6
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button_circle = new System.Windows.Forms.Button();
            this.button_square = new System.Windows.Forms.Button();
            this.button_section = new System.Windows.Forms.Button();
            this.button_triangle = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(12, 196);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(267, 56);
            this.trackBar1.TabIndex = 0;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(218, 88);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(46, 20);
            this.checkBox1.TabIndex = 1;
            this.checkBox1.Text = "ctrl";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 70);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(61, 54);
            this.button1.TabIndex = 2;
            this.button1.Text = "+";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(79, 70);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(61, 54);
            this.button2.TabIndex = 3;
            this.button2.Text = "-";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(146, 70);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(66, 54);
            this.button3.TabIndex = 4;
            this.button3.Text = "del";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button_circle
            // 
            this.button_circle.Location = new System.Drawing.Point(79, 10);
            this.button_circle.Name = "button_circle";
            this.button_circle.Size = new System.Drawing.Size(61, 54);
            this.button_circle.TabIndex = 5;
            this.button_circle.Text = "circle";
            this.button_circle.UseVisualStyleBackColor = true;
            this.button_circle.Click += new System.EventHandler(this.button_circle_Click);
            // 
            // button_square
            // 
            this.button_square.Location = new System.Drawing.Point(12, 10);
            this.button_square.Name = "button_square";
            this.button_square.Size = new System.Drawing.Size(61, 54);
            this.button_square.TabIndex = 6;
            this.button_square.Text = "square";
            this.button_square.UseVisualStyleBackColor = true;
            this.button_square.Click += new System.EventHandler(this.button_square_Click);
            // 
            // button_section
            // 
            this.button_section.Location = new System.Drawing.Point(218, 10);
            this.button_section.Name = "button_section";
            this.button_section.Size = new System.Drawing.Size(61, 54);
            this.button_section.TabIndex = 7;
            this.button_section.Text = "-----";
            this.button_section.UseVisualStyleBackColor = true;
            this.button_section.Click += new System.EventHandler(this.button_section_Click);
            // 
            // button_triangle
            // 
            this.button_triangle.Location = new System.Drawing.Point(151, 10);
            this.button_triangle.Name = "button_triangle";
            this.button_triangle.Size = new System.Drawing.Size(61, 54);
            this.button_triangle.TabIndex = 8;
            this.button_triangle.Text = "triangle";
            this.button_triangle.UseVisualStyleBackColor = true;
            this.button_triangle.Click += new System.EventHandler(this.button_triangle_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(12, 136);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(60, 54);
            this.button6.TabIndex = 9;
            this.button6.Text = "color";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(79, 136);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(61, 54);
            this.button4.TabIndex = 10;
            this.button4.Text = "select";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleVioletRed;
            this.ClientSize = new System.Drawing.Size(776, 437);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button_triangle);
            this.Controls.Add(this.button_section);
            this.Controls.Add(this.button_square);
            this.Controls.Add(this.button_circle);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.trackBar1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "shapes";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseClick);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button_circle;
        private System.Windows.Forms.Button button_square;
        private System.Windows.Forms.Button button_section;
        private System.Windows.Forms.Button button_triangle;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button4;
    }
}

