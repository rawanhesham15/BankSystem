namespace Bank_System
{
    partial class EmployeeMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeMenu));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            button3 = new Button();
            button2 = new Button();
            button4 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(776, 426);
            panel1.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(730, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(46, 34);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox2.Location = new Point(205, 18);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(80, 56);
            pictureBox2.TabIndex = 8;
            pictureBox2.TabStop = false;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ControlLightLight;
            button1.Font = new Font("Britannic Bold", 18F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.ActiveCaptionText;
            button1.Location = new Point(235, 120);
            button1.Name = "button1";
            button1.Size = new Size(302, 55);
            button1.TabIndex = 6;
            button1.Text = "Update Customer Details";
            button1.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Britannic Bold", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(177, 194);
            label1.Name = "label1";
            label1.Size = new Size(0, 38);
            label1.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Britannic Bold", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(279, 36);
            label2.Name = "label2";
            label2.Size = new Size(324, 38);
            label2.TabIndex = 4;
            label2.Text = "Employee Functions";
            // 
            // button3
            // 
            button3.BackColor = SystemColors.ControlLightLight;
            button3.Font = new Font("Britannic Bold", 18F, FontStyle.Regular, GraphicsUnit.Point);
            button3.ForeColor = SystemColors.ActiveCaptionText;
            button3.Location = new Point(235, 189);
            button3.Name = "button3";
            button3.Size = new Size(302, 55);
            button3.TabIndex = 12;
            button3.Text = "Add Customer";
            button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ControlLightLight;
            button2.Font = new Font("Britannic Bold", 18F, FontStyle.Regular, GraphicsUnit.Point);
            button2.ForeColor = SystemColors.ActiveCaptionText;
            button2.Location = new Point(235, 261);
            button2.Name = "button2";
            button2.Size = new Size(302, 55);
            button2.TabIndex = 13;
            button2.Text = "Show Customers";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click_1;
            // 
            // button4
            // 
            button4.BackColor = SystemColors.ControlLightLight;
            button4.Font = new Font("Britannic Bold", 18F, FontStyle.Regular, GraphicsUnit.Point);
            button4.ForeColor = SystemColors.ActiveCaptionText;
            button4.Location = new Point(235, 331);
            button4.Name = "button4";
            button4.Size = new Size(302, 55);
            button4.TabIndex = 14;
            button4.Text = "Show Loans";
            button4.UseVisualStyleBackColor = false;
            // 
            // EmployeeMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "EmployeeMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EmployeeMenu";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button button3;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Button button1;
        private Label label1;
        private Label label2;
        private Button button4;
        private Button button2;
    }
}