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
    public partial class UpdateDelete : Form
    {
        public UpdateDelete()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"data source=DESKTOP-NDT7O5N\SQLEXPRESS;Initial Catalog=GymDatabase;Trusted_Connection=True;MultipleActiveResultSets=True");
        private void populate()
        {
            con.Open();
            string query = "select * from Members";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder();
            var ds = new DataSet();
            sda.Fill(ds);
            membersDGV.DataSource = ds.Tables[0];
            con.Close();
        }

        private void UpdateDelete_Load(object sender, EventArgs e)
        {
            populate();
        }
                     
        private void resetButton_Click(object sender, EventArgs e)
        {
            memberTxtBoUD.Text = "";
            phoneTxtBoUD.Text = "";
            GenderComBoUD.Text = "";
            ageTxtBoUD.Text = "";
            amountTxtBoUD.Text = "";
            TimingComBoUD.Text = "";

        }

        private void backButton_Click(object sender, EventArgs e)
        {
            MainFormcs mainform = new MainFormcs();
            mainform.Show();
            this.Hide();
        }
        int key = 0;
        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (key == 0)
            {
                MessageBox.Show("Select The Member To Be Deleted ");
            }
            else
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete this member?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        con.Open();
                        string query = "delete from Members where MId=" + key + ";";
                        SqlCommand cmd = new SqlCommand(query, con);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Member Deleted Successfully");
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

        private void updateButton_Click(object sender, EventArgs e)
        {

            if (key == 0 || memberTxtBoUD.Text == "" || phoneTxtBoUD.Text=="" || ageTxtBoUD.Text=="" || amountTxtBoUD.Text=="" || GenderComBoUD.Text=="" || TimingComBoUD.Text=="" )
            {
                MessageBox.Show("You need to select member to update");
            }
            else
            {
                DialogResult result = MessageBox.Show("Are you sure you want to update information?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        con.Open();
                        string query = "update Members set MName= '" + memberTxtBoUD.Text + "', MPhoneNumber='" + phoneTxtBoUD.Text + "',MGender='" + GenderComBoUD.Text + "', MAge=" + ageTxtBoUD.Text + ", MemberAmount=" + amountTxtBoUD.Text + ", MTiming='" + TimingComBoUD.Text + "'where MId=" + key + ";";
                        SqlCommand cmd = new SqlCommand(query, con);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Member Updated Successfully");
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

        private void label11_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        
        private void membersDGV_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            key = Convert.ToInt32(membersDGV.SelectedRows[0].Cells[0].Value.ToString());
            memberTxtBoUD.Text = membersDGV.SelectedRows[0].Cells[1].Value.ToString();
            phoneTxtBoUD.Text = membersDGV.SelectedRows[0].Cells[2].Value.ToString();
            GenderComBoUD.Text = membersDGV.SelectedRows[0].Cells[3].Value.ToString();
            ageTxtBoUD.Text = membersDGV.SelectedRows[0].Cells[4].Value.ToString();
            amountTxtBoUD.Text = membersDGV.SelectedRows[0].Cells[5].Value.ToString();
            TimingComBoUD.Text = membersDGV.SelectedRows[0].Cells[6].Value.ToString();
        }
    }
}
