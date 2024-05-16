namespace CafeManagementSystem
{
    partial class RegisterCustomer
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
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            NameBox = new TextBox();
            emailBox = new TextBox();
            PasswordBox = new TextBox();
            phoneBox = new TextBox();
            CnicBox = new TextBox();
            CityBox = new TextBox();
            HouseBox = new TextBox();
            button1 = new Button();
            linkLabel1 = new LinkLabel();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.LightSeaGreen;
            label1.Location = new Point(401, 50);
            label1.Name = "label1";
            label1.Size = new Size(257, 45);
            label1.TabIndex = 0;
            label1.Text = "''Campus Bites''";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.DimGray;
            label2.Location = new Point(401, 105);
            label2.Name = "label2";
            label2.Size = new Size(257, 38);
            label2.TabIndex = 1;
            label2.Text = "Register Customer";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(395, 195);
            label3.Name = "label3";
            label3.Size = new Size(59, 25);
            label3.TabIndex = 2;
            label3.Text = "Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(395, 258);
            label4.Name = "label4";
            label4.Size = new Size(54, 25);
            label4.TabIndex = 3;
            label4.Text = "Email";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(395, 317);
            label5.Name = "label5";
            label5.Size = new Size(87, 25);
            label5.TabIndex = 4;
            label5.Text = "Password";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(395, 373);
            label6.Name = "label6";
            label6.Size = new Size(86, 25);
            label6.TabIndex = 5;
            label6.Text = "PhoneNo";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(691, 252);
            label7.Name = "label7";
            label7.Size = new Size(42, 25);
            label7.TabIndex = 6;
            label7.Text = "City";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(691, 314);
            label8.Name = "label8";
            label8.Size = new Size(87, 25);
            label8.TabIndex = 7;
            label8.Text = "HouseNo";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(691, 198);
            label9.Name = "label9";
            label9.Size = new Size(52, 25);
            label9.TabIndex = 8;
            label9.Text = "CNIC";
            // 
            // NameBox
            // 
            NameBox.Location = new Point(488, 192);
            NameBox.Name = "NameBox";
            NameBox.Size = new Size(150, 31);
            NameBox.TabIndex = 9;
            NameBox.TextChanged += textBox1_TextChanged;
            // 
            // emailBox
            // 
            emailBox.Location = new Point(488, 252);
            emailBox.Name = "emailBox";
            emailBox.Size = new Size(150, 31);
            emailBox.TabIndex = 10;
            // 
            // PasswordBox
            // 
            PasswordBox.Location = new Point(488, 314);
            PasswordBox.Name = "PasswordBox";
            PasswordBox.PasswordChar = '*';
            PasswordBox.Size = new Size(150, 31);
            PasswordBox.TabIndex = 11;
            // 
            // phoneBox
            // 
            phoneBox.Location = new Point(488, 373);
            phoneBox.Name = "phoneBox";
            phoneBox.Size = new Size(150, 31);
            phoneBox.TabIndex = 12;
            // 
            // CnicBox
            // 
            CnicBox.Location = new Point(784, 189);
            CnicBox.Name = "CnicBox";
            CnicBox.Size = new Size(150, 31);
            CnicBox.TabIndex = 13;
            // 
            // CityBox
            // 
            CityBox.Location = new Point(784, 252);
            CityBox.Name = "CityBox";
            CityBox.Size = new Size(150, 31);
            CityBox.TabIndex = 14;
            // 
            // HouseBox
            // 
            HouseBox.Location = new Point(784, 311);
            HouseBox.Name = "HouseBox";
            HouseBox.Size = new Size(150, 31);
            HouseBox.TabIndex = 15;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(621, 431);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 16;
            button1.Text = "Register";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.LinkColor = Color.LightSeaGreen;
            linkLabel1.Location = new Point(401, 495);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(213, 25);
            linkLabel1.TabIndex = 17;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Already registered? Login";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.campusnit;
            pictureBox1.Location = new Point(43, 192);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(298, 254);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 18;
            pictureBox1.TabStop = false;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Azure;
            ClientSize = new Size(1090, 565);
            Controls.Add(pictureBox1);
            Controls.Add(linkLabel1);
            Controls.Add(button1);
            Controls.Add(HouseBox);
            Controls.Add(CityBox);
            Controls.Add(CnicBox);
            Controls.Add(phoneBox);
            Controls.Add(PasswordBox);
            Controls.Add(emailBox);
            Controls.Add(NameBox);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form3";
            Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private TextBox NameBox;
        private TextBox emailBox;
        private TextBox PasswordBox;
        private TextBox phoneBox;
        private TextBox CnicBox;
        private TextBox CityBox;
        private TextBox HouseBox;
        private Button button1;
        private LinkLabel linkLabel1;
        private PictureBox pictureBox1;
    }
}