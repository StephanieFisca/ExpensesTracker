namespace ExpensesTracker
{
    partial class Splash
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Splash));
            timer1 = new System.Windows.Forms.Timer(components);
            label2 = new Label();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            panel1 = new Panel();
            pictureBox3 = new PictureBox();
            PercentageLbl = new Label();
            MyProgress = new ProgressBar();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.Desktop;
            label2.Location = new Point(190, 281);
            label2.Name = "label2";
            label2.Size = new Size(143, 19);
            label2.TabIndex = 20;
            label2.Text = "Loading Modules...";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(311, 78);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(154, 131);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 16;
            pictureBox2.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Desktop;
            label1.Location = new Point(238, 9);
            label1.Name = "label1";
            label1.Size = new Size(313, 27);
            label1.TabIndex = 15;
            label1.Text = "Expenses Management System";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Desktop;
            panel1.Controls.Add(pictureBox3);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(184, 333);
            panel1.TabIndex = 14;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(53, 12);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(74, 67);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 17;
            pictureBox3.TabStop = false;
            // 
            // PercentageLbl
            // 
            PercentageLbl.AutoSize = true;
            PercentageLbl.Font = new Font("Rockwell", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            PercentageLbl.ForeColor = SystemColors.Desktop;
            PercentageLbl.Location = new Point(509, 271);
            PercentageLbl.Name = "PercentageLbl";
            PercentageLbl.Size = new Size(42, 32);
            PercentageLbl.TabIndex = 21;
            PercentageLbl.Text = "%";
            // 
            // MyProgress
            // 
            MyProgress.BackColor = SystemColors.Desktop;
            MyProgress.ForeColor = SystemColors.Desktop;
            MyProgress.Location = new Point(190, 306);
            MyProgress.Name = "MyProgress";
            MyProgress.Size = new Size(361, 15);
            MyProgress.TabIndex = 22;
            // 
            // Splash
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(579, 333);
            Controls.Add(MyProgress);
            Controls.Add(PercentageLbl);
            Controls.Add(label2);
            Controls.Add(pictureBox2);
            Controls.Add(label1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Splash";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Splash_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private Label label2;
        private PictureBox pictureBox2;
        private Label label1;
        private Panel panel1;
        private PictureBox pictureBox3;
        private Label PercentageLbl;
        private ProgressBar MyProgress;
    }
}