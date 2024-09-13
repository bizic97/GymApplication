using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration.Provider;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Gym_Application
{
    public partial class ViewMember : Form
    {
        List<Member> members = new List<Member>();
        public ViewMember()
        {
            InitializeComponent();
        }

       /* private void UpdateBinding()
        {
            viewMemberListBox.DataSource = members;
            viewMemberListBox.DisplayMember="FullInfo";
        }*/

        private void label5_Click(object sender, EventArgs e)
        {
            Application.Exit();
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
        private void ViewMember_Load(object sender, EventArgs e)
        {
            populate();
        }
                               
        private void memberListBackButton_Click(object sender, EventArgs e)
        {
            MainPage log = new MainPage();
            log.Show();
            this.Hide();
        }
        private void FilterByName()
        {
            con.Open();
            string query = "select * from Members where MName='" + searchMemberTextBox.Text + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder();
            var ds = new DataSet();
            sda.Fill(ds);
            membersDGV.DataSource = ds.Tables[0];
            con.Close();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            FilterByName();
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            populate();
        }

        private void memberListBackButton_Click_1(object sender, EventArgs e)
        {
            MainFormcs mainForm = new MainFormcs();
            mainForm.Show();
            this.Hide();
        }
    }
}
