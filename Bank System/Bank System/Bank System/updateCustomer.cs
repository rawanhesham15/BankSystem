using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bank_System
{
    public partial class updateCustomer : Form
    {
        public updateCustomer()
        {
            InitializeComponent();
            showCustomers();
        }

        SqlConnection Con = new SqlConnection("Data Source=DESKTOP-28TECAI;Initial Catalog=BankingSystem2;Integrated Security=True");
        private void updateCustomer_Load(object sender, EventArgs e)
        {

        }

        private void updateGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Reset()
        {
            CityToupdate.Text = "";
            phonetoupdate.Text = "";
            nameToUpdate.Text = "";
            StreetToupdate.Text = "";
            buildingtoupdate.Text = "";
            updatessn.Text = "";
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            EmployeeMenu obj = new EmployeeMenu();
            obj.Show();
            this.Hide();
        }

        private void showCustomers()
        {
            SqlDataAdapter adb = new SqlDataAdapter("select * from customer", Con);
            DataTable dt = new DataTable();
            adb.Fill(dt);
            updateGrid.DataSource = dt;
        }

        private void search_Click_1(object sender, EventArgs e)
        {
            if (SSNupdate.Text == "")
            {
                MessageBox.Show("Please enter customer's SSN");
            }
            else
            {
                try
                {
                    SqlDataAdapter sda = new SqlDataAdapter("select * from customer where SSN = '" + SSNupdate.Text + "'", Con);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    SearchResult.DataSource = dt;
                }
                catch (Exception ex) { }
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            try
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand("Update Customer set Name = @AN , Street = @S , city = @City , buildingNo = @BN , phone = @phone where SSN = '" + updatessn.Text + "' ", Con);
                cmd.Parameters.AddWithValue("@AN", nameToUpdate.Text);
                cmd.Parameters.AddWithValue("@S", StreetToupdate.Text);
                cmd.Parameters.AddWithValue("@City", CityToupdate.Text);
                cmd.Parameters.AddWithValue("@BN", buildingtoupdate.Text);
                cmd.Parameters.AddWithValue("@phone", phonetoupdate.Text);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Customer's Information Updated Successfully!!" + updatessn.Text);
                Con.Close();
                showCustomers();
                Reset();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("delete Customer where SSN=@SSN", Con);
            SqlCommand cmd2 = new SqlCommand("delete Account where SSN=@SSN", Con);
            SqlCommand cmd3 = new SqlCommand("delete Serve where SSN=@SSN", Con);

            Con.Open();
            cmd.Parameters.AddWithValue("@SSN", SSNupdate.Text);
            cmd2.Parameters.AddWithValue("@SSN", SSNupdate.Text);
            cmd3.Parameters.AddWithValue("@SSN", SSNupdate.Text);

            cmd3.ExecuteNonQuery();
            cmd2.ExecuteNonQuery();
            cmd.ExecuteNonQuery();
            Con.Close();
            MessageBox.Show("Customer Deleted Successfully!");
            showCustomers();
            Reset();
        }

        private void SearchResult_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            updatessn.Text = SearchResult.Rows[e.RowIndex].Cells[0].Value.ToString();
            updatessn.ReadOnly = true;
            nameToUpdate.Text = SearchResult.Rows[e.RowIndex].Cells[2].Value.ToString();
            CityToupdate.Text = SearchResult.Rows[e.RowIndex].Cells[3].Value.ToString();
            StreetToupdate.Text = SearchResult.Rows[e.RowIndex].Cells[4].Value.ToString();
            buildingtoupdate.Text = SearchResult.Rows[e.RowIndex].Cells[5].Value.ToString();
            phonetoupdate.Text = SearchResult.Rows[e.RowIndex].Cells[6].Value.ToString();
        }

        private void SearchResult_CellContentClick(object sender, DataGridViewCellEventArgs e)
        { }

        private void CityToupdate_TextChanged(object sender, EventArgs e)
        {

        }
    }
}