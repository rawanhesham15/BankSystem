﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows;
using System.Data.SqlClient;

namespace Bank_System
{
    public partial class addCustomer : Form
    {
        public addCustomer()
        {
            InitializeComponent();
            DisplayAccounts();
        }

        SqlConnection Con = new SqlConnection("Data Source=DESKTOP-FJ2DD2M\\SQLEXPRESS01;Initial Catalog=bankSystem;Integrated Security=True");
        private void DisplayAccounts()
        {
            Con.Open();
            string Query = "select * from AccountTb1";
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
            if (AcNameTb.Text == "" || AcPhoneNumberTb.Text == "" || AcStreetTb.Text == "" || AcCityTb.Text == "")
            {
                MessageBox.Show("Missing information");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("update AccountTbl set AcName=@AN,AcStreet=@S,AcSSN=@SNN,AcCity=@City,AcBuildingNumber=@BN,AcPhoneNumber=@PN where AcSNN=@AcKey ", Con);
                    cmd.Parameters.AddWithValue("@AN", AcNameTb.Text);
                    cmd.Parameters.AddWithValue("@S", AcStreetTb.Text);
                    cmd.Parameters.AddWithValue("@SNN", AcSSNTb.Text);
                    cmd.Parameters.AddWithValue("@City", AcCityTb.Text);
                    cmd.Parameters.AddWithValue("@PN", AcBuildingNumberTb.Text);
                    cmd.Parameters.AddWithValue("@BN", AcPhoneNumberTb.Text);
                    cmd.Parameters.AddWithValue("@Key", Key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Account Updated!!");
                    Con.Close();
                    Rest();
                    DisplayAccounts();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }

        private void Rest()
        {
            AcNameTb.Text = "";
            AcCityTb.Text = "";
            AcPhoneNumberTb.Text = "";
            AcSSNTb.Text = "";
            AcStreetTb.Text = "";
            AcBuildingNumberTb.Text = "";
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            if (AcNameTb.Text == "" || AcPhoneNumberTb.Text == "" || AcStreetTb.Text == "" || AcCityTb.Text == "")
            {
                MessageBox.Show("Missing information");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("insert into AccountTbl(AcName,AcStreet,AcSSN,AcCity,AcBuildingNumber,AcPhoneNumber)valyes(@AN,@S,@SNN,@City,@BN,@PN)", Con);
                    cmd.Parameters.AddWithValue("@AN", AcNameTb.Text);
                    cmd.Parameters.AddWithValue("@S", AcStreetTb.Text);
                    cmd.Parameters.AddWithValue("@SNN", AcSSNTb.Text);
                    cmd.Parameters.AddWithValue("@City", AcCityTb.Text);
                    cmd.Parameters.AddWithValue("@PN", AcBuildingNumberTb.Text);
                    cmd.Parameters.AddWithValue("@BN", AcPhoneNumberTb.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Account Created!!");
                    Con.Close();
                    Rest();
                    DisplayAccounts();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void AcBuildingNumberTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void addCustomer_Load(object sender, EventArgs e)
        {
            AcNameTb.Text = customerDGV.SelectedRows[0].Cells[1].Value.ToString();
            AcSSNTb.Text = customerDGV.SelectedRows[0].Cells[2].Value.ToString();
            AcCityTb.Text = customerDGV.SelectedRows[0].Cells[3].Value.ToString();
            AcStreetTb.Text = customerDGV.SelectedRows[0].Cells[4].Value.ToString();
            AcBuildingNumberTb.Text = customerDGV.SelectedRows[0].Cells[5].Value.ToString();
            AcPhoneNumberTb.Text = customerDGV.SelectedRows[0].Cells[6].Value.ToString();
            if (AcSSNTb.Text == "")
            {
                Key = 0;
            }
            else
            {
                Key = Convert.ToInt32(customerDGV.SelectedRows[0].Cells[1].Value.ToString());
            }
        }


        private void CancelBtn_Click_1(object sender, EventArgs e)
        {
            if (Key == 0)
            {
                MessageBox.Show("Select the Account ");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("delete from AccountTbl where AcSSN=@AcKey", Con);
                    cmd.Parameters.AddWithValue("@AcKey", Key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Account Deleted!!");
                    Con.Close();
                    Rest();
                    DisplayAccounts();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }
        int Key = 0;

        private void AcSSNTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void AcCityTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
