namespace ExpensesTracker
{
    partial class Reports
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reports));
            panel1 = new Panel();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            panel2 = new Panel();
            MaxLbl = new Label();
            panel3 = new Panel();
            label1 = new Label();
            panel4 = new Panel();
            MinLbl = new Label();
            panel5 = new Panel();
            label5 = new Label();
            panel6 = new Panel();
            AvgLbl = new Label();
            panel7 = new Panel();
            label7 = new Label();
            panel8 = new Panel();
            TotalLbl = new Label();
            panel9 = new Panel();
            label9 = new Label();
            panel10 = new Panel();
            HighestLbl = new Label();
            panel11 = new Panel();
            label11 = new Label();
            panel12 = new Panel();
            LowestLbl = new Label();
            panel13 = new Panel();
            label13 = new Label();
            CatCB = new ComboBox();
            label14 = new Label();
            TotByCatLbl = new Label();
            CountLbl = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            panel7.SuspendLayout();
            panel8.SuspendLayout();
            panel9.SuspendLayout();
            panel10.SuspendLayout();
            panel11.SuspendLayout();
            panel12.SuspendLayout();
            panel13.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label3);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(pictureBox2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(832, 38);
            panel1.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ControlText;
            label3.Location = new Point(57, 11);
            label3.Name = "label3";
            label3.Size = new Size(77, 27);
            label3.TabIndex = 13;
            label3.Text = "Report";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(9, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(42, 31);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(781, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(42, 31);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 8;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.Desktop;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(MaxLbl);
            panel2.Controls.Add(panel3);
            panel2.Location = new Point(34, 68);
            panel2.Margin = new Padding(2);
            panel2.Name = "panel2";
            panel2.Size = new Size(211, 91);
            panel2.TabIndex = 3;
            // 
            // MaxLbl
            // 
            MaxLbl.AutoSize = true;
            MaxLbl.Font = new Font("Tahoma", 16F, FontStyle.Regular, GraphicsUnit.Point);
            MaxLbl.ForeColor = SystemColors.ControlText;
            MaxLbl.Location = new Point(3, 38);
            MaxLbl.Name = "MaxLbl";
            MaxLbl.Size = new Size(46, 27);
            MaxLbl.TabIndex = 15;
            MaxLbl.Text = "Min";
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ControlDark;
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(label1);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Margin = new Padding(2);
            panel3.Name = "panel3";
            panel3.Size = new Size(209, 16);
            panel3.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlText;
            label1.Location = new Point(2, -2);
            label1.Name = "label1";
            label1.Size = new Size(72, 18);
            label1.TabIndex = 14;
            label1.Text = "Maximum";
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.Desktop;
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(MinLbl);
            panel4.Controls.Add(panel5);
            panel4.Location = new Point(573, 69);
            panel4.Margin = new Padding(2);
            panel4.Name = "panel4";
            panel4.Size = new Size(211, 91);
            panel4.TabIndex = 4;
            // 
            // MinLbl
            // 
            MinLbl.AutoSize = true;
            MinLbl.Font = new Font("Tahoma", 16F, FontStyle.Regular, GraphicsUnit.Point);
            MinLbl.ForeColor = SystemColors.ControlText;
            MinLbl.Location = new Point(3, 37);
            MinLbl.Name = "MinLbl";
            MinLbl.Size = new Size(46, 27);
            MinLbl.TabIndex = 15;
            MinLbl.Text = "Min";
            // 
            // panel5
            // 
            panel5.BackColor = SystemColors.ControlDark;
            panel5.BorderStyle = BorderStyle.FixedSingle;
            panel5.Controls.Add(label5);
            panel5.Dock = DockStyle.Top;
            panel5.Location = new Point(0, 0);
            panel5.Margin = new Padding(2);
            panel5.Name = "panel5";
            panel5.Size = new Size(209, 16);
            panel5.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tahoma", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ControlText;
            label5.Location = new Point(2, -2);
            label5.Name = "label5";
            label5.Size = new Size(66, 18);
            label5.TabIndex = 14;
            label5.Text = "Minimum";
            // 
            // panel6
            // 
            panel6.BackColor = SystemColors.Desktop;
            panel6.BorderStyle = BorderStyle.FixedSingle;
            panel6.Controls.Add(AvgLbl);
            panel6.Controls.Add(panel7);
            panel6.Location = new Point(34, 177);
            panel6.Margin = new Padding(2);
            panel6.Name = "panel6";
            panel6.Size = new Size(211, 91);
            panel6.TabIndex = 5;
            // 
            // AvgLbl
            // 
            AvgLbl.AutoSize = true;
            AvgLbl.Font = new Font("Tahoma", 16F, FontStyle.Regular, GraphicsUnit.Point);
            AvgLbl.ForeColor = SystemColors.ControlText;
            AvgLbl.Location = new Point(2, 38);
            AvgLbl.Name = "AvgLbl";
            AvgLbl.Size = new Size(48, 27);
            AvgLbl.TabIndex = 15;
            AvgLbl.Text = "Avg";
            // 
            // panel7
            // 
            panel7.BackColor = SystemColors.ControlDark;
            panel7.BorderStyle = BorderStyle.FixedSingle;
            panel7.Controls.Add(label7);
            panel7.Dock = DockStyle.Top;
            panel7.Location = new Point(0, 0);
            panel7.Margin = new Padding(2);
            panel7.Name = "panel7";
            panel7.Size = new Size(209, 16);
            panel7.TabIndex = 4;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Tahoma", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = SystemColors.ControlText;
            label7.Location = new Point(2, -2);
            label7.Name = "label7";
            label7.Size = new Size(62, 18);
            label7.TabIndex = 14;
            label7.Text = "Average";
            // 
            // panel8
            // 
            panel8.BackColor = SystemColors.Desktop;
            panel8.BorderStyle = BorderStyle.FixedSingle;
            panel8.Controls.Add(TotalLbl);
            panel8.Controls.Add(panel9);
            panel8.Location = new Point(573, 178);
            panel8.Margin = new Padding(2);
            panel8.Name = "panel8";
            panel8.Size = new Size(211, 91);
            panel8.TabIndex = 6;
            // 
            // TotalLbl
            // 
            TotalLbl.AutoSize = true;
            TotalLbl.Font = new Font("Tahoma", 16F, FontStyle.Regular, GraphicsUnit.Point);
            TotalLbl.ForeColor = SystemColors.ControlText;
            TotalLbl.Location = new Point(-1, 37);
            TotalLbl.Name = "TotalLbl";
            TotalLbl.Size = new Size(61, 27);
            TotalLbl.TabIndex = 15;
            TotalLbl.Text = "Total";
            // 
            // panel9
            // 
            panel9.BackColor = SystemColors.ControlDark;
            panel9.BorderStyle = BorderStyle.FixedSingle;
            panel9.Controls.Add(label9);
            panel9.Dock = DockStyle.Top;
            panel9.Location = new Point(0, 0);
            panel9.Margin = new Padding(2);
            panel9.Name = "panel9";
            panel9.Size = new Size(209, 16);
            panel9.TabIndex = 4;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Tahoma", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label9.ForeColor = SystemColors.ControlText;
            label9.Location = new Point(2, -2);
            label9.Name = "label9";
            label9.Size = new Size(41, 18);
            label9.TabIndex = 14;
            label9.Text = "Total";
            // 
            // panel10
            // 
            panel10.BackColor = SystemColors.Desktop;
            panel10.BorderStyle = BorderStyle.FixedSingle;
            panel10.Controls.Add(HighestLbl);
            panel10.Controls.Add(panel11);
            panel10.Location = new Point(33, 286);
            panel10.Margin = new Padding(2);
            panel10.Name = "panel10";
            panel10.Size = new Size(211, 91);
            panel10.TabIndex = 7;
            // 
            // HighestLbl
            // 
            HighestLbl.AutoSize = true;
            HighestLbl.Font = new Font("Tahoma", 16F, FontStyle.Regular, GraphicsUnit.Point);
            HighestLbl.ForeColor = SystemColors.ControlText;
            HighestLbl.Location = new Point(1, 37);
            HighestLbl.Name = "HighestLbl";
            HighestLbl.Size = new Size(85, 27);
            HighestLbl.TabIndex = 15;
            HighestLbl.Text = "Highest";
            // 
            // panel11
            // 
            panel11.BackColor = SystemColors.ControlDark;
            panel11.BorderStyle = BorderStyle.FixedSingle;
            panel11.Controls.Add(label11);
            panel11.Dock = DockStyle.Top;
            panel11.Location = new Point(0, 0);
            panel11.Margin = new Padding(2);
            panel11.Name = "panel11";
            panel11.Size = new Size(209, 16);
            panel11.TabIndex = 4;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Tahoma", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label11.ForeColor = SystemColors.ControlText;
            label11.Location = new Point(2, -2);
            label11.Name = "label11";
            label11.Size = new Size(116, 18);
            label11.TabIndex = 14;
            label11.Text = "Highest Expense";
            // 
            // panel12
            // 
            panel12.BackColor = SystemColors.Desktop;
            panel12.BorderStyle = BorderStyle.FixedSingle;
            panel12.Controls.Add(LowestLbl);
            panel12.Controls.Add(panel13);
            panel12.Location = new Point(573, 286);
            panel12.Margin = new Padding(2);
            panel12.Name = "panel12";
            panel12.Size = new Size(211, 91);
            panel12.TabIndex = 8;
            // 
            // LowestLbl
            // 
            LowestLbl.AutoSize = true;
            LowestLbl.Font = new Font("Tahoma", 16F, FontStyle.Regular, GraphicsUnit.Point);
            LowestLbl.ForeColor = SystemColors.ControlText;
            LowestLbl.Location = new Point(0, 37);
            LowestLbl.Name = "LowestLbl";
            LowestLbl.Size = new Size(80, 27);
            LowestLbl.TabIndex = 15;
            LowestLbl.Text = "Lowest";
            // 
            // panel13
            // 
            panel13.BackColor = SystemColors.ControlDark;
            panel13.BorderStyle = BorderStyle.FixedSingle;
            panel13.Controls.Add(label13);
            panel13.Dock = DockStyle.Top;
            panel13.Location = new Point(0, 0);
            panel13.Margin = new Padding(2);
            panel13.Name = "panel13";
            panel13.Size = new Size(209, 16);
            panel13.TabIndex = 4;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Tahoma", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label13.ForeColor = SystemColors.ControlText;
            label13.Location = new Point(2, -2);
            label13.Name = "label13";
            label13.Size = new Size(113, 18);
            label13.TabIndex = 14;
            label13.Text = "Lowest Expense";
            // 
            // CatCB
            // 
            CatCB.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            CatCB.FormattingEnabled = true;
            CatCB.Items.AddRange(new object[] { "Food", "Shopping", "Medical", "Household", "Travel", "Vehicle", "Other" });
            CatCB.Location = new Point(234, 408);
            CatCB.Margin = new Padding(2);
            CatCB.Name = "CatCB";
            CatCB.Size = new Size(344, 29);
            CatCB.TabIndex = 20;
            CatCB.SelectionChangeCommitted += CatCB_SelectionChangeCommitted;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label14.ForeColor = SystemColors.Desktop;
            label14.Location = new Point(322, 381);
            label14.Name = "label14";
            label14.Size = new Size(141, 19);
            label14.TabIndex = 19;
            label14.Text = "Expense Category:";
            // 
            // TotByCatLbl
            // 
            TotByCatLbl.AutoSize = true;
            TotByCatLbl.Font = new Font("Tahoma", 16F, FontStyle.Regular, GraphicsUnit.Point);
            TotByCatLbl.ForeColor = SystemColors.ControlText;
            TotByCatLbl.Location = new Point(355, 445);
            TotByCatLbl.Name = "TotByCatLbl";
            TotByCatLbl.Size = new Size(86, 27);
            TotByCatLbl.TabIndex = 21;
            TotByCatLbl.Text = "Amount";
            TotByCatLbl.Visible = false;
            TotByCatLbl.Click += TotByCatLbl_Click;
            // 
            // CountLbl
            // 
            CountLbl.AutoSize = true;
            CountLbl.Font = new Font("Tahoma", 16F, FontStyle.Regular, GraphicsUnit.Point);
            CountLbl.ForeColor = SystemColors.ControlText;
            CountLbl.Location = new Point(574, 40);
            CountLbl.Name = "CountLbl";
            CountLbl.Size = new Size(68, 27);
            CountLbl.TabIndex = 22;
            CountLbl.Text = "Count";
            // 
            // Reports
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(832, 489);
            Controls.Add(CountLbl);
            Controls.Add(TotByCatLbl);
            Controls.Add(CatCB);
            Controls.Add(label14);
            Controls.Add(panel12);
            Controls.Add(panel10);
            Controls.Add(panel8);
            Controls.Add(panel6);
            Controls.Add(panel4);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2);
            Name = "Reports";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Reports";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            panel10.ResumeLayout(false);
            panel10.PerformLayout();
            panel11.ResumeLayout(false);
            panel11.PerformLayout();
            panel12.ResumeLayout(false);
            panel12.PerformLayout();
            panel13.ResumeLayout(false);
            panel13.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label3;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Panel panel2;
        private Label MaxLbl;
        private Panel panel3;
        private Label label1;
        private Panel panel4;
        private Label MinLbl;
        private Panel panel5;
        private Label label5;
        private Panel panel6;
        private Label AvgLbl;
        private Panel panel7;
        private Label label7;
        private Panel panel8;
        private Label TotalLbl;
        private Panel panel9;
        private Label label9;
        private Panel panel10;
        private Label HighestLbl;
        private Panel panel11;
        private Label label11;
        private Panel panel12;
        private Label LowestLbl;
        private Panel panel13;
        private Label label13;
        private ComboBox CatCB;
        private Label label14;
        private Label TotByCatLbl;
        private Label CountLbl;
    }
}