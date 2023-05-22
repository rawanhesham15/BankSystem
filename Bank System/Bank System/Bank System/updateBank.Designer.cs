namespace Bank_System
{
    partial class updateBank
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(updateBank));
            pictureBox1 = new PictureBox();
            textBox3 = new TextBox();
            textBox1 = new TextBox();
            codetoupdate = new TextBox();
            search = new Button();
            updateGrid = new DataGridView();
            textBox2 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            textBox7 = new TextBox();
            updateStreet = new TextBox();
            updateName = new TextBox();
            updatecity = new TextBox();
            updatecode = new TextBox();
            updatebuild = new TextBox();
            updatebtn = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)updateGrid).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(849, 24);
            pictureBox1.Margin = new Padding(4, 5, 4, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(73, 56);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 76;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // textBox3
            // 
            textBox3.BackColor = SystemColors.ActiveCaption;
            textBox3.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            textBox3.Location = new Point(321, 50);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(307, 55);
            textBox3.TabIndex = 77;
            textBox3.Text = "Update Bank";
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.ActiveCaption;
            textBox1.Font = new Font("Segoe UI Black", 14F, FontStyle.Bold, GraphicsUnit.Point);
            textBox1.Location = new Point(52, 163);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(182, 45);
            textBox1.TabIndex = 78;
            textBox1.Text = "Bank Code:";
            // 
            // codetoupdate
            // 
            codetoupdate.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            codetoupdate.Location = new Point(277, 163);
            codetoupdate.Name = "codetoupdate";
            codetoupdate.Size = new Size(109, 45);
            codetoupdate.TabIndex = 79;
            // 
            // search
            // 
            search.BackColor = SystemColors.ActiveCaption;
            search.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            search.Location = new Point(482, 167);
            search.Name = "search";
            search.Size = new Size(112, 41);
            search.TabIndex = 80;
            search.Text = "Search";
            search.UseVisualStyleBackColor = false;
            search.Click += search_Click;
            // 
            // updateGrid
            // 
            updateGrid.BackgroundColor = SystemColors.ButtonFace;
            updateGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            updateGrid.Location = new Point(52, 235);
            updateGrid.Name = "updateGrid";
            updateGrid.RowHeadersWidth = 62;
            updateGrid.RowTemplate.Height = 35;
            updateGrid.Size = new Size(836, 107);
            updateGrid.TabIndex = 81;
            // 
            // textBox2
            // 
            textBox2.BackColor = SystemColors.ActiveCaption;
            textBox2.Font = new Font("Segoe UI Black", 14F, FontStyle.Bold, GraphicsUnit.Point);
            textBox2.Location = new Point(205, 504);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(259, 45);
            textBox2.TabIndex = 82;
            textBox2.Text = "Building Number:";
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // textBox4
            // 
            textBox4.BackColor = SystemColors.ActiveCaption;
            textBox4.Font = new Font("Segoe UI Black", 14F, FontStyle.Bold, GraphicsUnit.Point);
            textBox4.Location = new Point(466, 432);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(113, 45);
            textBox4.TabIndex = 83;
            textBox4.Text = "Street:";
            // 
            // textBox5
            // 
            textBox5.BackColor = SystemColors.ActiveCaption;
            textBox5.Font = new Font("Segoe UI Black", 14F, FontStyle.Bold, GraphicsUnit.Point);
            textBox5.Location = new Point(52, 432);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(113, 45);
            textBox5.TabIndex = 84;
            textBox5.Text = "Name:";
            textBox5.TextChanged += textBox5_TextChanged;
            // 
            // textBox6
            // 
            textBox6.BackColor = SystemColors.ActiveCaption;
            textBox6.Font = new Font("Segoe UI Black", 14F, FontStyle.Bold, GraphicsUnit.Point);
            textBox6.Location = new Point(466, 361);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(113, 45);
            textBox6.TabIndex = 85;
            textBox6.Text = "City;";
            // 
            // textBox7
            // 
            textBox7.BackColor = SystemColors.ActiveCaption;
            textBox7.Font = new Font("Segoe UI Black", 14F, FontStyle.Bold, GraphicsUnit.Point);
            textBox7.Location = new Point(52, 361);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(182, 45);
            textBox7.TabIndex = 86;
            textBox7.Text = "Bank Code:";
            // 
            // updateStreet
            // 
            updateStreet.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            updateStreet.Location = new Point(630, 432);
            updateStreet.Name = "updateStreet";
            updateStreet.Size = new Size(178, 45);
            updateStreet.TabIndex = 87;
            // 
            // updateName
            // 
            updateName.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            updateName.Location = new Point(223, 432);
            updateName.Name = "updateName";
            updateName.Size = new Size(163, 45);
            updateName.TabIndex = 88;
            // 
            // updatecity
            // 
            updatecity.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            updatecity.Location = new Point(630, 361);
            updatecity.Name = "updatecity";
            updatecity.Size = new Size(178, 45);
            updatecity.TabIndex = 89;
            // 
            // updatecode
            // 
            updatecode.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            updatecode.Location = new Point(274, 361);
            updatecode.Name = "updatecode";
            updatecode.Size = new Size(109, 45);
            updatecode.TabIndex = 90;
            // 
            // updatebuild
            // 
            updatebuild.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            updatebuild.Location = new Point(482, 504);
            updatebuild.Name = "updatebuild";
            updatebuild.Size = new Size(98, 45);
            updatebuild.TabIndex = 91;
            // 
            // updatebtn
            // 
            updatebtn.BackColor = SystemColors.ActiveCaption;
            updatebtn.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            updatebtn.Location = new Point(373, 608);
            updatebtn.Name = "updatebtn";
            updatebtn.Size = new Size(206, 71);
            updatebtn.TabIndex = 93;
            updatebtn.Text = "Update";
            updatebtn.UseVisualStyleBackColor = false;
            updatebtn.Click += updatebtn_Click;
            // 
            // updateBank
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(963, 691);
            Controls.Add(updatebtn);
            Controls.Add(updatebuild);
            Controls.Add(updatecode);
            Controls.Add(updatecity);
            Controls.Add(updateName);
            Controls.Add(updateStreet);
            Controls.Add(textBox7);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox2);
            Controls.Add(updateGrid);
            Controls.Add(search);
            Controls.Add(codetoupdate);
            Controls.Add(textBox1);
            Controls.Add(textBox3);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "updateBank";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "updateBank";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)updateGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private TextBox textBox3;
        private TextBox textBox1;
        private TextBox codetoupdate;
        private Button search;
        private DataGridView updateGrid;
        private TextBox textBox2;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private TextBox textBox7;
        private TextBox updateStreet;
        private TextBox updateName;
        private TextBox updatecity;
        private TextBox updatecode;
        private TextBox updatebuild;
        private Button updatebtn;
    }
}