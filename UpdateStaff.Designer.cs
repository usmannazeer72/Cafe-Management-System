namespace CafeManagementSystem
{
    partial class UpdateStaff
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
            HouseNo = new TextBox();
            EmailBox = new TextBox();
            PhoneBox = new TextBox();
            Salary = new TextBox();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            label7 = new Label();
            idbox = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.LightSeaGreen;
            label1.Location = new Point(429, 43);
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
            label2.Location = new Point(460, 109);
            label2.Name = "label2";
            label2.Size = new Size(191, 38);
            label2.TabIndex = 1;
            label2.Text = "Update Staff ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(460, 219);
            label3.Name = "label3";
            label3.Size = new Size(54, 25);
            label3.TabIndex = 2;
            label3.Text = "Email";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(460, 261);
            label4.Name = "label4";
            label4.Size = new Size(86, 25);
            label4.TabIndex = 3;
            label4.Text = "PhoneNo";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(460, 310);
            label5.Name = "label5";
            label5.Size = new Size(59, 25);
            label5.TabIndex = 4;
            label5.Text = "Salary";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(459, 350);
            label6.Name = "label6";
            label6.Size = new Size(87, 25);
            label6.TabIndex = 5;
            label6.Text = "HouseNo";
            // 
            // HouseNo
            // 
            HouseNo.Location = new Point(550, 344);
            HouseNo.Name = "HouseNo";
            HouseNo.Size = new Size(150, 31);
            HouseNo.TabIndex = 6;
            // 
            // EmailBox
            // 
            EmailBox.Location = new Point(550, 213);
            EmailBox.Name = "EmailBox";
            EmailBox.Size = new Size(150, 31);
            EmailBox.TabIndex = 7;
            // 
            // PhoneBox
            // 
            PhoneBox.Location = new Point(550, 258);
            PhoneBox.Name = "PhoneBox";
            PhoneBox.Size = new Size(150, 31);
            PhoneBox.TabIndex = 8;
            // 
            // Salary
            // 
            Salary.Location = new Point(550, 304);
            Salary.Name = "Salary";
            Salary.Size = new Size(150, 31);
            Salary.TabIndex = 9;
            // 
            // button1
            // 
            button1.Location = new Point(493, 443);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 10;
            button1.Text = "Update";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.campusnit1;
            pictureBox1.Location = new Point(48, 164);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(297, 211);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(460, 178);
            label7.Name = "label7";
            label7.Size = new Size(64, 25);
            label7.TabIndex = 12;
            label7.Text = "StaffId";
            // 
            // idbox
            // 
            idbox.Location = new Point(548, 172);
            idbox.Name = "idbox";
            idbox.Size = new Size(150, 31);
            idbox.TabIndex = 13;
            // 
            // Form12
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Azure;
            ClientSize = new Size(1090, 565);
            Controls.Add(idbox);
            Controls.Add(label7);
            Controls.Add(pictureBox1);
            Controls.Add(button1);
            Controls.Add(Salary);
            Controls.Add(PhoneBox);
            Controls.Add(EmailBox);
            Controls.Add(HouseNo);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form12";
            Text = "Form12";
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
        private TextBox HouseNo;
        private TextBox EmailBox;
        private TextBox PhoneBox;
        private TextBox Salary;
        private Button button1;
        private PictureBox pictureBox1;
        private Label label7;
        private TextBox idbox;
    }
}