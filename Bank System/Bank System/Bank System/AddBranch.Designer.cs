namespace Bank_System
{
    partial class AddBranch
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddBranch));
            bAddbtn = new Button();
            label8 = new Label();
            label7 = new Label();
            bstreettb = new TextBox();
            label6 = new Label();
            bbuilidingtb = new TextBox();
            bcitytb = new TextBox();
            label1 = new Label();
            bnumtb = new TextBox();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            label2 = new Label();
            panel1 = new Panel();
            pictureBox3 = new PictureBox();
            contextMenuStrip1 = new ContextMenuStrip(components);
            bcodetb = new TextBox();
            bank = new Label();
            label4 = new Label();
            adminSSN = new TextBox();
            branches = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)branches).BeginInit();
            SuspendLayout();
            // 
            // bAddbtn
            // 
            bAddbtn.BackColor = SystemColors.ButtonHighlight;
            bAddbtn.Font = new Font("Britannic Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            bAddbtn.ForeColor = SystemColors.ActiveCaptionText;
            bAddbtn.Location = new Point(352, 338);
            bAddbtn.Name = "bAddbtn";
            bAddbtn.Size = new Size(123, 32);
            bAddbtn.TabIndex = 60;
            bAddbtn.Text = "Add";
            bAddbtn.UseVisualStyleBackColor = false;
            bAddbtn.Click += bAddbtn_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Britannic Bold", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = SystemColors.ActiveCaptionText;
            label8.Location = new Point(136, 172);
            label8.Name = "label8";
            label8.Size = new Size(52, 27);
            label8.TabIndex = 59;
            label8.Text = "City";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Britannic Bold", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = SystemColors.ActiveCaptionText;
            label7.Location = new Point(467, 91);
            label7.Name = "label7";
            label7.Size = new Size(75, 27);
            label7.TabIndex = 58;
            label7.Text = "Street";
            // 
            // bstreettb
            // 
            bstreettb.Location = new Point(473, 131);
            bstreettb.Name = "bstreettb";
            bstreettb.Size = new Size(248, 23);
            bstreettb.TabIndex = 57;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Britannic Bold", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.ActiveCaptionText;
            label6.Location = new Point(473, 172);
            label6.Name = "label6";
            label6.Size = new Size(192, 27);
            label6.TabIndex = 56;
            label6.Text = "Building Number";
            label6.Click += label6_Click_1;
            // 
            // bbuilidingtb
            // 
            bbuilidingtb.Location = new Point(473, 210);
            bbuilidingtb.Name = "bbuilidingtb";
            bbuilidingtb.Size = new Size(248, 23);
            bbuilidingtb.TabIndex = 55;
            // 
            // bcitytb
            // 
            bcitytb.Location = new Point(136, 205);
            bcitytb.Name = "bcitytb";
            bcitytb.Size = new Size(248, 23);
            bcitytb.TabIndex = 54;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Britannic Bold", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(136, 98);
            label1.Name = "label1";
            label1.Size = new Size(180, 27);
            label1.TabIndex = 51;
            label1.Text = "Branch Number";
            // 
            // bnumtb
            // 
            bnumtb.Location = new Point(136, 131);
            bnumtb.Name = "bnumtb";
            bnumtb.Size = new Size(248, 23);
            bnumtb.TabIndex = 50;
            bnumtb.TextChanged += textBox1_TextChanged_1;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(753, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(46, 34);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 49;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click_1;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox2.Location = new Point(263, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(68, 55);
            pictureBox2.TabIndex = 48;
            pictureBox2.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Britannic Bold", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(327, 29);
            label2.Name = "label2";
            label2.Size = new Size(197, 38);
            label2.TabIndex = 47;
            label2.Text = "Add Branch";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(pictureBox3);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(46, 539);
            panel1.TabIndex = 46;
            // 
            // pictureBox3
            // 
            pictureBox3.BackgroundImage = (Image)resources.GetObject("pictureBox3.BackgroundImage");
            pictureBox3.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox3.Location = new Point(0, 3);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(46, 34);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 68;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(24, 24);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // bcodetb
            // 
            bcodetb.Location = new Point(136, 282);
            bcodetb.Name = "bcodetb";
            bcodetb.Size = new Size(248, 23);
            bcodetb.TabIndex = 64;
            bcodetb.TextChanged += textBox1_TextChanged_2;
            // 
            // bank
            // 
            bank.AutoSize = true;
            bank.Font = new Font("Britannic Bold", 18F, FontStyle.Regular, GraphicsUnit.Point);
            bank.ForeColor = SystemColors.ActiveCaptionText;
            bank.Location = new Point(136, 245);
            bank.Name = "bank";
            bank.Size = new Size(126, 27);
            bank.TabIndex = 65;
            bank.Text = "Bank Code";
            bank.Click += label3_Click_1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Britannic Bold", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(473, 252);
            label4.Name = "label4";
            label4.Size = new Size(141, 27);
            label4.TabIndex = 67;
            label4.Text = "Admin's SSN";
            label4.Click += label4_Click;
            // 
            // adminSSN
            // 
            adminSSN.Location = new Point(473, 282);
            adminSSN.Name = "adminSSN";
            adminSSN.Size = new Size(248, 23);
            adminSSN.TabIndex = 66;
            // 
            // branches
            // 
            branches.BackgroundColor = SystemColors.ButtonHighlight;
            branches.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            branches.Location = new Point(156, 387);
            branches.Margin = new Padding(2);
            branches.Name = "branches";
            branches.RowHeadersWidth = 62;
            branches.RowTemplate.Height = 35;
            branches.Size = new Size(522, 132);
            branches.TabIndex = 68;
            // 
            // AddBranch
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 539);
            Controls.Add(branches);
            Controls.Add(label4);
            Controls.Add(adminSSN);
            Controls.Add(bank);
            Controls.Add(bcodetb);
            Controls.Add(bAddbtn);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(bstreettb);
            Controls.Add(label6);
            Controls.Add(bbuilidingtb);
            Controls.Add(bcitytb);
            Controls.Add(label1);
            Controls.Add(bnumtb);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox2);
            Controls.Add(label2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AddBranch";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddBranch";
            Load += AddBranch_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)branches).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button bAddbtn;
        private Label label8;
        private Label label7;
        private TextBox bstreettb;
        private Label label6;
        private TextBox bbuilidingtb;
        private TextBox bcitytb;
        private Label label1;
        private TextBox bnumtb;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label label2;
        private Panel panel1;
        private ContextMenuStrip contextMenuStrip1;
        private TextBox bcodetb;
        private Label bank;
        private Label label4;
        private TextBox adminSSN;
        private PictureBox pictureBox3;
        private DataGridView branches;
    }
}