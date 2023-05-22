namespace Bank_System
{
    partial class AddBank
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddBank));
            panel1 = new Panel();
            pictureBox3 = new PictureBox();
            bAddbtn = new Button();
            label8 = new Label();
            label7 = new Label();
            bstreettb = new TextBox();
            label6 = new Label();
            bbuildingnotb = new TextBox();
            bcity = new TextBox();
            label3 = new Label();
            bcode = new TextBox();
            label1 = new Label();
            bNametb = new TextBox();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            label2 = new Label();
            BankDGV = new DataGridView();
            label4 = new Label();
            adminSSN = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BankDGV).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(pictureBox3);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(46, 450);
            panel1.TabIndex = 1;
            // 
            // pictureBox3
            // 
            pictureBox3.BackgroundImage = (Image)resources.GetObject("pictureBox3.BackgroundImage");
            pictureBox3.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox3.Location = new Point(0, 3);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(46, 34);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 49;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // bAddbtn
            // 
            bAddbtn.BackColor = SystemColors.ButtonHighlight;
            bAddbtn.Font = new Font("Britannic Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            bAddbtn.ForeColor = SystemColors.ActiveCaptionText;
            bAddbtn.Location = new Point(356, 297);
            bAddbtn.Name = "bAddbtn";
            bAddbtn.Size = new Size(123, 32);
            bAddbtn.TabIndex = 43;
            bAddbtn.Text = "Add";
            bAddbtn.UseVisualStyleBackColor = false;
            bAddbtn.Click += bAddbtn_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Britannic Bold", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = SystemColors.ActiveCaptionText;
            label8.Location = new Point(119, 222);
            label8.Name = "label8";
            label8.Size = new Size(52, 27);
            label8.TabIndex = 42;
            label8.Text = "City";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Britannic Bold", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = SystemColors.ActiveCaptionText;
            label7.Location = new Point(456, 96);
            label7.Name = "label7";
            label7.Size = new Size(75, 27);
            label7.TabIndex = 41;
            label7.Text = "Street";
            // 
            // bstreettb
            // 
            bstreettb.Location = new Point(456, 126);
            bstreettb.Name = "bstreettb";
            bstreettb.Size = new Size(248, 23);
            bstreettb.TabIndex = 40;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Britannic Bold", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.ActiveCaptionText;
            label6.Location = new Point(456, 162);
            label6.Name = "label6";
            label6.Size = new Size(192, 27);
            label6.TabIndex = 39;
            label6.Text = "Building Number";
            // 
            // bbuildingnotb
            // 
            bbuildingnotb.Location = new Point(456, 189);
            bbuildingnotb.Name = "bbuildingnotb";
            bbuildingnotb.Size = new Size(248, 23);
            bbuildingnotb.TabIndex = 36;
            // 
            // bcity
            // 
            bcity.Location = new Point(119, 249);
            bcity.Name = "bcity";
            bcity.Size = new Size(248, 23);
            bcity.TabIndex = 35;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Britannic Bold", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(119, 162);
            label3.Name = "label3";
            label3.Size = new Size(126, 27);
            label3.TabIndex = 34;
            label3.Text = "Bank Code";
            // 
            // bcode
            // 
            bcode.Location = new Point(119, 189);
            bcode.Name = "bcode";
            bcode.Size = new Size(248, 23);
            bcode.TabIndex = 33;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Britannic Bold", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(119, 96);
            label1.Name = "label1";
            label1.Size = new Size(71, 27);
            label1.TabIndex = 32;
            label1.Text = "Name";
            // 
            // bNametb
            // 
            bNametb.Location = new Point(119, 126);
            bNametb.Name = "bNametb";
            bNametb.Size = new Size(248, 23);
            bNametb.TabIndex = 31;
            bNametb.TextChanged += textBox1_TextChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(752, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(46, 34);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 30;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox2.Location = new Point(273, 7);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(77, 55);
            pictureBox2.TabIndex = 29;
            pictureBox2.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Britannic Bold", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(356, 24);
            label2.Name = "label2";
            label2.Size = new Size(163, 38);
            label2.TabIndex = 28;
            label2.Text = "Add Bank";
            // 
            // BankDGV
            // 
            BankDGV.BackgroundColor = SystemColors.ButtonHighlight;
            BankDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            BankDGV.Location = new Point(148, 344);
            BankDGV.Margin = new Padding(2);
            BankDGV.Name = "BankDGV";
            BankDGV.RowHeadersWidth = 62;
            BankDGV.RowTemplate.Height = 35;
            BankDGV.Size = new Size(522, 95);
            BankDGV.TabIndex = 46;
            BankDGV.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Britannic Bold", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(456, 222);
            label4.Name = "label4";
            label4.Size = new Size(141, 27);
            label4.TabIndex = 48;
            label4.Text = "Admin's SSN";
            // 
            // adminSSN
            // 
            adminSSN.Location = new Point(456, 249);
            adminSSN.Name = "adminSSN";
            adminSSN.Size = new Size(248, 23);
            adminSSN.TabIndex = 47;
            // 
            // AddBank
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(adminSSN);
            Controls.Add(BankDGV);
            Controls.Add(bAddbtn);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(bstreettb);
            Controls.Add(label6);
            Controls.Add(bbuildingnotb);
            Controls.Add(bcity);
            Controls.Add(label3);
            Controls.Add(bcode);
            Controls.Add(label1);
            Controls.Add(bNametb);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox2);
            Controls.Add(label2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AddBank";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddBank";
            Load += AddBank_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)BankDGV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button bAddbtn;
        private Label label8;
        private Label label7;
        private TextBox bstreettb;
        private Label label6;
        private TextBox bbuildingnotb;
        private TextBox bcity;
        private Label label3;
        private TextBox bcode;
        private Label label1;
        private TextBox bNametb;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label label2;
        private DataGridView BankDGV;
        private Label label4;
        private TextBox adminSSN;
        private PictureBox pictureBox3;
    }
}