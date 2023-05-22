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
    public partial class updateBank : Form
    {
        public updateBank()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection("Data Source=DESKTOP-FJ2DD2M\\SQLEXPRESS01;Initial Catalog=bankSystem;Integrated Security=True");

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        private void Reset()
        {
            updatebuild.Text = "";
            updatecode.Text = "";
            updatecity.Text = "";
            updateName.Text = "";
            updateStreet.Text = "";
        }

        private void deletebtn_Click(object sender, EventArgs e)
        {
            string Query = "delete from bank where code = " + codetoupdate.Text;

            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder Build = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void search_Click(object sender, EventArgs e)
        {

            if (codetoupdate.Text == "")
            {
                MessageBox.Show("Please enter bank's code");
            }
            else
            {
                try
                {
                    Con.Open();
                    string Query = "select * from bank where code = " + codetoupdate.Text;

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

        private void updatebtn_Click(object sender, EventArgs e)
        {


            try
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand("Update bank set Name = @AN , Street = @S , city = @City , buildingNo = @BN , code =  @code where code = @code ", Con);
                cmd.Parameters.AddWithValue("@AN", updateName.Text);
                cmd.Parameters.AddWithValue("@S", updateStreet.Text);
                cmd.Parameters.AddWithValue("@City", updatecity.Text);
                cmd.Parameters.AddWithValue("@BN", updatebuild.Text);
                cmd.Parameters.AddWithValue("@Code", updatecode.Text);
                cmd.ExecuteNonQuery();
                //  MessageBox.Show(nameToUpdate.Text, CityToupdate.Text+ buildingtoupdate.Text+ StreetToupdate.Text+ phonetoupdate.Text + updatessn.Text);
                MessageBox.Show("Bank's Information Updated Successfully!!");
                Con.Close();
                Reset();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }
    }
}
