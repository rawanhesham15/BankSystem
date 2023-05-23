using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.DirectoryServices;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bank_System
{
    public partial class ListOfLoans : Form
    {
        public ListOfLoans()
        {
            InitializeComponent();
            DisplayLoans();
        }

        SqlConnection Con = new SqlConnection("Data Source=DESKTOP-28TECAI;Initial Catalog=BankingSystem2;Integrated Security=True");

        private void DisplayLoans()
        {
            Con.Open();
            string Query = "select LoanNo , loanType, loanAmount ,loan.ssn as 'customer SSN' , CUSTOMER.name  as 'customer name' , CUSTOMER.empssn as 'employee number' ,EMPLOYEE.NAME from LOAN , CUSTOMER , EMPLOYEE  where customer.ssn = loan.ssn and CUSTOMER.EMPSSN = EMPLOYEE.EMPSSN;";
            SqlDataAdapter sd = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder Build = new SqlCommandBuilder(sd);
            var ds = new DataSet();
            sd.Fill(ds);
            loanDGV.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            EmployeeMenu obj = new EmployeeMenu();
            obj.Show();
            this.Hide();
        }

        private void loanDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void loanDGV_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            loanNo.Text = loanDGV.Rows[e.RowIndex].Cells[0].Value.ToString();
            loanNo.ReadOnly = true;
            loanType.Text = loanDGV.Rows[e.RowIndex].Cells[1].Value.ToString();
            loanType.ReadOnly = true;
            SSN.Text = loanDGV.Rows[e.RowIndex].Cells[3].Value.ToString();
            SSN.ReadOnly = true;
            loanAmount.Text = loanDGV.Rows[e.RowIndex].Cells[2].Value.ToString();
            loanAmount.ReadOnly = true;
        }

        private void ListOfLoans_Load(object sender, EventArgs e)
        {

        }

        private void Reset()
        {
            loanNo.Text = "";
            loanType.Text = "";
            SSN.Text = "";
            loanAmount.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("delete loan where LoanNo=@loanNo", Con);

            Con.Open();
            cmd.Parameters.AddWithValue("@loanNo", loanNo.Text);
            cmd.ExecuteNonQuery();
            Con.Close();
            MessageBox.Show("Request Rejected!");
            DisplayLoans();
            Reset();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Con.Open();

            SqlCommand cmd = new SqlCommand("Update Account set Balance = Balance + '" + loanAmount.Text + "' where SSN = '" + SSN.Text + "' ", Con);
            SqlCommand cmd2 = new SqlCommand("delete loan where LoanNo=@loanNo", Con);

            cmd2.Parameters.AddWithValue("@loanNo", loanNo.Text);

            cmd.ExecuteNonQuery();
            cmd2.ExecuteNonQuery();
            MessageBox.Show("Request Accepted!");
            Con.Close();
            DisplayLoans();
            Reset();
        }
    }
}
