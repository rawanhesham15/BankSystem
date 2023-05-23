using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Markup;

namespace Bank_System
{
    public partial class addCustomer : Form
    {
        public addCustomer()
        {
            InitializeComponent();
            DisplayCustomers();
        }

        SqlConnection Con = new SqlConnection("Data Source=DESKTOP-28TECAI;Initial Catalog=BankingSystem2;Integrated Security=True"); private void DisplayCustomers()
        {
            Con.Open();
            string Query = "select * from customer";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder Build = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            customerDGV.DataSource = ds.Tables[0];

            Con.Close();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (cusNameTb.Text == "" || cusPhoneNumberTb.Text == "" || cusStreetTb.Text == "" || empSSN.Text == "")
            {
                MessageBox.Show("Missing information");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("update customer set name=@AN,street=@S,SSN=@SNN,city=@City,BuildingNo=@BN,phone=@PN where ssn=@cusKey ", Con);
                    cmd.Parameters.AddWithValue("@AN", cusNameTb.Text);
                    cmd.Parameters.AddWithValue("@S", cusStreetTb.Text);
                    cmd.Parameters.AddWithValue("@SNN", cusSSNTb.Text);
                    cmd.Parameters.AddWithValue("@City", empSSN.Text);
                    cmd.Parameters.AddWithValue("@PN", cusBuildingNumberTb.Text);
                    cmd.Parameters.AddWithValue("@BN", cusPhoneNumberTb.Text);
                    cmd.Parameters.AddWithValue("cus@Key", cusSSNTb.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("customer Updated!!");
                    Con.Close();
                    DisplayCustomers();
                    Reset();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }

        private void Reset()
        {
            cusNameTb.Text = "";
            empSSN.Text = "";
            cusPhoneNumberTb.Text = "";
            cusSSNTb.Text = "";
            cusStreetTb.Text = "";
            cusBuildingNumberTb.Text = "";
            city.Text = "";
            balance.Text = "";
            accType.Text = "";
            accNo.Text = "";
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            if (cusSSNTb.Text == "" || cusNameTb.Text == "" || empSSN.Text == "" || cusStreetTb.Text == "" || cusBuildingNumberTb.Text == "" || cusPhoneNumberTb.Text == "" || city.Text == "" || balance.Text == "" || accType.Text == "" || accNo.Text == "")
            {
                MessageBox.Show("Missing information");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("insert into customer(SSN,empSSN,Name,City,Street,BuildingNo,phone)values(@SNN,@empSSN,@AN,@City,@S,@BN,@PN)", Con);
                    
                    cmd.Parameters.AddWithValue("@AN", cusNameTb.Text);
                    cmd.Parameters.AddWithValue("@S", cusStreetTb.Text);
                    cmd.Parameters.AddWithValue("@SNN", cusSSNTb.Text);
                    cmd.Parameters.AddWithValue("@City", city.Text);
                    cmd.Parameters.AddWithValue("@BN", cusBuildingNumberTb.Text);
                    cmd.Parameters.AddWithValue("@PN", cusPhoneNumberTb.Text);
                    cmd.Parameters.AddWithValue("@empSSN", empSSN.Text);

                    cmd.ExecuteNonQuery();

                    SqlCommand cmd2 = new SqlCommand("insert into account(acctno, ssn, acctype, balance) values (@accNo, @ssn, @acctype, @balance)", Con);
                    
                    cmd2.Parameters.AddWithValue("@accNo", accNo.Text);
                    cmd2.Parameters.AddWithValue("@ssn", cusSSNTb.Text);
                    cmd2.Parameters.AddWithValue("@accType", accType.Text);
                    cmd2.Parameters.AddWithValue("@balance", balance.Text);

                    cmd2.ExecuteNonQuery();

                    SqlCommand cmd3 = new SqlCommand("insert into serve(Bra_BranchNo, Bra_BankCode, Cus_SSN, branchNo, bankCode, SSN) values (@BNPK, @bankNPK, @ssnPK, @BN, @bank, @ssn)", Con);
                    
                    cmd3.Parameters.AddWithValue("@BNPK", branchNum.Text);
                    cmd3.Parameters.AddWithValue("@bankNPK", bankCode.Text);
                    cmd3.Parameters.AddWithValue("@ssnPK", cusSSNTb.Text);
                    cmd3.Parameters.AddWithValue("@BN", branchNum.Text);
                    cmd3.Parameters.AddWithValue("@bank", bankCode.Text);
                    cmd3.Parameters.AddWithValue("@ssn", cusSSNTb.Text);

                    cmd3.ExecuteNonQuery();

                    MessageBox.Show("Customer Added!!");
                    Con.Close();
                    Reset();
                    DisplayCustomers();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        // el add zay el fol
        private void AcBuildingNumberTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void addCustomer_Load(object sender, EventArgs e)
        {
            if (customerDGV.SelectedRows == null || customerDGV.SelectedRows.Count == 0)
                return;

            cusNameTb.Text = customerDGV.SelectedRows[0].Cells[1].Value.ToString();
            cusSSNTb.Text = customerDGV.SelectedRows[0].Cells[2].Value.ToString();
            empSSN.Text = customerDGV.SelectedRows[0].Cells[3].Value.ToString();
            cusStreetTb.Text = customerDGV.SelectedRows[0].Cells[4].Value.ToString();
            cusBuildingNumberTb.Text = customerDGV.SelectedRows[0].Cells[5].Value.ToString();
            cusPhoneNumberTb.Text = customerDGV.SelectedRows[0].Cells[6].Value.ToString();
            if (cusSSNTb.Text == "")
            {
                Key = 0;
            }
            else
            {
                //   Key = Convert.ToInt32(customerDGV.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        int Key = 0;

        private void CancelBtn_Click_1(object sender, EventArgs e)
        {
            if (Key == 0)
            {
                MessageBox.Show("Select the Customer You want to delete ");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("delete from customer where SSN=@CusKey", Con);
                    cmd.Parameters.AddWithValue("@CusKey", Key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Customer Deleted!!");
                    Con.Close();
                    Reset();
                    DisplayCustomers();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }

        private void AcSSNTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void AcCityTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            /* cusNameTb.Text = customerDGV.SelectedRows[0].Cells[0].Value.ToString();
             cusSSNTb.Text = customerDGV.SelectedRows[0].Cells[1].Value.ToString();
             cusCityTb.Text = customerDGV.SelectedRows[0].Cells[2].Value.ToString();
             cusStreetTb.Text = customerDGV.SelectedRows[0].Cells[3].Value.ToString();
             cusBuildingNumberTb.Text = customerDGV.SelectedRows[0].Cells[4].Value.ToString();
             cusPhoneNumberTb.Text = customerDGV.SelectedRows[0].Cells[5].Value.ToString();
             if (cusSSNTb.Text == "")
             {
                 Key = 0;
             }
             else
             {
                 Key = Convert.ToInt32(customerDGV.SelectedRows[0].Cells[0].Value.ToString());
             }
             */
        }

        private void AcStreetTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void AcPhoneNumberTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void customerDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            cusNameTb.Text = customerDGV.SelectedRows[0].Cells[1].Value.ToString();
            cusSSNTb.Text = customerDGV.SelectedRows[0].Cells[2].Value.ToString();
            empSSN.Text = customerDGV.SelectedRows[0].Cells[3].Value.ToString();
            cusStreetTb.Text = customerDGV.SelectedRows[0].Cells[4].Value.ToString();
            cusBuildingNumberTb.Text = customerDGV.SelectedRows[0].Cells[5].Value.ToString();
            cusPhoneNumberTb.Text = customerDGV.SelectedRows[0].Cells[6].Value.ToString();


            if (cusSSNTb.Text == "")
            {
                Key = 0;
            }
            else
            {
                Key = Convert.ToInt32(customerDGV.SelectedRows[0].Cells[0].Value.ToString());
            }

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            EmployeeMenu obj = new EmployeeMenu();
            obj.Show();
            this.Hide();
        }
    }
}
