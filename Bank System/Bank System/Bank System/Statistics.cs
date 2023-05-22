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
        SqlConnection Con = new SqlConnection("Data Source=DESKTOP-FJ2DD2M\\SQLEXPRESS01;Initial Catalog=bankSystem;Integrated Security=True");

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
            string Quy = "select city as 'city ', count(SSN) as 'Number of Customers' from branch , customer where bank.code = branch.code group by city";
            SqlDataAdapter sdaa = new SqlDataAdapter(Quy, Con);
            SqlCommandBuilder Buildd = new SqlCommandBuilder(sdaa);
            var dss = new DataSet();
            sdaa.Fill(dss);
            customerbrnch.DataSource = dss.Tables[0];
            Con.Close();
        }
    }
}
