namespace ExpensesTracker
{
    partial class Expenses
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Expenses));
            panel1 = new Panel();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            ExpNameLbl = new TextBox();
            label2 = new Label();
            label4 = new Label();
            ExpAmountLbl = new TextBox();
            label5 = new Label();
            ExpDescriptionLbl = new TextBox();
            label6 = new Label();
            ExpCategoryLbl = new ComboBox();
            label7 = new Label();
            ExpDOB = new DateTimePicker();
            AddBtn = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
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
            panel1.Size = new Size(584, 38);
            panel1.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ControlText;
            label3.Location = new Point(57, 11);
            label3.Name = "label3";
            label3.Size = new Size(147, 27);
            label3.TabIndex = 13;
            label3.Text = "Add Expenses";
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
            pictureBox2.Location = new Point(533, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(42, 31);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 8;
            pictureBox2.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(67, 58);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(0, 21);
            label1.TabIndex = 1;
            // 
            // ExpNameLbl
            // 
            ExpNameLbl.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ExpNameLbl.Location = new Point(110, 110);
            ExpNameLbl.Margin = new Padding(2);
            ExpNameLbl.Name = "ExpNameLbl";
            ExpNameLbl.Size = new Size(344, 29);
            ExpNameLbl.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.Desktop;
            label2.Location = new Point(110, 91);
            label2.Name = "label2";
            label2.Size = new Size(119, 19);
            label2.TabIndex = 12;
            label2.Text = "Expense Name:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.Desktop;
            label4.Location = new Point(110, 150);
            label4.Name = "label4";
            label4.Size = new Size(135, 19);
            label4.TabIndex = 14;
            label4.Text = "Expense Amount:";
            // 
            // ExpAmountLbl
            // 
            ExpAmountLbl.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ExpAmountLbl.Location = new Point(110, 169);
            ExpAmountLbl.Margin = new Padding(2);
            ExpAmountLbl.Name = "ExpAmountLbl";
            ExpAmountLbl.Size = new Size(344, 29);
            ExpAmountLbl.TabIndex = 13;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.Desktop;
            label5.Location = new Point(110, 342);
            label5.Name = "label5";
            label5.Size = new Size(157, 19);
            label5.TabIndex = 16;
            label5.Text = "Expense Description:";
            // 
            // ExpDescriptionLbl
            // 
            ExpDescriptionLbl.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ExpDescriptionLbl.Location = new Point(112, 374);
            ExpDescriptionLbl.Margin = new Padding(2);
            ExpDescriptionLbl.Multiline = true;
            ExpDescriptionLbl.Name = "ExpDescriptionLbl";
            ExpDescriptionLbl.Size = new Size(344, 66);
            ExpDescriptionLbl.TabIndex = 15;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.Desktop;
            label6.Location = new Point(110, 217);
            label6.Name = "label6";
            label6.Size = new Size(141, 19);
            label6.TabIndex = 17;
            label6.Text = "Expense Category:";
            // 
            // ExpCategoryLbl
            // 
            ExpCategoryLbl.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ExpCategoryLbl.FormattingEnabled = true;
            ExpCategoryLbl.Items.AddRange(new object[] { "Food", "Shopping", "Medical", "Household", "Travel", "Vehicle", "Other" });
            ExpCategoryLbl.Location = new Point(110, 242);
            ExpCategoryLbl.Margin = new Padding(2);
            ExpCategoryLbl.Name = "ExpCategoryLbl";
            ExpCategoryLbl.Size = new Size(344, 29);
            ExpCategoryLbl.TabIndex = 18;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = SystemColors.Desktop;
            label7.Location = new Point(110, 278);
            label7.Name = "label7";
            label7.Size = new Size(110, 19);
            label7.TabIndex = 19;
            label7.Text = "Expense Date:";
            // 
            // ExpDOB
            // 
            ExpDOB.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ExpDOB.Format = DateTimePickerFormat.Short;
            ExpDOB.Location = new Point(110, 304);
            ExpDOB.Margin = new Padding(2);
            ExpDOB.Name = "ExpDOB";
            ExpDOB.Size = new Size(344, 29);
            ExpDOB.TabIndex = 20;
            // 
            // AddBtn
            // 
            AddBtn.BackColor = SystemColors.Desktop;
            AddBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            AddBtn.ForeColor = SystemColors.Control;
            AddBtn.Location = new Point(210, 449);
            AddBtn.Margin = new Padding(2);
            AddBtn.Name = "AddBtn";
            AddBtn.Size = new Size(136, 33);
            AddBtn.TabIndex = 21;
            AddBtn.Text = "Add Expense";
            AddBtn.UseVisualStyleBackColor = false;
            AddBtn.Click += AddBtn_Click;
            // 
            // Expenses
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(584, 489);
            Controls.Add(AddBtn);
            Controls.Add(ExpDOB);
            Controls.Add(label7);
            Controls.Add(ExpCategoryLbl);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(ExpDescriptionLbl);
            Controls.Add(label4);
            Controls.Add(ExpAmountLbl);
            Controls.Add(label2);
            Controls.Add(ExpNameLbl);
            Controls.Add(label1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2);
            Name = "Expenses";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Expenses";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label label3;
        private Label label1;
        private TextBox ExpNameLbl;
        private Label label2;
        private Label label4;
        private TextBox ExpAmountLbl;
        private Label label5;
        private TextBox ExpDescriptionLbl;
        private Label label6;
        private ComboBox ExpCategoryLbl;
        private Label label7;
        private DateTimePicker ExpDOB;
        private Button AddBtn;
    }
}