namespace CafeManagementSystem
{
    partial class MenuItemsView
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
            ItemGridView = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)ItemGridView).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.LightSeaGreen;
            label1.Location = new Point(416, 62);
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
            label2.Location = new Point(451, 117);
            label2.Name = "label2";
            label2.Size = new Size(174, 38);
            label2.TabIndex = 1;
            label2.Text = "Menu Items";
            label2.Click += label2_Click;
            // 
            // ItemGridView
            // 
            ItemGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ItemGridView.Location = new Point(224, 170);
            ItemGridView.Name = "ItemGridView";
            ItemGridView.RowHeadersWidth = 62;
            ItemGridView.RowTemplate.Height = 33;
            ItemGridView.Size = new Size(648, 346);
            ItemGridView.TabIndex = 2;
            // 
            // MenuItemsView
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Azure;
            ClientSize = new Size(1090, 565);
            Controls.Add(ItemGridView);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "MenuItemsView";
            Text = "Form7";
            ((System.ComponentModel.ISupportInitialize)ItemGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private DataGridView ItemGridView;
    }
}