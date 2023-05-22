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
        SqlConnection Con = new SqlConnection("Data Source=DESKTOP-FJ2DD2M\\SQLEXPRESS01;Initial Catalog=bankSystem;Integrated Security=True");

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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            ComponentResourceManager resources = new ComponentResourceManager(typeof(ListOfCustomers));
            textBox1 = new TextBox();
            listDGV = new DataGridView();
            exitbox = new PictureBox();
            ((ISupportInitialize)listDGV).BeginInit();
            ((ISupportInitialize)exitbox).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.ActiveCaption;
            textBox1.Font = new Font("Segoe UI Black", 16F, FontStyle.Bold, GraphicsUnit.Point);
            textBox1.ForeColor = SystemColors.InfoText;
            textBox1.Location = new Point(340, 62);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(392, 51);
            textBox1.TabIndex = 0;
            textBox1.Text = "   List OF Customers";
            textBox1.TextChanged += textBox1_TextChanged_1;
            // 
            // listDGV
            // 
            listDGV.BackgroundColor = SystemColors.ActiveCaption;
            listDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            listDGV.Location = new Point(126, 201);
            listDGV.Name = "listDGV";
            listDGV.RowHeadersWidth = 62;
            dataGridViewCellStyle1.ForeColor = SystemColors.ActiveCaptionText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.ButtonFace;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.ActiveCaption;
            listDGV.RowsDefaultCellStyle = dataGridViewCellStyle1;
            listDGV.RowTemplate.Height = 35;
            listDGV.Size = new Size(806, 366);
            listDGV.TabIndex = 1;
            // 
            // exitbox
            // 
            exitbox.BackgroundImage = (System.Drawing.Image)resources.GetObject("exitbox.BackgroundImage");
            exitbox.BackgroundImageLayout = ImageLayout.Zoom;
            exitbox.Image = (System.Drawing.Image)resources.GetObject("exitbox.Image");
            exitbox.Location = new Point(982, 38);
            exitbox.Margin = new Padding(4, 5, 4, 5);
            exitbox.Name = "exitbox";
            exitbox.Size = new Size(73, 56);
            exitbox.SizeMode = PictureBoxSizeMode.Zoom;
            exitbox.TabIndex = 11;
            exitbox.TabStop = false;
            exitbox.Click += pictureBox1_Click;
            // 
            // ListOfCustomers
            // 
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1089, 659);
            Controls.Add(exitbox);
            Controls.Add(listDGV);
            Controls.Add(textBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ListOfCustomers";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ListOfCustomers";
            Load += ListOfCustomers_Load;
            ((ISupportInitialize)listDGV).EndInit();
            ((ISupportInitialize)exitbox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
        }

        private TextBox textBox1;
        private DataGridView listDGV;

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void ListOfCustomers_Load(object sender, EventArgs e)
        {

        }

        private PictureBox exitbox;
    }
}
