namespace ExpensesTracker
{
    partial class Users
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Users));
            panel1 = new Panel();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            UDOB = new DateTimePicker();
            label7 = new Label();
            label5 = new Label();
            UAddressTxt = new TextBox();
            label4 = new Label();
            UPhoneTxt = new TextBox();
            label2 = new Label();
            UNameTxt = new TextBox();
            UPasswordTxt = new TextBox();
            label1 = new Label();
            label6 = new Label();
            AddBtn = new Button();
            UserDGV = new DataGridView();
            label8 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)UserDGV).BeginInit();
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
            label3.Size = new Size(66, 27);
            label3.TabIndex = 13;
            label3.Text = "Users";
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
            // UDOB
            // 
            UDOB.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            UDOB.Format = DateTimePickerFormat.Short;
            UDOB.Location = new Point(356, 79);
            UDOB.Margin = new Padding(2);
            UDOB.Name = "UDOB";
            UDOB.Size = new Size(150, 29);
            UDOB.TabIndex = 30;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = SystemColors.Desktop;
            label7.Location = new Point(356, 59);
            label7.Name = "label7";
            label7.Size = new Size(84, 19);
            label7.TabIndex = 29;
            label7.Text = "User DOB:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.Desktop;
            label5.Location = new Point(431, 115);
            label5.Name = "label5";
            label5.Size = new Size(72, 19);
            label5.TabIndex = 26;
            label5.Text = "Address:";
            // 
            // UAddressTxt
            // 
            UAddressTxt.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            UAddressTxt.Location = new Point(433, 147);
            UAddressTxt.Margin = new Padding(2);
            UAddressTxt.Multiline = true;
            UAddressTxt.Name = "UAddressTxt";
            UAddressTxt.Size = new Size(227, 64);
            UAddressTxt.TabIndex = 25;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.Desktop;
            label4.Location = new Point(519, 59);
            label4.Name = "label4";
            label4.Size = new Size(96, 19);
            label4.TabIndex = 24;
            label4.Text = "User Phone:";
            // 
            // UPhoneTxt
            // 
            UPhoneTxt.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            UPhoneTxt.Location = new Point(519, 79);
            UPhoneTxt.Margin = new Padding(2);
            UPhoneTxt.Name = "UPhoneTxt";
            UPhoneTxt.Size = new Size(169, 29);
            UPhoneTxt.TabIndex = 23;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.Desktop;
            label2.Location = new Point(146, 59);
            label2.Name = "label2";
            label2.Size = new Size(56, 19);
            label2.TabIndex = 22;
            label2.Text = "Name:";
            // 
            // UNameTxt
            // 
            UNameTxt.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            UNameTxt.Location = new Point(146, 79);
            UNameTxt.Margin = new Padding(2);
            UNameTxt.Name = "UNameTxt";
            UNameTxt.Size = new Size(196, 29);
            UNameTxt.TabIndex = 21;
            // 
            // UPasswordTxt
            // 
            UPasswordTxt.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            UPasswordTxt.Location = new Point(220, 134);
            UPasswordTxt.Margin = new Padding(2);
            UPasswordTxt.Name = "UPasswordTxt";
            UPasswordTxt.Size = new Size(169, 29);
            UPasswordTxt.TabIndex = 31;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Desktop;
            label1.Location = new Point(220, 115);
            label1.Name = "label1";
            label1.Size = new Size(82, 19);
            label1.TabIndex = 32;
            label1.Text = "Password:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Tahoma", 12F, FontStyle.Underline, GraphicsUnit.Point);
            label6.ForeColor = Color.Red;
            label6.Location = new Point(704, 46);
            label6.Name = "label6";
            label6.Size = new Size(113, 19);
            label6.TabIndex = 33;
            label6.Text = "View Expenses";
            label6.Click += label6_Click;
            // 
            // AddBtn
            // 
            AddBtn.BackColor = SystemColors.Desktop;
            AddBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            AddBtn.ForeColor = SystemColors.Control;
            AddBtn.Location = new Point(342, 449);
            AddBtn.Margin = new Padding(2);
            AddBtn.Name = "AddBtn";
            AddBtn.Size = new Size(136, 33);
            AddBtn.TabIndex = 34;
            AddBtn.Text = "Add User";
            AddBtn.UseVisualStyleBackColor = false;
            AddBtn.Click += AddBtn_Click;
            // 
            // UserDGV
            // 
            UserDGV.BackgroundColor = SystemColors.Control;
            UserDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            UserDGV.Location = new Point(0, 229);
            UserDGV.Margin = new Padding(2);
            UserDGV.Name = "UserDGV";
            UserDGV.RowHeadersWidth = 62;
            UserDGV.RowTemplate.Height = 33;
            UserDGV.Size = new Size(832, 203);
            UserDGV.TabIndex = 35;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Rockwell", 12F, FontStyle.Underline, GraphicsUnit.Point);
            label8.ForeColor = Color.Red;
            label8.Location = new Point(696, 463);
            label8.Name = "label8";
            label8.Size = new Size(124, 19);
            label8.TabIndex = 36;
            label8.Text = "Add new admin";
            label8.Click += label8_Click;
            // 
            // Users
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonShadow;
            ClientSize = new Size(832, 489);
            Controls.Add(label8);
            Controls.Add(UserDGV);
            Controls.Add(AddBtn);
            Controls.Add(label6);
            Controls.Add(label1);
            Controls.Add(UPasswordTxt);
            Controls.Add(UDOB);
            Controls.Add(label7);
            Controls.Add(label5);
            Controls.Add(UAddressTxt);
            Controls.Add(label4);
            Controls.Add(UPhoneTxt);
            Controls.Add(label2);
            Controls.Add(UNameTxt);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2);
            Name = "Users";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Users";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)UserDGV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label3;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private DateTimePicker UDOB;
        private Label label7;
        private Label label5;
        private TextBox UAddressTxt;
        private Label label4;
        private TextBox UPhoneTxt;
        private Label label2;
        private TextBox UNameTxt;
        private TextBox UPasswordTxt;
        private Label label1;
        private Label label6;
        private Button AddBtn;
        private DataGridView UserDGV;
        private Label label8;
    }
}