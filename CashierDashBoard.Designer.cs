namespace CafeManagementSystem
{
    partial class CashierDashBoard
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
            button5 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            transactionDetailsDataGridView = new DataGridView();
            label3 = new Label();
            button6 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)transactionDetailsDataGridView).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.LightSeaGreen;
            label1.Location = new Point(330, 24);
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
            label2.Location = new Point(349, 84);
            label2.Name = "label2";
            label2.Size = new Size(263, 38);
            label2.TabIndex = 1;
            label2.Text = "Cashier DashBoard";
            // 
            // panel1
            // 
            panel1.BackColor = Color.PaleTurquoise;
            panel1.Controls.Add(button6);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button5);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Location = new Point(1, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(323, 566);
            panel1.TabIndex = 2;
            // 
            // button4
            // 
            button4.BackColor = Color.MintCream;
            button4.Font = new Font("MS Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button4.Location = new Point(38, 250);
            button4.Name = "button4";
            button4.Size = new Size(231, 42);
            button4.TabIndex = 5;
            button4.Text = "Sales Per Category";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.LightSeaGreen;
            button5.Location = new Point(82, 459);
            button5.Name = "button5";
            button5.Size = new Size(112, 34);
            button5.TabIndex = 4;
            button5.Text = "Log out";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.MintCream;
            button3.Font = new Font("MS Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button3.Location = new Point(36, 183);
            button3.Name = "button3";
            button3.Size = new Size(231, 42);
            button3.TabIndex = 2;
            button3.Text = "Generate Receipt";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.MintCream;
            button2.Font = new Font("MS Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(36, 117);
            button2.Name = "button2";
            button2.Size = new Size(231, 42);
            button2.TabIndex = 1;
            button2.Text = "Order Summary";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.MintCream;
            button1.Font = new Font("MS Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(36, 52);
            button1.Name = "button1";
            button1.Size = new Size(231, 42);
            button1.TabIndex = 0;
            button1.Text = "POS";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // transactionDetailsDataGridView
            // 
            transactionDetailsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            transactionDetailsDataGridView.Location = new Point(361, 173);
            transactionDetailsDataGridView.Name = "transactionDetailsDataGridView";
            transactionDetailsDataGridView.RowHeadersWidth = 62;
            transactionDetailsDataGridView.RowTemplate.Height = 33;
            transactionDetailsDataGridView.Size = new Size(653, 351);
            transactionDetailsDataGridView.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(358, 133);
            label3.Name = "label3";
            label3.Size = new Size(158, 25);
            label3.TabIndex = 4;
            label3.Text = "Transaction Details";
            // 
            // button6
            // 
            button6.BackColor = Color.MintCream;
            button6.Font = new Font("MS Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button6.Location = new Point(38, 316);
            button6.Name = "button6";
            button6.Size = new Size(231, 42);
            button6.TabIndex = 6;
            button6.Text = "Top Selling Item";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // CashierDashBoard
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Azure;
            ClientSize = new Size(1090, 565);
            Controls.Add(label3);
            Controls.Add(transactionDetailsDataGridView);
            Controls.Add(panel1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "CashierDashBoard";
            Text = "Form1";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)transactionDetailsDataGridView).EndInit();
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
        private Button button5;
        private DataGridView transactionDetailsDataGridView;
        private Label label3;
        private Button button4;
        private Button button6;
    }
}