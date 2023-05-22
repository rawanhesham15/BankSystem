namespace Bank_System
{
    partial class updateCustomer
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
            TextBox phonetoupdate;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(updateCustomer));
            SSNupdate = new TextBox();
            textBox1 = new TextBox();
            textBox3 = new TextBox();
            updateGrid = new DataGridView();
            search = new Button();
            pictureBox1 = new PictureBox();
            button1 = new Button();
            button2 = new Button();
            textBox2 = new TextBox();
            nameToUpdate = new TextBox();
            ssntoupdate = new TextBox();
            textBox7 = new TextBox();
            textBox8 = new TextBox();
            textBox9 = new TextBox();
            CityToupdate = new TextBox();
            StreetToupdate = new TextBox();
            buildingtoupdate = new TextBox();
            updatessn = new TextBox();
            textBox5 = new TextBox();
            phonetoupdate = new TextBox();
            ((System.ComponentModel.ISupportInitialize)updateGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // phonetoupdate
            // 
            phonetoupdate.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            phonetoupdate.Location = new Point(191, 555);
            phonetoupdate.Name = "phonetoupdate";
            phonetoupdate.Size = new Size(203, 45);
            phonetoupdate.TabIndex = 80;
            // 
            // SSNupdate
            // 
            SSNupdate.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            SSNupdate.Location = new Point(355, 131);
            SSNupdate.Name = "SSNupdate";
            SSNupdate.Size = new Size(109, 45);
            SSNupdate.TabIndex = 70;
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.ActiveCaption;
            textBox1.Font = new Font("Segoe UI Black", 14F, FontStyle.Bold, GraphicsUnit.Point);
            textBox1.Location = new Point(46, 131);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(239, 45);
            textBox1.TabIndex = 71;
            textBox1.Text = "Customer's SSN:";
            // 
            // textBox3
            // 
            textBox3.BackColor = SystemColors.ActiveCaption;
            textBox3.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            textBox3.Location = new Point(252, 33);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(307, 55);
            textBox3.TabIndex = 72;
            textBox3.Text = "Update Customer";
            // 
            // updateGrid
            // 
            updateGrid.BackgroundColor = SystemColors.ButtonFace;
            updateGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            updateGrid.Location = new Point(36, 214);
            updateGrid.Name = "updateGrid";
            updateGrid.RowHeadersWidth = 62;
            updateGrid.RowTemplate.Height = 35;
            updateGrid.Size = new Size(836, 143);
            updateGrid.TabIndex = 73;
            updateGrid.CellContentClick += updateGrid_CellContentClick;
            // 
            // search
            // 
            search.BackColor = SystemColors.ActiveCaption;
            search.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            search.Location = new Point(541, 131);
            search.Name = "search";
            search.Size = new Size(112, 41);
            search.TabIndex = 74;
            search.Text = "Search";
            search.UseVisualStyleBackColor = false;
            search.Click += search_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(862, 32);
            pictureBox1.Margin = new Padding(4, 5, 4, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(73, 56);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 75;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaption;
            button1.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(282, 683);
            button1.Name = "button1";
            button1.Size = new Size(112, 41);
            button1.TabIndex = 76;
            button1.Text = "Delete";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ActiveCaption;
            button2.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(572, 683);
            button2.Name = "button2";
            button2.Size = new Size(112, 41);
            button2.TabIndex = 77;
            button2.Text = "Update";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // textBox2
            // 
            textBox2.BackColor = SystemColors.ActiveCaption;
            textBox2.Font = new Font("Segoe UI Black", 14F, FontStyle.Bold, GraphicsUnit.Point);
            textBox2.Location = new Point(46, 383);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(113, 45);
            textBox2.TabIndex = 78;
            textBox2.Text = "Name:";
            // 
            // nameToUpdate
            // 
            nameToUpdate.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            nameToUpdate.Location = new Point(191, 383);
            nameToUpdate.Name = "nameToUpdate";
            nameToUpdate.Size = new Size(197, 45);
            nameToUpdate.TabIndex = 79;
            // 
            // ssntoupdate
            // 
            ssntoupdate.BackColor = SystemColors.ActiveCaption;
            ssntoupdate.Font = new Font("Segoe UI Black", 14F, FontStyle.Bold, GraphicsUnit.Point);
            ssntoupdate.Location = new Point(46, 457);
            ssntoupdate.Name = "ssntoupdate";
            ssntoupdate.Size = new Size(113, 45);
            ssntoupdate.TabIndex = 81;
            ssntoupdate.Text = "SSN:";
            // 
            // textBox7
            // 
            textBox7.BackColor = SystemColors.ActiveCaption;
            textBox7.Font = new Font("Segoe UI Black", 14F, FontStyle.Bold, GraphicsUnit.Point);
            textBox7.Location = new Point(439, 383);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(120, 45);
            textBox7.TabIndex = 82;
            textBox7.Text = "City:";
            textBox7.TextChanged += textBox7_TextChanged;
            // 
            // textBox8
            // 
            textBox8.BackColor = SystemColors.ActiveCaption;
            textBox8.Font = new Font("Segoe UI Black", 14F, FontStyle.Bold, GraphicsUnit.Point);
            textBox8.Location = new Point(439, 555);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(239, 45);
            textBox8.TabIndex = 83;
            textBox8.Text = "Building Num:";
            // 
            // textBox9
            // 
            textBox9.BackColor = SystemColors.ActiveCaption;
            textBox9.Font = new Font("Segoe UI Black", 14F, FontStyle.Bold, GraphicsUnit.Point);
            textBox9.Location = new Point(439, 467);
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(120, 45);
            textBox9.TabIndex = 84;
            textBox9.Text = "Street:";
            textBox9.TextChanged += textBox9_TextChanged;
            // 
            // CityToupdate
            // 
            CityToupdate.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            CityToupdate.Location = new Point(651, 383);
            CityToupdate.Name = "CityToupdate";
            CityToupdate.Size = new Size(197, 45);
            CityToupdate.TabIndex = 85;
            // 
            // StreetToupdate
            // 
            StreetToupdate.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            StreetToupdate.Location = new Point(651, 467);
            StreetToupdate.Name = "StreetToupdate";
            StreetToupdate.Size = new Size(197, 45);
            StreetToupdate.TabIndex = 86;
            // 
            // buildingtoupdate
            // 
            buildingtoupdate.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            buildingtoupdate.Location = new Point(711, 555);
            buildingtoupdate.Name = "buildingtoupdate";
            buildingtoupdate.Size = new Size(137, 45);
            buildingtoupdate.TabIndex = 87;
            // 
            // updatessn
            // 
            updatessn.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            updatessn.Location = new Point(197, 467);
            updatessn.Name = "updatessn";
            updatessn.Size = new Size(197, 45);
            updatessn.TabIndex = 88;
            // 
            // textBox5
            // 
            textBox5.BackColor = SystemColors.ActiveCaption;
            textBox5.Font = new Font("Segoe UI Black", 14F, FontStyle.Bold, GraphicsUnit.Point);
            textBox5.Location = new Point(46, 555);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(113, 45);
            textBox5.TabIndex = 89;
            textBox5.Text = "Phone:";
            textBox5.TextChanged += textBox5_TextChanged;
            // 
            // updateCustomer
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1000, 800);
            Controls.Add(textBox5);
            Controls.Add(updatessn);
            Controls.Add(buildingtoupdate);
            Controls.Add(StreetToupdate);
            Controls.Add(CityToupdate);
            Controls.Add(textBox9);
            Controls.Add(textBox8);
            Controls.Add(textBox7);
            Controls.Add(ssntoupdate);
            Controls.Add(phonetoupdate);
            Controls.Add(nameToUpdate);
            Controls.Add(textBox2);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            Controls.Add(search);
            Controls.Add(updateGrid);
            Controls.Add(textBox3);
            Controls.Add(textBox1);
            Controls.Add(SSNupdate);
            FormBorderStyle = FormBorderStyle.None;
            Name = "updateCustomer";
            Text = "updateCustomer";
            Load += updateCustomer_Load;
            ((System.ComponentModel.ISupportInitialize)updateGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox SSNupdate;
        private TextBox textBox1;
        private TextBox textBox3;
        private DataGridView updateGrid;
        private Button search;
        private PictureBox pictureBox1;
        private Button button1;
        private Button button2;
        private TextBox textBox2;
        private TextBox nameToUpdate;
        private TextBox phonetoupdate;
        private TextBox ssntoupdate;
        private TextBox textBox7;
        private TextBox textBox8;
        private TextBox textBox9;
        private TextBox CityToupdate;
        private TextBox StreetToupdate;
        private TextBox buildingtoupdate;
        private TextBox updatessn;
        private TextBox textBox5;
    }
}