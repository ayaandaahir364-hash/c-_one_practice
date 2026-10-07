namespace WindowsFormsApp1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbloutput = new System.Windows.Forms.Label();
            this.txtsalary = new System.Windows.Forms.TextBox();
            this.txtyear = new System.Windows.Forms.TextBox();
            this.btncheck = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(282, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter saly";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(257, 132);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(129, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Enter year Exp";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(362, 208);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(177, 27);
            this.label3.TabIndex = 2;
            this.label3.Text = "Decision Results";
            // 
            // lbloutput
            // 
            this.lbloutput.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lbloutput.Location = new System.Drawing.Point(209, 248);
            this.lbloutput.Name = "lbloutput";
            this.lbloutput.Size = new System.Drawing.Size(441, 43);
            this.lbloutput.TabIndex = 3;
            // 
            // txtsalary
            // 
            this.txtsalary.Location = new System.Drawing.Point(471, 96);
            this.txtsalary.Name = "txtsalary";
            this.txtsalary.Size = new System.Drawing.Size(213, 26);
            this.txtsalary.TabIndex = 4;
            // 
            // txtyear
            // 
            this.txtyear.Location = new System.Drawing.Point(471, 143);
            this.txtyear.Name = "txtyear";
            this.txtyear.Size = new System.Drawing.Size(213, 26);
            this.txtyear.TabIndex = 5;
            // 
            // btncheck
            // 
            this.btncheck.Location = new System.Drawing.Point(117, 352);
            this.btncheck.Name = "btncheck";
            this.btncheck.Size = new System.Drawing.Size(173, 47);
            this.btncheck.TabIndex = 6;
            this.btncheck.Text = "Check &Qualification";
            this.btncheck.UseVisualStyleBackColor = true;
            this.btncheck.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnclear
            // 
            this.btnclear.Location = new System.Drawing.Point(309, 352);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(125, 47);
            this.btnclear.TabIndex = 7;
            this.btnclear.Text = "Clear";
            this.btnclear.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(514, 352);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(125, 47);
            this.button3.TabIndex = 8;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btncheck);
            this.Controls.Add(this.txtyear);
            this.Controls.Add(this.txtsalary);
            this.Controls.Add(this.lbloutput);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbloutput;
        private System.Windows.Forms.TextBox txtsalary;
        private System.Windows.Forms.TextBox txtyear;
        private System.Windows.Forms.Button btncheck;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button button3;
    }
}

