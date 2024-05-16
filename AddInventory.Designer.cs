namespace CafeManagementSystem
{
    partial class AddInventory
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
            label6 = new Label();
            label7 = new Label();
            Namebox = new TextBox();
            inventorybox = new TextBox();
            vendorbox = new TextBox();
            unitbox = new TextBox();
            quantitybox = new TextBox();
            pictureBox1 = new PictureBox();
            button1 = new Button();
            linkLabel1 = new LinkLabel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.LightSeaGreen;
            label1.Location = new Point(434, 55);
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
            label2.Location = new Point(434, 112);
            label2.Name = "label2";
            label2.Size = new Size(243, 38);
            label2.TabIndex = 1;
            label2.Text = "Add to Inventory";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(391, 187);
            label3.Name = "label3";
            label3.Size = new Size(59, 25);
            label3.TabIndex = 2;
            label3.Text = "Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(391, 237);
            label4.Name = "label4";
            label4.Size = new Size(102, 25);
            label4.TabIndex = 3;
            label4.Text = "Inventoryid";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(395, 393);
            label5.Name = "label5";
            label5.Size = new Size(80, 25);
            label5.TabIndex = 4;
            label5.Text = "Quantity";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(395, 289);
            label6.Name = "label6";
            label6.Size = new Size(84, 25);
            label6.TabIndex = 5;
            label6.Text = "Vendorid";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(395, 343);
            label7.Name = "label7";
            label7.Size = new Size(52, 25);
            label7.TabIndex = 6;
            label7.Text = "Units";
            // 
            // Namebox
            // 
            Namebox.Location = new Point(502, 181);
            Namebox.Name = "Namebox";
            Namebox.Size = new Size(150, 31);
            Namebox.TabIndex = 7;
            // 
            // inventorybox
            // 
            inventorybox.Location = new Point(502, 231);
            inventorybox.Name = "inventorybox";
            inventorybox.Size = new Size(150, 31);
            inventorybox.TabIndex = 8;
            // 
            // vendorbox
            // 
            vendorbox.Location = new Point(502, 283);
            vendorbox.Name = "vendorbox";
            vendorbox.Size = new Size(150, 31);
            vendorbox.TabIndex = 9;
            // 
            // unitbox
            // 
            unitbox.Location = new Point(502, 337);
            unitbox.Name = "unitbox";
            unitbox.Size = new Size(150, 31);
            unitbox.TabIndex = 10;
            // 
            // quantitybox
            // 
            quantitybox.Location = new Point(502, 387);
            quantitybox.Name = "quantitybox";
            quantitybox.Size = new Size(150, 31);
            quantitybox.TabIndex = 11;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.campusnit1;
            pictureBox1.Location = new Point(39, 181);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(327, 237);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.Location = new Point(502, 457);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 13;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.LinkColor = Color.LightSeaGreen;
            linkLabel1.Location = new Point(502, 514);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(185, 25);
            linkLabel1.TabIndex = 14;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Want to add another?";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // AddInventory
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Azure;
            ClientSize = new Size(1090, 593);
            Controls.Add(linkLabel1);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            Controls.Add(quantitybox);
            Controls.Add(unitbox);
            Controls.Add(vendorbox);
            Controls.Add(inventorybox);
            Controls.Add(Namebox);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AddInventory";
            Text = "Form19";
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
        private Label label6;
        private Label label7;
        private TextBox Namebox;
        private TextBox inventorybox;
        private TextBox vendorbox;
        private TextBox unitbox;
        private TextBox quantitybox;
        private PictureBox pictureBox1;
        private Button button1;
        private LinkLabel linkLabel1;
    }
}