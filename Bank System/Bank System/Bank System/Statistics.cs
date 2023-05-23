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
    public partial class Statistics : Form
    {
        public Statistics()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection("Data Source=DESKTOP-28TECAI;Initial Catalog=BankingSystem2;Integrated Security=True");

        private void Statistics_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            Con.Open();
            string Query = "select  Name as 'Bank Name', count(branchno) as 'Number of Branches' from branch , bank where bank.code = branch.code group by bank.Name";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder Build = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            branchBnk.DataSource = ds.Tables[0];
            string Quy = "select city , count(SSN) as 'number of customers' from customer\ngroup by city\nhaving count(SSN) = \n(\nselect  max(totalcus) as highest_total\n  from (\n       select city                               \n            , count(SSN) as totalcus       \n         from CUSTOMER                                    \n       group \n           by city                              \n       ) as t)";
            SqlDataAdapter sdaa = new SqlDataAdapter(Quy, Con);
            SqlCommandBuilder Buildd = new SqlCommandBuilder(sdaa);
            var dss = new DataSet();
            sdaa.Fill(dss);
            citymax.DataSource = dss.Tables[0];
            Con.Close();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            AdminMenu obj = new AdminMenu();
            obj.Show();
            this.Hide();
        }
    }
}
