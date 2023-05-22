namespace Bank_System
{
    partial class addAccount
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(addAccount));
            panel1 = new Panel();
            label2 = new Label();
            label3 = new Label();
            label1 = new Label();
            label4 = new Label();
            label5 = new Label();
            acctype = new TextBox();
            balance = new TextBox();
            ACCnum = new TextBox();
            cusSSn = new TextBox();
            AddBtn = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Location = new Point(2, -2);
            panel1.Name = "panel1";
            panel1.Size = new Size(74, 547);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Britannic Bold", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(343, 38);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(315, 58);
            label2.TabIndex = 6;
            label2.Text = "Add Account";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Britannic Bold", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(125, 265);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(154, 40);
            label3.TabIndex = 15;
            label3.Text = "Balance:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Britannic Bold", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(566, 265);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(237, 40);
            label1.TabIndex = 16;
            label1.Text = "Account Type:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Britannic Bold", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(566, 131);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(288, 40);
            label4.TabIndex = 17;
            label4.Text = "Account Number:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Britannic Bold", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ActiveCaptionText;
            label5.Location = new Point(115, 131);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(275, 40);
            label5.TabIndex = 18;
            label5.Text = "Customer's SSN:";
            // 
            // acctype
            // 
            acctype.Location = new Point(566, 341);
            acctype.Margin = new Padding(4, 5, 4, 5);
            acctype.Name = "acctype";
            acctype.Size = new Size(388, 33);
            acctype.TabIndex = 19;
            // 
            // balance
            // 
            balance.Location = new Point(115, 341);
            balance.Margin = new Padding(4, 5, 4, 5);
            balance.Name = "balance";
            balance.Size = new Size(388, 33);
            balance.TabIndex = 20;
            // 
            // ACCnum
            // 
            ACCnum.Location = new Point(566, 198);
            ACCnum.Margin = new Padding(4, 5, 4, 5);
            ACCnum.Name = "ACCnum";
            ACCnum.Size = new Size(388, 33);
            ACCnum.TabIndex = 21;
            // 
            // cusSSn
            // 
            cusSSn.Location = new Point(125, 198);
            cusSSn.Margin = new Padding(4, 5, 4, 5);
            cusSSn.Name = "cusSSn";
            cusSSn.Size = new Size(388, 33);
            cusSSn.TabIndex = 22;
            // 
            // AddBtn
            // 
            AddBtn.BackColor = SystemColors.ButtonHighlight;
            AddBtn.Font = new Font("Britannic Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            AddBtn.ForeColor = SystemColors.ActiveCaptionText;
            AddBtn.Location = new Point(404, 419);
            AddBtn.Margin = new Padding(4, 5, 4, 5);
            AddBtn.Name = "AddBtn";
            AddBtn.Size = new Size(194, 54);
            AddBtn.TabIndex = 25;
            AddBtn.Text = "Add";
            AddBtn.UseVisualStyleBackColor = false;
            AddBtn.Click += AddBtn_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(930, 38);
            pictureBox1.Margin = new Padding(4, 5, 4, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(73, 56);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 77;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // addAccount
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(1030, 557);
            Controls.Add(pictureBox1);
            Controls.Add(AddBtn);
            Controls.Add(cusSSn);
            Controls.Add(ACCnum);
            Controls.Add(balance);
            Controls.Add(acctype);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "addAccount";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "addAccount";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private Label label3;
        private Label label1;
        private Label label4;
        private Label label5;
        private TextBox acctype;
        private TextBox balance;
        private TextBox ACCnum;
        private TextBox cusSSn;
        private Button AddBtn;
        private PictureBox pictureBox1;
    }
}