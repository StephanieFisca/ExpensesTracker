namespace ExpensesTracker
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            pictureBox2 = new PictureBox();
            panel1 = new Panel();
            label1 = new Label();
            UNameTxt = new TextBox();
            UPasswordTxt = new TextBox();
            LoginBtn = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(370, 86);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(70, 66);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 6;
            pictureBox2.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Desktop;
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(189, 333);
            panel1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Desktop;
            label1.Location = new Point(237, 47);
            label1.Name = "label1";
            label1.Size = new Size(313, 27);
            label1.TabIndex = 2;
            label1.Text = "Expenses Management System";
            // 
            // UNameTxt
            // 
            UNameTxt.BackColor = Color.LightGray;
            UNameTxt.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            UNameTxt.Location = new Point(220, 158);
            UNameTxt.Name = "UNameTxt";
            UNameTxt.Size = new Size(330, 32);
            UNameTxt.TabIndex = 7;
            // 
            // UPasswordTxt
            // 
            UPasswordTxt.BackColor = Color.LightGray;
            UPasswordTxt.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            UPasswordTxt.Location = new Point(220, 213);
            UPasswordTxt.Name = "UPasswordTxt";
            UPasswordTxt.PasswordChar = '*';
            UPasswordTxt.Size = new Size(330, 32);
            UPasswordTxt.TabIndex = 8;
            // 
            // LoginBtn
            // 
            LoginBtn.BackColor = SystemColors.Desktop;
            LoginBtn.FlatStyle = FlatStyle.Flat;
            LoginBtn.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            LoginBtn.ForeColor = SystemColors.Control;
            LoginBtn.Location = new Point(309, 262);
            LoginBtn.Margin = new Padding(2);
            LoginBtn.Name = "LoginBtn";
            LoginBtn.Size = new Size(178, 30);
            LoginBtn.TabIndex = 9;
            LoginBtn.Text = "LOGIN";
            LoginBtn.UseVisualStyleBackColor = false;
            LoginBtn.Click += LoginBtn_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 12F, FontStyle.Underline, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.Desktop;
            label2.Location = new Point(370, 300);
            label2.Name = "label2";
            label2.Size = new Size(56, 19);
            label2.TabIndex = 10;
            label2.Text = "Admin";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.Desktop;
            label3.Location = new Point(220, 138);
            label3.Name = "label3";
            label3.Size = new Size(86, 19);
            label3.TabIndex = 11;
            label3.Text = "Username:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.Desktop;
            label4.Location = new Point(220, 193);
            label4.Name = "label4";
            label4.Size = new Size(82, 19);
            label4.TabIndex = 12;
            label4.Text = "Password:";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(543, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(37, 34);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 13;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(579, 333);
            Controls.Add(pictureBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(LoginBtn);
            Controls.Add(UPasswordTxt);
            Controls.Add(UNameTxt);
            Controls.Add(pictureBox2);
            Controls.Add(label1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox2;
        private Panel panel1;
        private Label label1;
        private TextBox UNameTxt;
        private TextBox UPasswordTxt;
        private Button LoginBtn;
        private Label label2;
        private Label label3;
        private Label label4;
        private PictureBox pictureBox1;
    }
}