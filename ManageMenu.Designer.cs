namespace CafeManagementSystem
{
    partial class ManageMenu
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
            pictureBox1 = new PictureBox();
            label2 = new Label();
            label1 = new Label();
            button1 = new Button();
            button3 = new Button();
            button4 = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.campusnit;
            pictureBox1.Location = new Point(58, 221);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(323, 238);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 23;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.DimGray;
            label2.Location = new Point(443, 109);
            label2.Name = "label2";
            label2.Size = new Size(207, 38);
            label2.TabIndex = 1;
            label2.Text = "Manage Menu";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.LightSeaGreen;
            label1.Location = new Point(422, 44);
            label1.Name = "label1";
            label1.Size = new Size(257, 45);
            label1.TabIndex = 0;
            label1.Text = "''Campus Bites''";
            // 
            // button1
            // 
            button1.BackColor = Color.LightSeaGreen;
            button1.Font = new Font("MS Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(431, 251);
            button1.Name = "button1";
            button1.Size = new Size(296, 34);
            button1.TabIndex = 24;
            button1.Text = "Add Menu Items";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // button3
            // 
            button3.BackColor = Color.LightSeaGreen;
            button3.Font = new Font("MS Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button3.Location = new Point(431, 401);
            button3.Name = "button3";
            button3.Size = new Size(296, 34);
            button3.TabIndex = 26;
            button3.Text = "Delete Menu Items";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.LightSeaGreen;
            button4.Font = new Font("MS Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button4.Location = new Point(431, 327);
            button4.Name = "button4";
            button4.Size = new Size(296, 34);
            button4.TabIndex = 27;
            button4.Text = "View Menu items";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button2
            // 
            button2.Location = new Point(36, 23);
            button2.Name = "button2";
            button2.Size = new Size(112, 34);
            button2.TabIndex = 28;
            button2.Text = "Back";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Azure;
            ClientSize = new Size(1090, 565);
            Controls.Add(button2);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form4";
            Text = "Form4";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pictureBox1;
        private Label label2;
        private Label label1;
        private Button button1;
        private Button button3;
        private Button button4;
        private Button button2;
    }
}