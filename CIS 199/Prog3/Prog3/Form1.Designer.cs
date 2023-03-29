namespace Prog3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Non = new System.Windows.Forms.Label();
            this.ProductLBL = new System.Windows.Forms.Label();
            this.QuanLBL = new System.Windows.Forms.Label();
            this.CalcBtn = new System.Windows.Forms.Button();
            this.QuanTXT = new System.Windows.Forms.TextBox();
            this.InitialLBL = new System.Windows.Forms.Label();
            this.DisCstLBL = new System.Windows.Forms.Label();
            this.TaxLBL = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.InitialTXT = new System.Windows.Forms.TextBox();
            this.DisCstTXT = new System.Windows.Forms.TextBox();
            this.TaxTXT = new System.Windows.Forms.TextBox();
            this.TotalTXT = new System.Windows.Forms.TextBox();
            this.StateCombo = new System.Windows.Forms.ComboBox();
            this.ProductCombo = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // Non
            // 
            this.Non.AutoSize = true;
            this.Non.Location = new System.Drawing.Point(51, 30);
            this.Non.Name = "Non";
            this.Non.Size = new System.Drawing.Size(36, 15);
            this.Non.TabIndex = 0;
            this.Non.Text = "State:";
            // 
            // ProductLBL
            // 
            this.ProductLBL.AutoSize = true;
            this.ProductLBL.Location = new System.Drawing.Point(51, 62);
            this.ProductLBL.Name = "ProductLBL";
            this.ProductLBL.Size = new System.Drawing.Size(52, 15);
            this.ProductLBL.TabIndex = 1;
            this.ProductLBL.Text = "Product:";
            // 
            // QuanLBL
            // 
            this.QuanLBL.AutoSize = true;
            this.QuanLBL.Location = new System.Drawing.Point(51, 100);
            this.QuanLBL.Name = "QuanLBL";
            this.QuanLBL.Size = new System.Drawing.Size(56, 15);
            this.QuanLBL.TabIndex = 2;
            this.QuanLBL.Text = "Quantity:";
            // 
            // CalcBtn
            // 
            this.CalcBtn.Location = new System.Drawing.Point(194, 138);
            this.CalcBtn.Name = "CalcBtn";
            this.CalcBtn.Size = new System.Drawing.Size(94, 23);
            this.CalcBtn.TabIndex = 3;
            this.CalcBtn.Text = "Calculate";
            this.CalcBtn.UseVisualStyleBackColor = true;
            this.CalcBtn.Click += new System.EventHandler(this.CalcBtn_Click);
            // 
            // QuanTXT
            // 
            this.QuanTXT.Location = new System.Drawing.Point(168, 97);
            this.QuanTXT.Name = "QuanTXT";
            this.QuanTXT.Size = new System.Drawing.Size(149, 23);
            this.QuanTXT.TabIndex = 6;
            // 
            // InitialLBL
            // 
            this.InitialLBL.AutoSize = true;
            this.InitialLBL.Location = new System.Drawing.Point(38, 181);
            this.InitialLBL.Name = "InitialLBL";
            this.InitialLBL.Size = new System.Drawing.Size(69, 15);
            this.InitialLBL.TabIndex = 7;
            this.InitialLBL.Text = "Initial Cost: ";
            // 
            // DisCstLBL
            // 
            this.DisCstLBL.AutoSize = true;
            this.DisCstLBL.Location = new System.Drawing.Point(38, 214);
            this.DisCstLBL.Name = "DisCstLBL";
            this.DisCstLBL.Size = new System.Drawing.Size(100, 15);
            this.DisCstLBL.TabIndex = 8;
            this.DisCstLBL.Text = "Discounted Cost: ";
            // 
            // TaxLBL
            // 
            this.TaxLBL.AutoSize = true;
            this.TaxLBL.Location = new System.Drawing.Point(38, 244);
            this.TaxLBL.Name = "TaxLBL";
            this.TaxLBL.Size = new System.Drawing.Size(27, 15);
            this.TaxLBL.TabIndex = 9;
            this.TaxLBL.Text = "Tax:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 273);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 15);
            this.label1.TabIndex = 10;
            this.label1.Text = "Total Price:";
            // 
            // InitialTXT
            // 
            this.InitialTXT.Location = new System.Drawing.Point(168, 178);
            this.InitialTXT.Name = "InitialTXT";
            this.InitialTXT.ReadOnly = true;
            this.InitialTXT.Size = new System.Drawing.Size(149, 23);
            this.InitialTXT.TabIndex = 11;
            // 
            // DisCstTXT
            // 
            this.DisCstTXT.Location = new System.Drawing.Point(168, 211);
            this.DisCstTXT.Name = "DisCstTXT";
            this.DisCstTXT.ReadOnly = true;
            this.DisCstTXT.Size = new System.Drawing.Size(149, 23);
            this.DisCstTXT.TabIndex = 12;
            // 
            // TaxTXT
            // 
            this.TaxTXT.Location = new System.Drawing.Point(168, 241);
            this.TaxTXT.Name = "TaxTXT";
            this.TaxTXT.ReadOnly = true;
            this.TaxTXT.Size = new System.Drawing.Size(149, 23);
            this.TaxTXT.TabIndex = 13;
            // 
            // TotalTXT
            // 
            this.TotalTXT.Location = new System.Drawing.Point(168, 270);
            this.TotalTXT.Name = "TotalTXT";
            this.TotalTXT.ReadOnly = true;
            this.TotalTXT.Size = new System.Drawing.Size(149, 23);
            this.TotalTXT.TabIndex = 14;
            // 
            // StateCombo
            // 
            this.StateCombo.FormattingEnabled = true;
            this.StateCombo.Location = new System.Drawing.Point(168, 27);
            this.StateCombo.Name = "StateCombo";
            this.StateCombo.Size = new System.Drawing.Size(149, 23);
            this.StateCombo.TabIndex = 15;
            // 
            // ProductCombo
            // 
            this.ProductCombo.FormattingEnabled = true;
            this.ProductCombo.Location = new System.Drawing.Point(168, 59);
            this.ProductCombo.Name = "ProductCombo";
            this.ProductCombo.Size = new System.Drawing.Size(149, 23);
            this.ProductCombo.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 450);
            this.Controls.Add(this.ProductCombo);
            this.Controls.Add(this.StateCombo);
            this.Controls.Add(this.TotalTXT);
            this.Controls.Add(this.TaxTXT);
            this.Controls.Add(this.DisCstTXT);
            this.Controls.Add(this.InitialTXT);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TaxLBL);
            this.Controls.Add(this.DisCstLBL);
            this.Controls.Add(this.InitialLBL);
            this.Controls.Add(this.QuanTXT);
            this.Controls.Add(this.CalcBtn);
            this.Controls.Add(this.QuanLBL);
            this.Controls.Add(this.ProductLBL);
            this.Controls.Add(this.Non);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Non;
        private System.Windows.Forms.Label ProductLBL;
        private System.Windows.Forms.Label QuanLBL;
        private System.Windows.Forms.Button CalcBtn;
        private System.Windows.Forms.TextBox QuanTXT;
        private System.Windows.Forms.Label InitialLBL;
        private System.Windows.Forms.Label DisCstLBL;
        private System.Windows.Forms.Label TaxLBL;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox InitialTXT;
        private System.Windows.Forms.TextBox DisCstTXT;
        private System.Windows.Forms.TextBox TaxTXT;
        private System.Windows.Forms.TextBox TotalTXT;
        private System.Windows.Forms.ComboBox StateCombo;
        private System.Windows.Forms.ComboBox ProductCombo;
    }
}

