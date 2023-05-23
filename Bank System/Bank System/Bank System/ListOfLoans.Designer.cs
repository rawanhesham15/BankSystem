namespace Bank_System
{
    partial class ListOfLoans
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListOfLoans));
            label2 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox3 = new PictureBox();
            loanDGV = new DataGridView();
            pictureBox2 = new PictureBox();
            label7 = new Label();
            label6 = new Label();
            label4 = new Label();
            label3 = new Label();
            SSN = new TextBox();
            loanAmount = new TextBox();
            loanType = new TextBox();
            loanNo = new TextBox();
            button1 = new Button();
            button2 = new Button();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)loanDGV).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Britannic Bold", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(260, 11);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(226, 38);
            label2.TabIndex = 14;
            label2.Text = "List OF Loans";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(637, 2);
            pictureBox1.Margin = new Padding(2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(41, 38);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 16;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.BackgroundImage = (Image)resources.GetObject("pictureBox3.BackgroundImage");
            pictureBox3.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox3.Location = new Point(2, 2);
            pictureBox3.Margin = new Padding(2);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(41, 38);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 71;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // loanDGV
            // 
            loanDGV.BackgroundColor = SystemColors.ButtonFace;
            loanDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            loanDGV.Location = new Point(61, 87);
            loanDGV.Margin = new Padding(2);
            loanDGV.Name = "loanDGV";
            loanDGV.RowHeadersWidth = 62;
            loanDGV.RowTemplate.Height = 35;
            loanDGV.Size = new Size(573, 143);
            loanDGV.TabIndex = 72;
            loanDGV.CellContentClick += loanDGV_CellContentClick;
            loanDGV.RowHeaderMouseClick += loanDGV_RowHeaderMouseClick;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox2.Location = new Point(188, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(82, 58);
            pictureBox2.TabIndex = 73;
            pictureBox2.TabStop = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Britannic Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = SystemColors.ActiveCaptionText;
            label7.Location = new Point(324, 289);
            label7.Name = "label7";
            label7.Size = new Size(121, 21);
            label7.TabIndex = 107;
            label7.Text = "Loan Amount";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Britannic Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.ActiveCaptionText;
            label6.Location = new Point(350, 240);
            label6.Name = "label6";
            label6.Size = new Size(95, 21);
            label6.TabIndex = 106;
            label6.Text = "Loan Type";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Britannic Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(3, 289);
            label4.Name = "label4";
            label4.Size = new Size(139, 21);
            label4.TabIndex = 105;
            label4.Text = "Customer's SSN";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Britannic Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(67, 240);
            label3.Name = "label3";
            label3.Size = new Size(72, 21);
            label3.TabIndex = 104;
            label3.Text = "LoanNo";
            // 
            // SSN
            // 
            SSN.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            SSN.Location = new Point(155, 296);
            SSN.Margin = new Padding(2);
            SSN.Name = "SSN";
            SSN.Size = new Size(163, 32);
            SSN.TabIndex = 103;
            // 
            // loanAmount
            // 
            loanAmount.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            loanAmount.Location = new Point(462, 296);
            loanAmount.Margin = new Padding(2);
            loanAmount.Name = "loanAmount";
            loanAmount.Size = new Size(172, 32);
            loanAmount.TabIndex = 102;
            // 
            // loanType
            // 
            loanType.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            loanType.Location = new Point(462, 247);
            loanType.Margin = new Padding(2);
            loanType.Name = "loanType";
            loanType.Size = new Size(172, 32);
            loanType.TabIndex = 101;
            // 
            // loanNo
            // 
            loanNo.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            loanNo.Location = new Point(155, 248);
            loanNo.Margin = new Padding(2);
            loanNo.Name = "loanNo";
            loanNo.Size = new Size(163, 32);
            loanNo.TabIndex = 100;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ButtonHighlight;
            button1.Font = new Font("Britannic Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.ActiveCaptionText;
            button1.Location = new Point(183, 346);
            button1.Name = "button1";
            button1.Size = new Size(123, 32);
            button1.TabIndex = 109;
            button1.Text = "Accept";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ButtonHighlight;
            button2.Font = new Font("Britannic Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            button2.ForeColor = SystemColors.ActiveCaptionText;
            button2.Location = new Point(340, 346);
            button2.Name = "button2";
            button2.Size = new Size(123, 32);
            button2.TabIndex = 108;
            button2.Text = "Reject";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Location = new Point(12, 13);
            panel1.Name = "panel1";
            panel1.Size = new Size(680, 395);
            panel1.TabIndex = 110;
            // 
            // ListOfLoans
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(704, 420);
            Controls.Add(SSN);
            Controls.Add(loanAmount);
            Controls.Add(loanType);
            Controls.Add(loanNo);
            Controls.Add(loanDGV);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2);
            Name = "ListOfLoans";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ListOfLoans";
            Load += ListOfLoans_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)loanDGV).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private PictureBox pictureBox1;
        private PictureBox pictureBox3;
        private DataGridView loanDGV;
        private PictureBox pictureBox2;
        private Label label7;
        private Label label6;
        private Label label4;
        private Label label3;
        private TextBox SSN;
        private TextBox loanAmount;
        private TextBox loanType;
        private TextBox loanNo;
        private Button button1;
        private Button button2;
        private Panel panel1;
    }
}