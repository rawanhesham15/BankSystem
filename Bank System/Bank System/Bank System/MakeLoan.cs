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
    public partial class MakeLoan : Form
    {
        public MakeLoan()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection("Data Source=DESKTOP-28TECAI;Initial Catalog=BankingSystem2;Integrated Security=True");

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
        private void Reset()
        {
            lnamnt.Text = "";
            lnbnkk.Text = "";
            lnbrnch.Text = "";
            lnssn.Text = "";
            lnnum.Text = "";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (lnnum.Text == "" || lnamnt.Text == "" || lnbnkk.Text == "" || lnbrnch.Text == "" || lnssn.Text == "" || lntype.SelectedIndex == -1)
            {
                MessageBox.Show("Missing information");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("insert into loan(LoanNo,BranchNo,BankCode,SSN,LoanType,LoanAmount)values(@ln,@ABR,@B,@ssn,@type,@amnt)", Con);
                    cmd.Parameters.AddWithValue("@ln", lnnum.Text);
                    cmd.Parameters.AddWithValue("@ABR", lnbrnch.Text);
                    cmd.Parameters.AddWithValue("@B", lnbnkk.Text);
                    cmd.Parameters.AddWithValue("@ssn", lnssn.Text);
                    cmd.Parameters.AddWithValue("@type", lntype.Text);
                    cmd.Parameters.AddWithValue("@amnt", lnamnt.Text);


                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Your Loan Request is Submitted Successfully!!");
                    Con.Close();
                    Reset();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MakeLoan_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            CustomerMenu obj = new CustomerMenu();
            obj.Show();
            this.Hide();
        }
    }
}
