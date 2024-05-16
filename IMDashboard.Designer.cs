namespace CafeManagementSystem
{
    partial class IMDashboard
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
            dataGridViewInventory = new DataGridView();
            label3 = new Label();
            button5 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewInventory).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.LightSeaGreen;
            label1.Location = new Point(343, 21);
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
            label2.Location = new Point(363, 82);
            label2.Name = "label2";
            label2.Size = new Size(420, 38);
            label2.TabIndex = 1;
            label2.Text = "Inventory Manager Dashboard";
            // 
            // panel1
            // 
            panel1.BackColor = Color.PaleTurquoise;
            panel1.Controls.Add(button5);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Location = new Point(-1, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(338, 565);
            panel1.TabIndex = 2;
            // 
            // button4
            // 
            button4.BackColor = Color.MintCream;
            button4.Font = new Font("MS Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button4.Location = new Point(32, 207);
            button4.Name = "button4";
            button4.Size = new Size(249, 47);
            button4.TabIndex = 3;
            button4.Text = "Ingredients for Menu items";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.MintCream;
            button3.Font = new Font("MS Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button3.Location = new Point(32, 144);
            button3.Name = "button3";
            button3.Size = new Size(249, 42);
            button3.TabIndex = 2;
            button3.Text = "Check Inventory";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.LightSeaGreen;
            button2.Location = new Point(89, 461);
            button2.Name = "button2";
            button2.Size = new Size(112, 34);
            button2.TabIndex = 1;
            button2.Text = "Log out";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.MintCream;
            button1.Font = new Font("MS Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(32, 77);
            button1.Name = "button1";
            button1.Size = new Size(249, 42);
            button1.TabIndex = 0;
            button1.Text = "Manage Inventory";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // dataGridViewInventory
            // 
            dataGridViewInventory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewInventory.Location = new Point(397, 196);
            dataGridViewInventory.Name = "dataGridViewInventory";
            dataGridViewInventory.RowHeadersWidth = 62;
            dataGridViewInventory.RowTemplate.Height = 33;
            dataGridViewInventory.Size = new Size(552, 300);
            dataGridViewInventory.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(397, 150);
            label3.Name = "label3";
            label3.Size = new Size(167, 25);
            label3.TabIndex = 4;
            label3.Text = "Cafe Inventory view";
            // 
            // button5
            // 
            button5.BackColor = Color.MintCream;
            button5.Font = new Font("MS Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button5.Location = new Point(34, 275);
            button5.Name = "button5";
            button5.Size = new Size(249, 47);
            button5.TabIndex = 4;
            button5.Text = "IngredientQuantity";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // IMDashboard
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Azure;
            ClientSize = new Size(1090, 565);
            Controls.Add(label3);
            Controls.Add(dataGridViewInventory);
            Controls.Add(panel1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "IMDashboard";
            Text = "Form18";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewInventory).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Panel panel1;
        private Button button1;
        private DataGridView dataGridViewInventory;
        private Label label3;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
    }
}