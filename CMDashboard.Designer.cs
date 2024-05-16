namespace CafeManagementSystem
{
    partial class CMDashboard
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
            panel1 = new Panel();
            button8 = new Button();
            button7 = new Button();
            button6 = new Button();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            dataGridViewIngredients = new DataGridView();
            label3 = new Label();
            button9 = new Button();
            button10 = new Button();
            button11 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewIngredients).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.LightSeaGreen;
            label1.Location = new Point(404, 20);
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
            label2.Location = new Point(422, 76);
            label2.Name = "label2";
            label2.Size = new Size(351, 38);
            label2.TabIndex = 1;
            label2.Text = "Cafe Manager DashBoard";
            // 
            // button1
            // 
            button1.BackColor = Color.MintCream;
            button1.Font = new Font("MS Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(54, 44);
            button1.Name = "button1";
            button1.Size = new Size(249, 42);
            button1.TabIndex = 2;
            button1.Text = "Manage Menu";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.PaleTurquoise;
            panel1.Controls.Add(button11);
            panel1.Controls.Add(button8);
            panel1.Controls.Add(button7);
            panel1.Controls.Add(button6);
            panel1.Controls.Add(button5);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Font = new Font("MS Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(398, 565);
            panel1.TabIndex = 3;
            // 
            // button8
            // 
            button8.BackColor = Color.MintCream;
            button8.Font = new Font("MS Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button8.Location = new Point(54, 390);
            button8.Name = "button8";
            button8.Size = new Size(249, 42);
            button8.TabIndex = 9;
            button8.Text = "Menu Order Details";
            button8.UseVisualStyleBackColor = false;
            button8.Click += button8_Click;
            // 
            // button7
            // 
            button7.BackColor = Color.MintCream;
            button7.Font = new Font("MS Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button7.Location = new Point(54, 331);
            button7.Name = "button7";
            button7.Size = new Size(249, 42);
            button7.TabIndex = 8;
            button7.Text = "Order Status";
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // button6
            // 
            button6.BackColor = Color.LightSeaGreen;
            button6.Location = new Point(127, 510);
            button6.Name = "button6";
            button6.Size = new Size(112, 34);
            button6.TabIndex = 7;
            button6.Text = "Log out";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.MintCream;
            button5.Font = new Font("MS Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button5.Location = new Point(54, 273);
            button5.Name = "button5";
            button5.Size = new Size(249, 42);
            button5.TabIndex = 6;
            button5.Text = "View Orders";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.MintCream;
            button4.Font = new Font("MS Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button4.Location = new Point(54, 215);
            button4.Name = "button4";
            button4.Size = new Size(249, 42);
            button4.TabIndex = 5;
            button4.Text = "Manage Finances";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.MintCream;
            button3.Font = new Font("MS Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button3.Location = new Point(54, 158);
            button3.Name = "button3";
            button3.Size = new Size(249, 42);
            button3.TabIndex = 4;
            button3.Text = "Manage Inventory";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.MintCream;
            button2.Font = new Font("MS Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(54, 101);
            button2.Name = "button2";
            button2.Size = new Size(249, 42);
            button2.TabIndex = 3;
            button2.Text = "Manage Staff";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // dataGridViewIngredients
            // 
            dataGridViewIngredients.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewIngredients.Location = new Point(468, 182);
            dataGridViewIngredients.Name = "dataGridViewIngredients";
            dataGridViewIngredients.RowHeadersWidth = 62;
            dataGridViewIngredients.RowTemplate.Height = 33;
            dataGridViewIngredients.Size = new Size(499, 289);
            dataGridViewIngredients.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(462, 128);
            label3.Name = "label3";
            label3.Size = new Size(154, 25);
            label3.TabIndex = 5;
            label3.Text = "Ingredients Status";
            // 
            // button9
            // 
            button9.Location = new Point(471, 510);
            button9.Name = "button9";
            button9.Size = new Size(201, 34);
            button9.TabIndex = 6;
            button9.Text = "Customer Satisfaction";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click;
            // 
            // button10
            // 
            button10.Location = new Point(731, 510);
            button10.Name = "button10";
            button10.Size = new Size(201, 34);
            button10.TabIndex = 7;
            button10.Text = "Loyalty Program";
            button10.UseVisualStyleBackColor = true;
            button10.Click += button10_Click;
            // 
            // button11
            // 
            button11.BackColor = Color.MintCream;
            button11.Location = new Point(54, 452);
            button11.Name = "button11";
            button11.Size = new Size(247, 42);
            button11.TabIndex = 10;
            button11.Text = "Staff View";
            button11.UseVisualStyleBackColor = false;
            button11.Click += button11_Click;
            // 
            // CMDashboard
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Azure;
            ClientSize = new Size(1090, 565);
            Controls.Add(button10);
            Controls.Add(button9);
            Controls.Add(label3);
            Controls.Add(dataGridViewIngredients);
            Controls.Add(panel1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "CMDashboard";
            Text = "Form9";
            Load += Form9_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewIngredients).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button button1;
        private Panel panel1;
        private Button button3;
        private Button button2;
        private Button button5;
        private Button button4;
        private DataGridView dataGridViewIngredients;
        private Label label3;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button10;
        private Button button11;
    }
}