namespace Bank_System
{
    partial class CustomerMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerMenu));
            panel1 = new Panel();
            button3 = new Button();
            button2 = new Button();
            pictureBox2 = new PictureBox();
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(776, 426);
            panel1.TabIndex = 0;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.ControlLightLight;
            button3.Font = new Font("Britannic Bold", 18F, FontStyle.Regular, GraphicsUnit.Point);
            button3.ForeColor = SystemColors.ActiveCaptionText;
            button3.Location = new Point(279, 295);
            button3.Name = "button3";
            button3.Size = new Size(207, 55);
            button3.TabIndex = 10;
            button3.Text = "Personal Loan";
            button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ControlLightLight;
            button2.Font = new Font("Britannic Bold", 18F, FontStyle.Regular, GraphicsUnit.Point);
            button2.ForeColor = SystemColors.ActiveCaptionText;
            button2.Location = new Point(279, 215);
            button2.Name = "button2";
            button2.Size = new Size(207, 55);
            button2.TabIndex = 9;
            button2.Text = "commercial loan";
            button2.UseVisualStyleBackColor = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox2.Location = new Point(244, 25);
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
            button1.Location = new Point(279, 129);
            button1.Name = "button1";
            button1.Size = new Size(207, 55);
            button1.TabIndex = 6;
            button1.Text = "industry loan";
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
            label2.Location = new Point(330, 34);
            label2.Name = "label2";
            label2.Size = new Size(190, 38);
            label2.TabIndex = 4;
            label2.Text = "Loan Types";
            label2.Click += label2_Click;
            // 
            // MainMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MainMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MainMenu";
            Load += MainMenu_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox2;
        private Button button1;
        private Button button2;
        private Button button3;
    }
}