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

namespace Gym_Application
{
    public partial class AddMember : Form
    {
       
        public AddMember()
        {
            InitializeComponent();
        }
        
      
        private void AddMember_Load(object sender, EventArgs e)
        {

        }

        private void addNMButton_Click(object sender, EventArgs e)
        {
            DataAccsess db = new DataAccsess();
            if (memberNameTxtbNM.Text == "" || PhoneTxtbNM.Text == "" || amountTxtbNM.Text == "" || ageTxtbNM.Text == "")
            {
                MessageBox.Show("You have to fill information for the member");
            }
            else
            {
               
                db.InsertMember(memberNameTxtbNM.Text,PhoneTxtbNM.Text, int.Parse(ageTxtbNM.Text),genderComboBox.SelectedItem.ToString(),int.Parse(amountTxtbNM.Text),timingComboBox.SelectedItem.ToString());
                {
                    memberNameTxtbNM.Text = "";
                    PhoneTxtbNM.Text = "";
                    genderComboBox.Text = "";
                    amountTxtbNM.Text = "";
                    ageTxtbNM.Text = "";
                    timingComboBox.Text = "";
                    MessageBox.Show("Member Successfully added");
                                                         
                }

            }
                
        }

        private void resetNMButton_Click(object sender, EventArgs e)
        {
            memberNameTxtbNM.Text = "";
            PhoneTxtbNM.Text = "";
            genderComboBox.Text = "";
            amountTxtbNM.Text = "";
            ageTxtbNM.Text = "";
            timingComboBox.Text = "";

        }

        private void exitSignNM_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void backButtonNM_Click(object sender, EventArgs e)
        {
            MainFormcs mainForm = new MainFormcs();
            mainForm.Show();
            this.Hide();
        }
    }
}
