namespace Calculator
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
            this.nine = new System.Windows.Forms.Button();
            this.zero = new System.Windows.Forms.Button();
            this.eight = new System.Windows.Forms.Button();
            this.seven = new System.Windows.Forms.Button();
            this.four = new System.Windows.Forms.Button();
            this.five = new System.Windows.Forms.Button();
            this.six = new System.Windows.Forms.Button();
            this.three = new System.Windows.Forms.Button();
            this.two = new System.Windows.Forms.Button();
            this.one = new System.Windows.Forms.Button();
            this.devide = new System.Windows.Forms.Button();
            this.multiply = new System.Windows.Forms.Button();
            this.minus = new System.Windows.Forms.Button();
            this.plus = new System.Windows.Forms.Button();
            this.clearLast = new System.Windows.Forms.Button();
            this.clearEntire = new System.Windows.Forms.Button();
            this.result = new System.Windows.Forms.Label();
            this.point = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // calcBox
            // 
            this.calcBox.Location = new System.Drawing.Point(20, 20);
            this.calcBox.Name = "calcBox";
            this.calcBox.ReadOnly = true;
            this.calcBox.Size = new System.Drawing.Size(141, 20);
            this.calcBox.TabIndex = 0;
            this.calcBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // nine
            // 
            this.nine.Location = new System.Drawing.Point(118, 216);
            this.nine.Name = "nine";
            this.nine.Size = new System.Drawing.Size(43, 45);
            this.nine.TabIndex = 10;
            this.nine.Text = "9";
            this.nine.UseVisualStyleBackColor = true;
            this.nine.Click += new System.EventHandler(this.nine_Click);
            // 
            // zero
            // 
            this.zero.Location = new System.Drawing.Point(20, 63);
            this.zero.Name = "zero";
            this.zero.Size = new System.Drawing.Size(43, 45);
            this.zero.TabIndex = 11;
            this.zero.Text = "0";
            this.zero.UseVisualStyleBackColor = true;
            this.zero.Click += new System.EventHandler(this.zero_Click);
            // 
            // eight
            // 
            this.eight.Location = new System.Drawing.Point(69, 216);
            this.eight.Name = "eight";
            this.eight.Size = new System.Drawing.Size(43, 45);
            this.eight.TabIndex = 12;
            this.eight.Text = "8";
            this.eight.UseVisualStyleBackColor = true;
            this.eight.Click += new System.EventHandler(this.eight_Click);
            // 
            // seven
            // 
            this.seven.Location = new System.Drawing.Point(20, 216);
            this.seven.Name = "seven";
            this.seven.Size = new System.Drawing.Size(43, 45);
            this.seven.TabIndex = 13;
            this.seven.Text = "7";
            this.seven.UseVisualStyleBackColor = true;
            this.seven.Click += new System.EventHandler(this.seven_Click);
            // 
            // four
            // 
            this.four.Location = new System.Drawing.Point(20, 165);
            this.four.Name = "four";
            this.four.Size = new System.Drawing.Size(43, 45);
            this.four.TabIndex = 14;
            this.four.Text = "4";
            this.four.UseVisualStyleBackColor = true;
            this.four.Click += new System.EventHandler(this.four_Click);
            // 
            // five
            // 
            this.five.Location = new System.Drawing.Point(69, 165);
            this.five.Name = "five";
            this.five.Size = new System.Drawing.Size(43, 45);
            this.five.TabIndex = 15;
            this.five.Text = "5";
            this.five.UseVisualStyleBackColor = true;
            this.five.Click += new System.EventHandler(this.five_Click);
            // 
            // six
            // 
            this.six.Location = new System.Drawing.Point(118, 165);
            this.six.Name = "six";
            this.six.Size = new System.Drawing.Size(43, 45);
            this.six.TabIndex = 16;
            this.six.Text = "6";
            this.six.UseVisualStyleBackColor = true;
            this.six.Click += new System.EventHandler(this.six_Click);
            // 
            // three
            // 
            this.three.Location = new System.Drawing.Point(118, 114);
            this.three.Name = "three";
            this.three.Size = new System.Drawing.Size(43, 45);
            this.three.TabIndex = 17;
            this.three.Text = "3";
            this.three.UseVisualStyleBackColor = true;
            this.three.Click += new System.EventHandler(this.three_Click);
            // 
            // two
            // 
            this.two.Location = new System.Drawing.Point(69, 114);
            this.two.Name = "two";
            this.two.Size = new System.Drawing.Size(43, 45);
            this.two.TabIndex = 18;
            this.two.Text = "2";
            this.two.UseVisualStyleBackColor = true;
            this.two.Click += new System.EventHandler(this.two_Click);
            // 
            // one
            // 
            this.one.Location = new System.Drawing.Point(20, 114);
            this.one.Name = "one";
            this.one.Size = new System.Drawing.Size(43, 45);
            this.one.TabIndex = 19;
            this.one.Text = "1";
            this.one.UseVisualStyleBackColor = true;
            this.one.Click += new System.EventHandler(this.one_Click);
            // 
            // devide
            // 
            this.devide.Location = new System.Drawing.Point(173, 216);
            this.devide.Name = "devide";
            this.devide.Size = new System.Drawing.Size(43, 45);
            this.devide.TabIndex = 20;
            this.devide.Text = "/";
            this.devide.UseVisualStyleBackColor = true;
            this.devide.Click += new System.EventHandler(this.devide_Click);
            // 
            // multiply
            // 
            this.multiply.Location = new System.Drawing.Point(173, 165);
            this.multiply.Name = "multiply";
            this.multiply.Size = new System.Drawing.Size(43, 45);
            this.multiply.TabIndex = 21;
            this.multiply.Text = "*";
            this.multiply.UseVisualStyleBackColor = true;
            this.multiply.Click += new System.EventHandler(this.multiply_Click);
            // 
            // minus
            // 
            this.minus.Location = new System.Drawing.Point(173, 114);
            this.minus.Name = "minus";
            this.minus.Size = new System.Drawing.Size(43, 45);
            this.minus.TabIndex = 22;
            this.minus.Text = "-";
            this.minus.UseVisualStyleBackColor = true;
            this.minus.Click += new System.EventHandler(this.minus_Click);
            // 
            // plus
            // 
            this.plus.Location = new System.Drawing.Point(173, 63);
            this.plus.Name = "plus";
            this.plus.Size = new System.Drawing.Size(43, 45);
            this.plus.TabIndex = 23;
            this.plus.Text = "+";
            this.plus.UseVisualStyleBackColor = true;
            this.plus.Click += new System.EventHandler(this.plus_Click);
            // 
            // clearLast
            // 
            this.clearLast.Location = new System.Drawing.Point(118, 63);
            this.clearLast.Name = "clearLast";
            this.clearLast.Size = new System.Drawing.Size(43, 45);
            this.clearLast.TabIndex = 25;
            this.clearLast.Text = "C";
            this.clearLast.UseVisualStyleBackColor = true;
            this.clearLast.Click += new System.EventHandler(this.clearLast_Click);
            // 
            // clearEntire
            // 
            this.clearEntire.Location = new System.Drawing.Point(69, 63);
            this.clearEntire.Name = "clearEntire";
            this.clearEntire.Size = new System.Drawing.Size(43, 45);
            this.clearEntire.TabIndex = 26;
            this.clearEntire.Text = "CE";
            this.clearEntire.UseVisualStyleBackColor = true;
            this.clearEntire.Click += new System.EventHandler(this.clearEntire_Click);
            // 
            // result
            // 
            this.result.AutoSize = true;
            this.result.Location = new System.Drawing.Point(29, 23);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(13, 13);
            this.result.TabIndex = 28;
            this.result.Text = "0";
            // 
            // point
            // 
            this.point.Location = new System.Drawing.Point(173, 12);
            this.point.Name = "point";
            this.point.Size = new System.Drawing.Size(43, 45);
            this.point.TabIndex = 29;
            this.point.Text = ".";
            this.point.UseVisualStyleBackColor = true;
            this.point.Click += new System.EventHandler(this.point_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(228, 271);
            this.Controls.Add(this.point);
            this.Controls.Add(this.result);
            this.Controls.Add(this.clearEntire);
            this.Controls.Add(this.clearLast);
            this.Controls.Add(this.plus);
            this.Controls.Add(this.minus);
            this.Controls.Add(this.multiply);
            this.Controls.Add(this.devide);
            this.Controls.Add(this.one);
            this.Controls.Add(this.two);
            this.Controls.Add(this.three);
            this.Controls.Add(this.six);
            this.Controls.Add(this.five);
            this.Controls.Add(this.four);
            this.Controls.Add(this.seven);
            this.Controls.Add(this.eight);
            this.Controls.Add(this.zero);
            this.Controls.Add(this.nine);
            this.Controls.Add(this.calcBox);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(244, 310);
            this.MinimumSize = new System.Drawing.Size(244, 310);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox calcBox;
        private System.Windows.Forms.Button nine;
        private System.Windows.Forms.Button zero;
        private System.Windows.Forms.Button eight;
        private System.Windows.Forms.Button seven;
        private System.Windows.Forms.Button four;
        private System.Windows.Forms.Button five;
        private System.Windows.Forms.Button six;
        private System.Windows.Forms.Button three;
        private System.Windows.Forms.Button two;
        private System.Windows.Forms.Button one;
        private System.Windows.Forms.Button devide;
        private System.Windows.Forms.Button multiply;
        private System.Windows.Forms.Button minus;
        private System.Windows.Forms.Button plus;
        private System.Windows.Forms.Button clearLast;
        private System.Windows.Forms.Button clearEntire;
        private System.Windows.Forms.Label result;
        private System.Windows.Forms.Button point;
    }
}

