namespace assignment
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
            this.components = new System.ComponentModel.Container();
            this.dayOfWeekTextBox = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.monthTextBox = new System.Windows.Forms.TextBox();
            this.DayOfMonthTextBox = new System.Windows.Forms.TextBox();
            this.txtyear = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.showDate = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.lblDateOutPut = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dayOfWeekTextBox
            // 
            this.dayOfWeekTextBox.Location = new System.Drawing.Point(498, 62);
            this.dayOfWeekTextBox.Name = "dayOfWeekTextBox";
            this.dayOfWeekTextBox.Size = new System.Drawing.Size(240, 26);
            this.dayOfWeekTextBox.TabIndex = 0;
            this.dayOfWeekTextBox.TextChanged += new System.EventHandler(this.dayOfWeekTextBox_TextChanged_1);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // monthTextBox
            // 
            this.monthTextBox.Location = new System.Drawing.Point(498, 110);
            this.monthTextBox.Name = "monthTextBox";
            this.monthTextBox.Size = new System.Drawing.Size(240, 26);
            this.monthTextBox.TabIndex = 2;
            this.monthTextBox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // DayOfMonthTextBox
            // 
            this.DayOfMonthTextBox.Location = new System.Drawing.Point(498, 158);
            this.DayOfMonthTextBox.Name = "DayOfMonthTextBox";
            this.DayOfMonthTextBox.Size = new System.Drawing.Size(240, 26);
            this.DayOfMonthTextBox.TabIndex = 3;
            this.DayOfMonthTextBox.TextChanged += new System.EventHandler(this.DayOfMonthTextBox_TextChanged);
            // 
            // txtyear
            // 
            this.txtyear.Location = new System.Drawing.Point(498, 209);
            this.txtyear.Name = "txtyear";
            this.txtyear.Size = new System.Drawing.Size(240, 26);
            this.txtyear.TabIndex = 4;
            this.txtyear.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(287, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Enter the day of the weel";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(259, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(213, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Enter the name of the month";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(216, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(256, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Enter the number day of the month";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(363, 213);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Enter the year";
            // 
            // showDate
            // 
            this.showDate.Location = new System.Drawing.Point(289, 366);
            this.showDate.Name = "showDate";
            this.showDate.Size = new System.Drawing.Size(155, 57);
            this.showDate.TabIndex = 10;
            this.showDate.Text = "Show date";
            this.showDate.UseVisualStyleBackColor = true;
            this.showDate.Click += new System.EventHandler(this.showDate_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(498, 366);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(155, 57);
            this.button3.TabIndex = 11;
            this.button3.Text = "clear";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // lblDateOutPut
            // 
            this.lblDateOutPut.BackColor = System.Drawing.Color.Gainsboro;
            this.lblDateOutPut.Location = new System.Drawing.Point(259, 266);
            this.lblDateOutPut.Name = "lblDateOutPut";
            this.lblDateOutPut.Size = new System.Drawing.Size(500, 50);
            this.lblDateOutPut.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblDateOutPut);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.showDate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtyear);
            this.Controls.Add(this.DayOfMonthTextBox);
            this.Controls.Add(this.monthTextBox);
            this.Controls.Add(this.dayOfWeekTextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox dayOfWeekTextBox;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox monthTextBox;
        private System.Windows.Forms.TextBox DayOfMonthTextBox;
        private System.Windows.Forms.TextBox txtyear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button showDate;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label lblDateOutPut;
    }
}

