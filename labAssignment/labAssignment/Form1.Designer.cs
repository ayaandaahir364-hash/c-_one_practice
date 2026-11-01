namespace labAssignment
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
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtDepartmen = new System.Windows.Forms.TextBox();
            this.txtmarks = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rpost = new System.Windows.Forms.RadioButton();
            this.rundergrow = new System.Windows.Forms.RadioButton();
            this.btnsave = new System.Windows.Forms.Button();
            this.btnreadfromfile = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(291, 41);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(100, 26);
            this.txtID.TabIndex = 0;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(291, 100);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 26);
            this.txtName.TabIndex = 1;
            // 
            // txtDepartmen
            // 
            this.txtDepartmen.Location = new System.Drawing.Point(291, 174);
            this.txtDepartmen.Name = "txtDepartmen";
            this.txtDepartmen.Size = new System.Drawing.Size(100, 26);
            this.txtDepartmen.TabIndex = 2;
            // 
            // txtmarks
            // 
            this.txtmarks.Location = new System.Drawing.Point(291, 237);
            this.txtmarks.Name = "txtmarks";
            this.txtmarks.Size = new System.Drawing.Size(100, 26);
            this.txtmarks.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(110, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Student ID :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(110, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Student Name :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(110, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Department :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(110, 243);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Marks :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rpost);
            this.groupBox1.Controls.Add(this.rundergrow);
            this.groupBox1.Location = new System.Drawing.Point(51, 337);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(294, 141);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Student Type";
            // 
            // rpost
            // 
            this.rpost.AutoSize = true;
            this.rpost.Location = new System.Drawing.Point(6, 69);
            this.rpost.Name = "rpost";
            this.rpost.Size = new System.Drawing.Size(134, 24);
            this.rpost.TabIndex = 10;
            this.rpost.TabStop = true;
            this.rpost.Text = "postgratuated";
            this.rpost.UseVisualStyleBackColor = true;
            // 
            // rundergrow
            // 
            this.rundergrow.AutoSize = true;
            this.rundergrow.Location = new System.Drawing.Point(6, 25);
            this.rundergrow.Name = "rundergrow";
            this.rundergrow.Size = new System.Drawing.Size(147, 24);
            this.rundergrow.TabIndex = 9;
            this.rundergrow.TabStop = true;
            this.rundergrow.Text = "Undergratuated";
            this.rundergrow.UseVisualStyleBackColor = true;
            // 
            // btnsave
            // 
            this.btnsave.Location = new System.Drawing.Point(91, 519);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(133, 50);
            this.btnsave.TabIndex = 9;
            this.btnsave.Text = "Save to file";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // btnreadfromfile
            // 
            this.btnreadfromfile.Location = new System.Drawing.Point(278, 519);
            this.btnreadfromfile.Name = "btnreadfromfile";
            this.btnreadfromfile.Size = new System.Drawing.Size(178, 50);
            this.btnreadfromfile.TabIndex = 10;
            this.btnreadfromfile.Text = "Read from the file";
            this.btnreadfromfile.UseVisualStyleBackColor = true;
            this.btnreadfromfile.Click += new System.EventHandler(this.btnreadfromfile_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(506, 519);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(133, 50);
            this.btnClear.TabIndex = 11;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(717, 519);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(133, 50);
            this.btnExit.TabIndex = 12;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(523, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(399, 324);
            this.listBox1.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 618);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnreadfromfile);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtmarks);
            this.Controls.Add(this.txtDepartmen);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtID);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtDepartmen;
        private System.Windows.Forms.TextBox txtmarks;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rpost;
        private System.Windows.Forms.RadioButton rundergrow;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Button btnreadfromfile;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ListBox listBox1;
    }
}

