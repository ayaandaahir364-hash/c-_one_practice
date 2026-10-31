namespace fileExample
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
            this.btnreadline = new System.Windows.Forms.Button();
            this.btnwriter = new System.Windows.Forms.Button();
            this.btnreadallLines = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnreadline
            // 
            this.btnreadline.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnreadline.Location = new System.Drawing.Point(77, 29);
            this.btnreadline.Name = "btnreadline";
            this.btnreadline.Size = new System.Drawing.Size(216, 45);
            this.btnreadline.TabIndex = 0;
            this.btnreadline.Text = "Readlines";
            this.btnreadline.UseVisualStyleBackColor = true;
            this.btnreadline.Click += new System.EventHandler(this.btnreadline_Click);
            // 
            // btnwriter
            // 
            this.btnwriter.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnwriter.Location = new System.Drawing.Point(335, 29);
            this.btnwriter.Name = "btnwriter";
            this.btnwriter.Size = new System.Drawing.Size(216, 45);
            this.btnwriter.TabIndex = 1;
            this.btnwriter.Text = "Write file";
            this.btnwriter.UseVisualStyleBackColor = true;
            this.btnwriter.Click += new System.EventHandler(this.btnwriter_Click);
            // 
            // btnreadallLines
            // 
            this.btnreadallLines.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnreadallLines.Location = new System.Drawing.Point(65, 107);
            this.btnreadallLines.Name = "btnreadallLines";
            this.btnreadallLines.Size = new System.Drawing.Size(216, 45);
            this.btnreadallLines.TabIndex = 2;
            this.btnreadallLines.Text = "ReadAllLines";
            this.btnreadallLines.UseVisualStyleBackColor = true;
            this.btnreadallLines.Click += new System.EventHandler(this.btnreadallLines_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(65, 194);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(216, 45);
            this.button4.TabIndex = 3;
            this.button4.Text = "Delate items from the file";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(65, 276);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(216, 45);
            this.button5.TabIndex = 4;
            this.button5.Text = "Delate the file";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // btnclear
            // 
            this.btnclear.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclear.Location = new System.Drawing.Point(363, 279);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(188, 38);
            this.btnclear.TabIndex = 7;
            this.btnclear.Text = "Clear";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(580, 3);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(366, 644);
            this.listBox1.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(947, 652);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btnreadallLines);
            this.Controls.Add(this.btnwriter);
            this.Controls.Add(this.btnreadline);
            this.Name = "Form1";
            this.Text = " ";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnreadline;
        private System.Windows.Forms.Button btnwriter;
        private System.Windows.Forms.Button btnreadallLines;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.ListBox listBox1;
    }
}

