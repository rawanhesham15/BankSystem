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
            textBox3 = new TextBox();
            textBox1 = new TextBox();
            numtodelete = new TextBox();
            Delete = new Button();
            textBox2 = new TextBox();
            codetodelete = new TextBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // textBox3
            // 
            textBox3.BackColor = SystemColors.ActiveCaption;
            textBox3.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            textBox3.Location = new Point(230, 35);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(307, 55);
            textBox3.TabIndex = 78;
            textBox3.Text = "Delete Branch";
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.ActiveCaption;
            textBox1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            textBox1.Location = new Point(23, 144);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(307, 55);
            textBox1.TabIndex = 79;
            textBox1.Text = "Branch's Number:";
            // 
            // numtodelete
            // 
            numtodelete.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            numtodelete.Location = new Point(395, 152);
            numtodelete.Name = "numtodelete";
            numtodelete.Size = new Size(109, 45);
            numtodelete.TabIndex = 80;
            // 
            // Delete
            // 
            Delete.BackColor = SystemColors.ActiveCaption;
            Delete.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Delete.Location = new Point(307, 346);
            Delete.Name = "Delete";
            Delete.Size = new Size(112, 41);
            Delete.TabIndex = 81;
            Delete.Text = "Delete";
            Delete.UseVisualStyleBackColor = false;
            Delete.Click += Delete_Click;
            // 
            // textBox2
            // 
            textBox2.BackColor = SystemColors.ActiveCaption;
            textBox2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            textBox2.Location = new Point(23, 235);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(307, 55);
            textBox2.TabIndex = 82;
            textBox2.Text = "Bank Code:";
            // 
            // codetodelete
            // 
            codetodelete.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            codetodelete.Location = new Point(395, 235);
            codetodelete.Name = "codetodelete";
            codetodelete.Size = new Size(109, 45);
            codetodelete.TabIndex = 83;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(572, 35);
            pictureBox1.Margin = new Padding(5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(72, 57);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 85;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // Delete_Branch
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(658, 450);
            Controls.Add(pictureBox1);
            Controls.Add(codetodelete);
            Controls.Add(textBox2);
            Controls.Add(Delete);
            Controls.Add(numtodelete);
            Controls.Add(textBox1);
            Controls.Add(textBox3);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Delete_Branch";
            Text = "Delete_Branch";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox3;
        private TextBox textBox1;
        private TextBox numtodelete;
        private Button Delete;
        private TextBox textBox2;
        private TextBox codetodelete;
        private PictureBox pictureBox1;
    }
}