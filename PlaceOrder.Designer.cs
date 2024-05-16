namespace CafeManagementSystem
{
    partial class PlaceOrder
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
            label5 = new Label();
            textBox1 = new TextBox();
            textBox3 = new TextBox();
            button1 = new Button();
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
            label1.Location = new Point(428, 29);
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
            label2.Location = new Point(473, 91);
            label2.Name = "label2";
            label2.Size = new Size(168, 38);
            label2.TabIndex = 1;
            label2.Text = "Place Order";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(445, 201);
            label3.Name = "label3";
            label3.Size = new Size(109, 25);
            label3.TabIndex = 2;
            label3.Text = "Customer id";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(445, 261);
            label5.Name = "label5";
            label5.Size = new Size(63, 25);
            label5.TabIndex = 4;
            label5.Text = "Itemid";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(580, 195);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(150, 31);
            textBox1.TabIndex = 5;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(580, 255);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(150, 31);
            textBox3.TabIndex = 7;
            // 
            // button1
            // 
            button1.Location = new Point(580, 329);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 8;
            button1.Text = "Place Order";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.campusnit1;
            pictureBox1.Location = new Point(42, 147);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(291, 216);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // button2
            // 
            button2.Location = new Point(42, 40);
            button2.Name = "button2";
            button2.Size = new Size(112, 34);
            button2.TabIndex = 10;
            button2.Text = "Back";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // PlaceOrder
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Azure;
            ClientSize = new Size(1090, 565);
            Controls.Add(button2);
            Controls.Add(pictureBox1);
            Controls.Add(button1);
            Controls.Add(textBox3);
            Controls.Add(textBox1);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "PlaceOrder";
            Text = "PlaceOrder";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label5;
        private TextBox textBox1;
        private TextBox textBox3;
        private Button button1;
        private PictureBox pictureBox1;
        private Button button2;
    }
}