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
    public partial class addAccount : Form
    {
        public addAccount()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection("Data Source=DESKTOP-FJ2DD2M\\SQLEXPRESS01;Initial Catalog=bankSystem;Integrated Security=True");

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void Reset()
        {
            acctype.Text = "";
            ACCnum.Text = "";
            balance.Text = "";
            cusSSn.Text = "";
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            if (acctype.Text == "" || ACCnum.Text == "" || cusSSn.Text == "" || balance.Text == "")
            {
                MessageBox.Show("Missing information");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("insert into account(ACCTNO,SSN,ACCTYPE,BALANCE)values(@AN,@SSN,@type,@BN)", Con);
                    cmd.Parameters.AddWithValue("@AN", ACCnum.Text);
                    cmd.Parameters.AddWithValue("@SSN", cusSSn.Text);
                    cmd.Parameters.AddWithValue("@type", acctype.Text);
                    cmd.Parameters.AddWithValue("@BN", balance.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Account Added!!");
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
    }
}
