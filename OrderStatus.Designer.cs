namespace CafeManagementSystem
{
    partial class OrderStatus
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
            IDBox1 = new TextBox();
            IDBox2 = new TextBox();
            status = new TextBox();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.LightSeaGreen;
            label1.Location = new Point(435, 37);
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
            label2.Location = new Point(468, 92);
            label2.Name = "label2";
            label2.Size = new Size(178, 38);
            label2.TabIndex = 1;
            label2.Text = "Order status";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(403, 158);
            label3.Name = "label3";
            label3.Size = new Size(74, 25);
            label3.TabIndex = 2;
            label3.Text = "OrderId";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(403, 213);
            label4.Name = "label4";
            label4.Size = new Size(105, 25);
            label4.TabIndex = 3;
            label4.Text = "CustomerId";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(403, 264);
            label5.Name = "label5";
            label5.Size = new Size(60, 25);
            label5.TabIndex = 4;
            label5.Text = "Status";
            // 
            // IDBox1
            // 
            IDBox1.Location = new Point(514, 152);
            IDBox1.Name = "IDBox1";
            IDBox1.Size = new Size(150, 31);
            IDBox1.TabIndex = 5;
            // 
            // IDBox2
            // 
            IDBox2.Location = new Point(514, 207);
            IDBox2.Name = "IDBox2";
            IDBox2.Size = new Size(150, 31);
            IDBox2.TabIndex = 6;
            // 
            // status
            // 
            status.Location = new Point(514, 258);
            status.Name = "status";
            status.Size = new Size(150, 31);
            status.TabIndex = 7;
            // 
            // button1
            // 
            button1.Location = new Point(514, 330);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 8;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(45, 37);
            button2.Name = "button2";
            button2.Size = new Size(112, 34);
            button2.TabIndex = 9;
            button2.Text = "Back";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // OrderStatus
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Azure;
            ClientSize = new Size(1090, 565);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(status);
            Controls.Add(IDBox2);
            Controls.Add(IDBox1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "OrderStatus";
            Text = "OrderStatus";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox IDBox1;
        private TextBox IDBox2;
        private TextBox status;
        private Button button1;
        private Button button2;
    }
}