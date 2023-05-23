namespace Bank_System
{
    partial class Statistics
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Statistics));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label3 = new Label();
            branchBnk = new DataGridView();
            AddBtn = new Button();
            citymax = new DataGridView();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            label4 = new Label();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)branchBnk).BeginInit();
            ((System.ComponentModel.ISupportInitialize)citymax).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(578, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(46, 34);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 78;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Britannic Bold", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(110, 69);
            label1.Name = "label1";
            label1.Size = new Size(387, 27);
            label1.TabIndex = 80;
            label1.Text = "Number of Branches In Each Bank:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Britannic Bold", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(81, 234);
            label3.Name = "label3";
            label3.Size = new Size(462, 27);
            label3.TabIndex = 82;
            label3.Text = "City With Maximum Number of Customers:";
            // 
            // branchBnk
            // 
            branchBnk.BackgroundColor = SystemColors.ButtonHighlight;
            branchBnk.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            branchBnk.Location = new Point(152, 98);
            branchBnk.Margin = new Padding(2);
            branchBnk.Name = "branchBnk";
            branchBnk.RowHeadersWidth = 62;
            branchBnk.RowTemplate.Height = 35;
            branchBnk.Size = new Size(306, 115);
            branchBnk.TabIndex = 84;
            // 
            // AddBtn
            // 
            AddBtn.BackColor = SystemColors.ButtonHighlight;
            AddBtn.Font = new Font("Britannic Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            AddBtn.ForeColor = SystemColors.ActiveCaptionText;
            AddBtn.Location = new Point(206, 399);
            AddBtn.Name = "AddBtn";
            AddBtn.Size = new Size(191, 32);
            AddBtn.TabIndex = 85;
            AddBtn.Text = "Generate Report";
            AddBtn.UseVisualStyleBackColor = false;
            AddBtn.Click += AddBtn_Click;
            // 
            // citymax
            // 
            citymax.BackgroundColor = SystemColors.ButtonHighlight;
            citymax.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            citymax.Location = new Point(164, 276);
            citymax.Margin = new Padding(2);
            citymax.Name = "citymax";
            citymax.RowHeadersWidth = 62;
            citymax.RowTemplate.Height = 35;
            citymax.Size = new Size(306, 118);
            citymax.TabIndex = 86;
            // 
            // pictureBox3
            // 
            pictureBox3.BackgroundImage = (Image)resources.GetObject("pictureBox3.BackgroundImage");
            pictureBox3.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox3.Location = new Point(0, 3);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(46, 34);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 87;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox2.Location = new Point(222, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(72, 58);
            pictureBox2.TabIndex = 89;
            pictureBox2.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Britannic Bold", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(288, 20);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(120, 38);
            label4.TabIndex = 88;
            label4.Text = "Report";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(AddBtn);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(branchBnk);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(12, 13);
            panel1.Name = "panel1";
            panel1.Size = new Size(624, 442);
            panel1.TabIndex = 90;
            // 
            // Statistics
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(652, 467);
            Controls.Add(citymax);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2);
            Name = "Statistics";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Statistics";
            Load += Statistics_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)branchBnk).EndInit();
            ((System.ComponentModel.ISupportInitialize)citymax).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label3;
        private DataGridView branchBnk;
        private Button AddBtn;
        private DataGridView citymax;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private Label label4;
        private Panel panel1;
    }
}