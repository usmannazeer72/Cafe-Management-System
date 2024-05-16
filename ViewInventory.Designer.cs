namespace CafeManagementSystem
{
    partial class ViewInventory
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
            InventoryGridView = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)InventoryGridView).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.LightSeaGreen;
            label1.Location = new Point(437, 31);
            label1.Name = "label1";
            label1.Size = new Size(253, 45);
            label1.TabIndex = 0;
            label1.Text = "\"Campus Bites\"";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.DimGray;
            label2.Location = new Point(451, 87);
            label2.Name = "label2";
            label2.Size = new Size(217, 38);
            label2.TabIndex = 14;
            label2.Text = "View Inventory";
            label2.Click += label2_Click;
            // 
            // InventoryGridView
            // 
            InventoryGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            InventoryGridView.Location = new Point(141, 149);
            InventoryGridView.Name = "InventoryGridView";
            InventoryGridView.RowHeadersWidth = 62;
            InventoryGridView.RowTemplate.Height = 33;
            InventoryGridView.Size = new Size(801, 308);
            InventoryGridView.TabIndex = 15;
            // 
            // ViewInventory
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Azure;
            ClientSize = new Size(1090, 565);
            Controls.Add(InventoryGridView);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "ViewInventory";
            Text = "Form14";
            Load += Form14_Load;
            ((System.ComponentModel.ISupportInitialize)InventoryGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label label2;
        private DataGridView InventoryGridView;
    }
}