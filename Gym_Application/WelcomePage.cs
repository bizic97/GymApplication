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
    public partial class MainPage : Form
    {
        public MainPage()
        {
            InitializeComponent();
        }

       
        private void label5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void continueButton_Click(object sender, EventArgs e)
        {
            MainFormcs mainF = new MainFormcs();
            mainF.Show();
            this.Hide();
        }
    }
}
