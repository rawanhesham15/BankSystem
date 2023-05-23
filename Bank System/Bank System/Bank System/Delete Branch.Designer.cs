namespace Bank_System
{
    partial class Delete_Branch
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Delete_Branch));
            numtodelete = new TextBox();
            codetodelete = new TextBox();
            pictureBox1 = new PictureBox();
            pictureBox3 = new PictureBox();
            panel1 = new Panel();
            bAddbtn = new Button();
            label3 = new Label();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // numtodelete
            // 
            numtodelete.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            numtodelete.Location = new Point(227, 112);
            numtodelete.Margin = new Padding(2);
            numtodelete.Name = "numtodelete";
            numtodelete.Size = new Size(212, 32);
            numtodelete.TabIndex = 80;
            // 
            // codetodelete
            // 
            codetodelete.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            codetodelete.Location = new Point(227, 162);
            codetodelete.Margin = new Padding(2);
            codetodelete.Name = "codetodelete";
            codetodelete.Size = new Size(212, 32);
            codetodelete.TabIndex = 83;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(479, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(46, 34);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 85;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.BackgroundImage = (Image)resources.GetObject("pictureBox3.BackgroundImage");
            pictureBox3.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox3.Location = new Point(0, 3);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(46, 34);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 86;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(bAddbtn);
            panel1.Controls.Add(numtodelete);
            panel1.Controls.Add(codetodelete);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(pictureBox3);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(525, 308);
            panel1.TabIndex = 87;
            // 
            // bAddbtn
            // 
            bAddbtn.BackColor = SystemColors.ButtonHighlight;
            bAddbtn.Font = new Font("Britannic Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            bAddbtn.ForeColor = SystemColors.ActiveCaptionText;
            bAddbtn.Location = new Point(199, 236);
            bAddbtn.Name = "bAddbtn";
            bAddbtn.Size = new Size(123, 32);
            bAddbtn.TabIndex = 91;
            bAddbtn.Text = "Delete";
            bAddbtn.UseVisualStyleBackColor = false;
            bAddbtn.Click += bAddbtn_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Britannic Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(101, 162);
            label3.Name = "label3";
            label3.Size = new Size(121, 23);
            label3.TabIndex = 90;
            label3.Text = "Bank's Code";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Britannic Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(54, 112);
            label1.Name = "label1";
            label1.Size = new Size(168, 23);
            label1.TabIndex = 89;
            label1.Text = "Branch's Number";
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox2.Location = new Point(112, 9);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(68, 55);
            pictureBox2.TabIndex = 88;
            pictureBox2.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Britannic Bold", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(176, 26);
            label2.Name = "label2";
            label2.Size = new Size(235, 38);
            label2.TabIndex = 87;
            label2.Text = "Delete Branch";
            // 
            // Delete_Branch
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(549, 332);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2);
            Name = "Delete_Branch";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Delete_Branch";
            Load += Delete_Branch_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private TextBox numtodelete;
        private TextBox codetodelete;
        private PictureBox pictureBox1;
        private PictureBox pictureBox3;
        private Panel panel1;
        private Label label2;
        private Label label3;
        private Label label1;
        private PictureBox pictureBox2;
        private Button bAddbtn;
    }
}