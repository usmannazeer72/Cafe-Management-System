namespace CafeManagementSystem
{
    partial class ManageStaff
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
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            pictureBox1 = new PictureBox();
            button4 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.LightSeaGreen;
            label1.Location = new Point(416, 54);
            label1.Name = "label1";
            label1.Size = new Size(253, 45);
            label1.TabIndex = 0;
            label1.Text = "\"Campus Bites\"";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.DimGray;
            label2.Location = new Point(443, 119);
            label2.Name = "label2";
            label2.Size = new Size(194, 38);
            label2.TabIndex = 1;
            label2.Text = "Manage Staff";
            // 
            // button1
            // 
            button1.BackColor = Color.LightSeaGreen;
            button1.Font = new Font("MS Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(466, 192);
            button1.Name = "button1";
            button1.Size = new Size(161, 34);
            button1.TabIndex = 2;
            button1.Text = "Add Staff";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.LightSeaGreen;
            button2.Font = new Font("MS Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(466, 256);
            button2.Name = "button2";
            button2.Size = new Size(161, 34);
            button2.TabIndex = 3;
            button2.Text = "Delete Staff";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.LightSeaGreen;
            button3.Font = new Font("MS Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button3.Location = new Point(466, 321);
            button3.Name = "button3";
            button3.Size = new Size(161, 34);
            button3.TabIndex = 4;
            button3.Text = "Update Staff";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.campusnit1;
            pictureBox1.Location = new Point(68, 166);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(324, 215);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // button4
            // 
            button4.Location = new Point(44, 24);
            button4.Name = "button4";
            button4.Size = new Size(112, 34);
            button4.TabIndex = 6;
            button4.Text = "Back";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // Form10
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Azure;
            ClientSize = new Size(1090, 565);
            Controls.Add(button4);
            Controls.Add(pictureBox1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form10";
            Text = "Form10";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button button1;
        private Button button2;
        private Button button3;
        private PictureBox pictureBox1;
        private Button button4;
    }
}