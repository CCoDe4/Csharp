namespace DailyBudget
{
    partial class main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(main));
            this.calculateBtn = new System.Windows.Forms.Button();
            this.monthlyBudget = new System.Windows.Forms.TextBox();
            this.dailyMoney = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.homeRent = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.communicationMoney = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.transportMoney = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.clearButton = new System.Windows.Forms.Button();
            this.currentDate = new System.Windows.Forms.Label();
            this.otherMoney = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // calculateBtn
            // 
            this.calculateBtn.Location = new System.Drawing.Point(52, 204);
            this.calculateBtn.Name = "calculateBtn";
            this.calculateBtn.Size = new System.Drawing.Size(172, 28);
            this.calculateBtn.TabIndex = 0;
            this.calculateBtn.Text = "Calculate";
            this.calculateBtn.UseVisualStyleBackColor = true;
            this.calculateBtn.Click += new System.EventHandler(this.calculateBtn_Click);
            // 
            // monthlyBudget
            // 
            this.monthlyBudget.Location = new System.Drawing.Point(373, 28);
            this.monthlyBudget.Name = "monthlyBudget";
            this.monthlyBudget.Size = new System.Drawing.Size(100, 20);
            this.monthlyBudget.TabIndex = 1;
            this.monthlyBudget.Text = "0";
            // 
            // dailyMoney
            // 
            this.dailyMoney.Location = new System.Drawing.Point(373, 209);
            this.dailyMoney.Name = "dailyMoney";
            this.dailyMoney.ReadOnly = true;
            this.dailyMoney.Size = new System.Drawing.Size(100, 20);
            this.dailyMoney.TabIndex = 2;
            this.dailyMoney.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(322, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "PLEASE ENTER YOUR CURRENT BUDGET FOR THE MONTH:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(265, 212);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Your daily budget is:";
            // 
            // homeRent
            // 
            this.homeRent.Location = new System.Drawing.Point(114, 81);
            this.homeRent.Name = "homeRent";
            this.homeRent.Size = new System.Drawing.Size(100, 20);
            this.homeRent.TabIndex = 5;
            this.homeRent.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Home rent:";
            // 
            // communicationMoney
            // 
            this.communicationMoney.Location = new System.Drawing.Point(114, 107);
            this.communicationMoney.Name = "communicationMoney";
            this.communicationMoney.Size = new System.Drawing.Size(100, 20);
            this.communicationMoney.TabIndex = 7;
            this.communicationMoney.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Communication :";
            // 
            // transportMoney
            // 
            this.transportMoney.Location = new System.Drawing.Point(114, 133);
            this.transportMoney.Name = "transportMoney";
            this.transportMoney.Size = new System.Drawing.Size(100, 20);
            this.transportMoney.TabIndex = 9;
            this.transportMoney.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(53, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Transport:";
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(157, 260);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(185, 31);
            this.clearButton.TabIndex = 11;
            this.clearButton.Text = "Clear All";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // currentDate
            // 
            this.currentDate.AutoSize = true;
            this.currentDate.Location = new System.Drawing.Point(12, 9);
            this.currentDate.Name = "currentDate";
            this.currentDate.Size = new System.Drawing.Size(60, 13);
            this.currentDate.TabIndex = 12;
            this.currentDate.Text = "DateToday";
            // 
            // otherMoney
            // 
            this.otherMoney.Location = new System.Drawing.Point(114, 159);
            this.otherMoney.Name = "otherMoney";
            this.otherMoney.Size = new System.Drawing.Size(100, 20);
            this.otherMoney.TabIndex = 13;
            this.otherMoney.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(72, 162);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Other:";
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 303);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.otherMoney);
            this.Controls.Add(this.currentDate);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.transportMoney);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.communicationMoney);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.homeRent);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dailyMoney);
            this.Controls.Add(this.monthlyBudget);
            this.Controls.Add(this.calculateBtn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(536, 342);
            this.MinimumSize = new System.Drawing.Size(536, 342);
            this.Name = "main";
            this.Text = "Daily Budget";
            this.Load += new System.EventHandler(this.main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button calculateBtn;
        private System.Windows.Forms.TextBox monthlyBudget;
        private System.Windows.Forms.TextBox dailyMoney;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox homeRent;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox communicationMoney;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox transportMoney;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Label currentDate;
        private System.Windows.Forms.TextBox otherMoney;
        private System.Windows.Forms.Label label6;
    }
}

