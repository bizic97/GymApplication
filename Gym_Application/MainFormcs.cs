using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gym_Application
{
    public partial class MainFormcs : Form
    {
        public MainFormcs()
        {
            InitializeComponent();
        }

       
        private void addMemberbButton_Click(object sender, EventArgs e)
        {
            AddMember addMember = new AddMember();
            addMember.Show();
            this.Hide();
        }

        private void updateMainFormButton_Click(object sender, EventArgs e)
        {
            UpdateDelete upDel = new UpdateDelete();
            upDel.Show();
            this.Hide();
        }

        private void paymentButton_Click(object sender, EventArgs e)
        {
            Payment pay = new Payment();
            pay.Show();
            this.Hide();
        }

        private void viewMemberButton_Click(object sender, EventArgs e)
        {
            ViewMember viewMember = new ViewMember();
            viewMember.Show();
            this.Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void backToLoginButton_Click(object sender, EventArgs e)
        {
            MainPage login = new MainPage();
            login.Show();
            this.Hide();
        }
    }
}
