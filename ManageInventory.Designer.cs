namespace CafeManagementSystem
{
    partial class ManageInventory
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
            button4 = new Button();
            button5 = new Button();
            pictureBox1 = new PictureBox();
            button6 = new Button();
            button7 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.LightSeaGreen;
            label1.Location = new Point(430, 45);
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
            label2.Location = new Point(424, 99);
            label2.Name = "label2";
            label2.Size = new Size(259, 38);
            label2.TabIndex = 1;
            label2.Text = "Manage Inventory";
            // 
            // button1
            // 
            button1.BackColor = Color.LightSeaGreen;
            button1.Font = new Font("MS Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(460, 170);
            button1.Name = "button1";
            button1.Size = new Size(195, 34);
            button1.TabIndex = 2;
            button1.Text = "Add In Inventory";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.LightSeaGreen;
            button2.Font = new Font("MS Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(460, 275);
            button2.Name = "button2";
            button2.Size = new Size(195, 34);
            button2.TabIndex = 3;
            button2.Text = "Delete from Inventory";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.LightSeaGreen;
            button3.Font = new Font("MS Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button3.Location = new Point(460, 325);
            button3.Name = "button3";
            button3.Size = new Size(195, 34);
            button3.TabIndex = 4;
            button3.Text = "View Inventory";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.LightSeaGreen;
            button4.Font = new Font("MS Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button4.Location = new Point(460, 390);
            button4.Name = "button4";
            button4.Size = new Size(195, 34);
            button4.TabIndex = 5;
            button4.Text = "Update Inventory";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(45, 25);
            button5.Name = "button5";
            button5.Size = new Size(231, 34);
            button5.TabIndex = 6;
            button5.Text = "Back to Cafe Manager";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.campusnit1;
            pictureBox1.Location = new Point(70, 170);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(328, 254);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // button6
            // 
            button6.BackColor = Color.LightSeaGreen;
            button6.Font = new Font("MS Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button6.Location = new Point(460, 222);
            button6.Name = "button6";
            button6.Size = new Size(195, 34);
            button6.TabIndex = 8;
            button6.Text = "Order from Inventory";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.Location = new Point(46, 82);
            button7.Name = "button7";
            button7.Size = new Size(230, 34);
            button7.TabIndex = 9;
            button7.Text = "Back to Inventory Manager";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // Form13
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Azure;
            ClientSize = new Size(1090, 565);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(pictureBox1);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form13";
            Text = "Form13";
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
        private Button button4;
        private Button button5;
        private PictureBox pictureBox1;
        private Button button6;
        private Button button7;
    }
}