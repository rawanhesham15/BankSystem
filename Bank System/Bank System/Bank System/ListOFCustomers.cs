using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;


namespace Bank_System
{
    public partial class ListOfCustomers : Form
    {
        public ListOfCustomers()
        {
            InitializeComponent();
            DisplayCustomers();
        }
        SqlConnection Con = new SqlConnection("Data Source=DESKTOP-28TECAI;Initial Catalog=BankingSystem2;Integrated Security=True");

        private void DisplayCustomers()
        {
            Con.Open();
            string Query = "select * from customer";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder Build = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            listDGV.DataSource = ds.Tables[0];

            Con.Close();
        }
        private void form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void InitializeComponent()
        {
            ComponentResourceManager resources = new ComponentResourceManager(typeof(ListOfCustomers));
            listDGV = new DataGridView();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            ((ISupportInitialize)listDGV).BeginInit();
            ((ISupportInitialize)pictureBox1).BeginInit();
            ((ISupportInitialize)pictureBox2).BeginInit();
            ((ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // listDGV
            // 
            listDGV.BackgroundColor = SystemColors.Control;
            listDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            listDGV.Location = new Point(88, 110);
            listDGV.Name = "listDGV";
            listDGV.RowTemplate.Height = 25;
            listDGV.Size = new Size(713, 346);
            listDGV.TabIndex = 12;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Britannic Bold", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(306, 30);
            label2.Name = "label2";
            label2.Size = new Size(289, 38);
            label2.TabIndex = 13;
            label2.Text = "List of Customers";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (System.Drawing.Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Image = (System.Drawing.Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(836, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(46, 34);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 14;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click_1;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = (System.Drawing.Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox2.Location = new Point(233, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(80, 56);
            pictureBox2.TabIndex = 15;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackgroundImage = (System.Drawing.Image)resources.GetObject("pictureBox3.BackgroundImage");
            pictureBox3.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox3.Location = new Point(1, 2);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(46, 34);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 70;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // ListOfCustomers
            // 
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(882, 496);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Controls.Add(listDGV);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ListOfCustomers";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ListOfCustomers";
            Load += ListOfCustomers_Load;
            ((ISupportInitialize)listDGV).EndInit();
            ((ISupportInitialize)pictureBox1).EndInit();
            ((ISupportInitialize)pictureBox2).EndInit();
            ((ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void ListOfCustomers_Load(object sender, EventArgs e)
        {

        }

        private void listDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            //Application.Exit();
        }

        private DataGridView listDGV;
        private Label label2;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            EmployeeMenu obj = new EmployeeMenu();
            obj.Show();
            this.Hide();
        }
    }
}
