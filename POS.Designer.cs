namespace CafeManagementSystem
{
    partial class POS
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
            label6 = new Label();
            label7 = new Label();
            AmountBox = new TextBox();
            ID2Box = new TextBox();
            MethodBox = new TextBox();
            ID1Box = new TextBox();
            ID3Box = new TextBox();
            label5 = new Label();
            pictureBox1 = new PictureBox();
            button1 = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.LightSeaGreen;
            label1.Location = new Point(421, 39);
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
            label2.Location = new Point(492, 104);
            label2.Name = "label2";
            label2.Size = new Size(99, 38);
            label2.TabIndex = 1;
            label2.Text = "\"POS\"";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(421, 201);
            label3.Name = "label3";
            label3.Size = new Size(77, 25);
            label3.TabIndex = 2;
            label3.Text = "Amount";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(423, 249);
            label4.Name = "label4";
            label4.Size = new Size(75, 25);
            label4.TabIndex = 3;
            label4.Text = "Method";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(421, 331);
            label6.Name = "label6";
            label6.Size = new Size(62, 25);
            label6.TabIndex = 5;
            label6.Text = "Cafeid";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(424, 375);
            label7.Name = "label7";
            label7.Size = new Size(73, 25);
            label7.TabIndex = 6;
            label7.Text = "Orderid";
            // 
            // AmountBox
            // 
            AmountBox.Location = new Point(524, 195);
            AmountBox.Name = "AmountBox";
            AmountBox.Size = new Size(150, 31);
            AmountBox.TabIndex = 7;
            // 
            // ID2Box
            // 
            ID2Box.Location = new Point(524, 325);
            ID2Box.Name = "ID2Box";
            ID2Box.Size = new Size(150, 31);
            ID2Box.TabIndex = 8;
            // 
            // MethodBox
            // 
            MethodBox.Location = new Point(524, 243);
            MethodBox.Name = "MethodBox";
            MethodBox.Size = new Size(150, 31);
            MethodBox.TabIndex = 9;
            // 
            // ID1Box
            // 
            ID1Box.Location = new Point(524, 285);
            ID1Box.Name = "ID1Box";
            ID1Box.Size = new Size(150, 31);
            ID1Box.TabIndex = 10;
            // 
            // ID3Box
            // 
            ID3Box.Location = new Point(524, 369);
            ID3Box.Name = "ID3Box";
            ID3Box.Size = new Size(150, 31);
            ID3Box.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(423, 291);
            label5.Name = "label5";
            label5.Size = new Size(63, 25);
            label5.TabIndex = 4;
            label5.Text = "Staffid";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.campusnit1;
            pictureBox1.Location = new Point(58, 195);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(278, 205);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.Location = new Point(524, 429);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 13;
            button1.Text = "Enter";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(58, 39);
            button2.Name = "button2";
            button2.Size = new Size(112, 34);
            button2.TabIndex = 14;
            button2.Text = "Back";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // POS
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Azure;
            ClientSize = new Size(1090, 565);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            Controls.Add(ID3Box);
            Controls.Add(ID1Box);
            Controls.Add(MethodBox);
            Controls.Add(ID2Box);
            Controls.Add(AmountBox);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "POS";
            Text = "POS";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label6;
        private Label label7;
        private TextBox AmountBox;
        private TextBox ID2Box;
        private TextBox MethodBox;
        private TextBox ID1Box;
        private TextBox ID3Box;
        private Label label5;
        private PictureBox pictureBox1;
        private Button button1;
        private Button button2;
    }
}