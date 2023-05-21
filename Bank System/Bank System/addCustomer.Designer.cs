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
            label2 = new Label();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            AcNameTb = new TextBox();
            label3 = new Label();
            AcSSNTb = new TextBox();
            label4 = new Label();
            AcCityTb = new TextBox();
            label5 = new Label();
            AcBuildingNumberTb = new TextBox();
            label6 = new Label();
            AcPhoneNumberTb = new TextBox();
            label7 = new Label();
            AcStreetTb = new TextBox();
            label8 = new Label();
            AddBtn = new Button();
            EditBtn = new Button();
            CancelBtn = new Button();
            customerDGV = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)customerDGV).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4, 5, 4, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(73, 750);
            panel1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Britannic Bold", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(499, 49);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(354, 58);
            label2.TabIndex = 5;
            label2.Text = "Add Customer";
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox2.Location = new Point(356, 20);
            pictureBox2.Margin = new Padding(4, 5, 4, 5);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(153, 115);
            pictureBox2.TabIndex = 9;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(1158, 30);
            pictureBox1.Margin = new Padding(4, 5, 4, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(73, 56);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Britannic Bold", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(223, 157);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(106, 40);
            label1.TabIndex = 12;
            label1.Text = "Name";
            // 
            // AcNameTb
            // 
            AcNameTb.Location = new Point(223, 218);
            AcNameTb.Margin = new Padding(4, 5, 4, 5);
            AcNameTb.Name = "AcNameTb";
            AcNameTb.Size = new Size(388, 33);
            AcNameTb.TabIndex = 11;
            AcNameTb.TextChanged += textBox1_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Britannic Bold", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(223, 285);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(79, 40);
            label3.TabIndex = 14;
            label3.Text = "SSN";
            // 
            // AcSSNTb
            // 
            AcSSNTb.Location = new Point(223, 330);
            AcSSNTb.Margin = new Padding(4, 5, 4, 5);
            AcSSNTb.Name = "AcSSNTb";
            AcSSNTb.Size = new Size(388, 33);
            AcSSNTb.TabIndex = 13;
            AcSSNTb.TextChanged += AcSSNTb_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Britannic Bold", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(1313, 616);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(77, 40);
            label4.TabIndex = 16;
            label4.Text = "City";
            // 
            // AcCityTb
            // 
            AcCityTb.Location = new Point(225, 464);
            AcCityTb.Margin = new Padding(4, 5, 4, 5);
            AcCityTb.Name = "AcCityTb";
            AcCityTb.Size = new Size(388, 33);
            AcCityTb.TabIndex = 15;
            AcCityTb.TextChanged += AcCityTb_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Britannic Bold", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ActiveCaptionText;
            label5.Location = new Point(752, 392);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(250, 40);
            label5.TabIndex = 18;
            label5.Text = "Phone Number";
            // 
            // AcBuildingNumberTb
            // 
            AcBuildingNumberTb.Location = new Point(752, 330);
            AcBuildingNumberTb.Margin = new Padding(4, 5, 4, 5);
            AcBuildingNumberTb.Name = "AcBuildingNumberTb";
            AcBuildingNumberTb.Size = new Size(388, 33);
            AcBuildingNumberTb.TabIndex = 17;
            AcBuildingNumberTb.TextChanged += AcBuildingNumberTb_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Britannic Bold", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.ActiveCaptionText;
            label6.Location = new Point(752, 285);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(283, 40);
            label6.TabIndex = 20;
            label6.Text = "Building Number";
            // 
            // AcPhoneNumberTb
            // 
            AcPhoneNumberTb.Location = new Point(752, 464);
            AcPhoneNumberTb.Margin = new Padding(4, 5, 4, 5);
            AcPhoneNumberTb.Name = "AcPhoneNumberTb";
            AcPhoneNumberTb.Size = new Size(388, 33);
            AcPhoneNumberTb.TabIndex = 19;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Britannic Bold", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = SystemColors.ActiveCaptionText;
            label7.Location = new Point(752, 146);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(112, 40);
            label7.TabIndex = 22;
            label7.Text = "Street";
            // 
            // AcStreetTb
            // 
            AcStreetTb.Location = new Point(752, 218);
            AcStreetTb.Margin = new Padding(4, 5, 4, 5);
            AcStreetTb.Name = "AcStreetTb";
            AcStreetTb.Size = new Size(388, 33);
            AcStreetTb.TabIndex = 21;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Britannic Bold", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = SystemColors.ActiveCaptionText;
            label8.Location = new Point(225, 392);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(77, 40);
            label8.TabIndex = 23;
            label8.Text = "City";
            // 
            // AddBtn
            // 
            AddBtn.BackColor = SystemColors.ButtonHighlight;
            AddBtn.Font = new Font("Britannic Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            AddBtn.ForeColor = SystemColors.ActiveCaptionText;
            AddBtn.Location = new Point(261, 541);
            AddBtn.Margin = new Padding(4, 5, 4, 5);
            AddBtn.Name = "AddBtn";
            AddBtn.Size = new Size(194, 54);
            AddBtn.TabIndex = 24;
            AddBtn.Text = "Add";
            AddBtn.UseVisualStyleBackColor = false;
            AddBtn.Click += AddBtn_Click;
            // 
            // EditBtn
            // 
            EditBtn.BackColor = SystemColors.ButtonHighlight;
            EditBtn.Font = new Font("Britannic Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            EditBtn.ForeColor = SystemColors.ActiveCaptionText;
            EditBtn.Location = new Point(576, 541);
            EditBtn.Margin = new Padding(4, 5, 4, 5);
            EditBtn.Name = "EditBtn";
            EditBtn.Size = new Size(194, 54);
            EditBtn.TabIndex = 25;
            EditBtn.Text = "Edit";
            EditBtn.UseVisualStyleBackColor = false;
            EditBtn.Click += button2_Click;
            // 
            // CancelBtn
            // 
            CancelBtn.BackColor = SystemColors.ButtonHighlight;
            CancelBtn.Font = new Font("Britannic Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            CancelBtn.ForeColor = SystemColors.ActiveCaptionText;
            CancelBtn.Location = new Point(868, 541);
            CancelBtn.Margin = new Padding(4, 5, 4, 5);
            CancelBtn.Name = "CancelBtn";
            CancelBtn.Size = new Size(194, 54);
            CancelBtn.TabIndex = 26;
            CancelBtn.Text = "Cancel";
            CancelBtn.UseVisualStyleBackColor = false;
            CancelBtn.Click += CancelBtn_Click_1;
            // 
            // customerDGV
            // 
            customerDGV.BackgroundColor = SystemColors.ButtonFace;
            customerDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            customerDGV.Location = new Point(138, 631);
            customerDGV.Name = "customerDGV";
            customerDGV.RowHeadersWidth = 62;
            customerDGV.RowTemplate.Height = 35;
            customerDGV.Size = new Size(1002, 71);
            customerDGV.TabIndex = 27;
            customerDGV.CellContentClick += dataGridView1_CellContentClick;
            // 
            // addCustomer
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1257, 750);
            Controls.Add(customerDGV);
            Controls.Add(CancelBtn);
            Controls.Add(EditBtn);
            Controls.Add(AddBtn);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(AcStreetTb);
            Controls.Add(label6);
            Controls.Add(AcPhoneNumberTb);
            Controls.Add(label5);
            Controls.Add(AcBuildingNumberTb);
            Controls.Add(label4);
            Controls.Add(AcCityTb);
            Controls.Add(label3);
            Controls.Add(AcSSNTb);
            Controls.Add(label1);
            Controls.Add(AcNameTb);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox2);
            Controls.Add(label2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 5, 4, 5);
            Name = "addCustomer";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "addCustomer";
            Load += addCustomer_Load;
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
        private TextBox AcNameTb;
        private Label label3;
        private TextBox AcSSNTb;
        private Label label4;
        private TextBox AcCityTb;
        private Label label5;
        private TextBox AcBuildingNumberTb;
        private Label label6;
        private TextBox AcPhoneNumberTb;
        private Label label7;
        private TextBox AcStreetTb;
        private Label label8;
        private Button AddBtn;
        private Button EditBtn;
        private Button CancelBtn;
        private DataGridView customerDGV;
    }
}