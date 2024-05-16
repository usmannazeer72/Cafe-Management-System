namespace CafeManagementSystem
{
    partial class LogIn
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
            label3 = new Label();
            label4 = new Label();
            EmailBox = new TextBox();
            PassBox = new TextBox();
            button1 = new Button();
            linkLabel1 = new LinkLabel();
            pictureBox1 = new PictureBox();
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            checkBox3 = new CheckBox();
            checkBox4 = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.LightSeaGreen;
            label1.Location = new Point(260, 33);
            label1.Name = "label1";
            label1.Size = new Size(262, 45);
            label1.TabIndex = 0;
            label1.Text = "\"Campus Bites \"";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.DimGray;
            label2.Location = new Point(330, 89);
            label2.Name = "label2";
            label2.Size = new Size(99, 38);
            label2.TabIndex = 1;
            label2.Text = "Log In";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(386, 187);
            label3.Name = "label3";
            label3.Size = new Size(54, 25);
            label3.TabIndex = 2;
            label3.Text = "Email";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(386, 235);
            label4.Name = "label4";
            label4.Size = new Size(87, 25);
            label4.TabIndex = 3;
            label4.Text = "Password";
            // 
            // EmailBox
            // 
            EmailBox.Location = new Point(479, 184);
            EmailBox.Name = "EmailBox";
            EmailBox.Size = new Size(150, 31);
            EmailBox.TabIndex = 4;
            // 
            // PassBox
            // 
            PassBox.Location = new Point(479, 235);
            PassBox.Name = "PassBox";
            PassBox.PasswordChar = '*';
            PassBox.Size = new Size(150, 31);
            PassBox.TabIndex = 5;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(498, 356);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 6;
            button1.Text = "LogIn";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.LinkColor = Color.LightSeaGreen;
            linkLabel1.Location = new Point(464, 393);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(193, 25);
            linkLabel1.TabIndex = 7;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Not registerd? Register";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.campusnit1;
            pictureBox1.Location = new Point(52, 144);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(305, 246);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(478, 281);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(115, 29);
            checkBox1.TabIndex = 9;
            checkBox1.Text = "Customer";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(599, 281);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(178, 29);
            checkBox2.TabIndex = 10;
            checkBox2.Text = "Invetory Manager";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Location = new Point(478, 316);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(95, 29);
            checkBox3.TabIndex = 11;
            checkBox3.Text = "Cashier";
            checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            checkBox4.AutoSize = true;
            checkBox4.Location = new Point(599, 316);
            checkBox4.Name = "checkBox4";
            checkBox4.Size = new Size(148, 29);
            checkBox4.TabIndex = 12;
            checkBox4.Text = "Cafe Manager";
            checkBox4.UseVisualStyleBackColor = true;
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Azure;
            ClientSize = new Size(800, 450);
            Controls.Add(checkBox4);
            Controls.Add(checkBox3);
            Controls.Add(checkBox2);
            Controls.Add(checkBox1);
            Controls.Add(pictureBox1);
            Controls.Add(linkLabel1);
            Controls.Add(button1);
            Controls.Add(PassBox);
            Controls.Add(EmailBox);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form5";
            Text = "Form5";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox EmailBox;
        private TextBox PassBox;
        private Button button1;
        private LinkLabel linkLabel1;
        private PictureBox pictureBox1;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private CheckBox checkBox3;
        private CheckBox checkBox4;
    }
}