namespace CafeManagementSystem
{
    partial class CustomerPortal
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
            panel1 = new Panel();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            dataGridView1 = new DataGridView();
            label3 = new Label();
            button5 = new Button();
            button6 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.LightSeaGreen;
            label1.Location = new Point(357, 36);
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
            label2.Location = new Point(380, 94);
            label2.Name = "label2";
            label2.Size = new Size(230, 38);
            label2.TabIndex = 1;
            label2.Text = "Customer Portal";
            // 
            // panel1
            // 
            panel1.BackColor = Color.PaleTurquoise;
            panel1.Controls.Add(button6);
            panel1.Controls.Add(button5);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(324, 565);
            panel1.TabIndex = 2;
            // 
            // button4
            // 
            button4.BackColor = Color.LightSeaGreen;
            button4.Location = new Point(88, 391);
            button4.Name = "button4";
            button4.Size = new Size(112, 34);
            button4.TabIndex = 3;
            button4.Text = "Log out";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.MintCream;
            button3.Font = new Font("MS Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button3.Location = new Point(37, 185);
            button3.Name = "button3";
            button3.Size = new Size(231, 42);
            button3.TabIndex = 2;
            button3.Text = "Register Loyalty";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.MintCream;
            button2.Font = new Font("MS Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(37, 123);
            button2.Name = "button2";
            button2.Size = new Size(231, 42);
            button2.TabIndex = 1;
            button2.Text = "Give Feedback";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.MintCream;
            button1.Font = new Font("MS Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(37, 62);
            button1.Name = "button1";
            button1.Size = new Size(231, 42);
            button1.TabIndex = 0;
            button1.Text = "Place Order";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(380, 185);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 33;
            dataGridView1.Size = new Size(614, 336);
            dataGridView1.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.LightSeaGreen;
            label3.Location = new Point(380, 140);
            label3.Name = "label3";
            label3.Size = new Size(57, 25);
            label3.TabIndex = 4;
            label3.Text = "Menu";
            // 
            // button5
            // 
            button5.BackColor = Color.MintCream;
            button5.Font = new Font("MS Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button5.Location = new Point(37, 244);
            button5.Name = "button5";
            button5.Size = new Size(231, 39);
            button5.TabIndex = 4;
            button5.Text = "Student Offers";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.BackColor = Color.MintCream;
            button6.Font = new Font("MS Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button6.Location = new Point(37, 302);
            button6.Name = "button6";
            button6.Size = new Size(231, 42);
            button6.TabIndex = 5;
            button6.Text = "Repating Customers";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // CustomerPortal
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Azure;
            ClientSize = new Size(1090, 565);
            Controls.Add(label3);
            Controls.Add(dataGridView1);
            Controls.Add(panel1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "CustomerPortal";
            Text = "CustomerPortal";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Panel panel1;
        private Button button3;
        private Button button2;
        private Button button1;
        private Button button4;
        private DataGridView dataGridView1;
        private Label label3;
        private Button button6;
        private Button button5;
    }
}