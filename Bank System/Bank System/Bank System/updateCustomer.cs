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
        }
        SqlConnection Con = new SqlConnection("Data Source=DESKTOP-FJ2DD2M\\SQLEXPRESS01;Initial Catalog=bankSystem;Integrated Security=True");

        private void updateCustomer_Load(object sender, EventArgs e)
        {

        }

        private void updateGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void search_Click(object sender, EventArgs e)
        {
            if (SSNupdate.Text == "")
            {
                MessageBox.Show("Please enter customer's SSN");
            }
            else
            {
                try
                {
                    Con.Open();
                    string Query = "select * from Customer where SSN = " + SSNupdate.Text;

                    SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
                    SqlCommandBuilder Build = new SqlCommandBuilder(sda);
                    var ds = new DataSet();
                    sda.Fill(ds);
                    updateGrid.DataSource = ds.Tables[0];

                    Con.Close();
                }
                catch (Exception ex) { }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Query = "delete from Customer where SSN = " + SSNupdate.Text;

            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder Build = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
        }
        private void Reset()
        {
            CityToupdate.Text = "";
            //phonetoupdate.Text = "";
            nameToUpdate.Text = "";
            StreetToupdate.Text = "";
            buildingtoupdate.Text = "";
        }
        private void button2_Click(object sender, EventArgs e)
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

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
