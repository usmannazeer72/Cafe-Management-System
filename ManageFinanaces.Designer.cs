namespace CafeManagementSystem
{
    partial class ManageFinanaces
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
            dataGridViewOrders = new DataGridView();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            StaffId = new TextBox();
            CustomerId = new TextBox();
            Status = new TextBox();
            TotalBill = new TextBox();
            button1 = new Button();
            labelTotalSales = new Label();
            button2 = new Button();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOrders).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.LightSeaGreen;
            label1.Location = new Point(449, 28);
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
            label2.Location = new Point(449, 88);
            label2.Name = "label2";
            label2.Size = new Size(243, 38);
            label2.TabIndex = 1;
            label2.Text = "Manage Finances";
            // 
            // dataGridViewOrders
            // 
            dataGridViewOrders.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewOrders.Location = new Point(25, 168);
            dataGridViewOrders.Name = "dataGridViewOrders";
            dataGridViewOrders.RowHeadersWidth = 62;
            dataGridViewOrders.RowTemplate.Height = 33;
            dataGridViewOrders.Size = new Size(450, 287);
            dataGridViewOrders.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(568, 202);
            label3.Name = "label3";
            label3.Size = new Size(70, 25);
            label3.TabIndex = 3;
            label3.Text = "StaffId";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(568, 258);
            label4.Name = "label4";
            label4.Size = new Size(109, 25);
            label4.TabIndex = 4;
            label4.Text = "Customerid";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(568, 309);
            label5.Name = "label5";
            label5.Size = new Size(65, 25);
            label5.TabIndex = 5;
            label5.Text = "Status";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(568, 359);
            label6.Name = "label6";
            label6.Size = new Size(86, 25);
            label6.TabIndex = 6;
            label6.Text = "Total Bill";
            // 
            // StaffId
            // 
            StaffId.Location = new Point(689, 202);
            StaffId.Name = "StaffId";
            StaffId.Size = new Size(165, 31);
            StaffId.TabIndex = 7;
            // 
            // CustomerId
            // 
            CustomerId.Location = new Point(689, 252);
            CustomerId.Name = "CustomerId";
            CustomerId.Size = new Size(165, 31);
            CustomerId.TabIndex = 8;
            // 
            // Status
            // 
            Status.Location = new Point(689, 303);
            Status.Name = "Status";
            Status.Size = new Size(165, 31);
            Status.TabIndex = 9;
            // 
            // TotalBill
            // 
            TotalBill.Location = new Point(689, 353);
            TotalBill.Name = "TotalBill";
            TotalBill.Size = new Size(165, 31);
            TotalBill.TabIndex = 10;
            // 
            // button1
            // 
            button1.Location = new Point(689, 438);
            button1.Name = "button1";
            button1.Size = new Size(123, 34);
            button1.TabIndex = 11;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // labelTotalSales
            // 
            labelTotalSales.AutoSize = true;
            labelTotalSales.Location = new Point(91, 127);
            labelTotalSales.Name = "labelTotalSales";
            labelTotalSales.Size = new Size(102, 25);
            labelTotalSales.TabIndex = 12;
            labelTotalSales.Text = "Total Sales";
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(25, 28);
            button2.Name = "button2";
            button2.Size = new Size(112, 34);
            button2.TabIndex = 13;
            button2.Text = "Back";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.LightSeaGreen;
            label7.Location = new Point(25, 127);
            label7.Name = "label7";
            label7.Size = new Size(60, 25);
            label7.TabIndex = 14;
            label7.Text = "Sales:";
            // 
            // Form16
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Azure;
            ClientSize = new Size(1199, 565);
            Controls.Add(label7);
            Controls.Add(button2);
            Controls.Add(labelTotalSales);
            Controls.Add(button1);
            Controls.Add(TotalBill);
            Controls.Add(Status);
            Controls.Add(CustomerId);
            Controls.Add(StaffId);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(dataGridViewOrders);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Name = "Form16";
            Text = "Form16";
            Load += Form16_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewOrders).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private DataGridView dataGridViewOrders;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox StaffId;
        private TextBox CustomerId;
        private TextBox Status;
        private TextBox TotalBill;
        private Button button1;
        private Label labelTotalSales;
        private Button button2;
        private Label label7;
    }
}