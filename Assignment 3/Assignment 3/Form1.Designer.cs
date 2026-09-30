namespace Assignment_3
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
            this.txtCustomer = new System.Windows.Forms.TextBox();
            this.txtprevious = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.txtcurrent = new System.Windows.Forms.TextBox();
            this.txtUnitprice = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ElectryUsage = new System.Windows.Forms.Label();
            this.btncalculate = new System.Windows.Forms.Button();
            this.Taxtamount = new System.Windows.Forms.Label();
            this.Tota = new System.Windows.Forms.Label();
            this.Usage = new System.Windows.Forms.Label();
            this.Taxamount = new System.Windows.Forms.Label();
            this.TotalBill = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtCustomer
            // 
            this.txtCustomer.Location = new System.Drawing.Point(521, 16);
            this.txtCustomer.Name = "txtCustomer";
            this.txtCustomer.Size = new System.Drawing.Size(215, 26);
            this.txtCustomer.TabIndex = 0;
            // 
            // txtprevious
            // 
            this.txtprevious.Location = new System.Drawing.Point(521, 63);
            this.txtprevious.Name = "txtprevious";
            this.txtprevious.Size = new System.Drawing.Size(215, 26);
            this.txtprevious.TabIndex = 1;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // txtcurrent
            // 
            this.txtcurrent.Location = new System.Drawing.Point(521, 113);
            this.txtcurrent.Name = "txtcurrent";
            this.txtcurrent.Size = new System.Drawing.Size(215, 26);
            this.txtcurrent.TabIndex = 3;
            // 
            // txtUnitprice
            // 
            this.txtUnitprice.Location = new System.Drawing.Point(521, 163);
            this.txtUnitprice.Name = "txtUnitprice";
            this.txtUnitprice.Size = new System.Drawing.Size(215, 26);
            this.txtUnitprice.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(284, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 26);
            this.label1.TabIndex = 5;
            this.label1.Text = "Enter Customer name :";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(284, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(200, 32);
            this.label2.TabIndex = 6;
            this.label2.Text = "Enter previous reading :";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(284, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(200, 35);
            this.label3.TabIndex = 7;
            this.label3.Text = "Enter Current reading :";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(284, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(188, 34);
            this.label4.TabIndex = 8;
            this.label4.Text = "Enter price per unit ($)";
            // 
            // ElectryUsage
            // 
            this.ElectryUsage.Location = new System.Drawing.Point(44, 273);
            this.ElectryUsage.Name = "ElectryUsage";
            this.ElectryUsage.Size = new System.Drawing.Size(215, 29);
            this.ElectryUsage.TabIndex = 9;
            this.ElectryUsage.Text = "Electricity usage (units)";
            // 
            // btncalculate
            // 
            this.btncalculate.Location = new System.Drawing.Point(432, 224);
            this.btncalculate.Name = "btncalculate";
            this.btncalculate.Size = new System.Drawing.Size(192, 37);
            this.btncalculate.TabIndex = 10;
            this.btncalculate.Text = "Calculate Bill";
            this.btncalculate.UseVisualStyleBackColor = true;
            this.btncalculate.Click += new System.EventHandler(this.btncalculate_Click);
            // 
            // Taxtamount
            // 
            this.Taxtamount.Location = new System.Drawing.Point(44, 317);
            this.Taxtamount.Name = "Taxtamount";
            this.Taxtamount.Size = new System.Drawing.Size(176, 23);
            this.Taxtamount.TabIndex = 11;
            this.Taxtamount.Text = "Tax amount(7%)";
            // 
            // Tota
            // 
            this.Tota.Location = new System.Drawing.Point(44, 358);
            this.Tota.Name = "Tota";
            this.Tota.Size = new System.Drawing.Size(286, 34);
            this.Tota.TabIndex = 12;
            this.Tota.Text = "total Bill (encluding$5 fixed charge)";
            this.Tota.Click += new System.EventHandler(this.label7_Click);
            // 
            // Usage
            // 
            this.Usage.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Usage.Location = new System.Drawing.Point(575, 308);
            this.Usage.Name = "Usage";
            this.Usage.Size = new System.Drawing.Size(176, 32);
            this.Usage.TabIndex = 13;
            // 
            // Taxamount
            // 
            this.Taxamount.BackColor = System.Drawing.Color.Gray;
            this.Taxamount.Location = new System.Drawing.Point(571, 352);
            this.Taxamount.Name = "Taxamount";
            this.Taxamount.Size = new System.Drawing.Size(180, 31);
            this.Taxamount.TabIndex = 14;
            // 
            // TotalBill
            // 
            this.TotalBill.BackColor = System.Drawing.SystemColors.ControlDark;
            this.TotalBill.Location = new System.Drawing.Point(571, 394);
            this.TotalBill.Name = "TotalBill";
            this.TotalBill.Size = new System.Drawing.Size(180, 32);
            this.TotalBill.TabIndex = 15;
            this.TotalBill.Click += new System.EventHandler(this.label10_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TotalBill);
            this.Controls.Add(this.Taxamount);
            this.Controls.Add(this.Usage);
            this.Controls.Add(this.Tota);
            this.Controls.Add(this.Taxtamount);
            this.Controls.Add(this.btncalculate);
            this.Controls.Add(this.ElectryUsage);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtUnitprice);
            this.Controls.Add(this.txtcurrent);
            this.Controls.Add(this.txtprevious);
            this.Controls.Add(this.txtCustomer);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCustomer;
        private System.Windows.Forms.TextBox txtprevious;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox txtcurrent;
        private System.Windows.Forms.TextBox txtUnitprice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label ElectryUsage;
        private System.Windows.Forms.Button btncalculate;
        private System.Windows.Forms.Label Taxtamount;
        private System.Windows.Forms.Label Tota;
        private System.Windows.Forms.Label Usage;
        private System.Windows.Forms.Label Taxamount;
        private System.Windows.Forms.Label TotalBill;
    }
}

