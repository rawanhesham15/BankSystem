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
    public partial class AddBranch : Form
    {
        public AddBranch()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection("Data Source=DESKTOP-28TECAI;Initial Catalog=BankingSystem2;Integrated Security=True");

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void label8_Click(object sender, EventArgs e)
        {
        }

        private void label7_Click(object sender, EventArgs e)
        {
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
        }

        private void label6_Click(object sender, EventArgs e)
        {
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }

        private void button3_Click(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void AddBranch_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }


        private void Reset()
        {
            bstreettb.Text = "";
            bnumtb.Text = "";
            bcitytb.Text = "";
            bcodetb.Text = "";
            bbuilidingtb.Text = "";
            adminSSN.Text = "";
        }

        private void bAddbtn_Click(object sender, EventArgs e)
        {//removed checking banck code and branch code
            if (bcitytb.Text == "" || bbuilidingtb.Text == "" || bnumtb.Text == "" || bstreettb.Text == "")
            {
                MessageBox.Show("Missing information");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("insert into branch(branchNo,BankCode,ADMINSSN,City,Street,BuildingNo,Code)values(@BNUM,@BankCODE,@adminSSN,@City,@Street,@BN,@BCODE)", Con);
                    cmd.Parameters.AddWithValue("@BNUM", bnumtb.Text);
                    cmd.Parameters.AddWithValue("@BankCODE", bcodetb.Text);
                    cmd.Parameters.AddWithValue("@adminSSN", adminSSN.Text);
                    cmd.Parameters.AddWithValue("@City", bcitytb.Text);
                    cmd.Parameters.AddWithValue("@Street", bstreettb.Text);
                    cmd.Parameters.AddWithValue("@BN", bbuilidingtb.Text);
                    cmd.Parameters.AddWithValue("@BCODE", bcodetb.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("branch Added!!");
                    Con.Close();
                    Reset();
                    // DisplayCustomers();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void label6_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_2(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            AdminMenu obj = new AdminMenu();
            obj.Show();
            this.Hide();
        }
    }
}
