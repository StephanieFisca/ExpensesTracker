namespace ExpensesTracker
{
    partial class AdminLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminLogin));
            pictureBox1 = new PictureBox();
            label4 = new Label();
            label2 = new Label();
            LoginBtn = new Button();
            UPasswordTxt = new TextBox();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            panel1 = new Panel();
            label3 = new Label();
            UNameTxt = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(547, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(37, 34);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 23;
            pictureBox1.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.Desktop;
            label4.Location = new Point(349, 155);
            label4.Name = "label4";
            label4.Size = new Size(82, 19);
            label4.TabIndex = 22;
            label4.Text = "Password:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 12F, FontStyle.Underline, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.Desktop;
            label2.Location = new Point(370, 273);
            label2.Name = "label2";
            label2.Size = new Size(41, 19);
            label2.TabIndex = 20;
            label2.Text = "Back";
            label2.Click += label2_Click;
            // 
            // LoginBtn
            // 
            LoginBtn.BackColor = SystemColors.Desktop;
            LoginBtn.FlatStyle = FlatStyle.Flat;
            LoginBtn.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            LoginBtn.ForeColor = SystemColors.Control;
            LoginBtn.Location = new Point(303, 227);
            LoginBtn.Margin = new Padding(2);
            LoginBtn.Name = "LoginBtn";
            LoginBtn.Size = new Size(178, 30);
            LoginBtn.TabIndex = 19;
            LoginBtn.Text = "LOGIN";
            LoginBtn.UseVisualStyleBackColor = false;
            LoginBtn.Click += LoginBtn_Click;
            // 
            // UPasswordTxt
            // 
            UPasswordTxt.BackColor = Color.LightGray;
            UPasswordTxt.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            UPasswordTxt.Location = new Point(228, 177);
            UPasswordTxt.Name = "UPasswordTxt";
            UPasswordTxt.PasswordChar = '*';
            UPasswordTxt.Size = new Size(330, 32);
            UPasswordTxt.TabIndex = 18;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(27, 86);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(123, 135);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 16;
            pictureBox2.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Desktop;
            label1.Location = new Point(215, 9);
            label1.Name = "label1";
            label1.Size = new Size(313, 27);
            label1.TabIndex = 15;
            label1.Text = "Expenses Management System";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Desktop;
            panel1.Controls.Add(pictureBox2);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(189, 319);
            panel1.TabIndex = 14;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.Desktop;
            label3.Location = new Point(345, 86);
            label3.Name = "label3";
            label3.Size = new Size(86, 19);
            label3.TabIndex = 25;
            label3.Text = "Username:";
            // 
            // UNameTxt
            // 
            UNameTxt.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            UNameTxt.Location = new Point(228, 114);
            UNameTxt.Margin = new Padding(2);
            UNameTxt.Name = "UNameTxt";
            UNameTxt.Size = new Size(330, 29);
            UNameTxt.TabIndex = 24;
            // 
            // AdminLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(589, 319);
            Controls.Add(label3);
            Controls.Add(UNameTxt);
            Controls.Add(pictureBox1);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(LoginBtn);
            Controls.Add(UPasswordTxt);
            Controls.Add(label1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AdminLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AdminLogin";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label4;
        private Label label2;
        private Button LoginBtn;
        private TextBox UPasswordTxt;
        private PictureBox pictureBox2;
        private Label label1;
        private Panel panel1;
        private Label label3;
        private TextBox UNameTxt;
    }
}