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

namespace Gym_Application
{
    public partial class Payment : Form
    {
        public Payment()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"data source=DESKTOP-NDT7O5N\SQLEXPRESS;Initial Catalog=GymDatabase;Trusted_Connection=True;MultipleActiveResultSets=True");
        private void FillName()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select MName from Members", con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("MName", typeof(string));
            dt.Load(rdr);
            nameComboBox.ValueMember = "MName";
            nameComboBox.DataSource = dt;
            con.Close();
        }
        private void FilterByName()
        {
            con.Open();
            string query = "select * from Payment where PMember='"+searchNameTxtBox.Text+"'";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder();
            var ds = new DataSet();
            sda.Fill(ds);
            paymentDGV.DataSource = ds.Tables[0];
            con.Close();
        }
        private void populate()
        {
            con.Open();
            string query = "select * from Payment";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder();
            var ds = new DataSet();
            sda.Fill(ds);
            paymentDGV.DataSource = ds.Tables[0];
            con.Close();
        }
        private void resetButton_Click(object sender, EventArgs e)
        {
            nameComboBox.Text = "";
            amountTxtBox.Text = "";
            periodeDateTimePicker.Text = "";
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            MainFormcs mainForm = new MainFormcs();
            mainForm.Show();
            this.Hide();
        }

        private void Payment_Load(object sender, EventArgs e)
        {
            FillName();
            populate();
        }
        
        private void payButton_Click(object sender, EventArgs e)
        {
            DateTime payPeriod;
            if (nameComboBox.Text == "" || amountTxtBox.Text == "")
            {
                MessageBox.Show("Plese Insert Members Name and Amount");
            }
            else
            {
                payPeriod = periodeDateTimePicker.Value;
                con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("select count (*) from Payment where PMember='" + nameComboBox.SelectedValue.ToString() + "'and PMonth='" + payPeriod + "'", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows[0][0].ToString() == "1")
                {
                    MessageBox.Show("Alredy Paid For This Month");
                }
                else
                {
                    string query = "insert into Payment values('" + payPeriod + "','" + nameComboBox.SelectedValue.ToString() + "','" + amountTxtBox.Text + "')";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Amount Paid Successfully");
                }
                con.Close();
                populate();
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            FilterByName();
            searchNameTxtBox.Text = "";
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            populate();
        }
        int key = 0;
        private void deleteButton_Click(object sender, EventArgs e)
        {
            
                if (key == 0 && periodeDateTimePicker.Text == "" || nameComboBox.Text == "" || amountTxtBox.Text == "")
                {
                    MessageBox.Show("Please Select The Payment To Be Deleted ");
                }
                else
                {
                    DialogResult result = MessageBox.Show("Are you sure you want to delete this payment?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        try
                        {
                            con.Open();
                            string query = "delete from Payment where PId=" + key + ";";
                            SqlCommand cmd = new SqlCommand(query, con);
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Payment Deleted Successfully");
                            con.Close();
                            populate();

                        }
                        catch (Exception Ex)
                        {

                            MessageBox.Show(Ex.Message);
                        }
                    }
                }
            
            
        }

        private void paymentDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            key = Convert.ToInt32(paymentDGV.SelectedRows[0].Cells[0].Value.ToString());
            periodeDateTimePicker.Text = paymentDGV.SelectedRows[0].Cells[1].Value.ToString();
            nameComboBox.Text = paymentDGV.SelectedRows[0].Cells[2].Value.ToString();
            amountTxtBox.Text = paymentDGV.SelectedRows[0].Cells[3].Value.ToString();
            
        }
    }
}
