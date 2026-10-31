namespace Airline_Ticket_Booking_System
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
            this.txtname = new System.Windows.Forms.TextBox();
            this.txtage = new System.Windows.Forms.TextBox();
            this.txttickets = new System.Windows.Forms.TextBox();
            this.txtbaggage = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.rfirstClass = new System.Windows.Forms.RadioButton();
            this.rnormalclass = new System.Windows.Forms.RadioButton();
            this.rBusiness = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.checkadd = new System.Windows.Forms.CheckBox();
            this.btncalculate = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(486, 50);
            this.txtname.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(277, 28);
            this.txtname.TabIndex = 0;
            // 
            // txtage
            // 
            this.txtage.Location = new System.Drawing.Point(486, 98);
            this.txtage.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtage.Name = "txtage";
            this.txtage.Size = new System.Drawing.Size(277, 28);
            this.txtage.TabIndex = 1;
            // 
            // txttickets
            // 
            this.txttickets.Location = new System.Drawing.Point(486, 150);
            this.txttickets.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txttickets.Name = "txttickets";
            this.txttickets.Size = new System.Drawing.Size(277, 28);
            this.txttickets.TabIndex = 2;
            // 
            // txtbaggage
            // 
            this.txtbaggage.Location = new System.Drawing.Point(486, 204);
            this.txtbaggage.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtbaggage.Name = "txtbaggage";
            this.txtbaggage.Size = new System.Drawing.Size(277, 28);
            this.txtbaggage.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(174, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 32);
            this.label1.TabIndex = 4;
            this.label1.Text = "Personal Information";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(174, 56);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(240, 22);
            this.label2.TabIndex = 5;
            this.label2.Text = "Passenger Name :";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(174, 104);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(210, 34);
            this.label3.TabIndex = 6;
            this.label3.Text = "Passenger Age :";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(174, 156);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(240, 41);
            this.label4.TabIndex = 7;
            this.label4.Text = "Number of tickets :";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(174, 210);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(240, 38);
            this.label5.TabIndex = 8;
            this.label5.Text = "Baggage Weight(kg) :";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(70, 306);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(178, 36);
            this.label6.TabIndex = 9;
            this.label6.Text = "Travel Class ";
            // 
            // rfirstClass
            // 
            this.rfirstClass.AutoSize = true;
            this.rfirstClass.Location = new System.Drawing.Point(35, 358);
            this.rfirstClass.Name = "rfirstClass";
            this.rfirstClass.Size = new System.Drawing.Size(131, 26);
            this.rfirstClass.TabIndex = 10;
            this.rfirstClass.TabStop = true;
            this.rfirstClass.Text = "First Class";
            this.rfirstClass.UseVisualStyleBackColor = true;
            // 
            // rnormalclass
            // 
            this.rnormalclass.AutoSize = true;
            this.rnormalclass.Location = new System.Drawing.Point(242, 358);
            this.rnormalclass.Name = "rnormalclass";
            this.rnormalclass.Size = new System.Drawing.Size(154, 26);
            this.rnormalclass.TabIndex = 11;
            this.rnormalclass.TabStop = true;
            this.rnormalclass.Text = "Normal Class";
            this.rnormalclass.UseVisualStyleBackColor = true;
            // 
            // rBusiness
            // 
            this.rBusiness.AutoSize = true;
            this.rBusiness.Location = new System.Drawing.Point(473, 358);
            this.rBusiness.Name = "rBusiness";
            this.rBusiness.Size = new System.Drawing.Size(172, 26);
            this.rBusiness.TabIndex = 12;
            this.rBusiness.TabStop = true;
            this.rBusiness.Text = "Business Class";
            this.rBusiness.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(31, 430);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(198, 34);
            this.label7.TabIndex = 13;
            this.label7.Text = "Aditional Option";
            // 
            // checkadd
            // 
            this.checkadd.AutoSize = true;
            this.checkadd.Location = new System.Drawing.Point(59, 467);
            this.checkadd.Name = "checkadd";
            this.checkadd.Size = new System.Drawing.Size(371, 26);
            this.checkadd.TabIndex = 14;
            this.checkadd.Text = "Add Travel Insurence ($25 Per ticket)";
            this.checkadd.UseVisualStyleBackColor = true;
            // 
            // btncalculate
            // 
            this.btncalculate.Location = new System.Drawing.Point(168, 537);
            this.btncalculate.Name = "btncalculate";
            this.btncalculate.Size = new System.Drawing.Size(150, 63);
            this.btncalculate.TabIndex = 15;
            this.btncalculate.Text = "Calculate";
            this.btncalculate.UseVisualStyleBackColor = true;
            this.btncalculate.Click += new System.EventHandler(this.btncalculate_Click);
            // 
            // btnclear
            // 
            this.btnclear.Location = new System.Drawing.Point(445, 537);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(150, 63);
            this.btnclear.TabIndex = 16;
            this.btnclear.Text = "Clear";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(726, 537);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(150, 63);
            this.btnExit.TabIndex = 17;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 22;
            this.listBox1.Items.AddRange(new object[] {
            "AirlineBookDetails"});
            this.listBox1.Location = new System.Drawing.Point(851, 19);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(376, 488);
            this.listBox1.TabIndex = 18;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1219, 623);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btncalculate);
            this.Controls.Add(this.checkadd);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.rBusiness);
            this.Controls.Add(this.rnormalclass);
            this.Controls.Add(this.rfirstClass);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtbaggage);
            this.Controls.Add(this.txttickets);
            this.Controls.Add(this.txtage);
            this.Controls.Add(this.txtname);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.TextBox txtage;
        private System.Windows.Forms.TextBox txttickets;
        private System.Windows.Forms.TextBox txtbaggage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton rfirstClass;
        private System.Windows.Forms.RadioButton rnormalclass;
        private System.Windows.Forms.RadioButton rBusiness;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox checkadd;
        private System.Windows.Forms.Button btncalculate;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ListBox listBox1;
    }
}

