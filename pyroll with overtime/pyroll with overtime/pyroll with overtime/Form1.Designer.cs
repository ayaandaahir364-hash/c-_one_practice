namespace pyroll_with_overtime
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
            this.lblgrosspa = new System.Windows.Forms.Label();
            this.txtHours = new System.Windows.Forms.TextBox();
            this.txtPayrate = new System.Windows.Forms.TextBox();
            this.lblgrospay = new System.Windows.Forms.Label();
            this.btncalculate = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.btnclose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(215, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = " HOURS WORKED :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(215, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Enter pay rate: ";
            // 
            // lblgrosspa
            // 
            this.lblgrosspa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblgrosspa.Location = new System.Drawing.Point(215, 158);
            this.lblgrosspa.Name = "lblgrosspa";
            this.lblgrosspa.Size = new System.Drawing.Size(100, 23);
            this.lblgrosspa.TabIndex = 2;
            this.lblgrosspa.Text = "Gross by :";
            this.lblgrosspa.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtHours
            // 
            this.txtHours.Location = new System.Drawing.Point(453, 70);
            this.txtHours.Name = "txtHours";
            this.txtHours.Size = new System.Drawing.Size(247, 26);
            this.txtHours.TabIndex = 3;
            // 
            // txtPayrate
            // 
            this.txtPayrate.Location = new System.Drawing.Point(453, 122);
            this.txtPayrate.Name = "txtPayrate";
            this.txtPayrate.Size = new System.Drawing.Size(247, 26);
            this.txtPayrate.TabIndex = 4;
            // 
            // lblgrospay
            // 
            this.lblgrospay.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblgrospay.Location = new System.Drawing.Point(453, 173);
            this.lblgrospay.Name = "lblgrospay";
            this.lblgrospay.Size = new System.Drawing.Size(247, 30);
            this.lblgrospay.TabIndex = 5;
            // 
            // btncalculate
            // 
            this.btncalculate.Location = new System.Drawing.Point(153, 332);
            this.btncalculate.Name = "btncalculate";
            this.btncalculate.Size = new System.Drawing.Size(146, 71);
            this.btncalculate.TabIndex = 6;
            this.btncalculate.Text = "C&alculate &gross pay ";
            this.btncalculate.UseVisualStyleBackColor = true;
            this.btncalculate.Click += new System.EventHandler(this.btncalculate_Click);
            // 
            // btnclear
            // 
            this.btnclear.Location = new System.Drawing.Point(322, 332);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(114, 71);
            this.btnclear.TabIndex = 7;
            this.btnclear.Text = "clear";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // btnclose
            // 
            this.btnclose.Location = new System.Drawing.Point(481, 332);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(116, 71);
            this.btnclose.TabIndex = 8;
            this.btnclose.Text = "close";
            this.btnclose.UseVisualStyleBackColor = true;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btncalculate);
            this.Controls.Add(this.lblgrospay);
            this.Controls.Add(this.txtPayrate);
            this.Controls.Add(this.txtHours);
            this.Controls.Add(this.lblgrosspa);
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
        private System.Windows.Forms.Label lblgrosspa;
        private System.Windows.Forms.TextBox txtHours;
        private System.Windows.Forms.TextBox txtPayrate;
        private System.Windows.Forms.Label lblgrospay;
        private System.Windows.Forms.Button btncalculate;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button btnclose;
    }
}

