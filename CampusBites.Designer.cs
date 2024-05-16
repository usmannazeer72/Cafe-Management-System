namespace CafeManagementSystem
{
    partial class CampusBites
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CampusBites));
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            label1 = new Label();
            label2 = new Label();
            linkLabel1 = new LinkLabel();
            linkLabel3 = new LinkLabel();
            linkLabel4 = new LinkLabel();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.LightSeaGreen;
            label1.Location = new Point(371, 32);
            label1.Name = "label1";
            label1.Size = new Size(449, 45);
            label1.TabIndex = 0;
            label1.Text = "Welcome To ''Campus Bites''";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.DimGray;
            label2.Location = new Point(442, 109);
            label2.Name = "label2";
            label2.Size = new Size(335, 38);
            label2.TabIndex = 1;
            label2.Text = "Do you want to Register";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.LinkColor = Color.LightSeaGreen;
            linkLabel1.Location = new Point(571, 196);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(81, 25);
            linkLabel1.TabIndex = 6;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "As Staff?";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // linkLabel3
            // 
            linkLabel3.AutoSize = true;
            linkLabel3.LinkColor = Color.LightSeaGreen;
            linkLabel3.Location = new Point(571, 247);
            linkLabel3.Name = "linkLabel3";
            linkLabel3.Size = new Size(122, 25);
            linkLabel3.TabIndex = 8;
            linkLabel3.TabStop = true;
            linkLabel3.Text = "As Customer?";
            linkLabel3.LinkClicked += linkLabel3_LinkClicked;
            // 
            // linkLabel4
            // 
            linkLabel4.AutoSize = true;
            linkLabel4.LinkColor = Color.LightSeaGreen;
            linkLabel4.Location = new Point(515, 326);
            linkLabel4.Name = "linkLabel4";
            linkLabel4.Size = new Size(214, 25);
            linkLabel4.TabIndex = 9;
            linkLabel4.TabStop = true;
            linkLabel4.Text = "Already registered? LogIn";
            linkLabel4.LinkClicked += linkLabel4_LinkClicked;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 146);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(407, 333);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // CampusBites
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Azure;
            ClientSize = new Size(1090, 565);
            Controls.Add(pictureBox1);
            Controls.Add(linkLabel4);
            Controls.Add(linkLabel3);
            Controls.Add(linkLabel1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "CampusBites";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Label label1;
        private Label label2;
        private LinkLabel linkLabel1;
        private LinkLabel linkLabel3;
        private LinkLabel linkLabel4;
        private PictureBox pictureBox1;
    }
}