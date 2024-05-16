namespace CafeManagementSystem
{
    partial class AddMenu
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
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            NameBox = new TextBox();
            PriceBox = new TextBox();
            DescBox = new TextBox();
            IDbox = new TextBox();
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
            label1.Location = new Point(367, 44);
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
            label2.Location = new Point(384, 108);
            label2.Name = "label2";
            label2.Size = new Size(236, 38);
            label2.TabIndex = 1;
            label2.Text = "Add Menu Items";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(374, 181);
            label4.Name = "label4";
            label4.Size = new Size(59, 25);
            label4.TabIndex = 3;
            label4.Text = "Name";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(374, 239);
            label5.Name = "label5";
            label5.Size = new Size(49, 25);
            label5.TabIndex = 4;
            label5.Text = "Price";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(372, 352);
            label6.Name = "label6";
            label6.Size = new Size(100, 25);
            label6.TabIndex = 5;
            label6.Text = "CategoryId";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(372, 297);
            label7.Name = "label7";
            label7.Size = new Size(102, 25);
            label7.TabIndex = 6;
            label7.Text = "Description";
            // 
            // NameBox
            // 
            NameBox.Location = new Point(489, 175);
            NameBox.Name = "NameBox";
            NameBox.Size = new Size(150, 31);
            NameBox.TabIndex = 8;
            // 
            // PriceBox
            // 
            PriceBox.Location = new Point(489, 233);
            PriceBox.Name = "PriceBox";
            PriceBox.Size = new Size(150, 31);
            PriceBox.TabIndex = 9;
            // 
            // DescBox
            // 
            DescBox.Location = new Point(489, 291);
            DescBox.Name = "DescBox";
            DescBox.Size = new Size(150, 31);
            DescBox.TabIndex = 10;
            // 
            // IDbox
            // 
            IDbox.Location = new Point(489, 346);
            IDbox.Name = "IDbox";
            IDbox.Size = new Size(150, 31);
            IDbox.TabIndex = 11;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.campusnit;
            pictureBox1.Location = new Point(39, 175);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(284, 243);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.Location = new Point(489, 410);
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
            linkLabel1.Location = new Point(489, 471);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(217, 25);
            linkLabel1.TabIndex = 14;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Want to add another item";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // Form6
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Azure;
            ClientSize = new Size(990, 565);
            Controls.Add(linkLabel1);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            Controls.Add(IDbox);
            Controls.Add(DescBox);
            Controls.Add(PriceBox);
            Controls.Add(NameBox);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form6";
            Text = "Form6";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox NameBox;
        private TextBox PriceBox;
        private TextBox DescBox;
        private TextBox IDbox;
        private PictureBox pictureBox1;
        private Button button1;
        private LinkLabel linkLabel1;
    }
}