using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Bank_System
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection("Data Source=DESKTOP-28TECAI;Initial Catalog=BankingSystem2;Integrated Security=True"); private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (role.SelectedIndex == -1)
            {
                MessageBox.Show("Select the Role!");
            }
            else if (role.SelectedIndex == 0)
            {
                if (userName.Text == "" || SSN.Text == "")
                {
                    MessageBox.Show("Enter Both Admin's Name and SSN!");
                }
                else
                {
                    Con.Open();
                    SqlDataAdapter sda = new SqlDataAdapter("select count(*) from Admin where AdminSSN = '" + SSN.Text + "' and Name = '" + userName.Text + "'", Con);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    if (dt.Rows[0][0].ToString() == "1")
                    {
                        AdminMenu obj = new AdminMenu();
                        obj.Show();
                        this.Hide();
                        Con.Close();
                    }
                    else
                    {
                        MessageBox.Show("Wrong Admin Name or SSN!");
                        userName.Text = "";
                        SSN.Text = "";
                    }
                    Con.Close();
                }
            }
            else if (role.SelectedIndex == 1)
            {
                if (userName.Text == "" || SSN.Text == "")
                {
                    MessageBox.Show("Enter Both Employee's Name and SSN!");
                }
                else
                {
                    Con.Open();
                    SqlDataAdapter sda = new SqlDataAdapter("select count(*) from Employee where empSSN = '" + SSN.Text + "' and Name = '" + userName.Text + "'", Con);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    if (dt.Rows[0][0].ToString() == "1")
                    {
                        EmployeeMenu obj = new EmployeeMenu();
                        obj.Show();
                        this.Hide();
                        Con.Close();
                    }
                    else
                    {
                        MessageBox.Show("Wrong Employee Name or SSN!");
                        userName.Text = "";
                        SSN.Text = "";
                    }
                    Con.Close();
                }
            }
            else
            {
                if (userName.Text == "" || SSN.Text == "")
                {
                    MessageBox.Show("Enter Both Customer's Name and SSN!");
                }
                else
                {
                    Con.Open();
                    SqlDataAdapter sda = new SqlDataAdapter("select count(*) from Customer where SSN = '" + SSN.Text + "' and Name = '" + userName.Text + "'", Con);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    if (dt.Rows[0][0].ToString() == "1")
                    {
                        CustomerMenu obj = new CustomerMenu();
                        obj.Show();
                        this.Hide();
                        Con.Close();
                    }
                    else
                    {
                        MessageBox.Show("Wrong Customer Name or SSN!");
                        userName.Text = "";
                        SSN.Text = "";
                    }
                    Con.Close();
                }
            }
        }



        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
