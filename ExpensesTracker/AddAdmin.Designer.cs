namespace ExpensesTracker
{
    partial class AddAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddAdmin));
            label4 = new Label();
            AddBtn = new Button();
            UPasswordTxt = new TextBox();
            label1 = new Label();
            label2 = new Label();
            UNameTxt = new TextBox();
            pictureBox3 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.Desktop;
            label4.Location = new Point(242, 127);
            label4.Name = "label4";
            label4.Size = new Size(82, 19);
            label4.TabIndex = 26;
            label4.Text = "Password:";
            // 
            // AddBtn
            // 
            AddBtn.BackColor = SystemColors.Desktop;
            AddBtn.FlatStyle = FlatStyle.Flat;
            AddBtn.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            AddBtn.ForeColor = SystemColors.Control;
            AddBtn.Location = new Point(196, 195);
            AddBtn.Margin = new Padding(2);
            AddBtn.Name = "AddBtn";
            AddBtn.Size = new Size(178, 30);
            AddBtn.TabIndex = 25;
            AddBtn.Text = "ADD";
            AddBtn.UseVisualStyleBackColor = false;
            AddBtn.Click += AddBtn_Click;
            // 
            // UPasswordTxt
            // 
            UPasswordTxt.BackColor = Color.LightGray;
            UPasswordTxt.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            UPasswordTxt.Location = new Point(120, 149);
            UPasswordTxt.Name = "UPasswordTxt";
            UPasswordTxt.PasswordChar = '*';
            UPasswordTxt.Size = new Size(330, 32);
            UPasswordTxt.TabIndex = 24;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Desktop;
            label1.Location = new Point(196, 9);
            label1.Name = "label1";
            label1.Size = new Size(188, 27);
            label1.TabIndex = 23;
            label1.Text = "Add Admin Access";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.Desktop;
            label2.Location = new Point(242, 53);
            label2.Name = "label2";
            label2.Size = new Size(86, 19);
            label2.TabIndex = 28;
            label2.Text = "Username:";
            // 
            // UNameTxt
            // 
            UNameTxt.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            UNameTxt.Location = new Point(120, 74);
            UNameTxt.Margin = new Padding(2);
            UNameTxt.Name = "UNameTxt";
            UNameTxt.Size = new Size(330, 29);
            UNameTxt.TabIndex = 27;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(519, 9);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(42, 35);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 39;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // AddAdmin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(573, 247);
            Controls.Add(pictureBox3);
            Controls.Add(label2);
            Controls.Add(UNameTxt);
            Controls.Add(label4);
            Controls.Add(AddBtn);
            Controls.Add(UPasswordTxt);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AddAdmin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddAdmin";
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label4;
        private Button AddBtn;
        private TextBox UPasswordTxt;
        private Label label1;
        private Label label2;
        private TextBox UNameTxt;
        private PictureBox pictureBox3;
    }
}