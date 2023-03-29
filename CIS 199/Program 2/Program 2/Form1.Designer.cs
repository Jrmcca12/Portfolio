namespace Program_2
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
            this.WeightLBL = new System.Windows.Forms.Label();
            this.DistanceLBL = new System.Windows.Forms.Label();
            this.DeliveryLBL = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TxtLowest = new System.Windows.Forms.TextBox();
            this.ComALBL = new System.Windows.Forms.Label();
            this.ComBLBL = new System.Windows.Forms.Label();
            this.TXTComB = new System.Windows.Forms.TextBox();
            this.ComCLBL = new System.Windows.Forms.Label();
            this.TXTComC = new System.Windows.Forms.TextBox();
            this.TXTComA = new System.Windows.Forms.TextBox();
            this.TXTWeight = new System.Windows.Forms.TextBox();
            this.TXTDelivery = new System.Windows.Forms.TextBox();
            this.TXTDistance = new System.Windows.Forms.TextBox();
            this.CalcBtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // WeightLBL
            // 
            this.WeightLBL.AutoSize = true;
            this.WeightLBL.Location = new System.Drawing.Point(34, 80);
            this.WeightLBL.Name = "WeightLBL";
            this.WeightLBL.Size = new System.Drawing.Size(98, 15);
            this.WeightLBL.TabIndex = 0;
            this.WeightLBL.Text = "Package Weight: ";
            
            // 
            // DistanceLBL
            // 
            this.DistanceLBL.AutoSize = true;
            this.DistanceLBL.Location = new System.Drawing.Point(34, 135);
            this.DistanceLBL.Name = "DistanceLBL";
            this.DistanceLBL.Size = new System.Drawing.Size(91, 15);
            this.DistanceLBL.TabIndex = 0;
            this.DistanceLBL.Text = "Distance (Miles)";
            // 
            // DeliveryLBL
            // 
            this.DeliveryLBL.AutoSize = true;
            this.DeliveryLBL.Location = new System.Drawing.Point(34, 188);
            this.DeliveryLBL.Name = "DeliveryLBL";
            this.DeliveryLBL.Size = new System.Drawing.Size(77, 15);
            this.DeliveryLBL.TabIndex = 0;
            this.DeliveryLBL.Text = "Delivery Days";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TxtLowest);
            this.groupBox1.Controls.Add(this.ComALBL);
            this.groupBox1.Controls.Add(this.ComBLBL);
            this.groupBox1.Controls.Add(this.TXTComB);
            this.groupBox1.Controls.Add(this.ComCLBL);
            this.groupBox1.Controls.Add(this.TXTComC);
            this.groupBox1.Controls.Add(this.TXTComA);
            this.groupBox1.Location = new System.Drawing.Point(324, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(352, 295);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Results";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // TxtLowest
            // 
            this.TxtLowest.Location = new System.Drawing.Point(39, 247);
            this.TxtLowest.Name = "TxtLowest";
            this.TxtLowest.ReadOnly = true;
            this.TxtLowest.Size = new System.Drawing.Size(278, 23);
            this.TxtLowest.TabIndex = 3;
            // 
            // ComALBL
            // 
            this.ComALBL.AutoSize = true;
            this.ComALBL.Location = new System.Drawing.Point(63, 63);
            this.ComALBL.Name = "ComALBL";
            this.ComALBL.Size = new System.Drawing.Size(97, 15);
            this.ComALBL.TabIndex = 0;
            this.ComALBL.Text = "Company A Cost";
            // 
            // ComBLBL
            // 
            this.ComBLBL.AutoSize = true;
            this.ComBLBL.Location = new System.Drawing.Point(63, 118);
            this.ComBLBL.Name = "ComBLBL";
            this.ComBLBL.Size = new System.Drawing.Size(96, 15);
            this.ComBLBL.TabIndex = 0;
            this.ComBLBL.Text = "Company B Cost";
            // 
            // TXTComB
            // 
            this.TXTComB.Location = new System.Drawing.Point(197, 115);
            this.TXTComB.Name = "TXTComB";
            this.TXTComB.ReadOnly = true;
            this.TXTComB.Size = new System.Drawing.Size(100, 23);
            this.TXTComB.TabIndex = 2;
            // 
            // ComCLBL
            // 
            this.ComCLBL.AutoSize = true;
            this.ComCLBL.Location = new System.Drawing.Point(63, 171);
            this.ComCLBL.Name = "ComCLBL";
            this.ComCLBL.Size = new System.Drawing.Size(97, 15);
            this.ComCLBL.TabIndex = 0;
            this.ComCLBL.Text = "Company C Cost";
            // 
            // TXTComC
            // 
            this.TXTComC.Location = new System.Drawing.Point(197, 168);
            this.TXTComC.Name = "TXTComC";
            this.TXTComC.ReadOnly = true;
            this.TXTComC.Size = new System.Drawing.Size(100, 23);
            this.TXTComC.TabIndex = 2;
            // 
            // TXTComA
            // 
            this.TXTComA.Location = new System.Drawing.Point(197, 60);
            this.TXTComA.Name = "TXTComA";
            this.TXTComA.ReadOnly = true;
            this.TXTComA.Size = new System.Drawing.Size(100, 23);
            this.TXTComA.TabIndex = 2;
            // 
            // TXTWeight
            // 
            this.TXTWeight.Location = new System.Drawing.Point(168, 77);
            this.TXTWeight.Name = "TXTWeight";
            this.TXTWeight.Size = new System.Drawing.Size(100, 23);
            this.TXTWeight.TabIndex = 2;
            // 
            // TXTDelivery
            // 
            this.TXTDelivery.Location = new System.Drawing.Point(168, 185);
            this.TXTDelivery.Name = "TXTDelivery";
            this.TXTDelivery.Size = new System.Drawing.Size(100, 23);
            this.TXTDelivery.TabIndex = 2;
            // 
            // TXTDistance
            // 
            this.TXTDistance.Location = new System.Drawing.Point(168, 132);
            this.TXTDistance.Name = "TXTDistance";
            this.TXTDistance.Size = new System.Drawing.Size(100, 23);
            this.TXTDistance.TabIndex = 2;
            // 
            // CalcBtn
            // 
            this.CalcBtn.Location = new System.Drawing.Point(85, 304);
            this.CalcBtn.Name = "CalcBtn";
            this.CalcBtn.Size = new System.Drawing.Size(110, 23);
            this.CalcBtn.TabIndex = 3;
            this.CalcBtn.Text = "Calculate Cost";
            this.CalcBtn.UseVisualStyleBackColor = true;
            this.CalcBtn.Click += new System.EventHandler(this.CalcBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CalcBtn);
            this.Controls.Add(this.TXTDistance);
            this.Controls.Add(this.TXTDelivery);
            this.Controls.Add(this.TXTWeight);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.DeliveryLBL);
            this.Controls.Add(this.DistanceLBL);
            this.Controls.Add(this.WeightLBL);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label WeightLBL;
        private System.Windows.Forms.Label DistanceLBL;
        private System.Windows.Forms.Label DeliveryLBL;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TxtLowest;
        private System.Windows.Forms.Label ComALBL;
        private System.Windows.Forms.Label ComBLBL;
        private System.Windows.Forms.TextBox TXTComB;
        private System.Windows.Forms.Label ComCLBL;
        private System.Windows.Forms.TextBox TXTComC;
        private System.Windows.Forms.TextBox TXTComA;
        private System.Windows.Forms.TextBox TXTWeight;
        private System.Windows.Forms.TextBox TXTDelivery;
        private System.Windows.Forms.TextBox TXTDistance;
        private System.Windows.Forms.Button CalcBtn;
    }
}

