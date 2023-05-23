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
            //phonetoupdate.Text = "";
            nameToUpdate.Text = "";
            StreetToupdate.Text = "";
            buildingtoupdate.Text = "";
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
                    //Con.Open();
                    //string Query = "select * from Customer where SSN = " + SSNupdate.Text;
                    //SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
                    //SqlCommandBuilder Build = new SqlCommandBuilder(sda);
                    //var ds = new DataSet();
                    //sda.Fill(ds);
                    //updateGrid.DataSource = ds.Tables[0];
                    //SqlCommand cmd = new SqlCommand();
                    //cmd.CommandText = "select * from customer where SSN = '"+ SSNupdate.Text + "'";
                    SqlDataAdapter sda = new SqlDataAdapter("select * from customer where SSN = '" + SSNupdate.Text + "'", Con);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    SearchResult.DataSource = dt;

                    //Con.Close();
                }
                catch (Exception ex) { }
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            try
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand("Update Customer set Name = @AN , Street = @S , city = @City , buildingNo = @BN , SSN =  @SSN where SSN = @SSN ", Con);
                cmd.Parameters.AddWithValue("@AN", nameToUpdate.Text);
                cmd.Parameters.AddWithValue("@S", StreetToupdate.Text);
                cmd.Parameters.AddWithValue("@City", CityToupdate.Text);
                cmd.Parameters.AddWithValue("@BN", buildingtoupdate.Text);
                // cmd.Parameters.AddWithValue("@PN", phonetoupdate.Text);
                cmd.Parameters.AddWithValue("@SSN", updatessn.Text);
                cmd.ExecuteNonQuery();
                //  MessageBox.Show(nameToUpdate.Text, CityToupdate.Text+ buildingtoupdate.Text+ StreetToupdate.Text+ phonetoupdate.Text + updatessn.Text);
                MessageBox.Show("Customer's Information Updated Successfully!!" + updatessn.Text);
                Con.Close();
                Reset();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Query = "delete from Customer where SSN = " + SSNupdate.Text;

            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder Build = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
        }

        private void SearchResult_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //DataGridView dgv = new DataGridView();
            //dgv = SearchResult;
            //updatessn.Text = dgv.CurrentRow.Cells[0].Value.ToString();
            //nameToUpdate.Text = dgv.CurrentRow.Cells[2].Value.ToString();
            //CityToupdate.Text = dgv.CurrentRow.Cells[3].Value.ToString();
            //StreetToupdate.Text = dgv.CurrentRow.Cells[4].Value.ToString();
            //buildingtoupdate.Text = dgv.CurrentRow.Cells[5].Value.ToString();
            //phonetoupdate.Text = dgv.CurrentRow.Cells[6].Value.ToString();

            //txt_Name.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();

            updatessn.Text = SearchResult.Rows[e.RowIndex].Cells[0].Value.ToString();
            nameToUpdate.Text = SearchResult.Rows[e.RowIndex].Cells[2].Value.ToString();
            CityToupdate.Text = SearchResult.Rows[e.RowIndex].Cells[3].Value.ToString();
            StreetToupdate.Text = SearchResult.Rows[e.RowIndex].Cells[4].Value.ToString();
            buildingtoupdate.Text = SearchResult.Rows[e.RowIndex].Cells[5].Value.ToString();
            phonetoupdate.Text = SearchResult.Rows[e.RowIndex].Cells[6].Value.ToString();
        }

        private void SearchResult_CellContentClick(object sender, DataGridViewCellEventArgs e)
        { }
    }
}
