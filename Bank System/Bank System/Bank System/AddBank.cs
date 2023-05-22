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
    public partial class AddBank : Form
    {
        public AddBank()
        {
            InitializeComponent();
            DisplayBanks();
        }

        SqlConnection Con = new SqlConnection("Data Source=DESKTOP-28TECAI;Initial Catalog=BankingSystem2;Integrated Security=True");

        private void DisplayBanks()
        {
            Con.Open();
            string Query = "select * from Bank";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder Build = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            BankDGV.DataSource = ds.Tables[0];

            Con.Close();
        }

        private void Reset()
        {
            bNametb.Text = "";
            bstreettb.Text = "";
            bcode.Text = "";
            bbuildingnotb.Text = "";
            bcity.Text = "";
        }
        private void AddBank_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        public int Key { get; private set; }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            bNametb.Text = BankDGV.SelectedRows[0].Cells[0].Value.ToString();
            adminSSN.Text = BankDGV.SelectedRows[0].Cells[1].Value.ToString();
            bstreettb.Text = BankDGV.SelectedRows[0].Cells[2].Value.ToString();
            bcode.Text = BankDGV.SelectedRows[0].Cells[3].Value.ToString();
            bbuildingnotb.Text = BankDGV.SelectedRows[0].Cells[4].Value.ToString();
            bcity.Text = BankDGV.SelectedRows[0].Cells[5].Value.ToString();

            if (bNametb.Text == "")
            {
                Key = 0;
            }
            else
            {
                Key = Convert.ToInt32(BankDGV.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void bAddbtn_Click(object sender, EventArgs e)
        {
            if (bNametb.Text == "" || bstreettb.Text == "" || bcode.Text == "" || bbuildingnotb.Text == "" || bcity.Text == "" || adminSSN.Text == "")
            {
                MessageBox.Show("Missing information");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("insert into BANK(CODE,ADMINSSN,NAME,CITY,STREET,BUILDINGNO)values(@BC,@AS,@BN,@BCc,@S,@BB)", Con);
                    cmd.Parameters.AddWithValue("@BC", bcode.Text);
                    cmd.Parameters.AddWithValue("@AS", adminSSN.Text);
                    cmd.Parameters.AddWithValue("@BN", bNametb.Text);
                    cmd.Parameters.AddWithValue("@BCc", bcity.Text);
                    cmd.Parameters.AddWithValue("@S", bstreettb.Text);
                    cmd.Parameters.AddWithValue("@BB", bbuildingnotb.Text);


                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Bank Added!!");
                    Con.Close();
                    Reset();
                    DisplayBanks();

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

        private void bEditbtn_Click(object sender, EventArgs e)
        {
            if (bNametb.Text == "" || bstreettb.Text == "" || bcode.Text == "" || bbuildingnotb.Text == "" || bcity.Text == "" || adminSSN.Text == "")
            {
                MessageBox.Show("Missing information");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("Update BANK set CODE=@BC,ADMINSSN=@AS,NAME=@BN,CITY=@BCc,STREET=@S,BUILDINGNO=@BB where code = @BC)", Con);
                    cmd.Parameters.AddWithValue("@BC", bcode.Text);
                    cmd.Parameters.AddWithValue("@AS", adminSSN.Text);
                    cmd.Parameters.AddWithValue("@BN", bNametb.Text);
                    cmd.Parameters.AddWithValue("@BCc", bcity.Text);
                    cmd.Parameters.AddWithValue("@S", bstreettb.Text);
                    cmd.Parameters.AddWithValue("@BB", bbuildingnotb.Text);



                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Bank Updated!!");
                    Con.Close();
                    Reset();
                    DisplayBanks();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            AdminMenu obj = new AdminMenu();
            obj.Show();
            this.Hide();
        }
    }
}
