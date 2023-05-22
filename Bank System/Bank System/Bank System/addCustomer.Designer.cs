namespace Bank_System
{
    partial class addCustomer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(addCustomer));
            panel1 = new Panel();
            pictureBox3 = new PictureBox();
            label2 = new Label();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            cusNameTb = new TextBox();
            label3 = new Label();
            cusSSNTb = new TextBox();
            label4 = new Label();
            empSSN = new TextBox();
            label5 = new Label();
            cusBuildingNumberTb = new TextBox();
            label6 = new Label();
            cusPhoneNumberTb = new TextBox();
            label7 = new Label();
            cusStreetTb = new TextBox();
            label8 = new Label();
            cusAddBtn = new Button();
            customerDGV = new DataGridView();
            label9 = new Label();
            balance = new TextBox();
            label10 = new Label();
            city = new TextBox();
            label11 = new Label();
            accNo = new TextBox();
            label12 = new Label();
            accType = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)customerDGV).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(pictureBox3);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(46, 594);
            panel1.TabIndex = 0;
            // 
            // pictureBox3
            // 
            pictureBox3.BackgroundImage = (Image)resources.GetObject("pictureBox3.BackgroundImage");
            pictureBox3.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox3.Location = new Point(0, 3);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(46, 34);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 69;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Britannic Bold", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(321, 22);
            label2.Name = "label2";
            label2.Size = new Size(233, 38);
            label2.TabIndex = 5;
            label2.Text = "Add Customer";
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox2.Location = new Point(241, 5);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(85, 56);
            pictureBox2.TabIndex = 9;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(783, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(46, 34);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Britannic Bold", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(142, 80);
            label1.Name = "label1";
            label1.Size = new Size(71, 27);
            label1.TabIndex = 12;
            label1.Text = "Name";
            // 
            // cusNameTb
            // 
            cusNameTb.Location = new Point(142, 110);
            cusNameTb.Name = "cusNameTb";
            cusNameTb.Size = new Size(248, 23);
            cusNameTb.TabIndex = 11;
            cusNameTb.TextChanged += textBox1_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Britannic Bold", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(142, 149);
            label3.Name = "label3";
            label3.Size = new Size(52, 27);
            label3.TabIndex = 14;
            label3.Text = "SSN";
            // 
            // cusSSNTb
            // 
            cusSSNTb.Location = new Point(142, 176);
            cusSSNTb.Name = "cusSSNTb";
            cusSSNTb.Size = new Size(248, 23);
            cusSSNTb.TabIndex = 13;
            cusSSNTb.TextChanged += AcSSNTb_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Britannic Bold", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(836, 370);
            label4.Name = "label4";
            label4.Size = new Size(52, 27);
            label4.TabIndex = 16;
            label4.Text = "City";
            // 
            // empSSN
            // 
            empSSN.Location = new Point(142, 245);
            empSSN.Name = "empSSN";
            empSSN.Size = new Size(248, 23);
            empSSN.TabIndex = 15;
            empSSN.TextChanged += AcCityTb_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Britannic Bold", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ActiveCaptionText;
            label5.Location = new Point(479, 215);
            label5.Name = "label5";
            label5.Size = new Size(169, 27);
            label5.TabIndex = 18;
            label5.Text = "Phone Number";
            // 
            // cusBuildingNumberTb
            // 
            cusBuildingNumberTb.Location = new Point(479, 176);
            cusBuildingNumberTb.Name = "cusBuildingNumberTb";
            cusBuildingNumberTb.Size = new Size(248, 23);
            cusBuildingNumberTb.TabIndex = 17;
            cusBuildingNumberTb.TextChanged += AcBuildingNumberTb_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Britannic Bold", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.ActiveCaptionText;
            label6.Location = new Point(479, 149);
            label6.Name = "label6";
            label6.Size = new Size(192, 27);
            label6.TabIndex = 20;
            label6.Text = "Building Number";
            // 
            // cusPhoneNumberTb
            // 
            cusPhoneNumberTb.Location = new Point(479, 245);
            cusPhoneNumberTb.Name = "cusPhoneNumberTb";
            cusPhoneNumberTb.Size = new Size(248, 23);
            cusPhoneNumberTb.TabIndex = 19;
            cusPhoneNumberTb.TextChanged += AcPhoneNumberTb_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Britannic Bold", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = SystemColors.ActiveCaptionText;
            label7.Location = new Point(479, 80);
            label7.Name = "label7";
            label7.Size = new Size(75, 27);
            label7.TabIndex = 22;
            label7.Text = "Street";
            // 
            // cusStreetTb
            // 
            cusStreetTb.Location = new Point(479, 110);
            cusStreetTb.Name = "cusStreetTb";
            cusStreetTb.Size = new Size(248, 23);
            cusStreetTb.TabIndex = 21;
            cusStreetTb.TextChanged += AcStreetTb_TextChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Britannic Bold", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = SystemColors.ActiveCaptionText;
            label8.Location = new Point(142, 215);
            label8.Name = "label8";
            label8.Size = new Size(175, 27);
            label8.TabIndex = 23;
            label8.Text = "Employee's SSN";
            // 
            // cusAddBtn
            // 
            cusAddBtn.BackColor = SystemColors.ButtonHighlight;
            cusAddBtn.Font = new Font("Britannic Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            cusAddBtn.ForeColor = SystemColors.ActiveCaptionText;
            cusAddBtn.Location = new Point(372, 427);
            cusAddBtn.Name = "cusAddBtn";
            cusAddBtn.Size = new Size(123, 32);
            cusAddBtn.TabIndex = 24;
            cusAddBtn.Text = "Add";
            cusAddBtn.UseVisualStyleBackColor = false;
            cusAddBtn.Click += AddBtn_Click;
            // 
            // customerDGV
            // 
            customerDGV.BackgroundColor = SystemColors.ButtonHighlight;
            customerDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            customerDGV.Location = new Point(142, 478);
            customerDGV.Margin = new Padding(2);
            customerDGV.Name = "customerDGV";
            customerDGV.RowHeadersWidth = 62;
            customerDGV.RowTemplate.Height = 35;
            customerDGV.Size = new Size(584, 105);
            customerDGV.TabIndex = 27;
            customerDGV.CellContentClick += customerDGV_CellContentClick;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Britannic Bold", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label9.ForeColor = SystemColors.ActiveCaptionText;
            label9.Location = new Point(143, 277);
            label9.Name = "label9";
            label9.Size = new Size(52, 27);
            label9.TabIndex = 31;
            label9.Text = "City";
            // 
            // balance
            // 
            balance.Location = new Point(479, 307);
            balance.Name = "balance";
            balance.Size = new Size(248, 23);
            balance.TabIndex = 30;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Britannic Bold", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label10.ForeColor = SystemColors.ActiveCaptionText;
            label10.Location = new Point(479, 277);
            label10.Name = "label10";
            label10.Size = new Size(98, 27);
            label10.TabIndex = 29;
            label10.Text = "Balance";
            // 
            // city
            // 
            city.Location = new Point(142, 307);
            city.Name = "city";
            city.Size = new Size(248, 23);
            city.TabIndex = 28;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Britannic Bold", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label11.ForeColor = SystemColors.ActiveCaptionText;
            label11.Location = new Point(142, 348);
            label11.Name = "label11";
            label11.Size = new Size(188, 27);
            label11.TabIndex = 33;
            label11.Text = "Account Number";
            // 
            // accNo
            // 
            accNo.Location = new Point(142, 378);
            accNo.Name = "accNo";
            accNo.Size = new Size(248, 23);
            accNo.TabIndex = 32;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Britannic Bold", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label12.ForeColor = SystemColors.ActiveCaptionText;
            label12.Location = new Point(479, 348);
            label12.Name = "label12";
            label12.Size = new Size(153, 27);
            label12.TabIndex = 35;
            label12.Text = "Account Type";
            // 
            // accType
            // 
            accType.Location = new Point(479, 378);
            accType.Name = "accType";
            accType.Size = new Size(248, 23);
            accType.TabIndex = 34;
            // 
            // addCustomer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(830, 594);
            Controls.Add(label12);
            Controls.Add(accType);
            Controls.Add(label11);
            Controls.Add(accNo);
            Controls.Add(label9);
            Controls.Add(balance);
            Controls.Add(label10);
            Controls.Add(city);
            Controls.Add(customerDGV);
            Controls.Add(cusAddBtn);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(cusStreetTb);
            Controls.Add(label6);
            Controls.Add(cusPhoneNumberTb);
            Controls.Add(label5);
            Controls.Add(cusBuildingNumberTb);
            Controls.Add(label4);
            Controls.Add(empSSN);
            Controls.Add(label3);
            Controls.Add(cusSSNTb);
            Controls.Add(label1);
            Controls.Add(cusNameTb);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox2);
            Controls.Add(label2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "addCustomer";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "addCustomer";
            Load += addCustomer_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)customerDGV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Label label1;
        private TextBox cusNameTb;
        private Label label3;
        private TextBox cusSSNTb;
        private Label label4;
        private TextBox empSSN;
        private Label label5;
        private TextBox cusBuildingNumberTb;
        private Label label6;
        private TextBox cusPhoneNumberTb;
        private Label label7;
        private TextBox cusStreetTb;
        private Label label8;
        private Button cusAddBtn;
        private DataGridView customerDGV;
        private Label label9;
        private TextBox balance;
        private Label label10;
        private TextBox city;
        private Label label11;
        private TextBox accNo;
        private PictureBox pictureBox3;
        private Label label12;
        private TextBox accType;
    }
}