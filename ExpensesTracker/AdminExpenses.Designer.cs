namespace ExpensesTracker
{
    partial class AdminExpenses
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminExpenses));
            panel1 = new Panel();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            ExpensesDGV = new DataGridView();
            pictureBox3 = new PictureBox();
            ExpCategoryLbl = new ComboBox();
            label6 = new Label();
            pictureBox4 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ExpensesDGV).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
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
            panel1.TabIndex = 34;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ControlText;
            label3.Location = new Point(57, 11);
            label3.Name = "label3";
            label3.Size = new Size(156, 27);
            label3.TabIndex = 13;
            label3.Text = "View Expenses";
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
            // ExpensesDGV
            // 
            ExpensesDGV.BackgroundColor = SystemColors.ControlDarkDark;
            ExpensesDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ExpensesDGV.Location = new Point(0, 110);
            ExpensesDGV.Margin = new Padding(2);
            ExpensesDGV.Name = "ExpensesDGV";
            ExpensesDGV.RowHeadersWidth = 62;
            ExpensesDGV.RowTemplate.Height = 33;
            ExpensesDGV.Size = new Size(832, 379);
            ExpensesDGV.TabIndex = 36;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(781, 43);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(42, 35);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 38;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // ExpCategoryLbl
            // 
            ExpCategoryLbl.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ExpCategoryLbl.FormattingEnabled = true;
            ExpCategoryLbl.Items.AddRange(new object[] { "Food", "Shopping", "Medical", "Household", "Travel", "Vehicle", "Other" });
            ExpCategoryLbl.Location = new Point(265, 66);
            ExpCategoryLbl.Margin = new Padding(2);
            ExpCategoryLbl.Name = "ExpCategoryLbl";
            ExpCategoryLbl.Size = new Size(344, 29);
            ExpCategoryLbl.TabIndex = 42;
            ExpCategoryLbl.SelectedIndexChanged += ExpCategoryLbl_SelectedIndexChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.Desktop;
            label6.Location = new Point(119, 70);
            label6.Name = "label6";
            label6.Size = new Size(141, 19);
            label6.TabIndex = 41;
            label6.Text = "Expense Category:";
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(614, 66);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(42, 35);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 40;
            pictureBox4.TabStop = false;
            pictureBox4.Click += pictureBox4_Click;
            // 
            // AdminExpenses
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(832, 489);
            Controls.Add(ExpCategoryLbl);
            Controls.Add(label6);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(ExpensesDGV);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2);
            Name = "AdminExpenses";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AdminExpenses";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)ExpensesDGV).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panel1;
        private Label label3;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private DataGridView ExpensesDGV;
        private PictureBox pictureBox3;
        private ComboBox ExpCategoryLbl;
        private Label label6;
        private PictureBox pictureBox4;
    }
}