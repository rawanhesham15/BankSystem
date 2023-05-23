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

namespace Bank_System
{
    public partial class Delete_Branch : Form
    {
        public Delete_Branch()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection("Data Source=DESKTOP-28TECAI;Initial Catalog=BankingSystem2;Integrated Security=True");

        private void Delete_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Delete_Branch_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            AdminMenu obj = new AdminMenu();
            obj.Show();
            this.Hide();
        }

        private void bAddbtn_Click(object sender, EventArgs e)
        {
            Con.Open();
            if (numtodelete.Text == "" || codetodelete.Text == "")
            { MessageBox.Show("Complete the Missing Information"); }
            string Query = "delete from branch where branchNo = " + numtodelete.Text + " and BankCode =  " + codetodelete.Text;

            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder Build = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            Con.Close();
            MessageBox.Show("Branch is deleted Successfully!!");

        }
    }
}
