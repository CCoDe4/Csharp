namespace Calculator_v2
{
    partial class Form1
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
            this.calcBox = new System.Windows.Forms.TextBox();
            this.one = new System.Windows.Forms.Button();
            this.two = new System.Windows.Forms.Button();
            this.three = new System.Windows.Forms.Button();
            this.four = new System.Windows.Forms.Button();
            this.five = new System.Windows.Forms.Button();
            this.six = new System.Windows.Forms.Button();
            this.seven = new System.Windows.Forms.Button();
            this.eight = new System.Windows.Forms.Button();
            this.nine = new System.Windows.Forms.Button();
            this.zero = new System.Windows.Forms.Button();
            this.point = new System.Windows.Forms.Button();
            this.devide = new System.Windows.Forms.Button();
            this.c = new System.Windows.Forms.Button();
            this.ce = new System.Windows.Forms.Button();
            this.plus = new System.Windows.Forms.Button();
            this.minus = new System.Windows.Forms.Button();
            this.multiply = new System.Windows.Forms.Button();
            this.result = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // calcBox
            // 
            this.calcBox.Location = new System.Drawing.Point(12, 12);
            this.calcBox.Name = "calcBox";
            this.calcBox.Size = new System.Drawing.Size(182, 20);
            this.calcBox.TabIndex = 0;
            this.calcBox.TextChanged += new System.EventHandler(this.calcBox_TextChanged);
            this.calcBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.calcBox_KeyPress);
            // 
            // one
            // 
            this.one.Location = new System.Drawing.Point(12, 81);
            this.one.Name = "one";
            this.one.Size = new System.Drawing.Size(41, 39);
            this.one.TabIndex = 1;
            this.one.Text = "1";
            this.one.UseVisualStyleBackColor = true;
            this.one.Click += new System.EventHandler(this.one_Click);
            // 
            // two
            // 
            this.two.Location = new System.Drawing.Point(59, 81);
            this.two.Name = "two";
            this.two.Size = new System.Drawing.Size(41, 39);
            this.two.TabIndex = 2;
            this.two.Text = "2";
            this.two.UseVisualStyleBackColor = true;
            this.two.Click += new System.EventHandler(this.two_Click);
            // 
            // three
            // 
            this.three.Location = new System.Drawing.Point(106, 81);
            this.three.Name = "three";
            this.three.Size = new System.Drawing.Size(41, 39);
            this.three.TabIndex = 3;
            this.three.Text = "3";
            this.three.UseVisualStyleBackColor = true;
            this.three.Click += new System.EventHandler(this.three_Click);
            // 
            // four
            // 
            this.four.Location = new System.Drawing.Point(12, 126);
            this.four.Name = "four";
            this.four.Size = new System.Drawing.Size(41, 39);
            this.four.TabIndex = 4;
            this.four.Text = "4";
            this.four.UseVisualStyleBackColor = true;
            this.four.Click += new System.EventHandler(this.four_Click);
            // 
            // five
            // 
            this.five.Location = new System.Drawing.Point(59, 126);
            this.five.Name = "five";
            this.five.Size = new System.Drawing.Size(41, 39);
            this.five.TabIndex = 5;
            this.five.Text = "5";
            this.five.UseVisualStyleBackColor = true;
            this.five.Click += new System.EventHandler(this.five_Click);
            // 
            // six
            // 
            this.six.Location = new System.Drawing.Point(106, 126);
            this.six.Name = "six";
            this.six.Size = new System.Drawing.Size(41, 39);
            this.six.TabIndex = 6;
            this.six.Text = "6";
            this.six.UseVisualStyleBackColor = true;
            this.six.Click += new System.EventHandler(this.six_Click);
            // 
            // seven
            // 
            this.seven.Location = new System.Drawing.Point(12, 174);
            this.seven.Name = "seven";
            this.seven.Size = new System.Drawing.Size(41, 39);
            this.seven.TabIndex = 7;
            this.seven.Text = "7";
            this.seven.UseVisualStyleBackColor = true;
            this.seven.Click += new System.EventHandler(this.seven_Click);
            // 
            // eight
            // 
            this.eight.Location = new System.Drawing.Point(59, 174);
            this.eight.Name = "eight";
            this.eight.Size = new System.Drawing.Size(41, 39);
            this.eight.TabIndex = 8;
            this.eight.Text = "8";
            this.eight.UseVisualStyleBackColor = true;
            this.eight.Click += new System.EventHandler(this.eight_Click);
            // 
            // nine
            // 
            this.nine.Location = new System.Drawing.Point(106, 174);
            this.nine.Name = "nine";
            this.nine.Size = new System.Drawing.Size(41, 39);
            this.nine.TabIndex = 9;
            this.nine.Text = "9";
            this.nine.UseVisualStyleBackColor = true;
            this.nine.Click += new System.EventHandler(this.nine_Click);
            // 
            // zero
            // 
            this.zero.Location = new System.Drawing.Point(12, 39);
            this.zero.Name = "zero";
            this.zero.Size = new System.Drawing.Size(88, 39);
            this.zero.TabIndex = 10;
            this.zero.Text = "0";
            this.zero.UseVisualStyleBackColor = true;
            this.zero.Click += new System.EventHandler(this.zero_Click);
            // 
            // point
            // 
            this.point.Location = new System.Drawing.Point(153, 84);
            this.point.Name = "point";
            this.point.Size = new System.Drawing.Size(41, 39);
            this.point.TabIndex = 11;
            this.point.Text = ".";
            this.point.UseVisualStyleBackColor = true;
            this.point.Click += new System.EventHandler(this.point_Click);
            // 
            // devide
            // 
            this.devide.Location = new System.Drawing.Point(153, 219);
            this.devide.Name = "devide";
            this.devide.Size = new System.Drawing.Size(41, 39);
            this.devide.TabIndex = 15;
            this.devide.Text = "/";
            this.devide.UseVisualStyleBackColor = true;
            this.devide.Click += new System.EventHandler(this.devide_Click);
            // 
            // c
            // 
            this.c.Location = new System.Drawing.Point(106, 38);
            this.c.Name = "c";
            this.c.Size = new System.Drawing.Size(41, 39);
            this.c.TabIndex = 16;
            this.c.Text = "C";
            this.c.UseVisualStyleBackColor = true;
            this.c.Click += new System.EventHandler(this.c_Click);
            // 
            // ce
            // 
            this.ce.Location = new System.Drawing.Point(153, 39);
            this.ce.Name = "ce";
            this.ce.Size = new System.Drawing.Size(41, 39);
            this.ce.TabIndex = 17;
            this.ce.Text = "CE";
            this.ce.UseVisualStyleBackColor = true;
            this.ce.Click += new System.EventHandler(this.ce_Click);
            // 
            // plus
            // 
            this.plus.Location = new System.Drawing.Point(12, 219);
            this.plus.Name = "plus";
            this.plus.Size = new System.Drawing.Size(41, 39);
            this.plus.TabIndex = 18;
            this.plus.Text = "+";
            this.plus.UseVisualStyleBackColor = true;
            this.plus.Click += new System.EventHandler(this.plus_Click);
            // 
            // minus
            // 
            this.minus.Location = new System.Drawing.Point(59, 219);
            this.minus.Name = "minus";
            this.minus.Size = new System.Drawing.Size(41, 39);
            this.minus.TabIndex = 19;
            this.minus.Text = "-";
            this.minus.UseVisualStyleBackColor = true;
            this.minus.Click += new System.EventHandler(this.minus_Click);
            // 
            // multiply
            // 
            this.multiply.Location = new System.Drawing.Point(106, 219);
            this.multiply.Name = "multiply";
            this.multiply.Size = new System.Drawing.Size(41, 39);
            this.multiply.TabIndex = 20;
            this.multiply.Text = "*";
            this.multiply.UseVisualStyleBackColor = true;
            this.multiply.Click += new System.EventHandler(this.multiply_Click);
            // 
            // result
            // 
            this.result.Location = new System.Drawing.Point(153, 126);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(41, 87);
            this.result.TabIndex = 21;
            this.result.Text = "=";
            this.result.UseVisualStyleBackColor = true;
            this.result.Click += new System.EventHandler(this.result_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(202, 274);
            this.Controls.Add(this.result);
            this.Controls.Add(this.multiply);
            this.Controls.Add(this.minus);
            this.Controls.Add(this.plus);
            this.Controls.Add(this.ce);
            this.Controls.Add(this.c);
            this.Controls.Add(this.devide);
            this.Controls.Add(this.point);
            this.Controls.Add(this.zero);
            this.Controls.Add(this.nine);
            this.Controls.Add(this.eight);
            this.Controls.Add(this.seven);
            this.Controls.Add(this.six);
            this.Controls.Add(this.five);
            this.Controls.Add(this.four);
            this.Controls.Add(this.three);
            this.Controls.Add(this.two);
            this.Controls.Add(this.one);
            this.Controls.Add(this.calcBox);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(218, 313);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(218, 313);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Calculator ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox calcBox;
        private System.Windows.Forms.Button one;
        private System.Windows.Forms.Button two;
        private System.Windows.Forms.Button three;
        private System.Windows.Forms.Button four;
        private System.Windows.Forms.Button five;
        private System.Windows.Forms.Button six;
        private System.Windows.Forms.Button seven;
        private System.Windows.Forms.Button eight;
        private System.Windows.Forms.Button nine;
        private System.Windows.Forms.Button zero;
        private System.Windows.Forms.Button point;
        
        private System.Windows.Forms.Button devide;
        private System.Windows.Forms.Button c;
        private System.Windows.Forms.Button ce;
        private System.Windows.Forms.Button plus;
        private System.Windows.Forms.Button minus;
        private System.Windows.Forms.Button multiply;
        private System.Windows.Forms.Button result;
    }
}

