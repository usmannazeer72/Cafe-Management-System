namespace CafeManagementSystem
{
    partial class ViewOrders
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
            dataGridViewStaffOrders = new DataGridView();
            dataGridViewOrdersDetails = new DataGridView();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewStaffOrders).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOrdersDetails).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.LightSeaGreen;
            label1.Location = new Point(435, 38);
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
            label2.Location = new Point(468, 83);
            label2.Name = "label2";
            label2.Size = new Size(176, 38);
            label2.TabIndex = 1;
            label2.Text = "View Orders";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(617, 150);
            label3.Name = "label3";
            label3.Size = new Size(124, 25);
            label3.TabIndex = 2;
            label3.Text = "Orders Detail";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(80, 150);
            label4.Name = "label4";
            label4.Size = new Size(115, 25);
            label4.TabIndex = 3;
            label4.Text = "Staff Orders";
            // 
            // dataGridViewStaffOrders
            // 
            dataGridViewStaffOrders.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewStaffOrders.Location = new Point(80, 203);
            dataGridViewStaffOrders.Name = "dataGridViewStaffOrders";
            dataGridViewStaffOrders.RowHeadersWidth = 62;
            dataGridViewStaffOrders.RowTemplate.Height = 33;
            dataGridViewStaffOrders.Size = new Size(411, 253);
            dataGridViewStaffOrders.TabIndex = 4;
            // 
            // dataGridViewOrdersDetails
            // 
            dataGridViewOrdersDetails.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewOrdersDetails.Location = new Point(617, 203);
            dataGridViewOrdersDetails.Name = "dataGridViewOrdersDetails";
            dataGridViewOrdersDetails.RowHeadersWidth = 62;
            dataGridViewOrdersDetails.RowTemplate.Height = 33;
            dataGridViewOrdersDetails.Size = new Size(432, 253);
            dataGridViewOrdersDetails.TabIndex = 5;
            // 
            // button1
            // 
            button1.Location = new Point(80, 29);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 6;
            button1.Text = "Back";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form17
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Azure;
            ClientSize = new Size(1090, 565);
            Controls.Add(button1);
            Controls.Add(dataGridViewOrdersDetails);
            Controls.Add(dataGridViewStaffOrders);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form17";
            Text = "Form17";
            Load += Form17_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewStaffOrders).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOrdersDetails).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private DataGridView dataGridViewStaffOrders;
        private DataGridView dataGridViewOrdersDetails;
        private Button button1;
    }
}