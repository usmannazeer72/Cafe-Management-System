namespace CafeManagementSystem
{
    partial class Updateinventory
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
            IDbox = new TextBox();
            QuantityBox = new TextBox();
            ID2box = new TextBox();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.LightSeaGreen;
            label1.Location = new Point(441, 34);
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
            label2.Location = new Point(446, 95);
            label2.Name = "label2";
            label2.Size = new Size(248, 38);
            label2.TabIndex = 1;
            label2.Text = "Update Inventory";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(461, 196);
            label3.Name = "label3";
            label3.Size = new Size(30, 25);
            label3.TabIndex = 2;
            label3.Text = "ID";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(461, 247);
            label4.Name = "label4";
            label4.Size = new Size(80, 25);
            label4.TabIndex = 3;
            label4.Text = "Quantity";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(458, 298);
            label5.Name = "label5";
            label5.Size = new Size(103, 25);
            label5.TabIndex = 4;
            label5.Text = "InventoryId";
            // 
            // IDbox
            // 
            IDbox.Location = new Point(570, 190);
            IDbox.Name = "IDbox";
            IDbox.Size = new Size(150, 31);
            IDbox.TabIndex = 5;
            // 
            // QuantityBox
            // 
            QuantityBox.Location = new Point(570, 241);
            QuantityBox.Name = "QuantityBox";
            QuantityBox.Size = new Size(150, 31);
            QuantityBox.TabIndex = 6;
            // 
            // ID2box
            // 
            ID2box.Location = new Point(570, 292);
            ID2box.Name = "ID2box";
            ID2box.Size = new Size(150, 31);
            ID2box.TabIndex = 7;
            // 
            // button1
            // 
            button1.Location = new Point(570, 356);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 8;
            button1.Text = "Update";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.campusnit1;
            pictureBox1.Location = new Point(59, 190);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(286, 209);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // Form21
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Azure;
            ClientSize = new Size(1090, 565);
            Controls.Add(pictureBox1);
            Controls.Add(button1);
            Controls.Add(ID2box);
            Controls.Add(QuantityBox);
            Controls.Add(IDbox);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form21";
            Text = "Form21";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox IDbox;
        private TextBox QuantityBox;
        private TextBox ID2box;
        private Button button1;
        private PictureBox pictureBox1;
    }
}