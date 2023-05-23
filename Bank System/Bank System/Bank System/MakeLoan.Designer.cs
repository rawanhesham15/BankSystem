namespace Bank_System
{
    partial class MakeLoan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MakeLoan));
            pictureBox2 = new PictureBox();
            panel1 = new Panel();
            pictureBox3 = new PictureBox();
            label2 = new Label();
            label1 = new Label();
            label3 = new Label();
            lnssn = new TextBox();
            label4 = new Label();
            lnnum = new TextBox();
            request = new Button();
            button3 = new Button();
            pictureBox1 = new PictureBox();
            label5 = new Label();
            lnbrnch = new TextBox();
            lnbnkk = new TextBox();
            lnamnt = new TextBox();
            label6 = new Label();
            label7 = new Label();
            text = new Label();
            lntype = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox2.Location = new Point(210, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(82, 58);
            pictureBox2.TabIndex = 10;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(pictureBox3);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(49, 450);
            panel1.TabIndex = 11;
            // 
            // pictureBox3
            // 
            pictureBox3.BackgroundImage = (Image)resources.GetObject("pictureBox3.BackgroundImage");
            pictureBox3.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox3.Location = new Point(0, 3);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(46, 34);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 70;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Britannic Bold", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(298, 23);
            label2.Name = "label2";
            label2.Size = new Size(0, 38);
            label2.TabIndex = 12;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Britannic Bold", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(298, 23);
            label1.Name = "label1";
            label1.Size = new Size(226, 38);
            label1.TabIndex = 13;
            label1.Text = "Request Loan";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Britannic Bold", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(454, 121);
            label3.Name = "label3";
            label3.Size = new Size(176, 27);
            label3.TabIndex = 27;
            label3.Text = "Customer's SSN";
            // 
            // lnssn
            // 
            lnssn.Location = new Point(454, 161);
            lnssn.Name = "lnssn";
            lnssn.Size = new Size(248, 23);
            lnssn.TabIndex = 26;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Britannic Bold", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(135, 121);
            label4.Name = "label4";
            label4.Size = new Size(149, 27);
            label4.TabIndex = 25;
            label4.Text = "loan Number";
            // 
            // lnnum
            // 
            lnnum.Location = new Point(135, 161);
            lnnum.Name = "lnnum";
            lnnum.Size = new Size(248, 23);
            lnnum.TabIndex = 24;
            // 
            // request
            // 
            request.BackColor = SystemColors.ButtonHighlight;
            request.Font = new Font("Britannic Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            request.ForeColor = SystemColors.ActiveCaptionText;
            request.Location = new Point(257, 358);
            request.Name = "request";
            request.Size = new Size(123, 32);
            request.TabIndex = 28;
            request.Text = "Request";
            request.UseVisualStyleBackColor = false;
            request.Click += button1_Click;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.ButtonHighlight;
            button3.Font = new Font("Britannic Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            button3.ForeColor = SystemColors.ActiveCaptionText;
            button3.Location = new Point(431, 358);
            button3.Name = "button3";
            button3.Size = new Size(123, 32);
            button3.TabIndex = 29;
            button3.Text = "Cancel";
            button3.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(751, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(46, 34);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 30;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Britannic Bold", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ActiveCaptionText;
            label5.Location = new Point(454, 190);
            label5.Name = "label5";
            label5.Size = new Size(119, 27);
            label5.TabIndex = 31;
            label5.Text = "Loan Type";
            // 
            // lnbrnch
            // 
            lnbrnch.Location = new Point(135, 289);
            lnbrnch.Name = "lnbrnch";
            lnbrnch.Size = new Size(248, 23);
            lnbrnch.TabIndex = 32;
            // 
            // lnbnkk
            // 
            lnbnkk.Location = new Point(135, 225);
            lnbnkk.Name = "lnbnkk";
            lnbnkk.Size = new Size(248, 23);
            lnbnkk.TabIndex = 34;
            // 
            // lnamnt
            // 
            lnamnt.Location = new Point(454, 289);
            lnamnt.Name = "lnamnt";
            lnamnt.Size = new Size(248, 23);
            lnamnt.TabIndex = 35;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Britannic Bold", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.ActiveCaptionText;
            label6.Location = new Point(454, 254);
            label6.Name = "label6";
            label6.Size = new Size(94, 27);
            label6.TabIndex = 36;
            label6.Text = "Amount";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Britannic Bold", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = SystemColors.ActiveCaptionText;
            label7.Location = new Point(135, 254);
            label7.Name = "label7";
            label7.Size = new Size(180, 27);
            label7.TabIndex = 37;
            label7.Text = "Branch Number";
            // 
            // text
            // 
            text.AutoSize = true;
            text.Font = new Font("Britannic Bold", 18F, FontStyle.Regular, GraphicsUnit.Point);
            text.ForeColor = SystemColors.ActiveCaptionText;
            text.Location = new Point(135, 198);
            text.Name = "text";
            text.Size = new Size(126, 27);
            text.TabIndex = 38;
            text.Text = "Bank Code";
            // 
            // lntype
            // 
            lntype.FormattingEnabled = true;
            lntype.Items.AddRange(new object[] { "Industrial Loan", "Commercial Loan ", "Personal Loan" });
            lntype.Location = new Point(454, 217);
            lntype.Name = "lntype";
            lntype.Size = new Size(248, 23);
            lntype.TabIndex = 39;
            // 
            // MakeLoan
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lntype);
            Controls.Add(text);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(lnamnt);
            Controls.Add(lnbnkk);
            Controls.Add(lnbrnch);
            Controls.Add(label5);
            Controls.Add(pictureBox1);
            Controls.Add(button3);
            Controls.Add(request);
            Controls.Add(label3);
            Controls.Add(lnssn);
            Controls.Add(label4);
            Controls.Add(lnnum);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(panel1);
            Controls.Add(pictureBox2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MakeLoan";
            StartPosition = FormStartPosition.CenterScreen;
            Load += MakeLoan_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox2;
        private Panel panel1;
        private Label label2;
        private Label label1;
        private Label label3;
        private TextBox lnssn;
        private Label label4;
        private TextBox lnnum;
        private Button request;
        private Button button3;
        private PictureBox pictureBox1;
        private Label label5;
        private TextBox lnbrnch;
        private TextBox lnbnkk;
        private TextBox lnamnt;
        private Label label6;
        private Label label7;
        private Label text;
        private ComboBox lntype;
        private PictureBox pictureBox3;
    }
}