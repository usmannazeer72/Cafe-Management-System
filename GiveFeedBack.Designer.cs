namespace CafeManagementSystem
{
    partial class GiveFeedBack
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
            button1 = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            pictureBox1 = new PictureBox();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.LightSeaGreen;
            label1.Location = new Point(419, 36);
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
            label2.Location = new Point(439, 97);
            label2.Name = "label2";
            label2.Size = new Size(206, 38);
            label2.TabIndex = 1;
            label2.Text = "Give Feedback";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(412, 192);
            label3.Name = "label3";
            label3.Size = new Size(104, 25);
            label3.TabIndex = 2;
            label3.Text = "Customerid";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(412, 261);
            label4.Name = "label4";
            label4.Size = new Size(63, 25);
            label4.TabIndex = 3;
            label4.Text = "Rating";
            // 
            // button1
            // 
            button1.Location = new Point(522, 317);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 4;
            button1.Text = "Submit";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(522, 189);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(150, 31);
            textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(522, 255);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(150, 31);
            textBox2.TabIndex = 6;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.campusnit1;
            pictureBox1.Location = new Point(50, 142);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(296, 209);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // button2
            // 
            button2.Location = new Point(50, 36);
            button2.Name = "button2";
            button2.Size = new Size(112, 34);
            button2.TabIndex = 8;
            button2.Text = "Back";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // GiveFeedBack
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Azure;
            ClientSize = new Size(1090, 565);
            Controls.Add(button2);
            Controls.Add(pictureBox1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "GiveFeedBack";
            Text = "GiveFeedBack";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button button1;
        private TextBox textBox1;
        private TextBox textBox2;
        private PictureBox pictureBox1;
        private Button button2;
    }
}