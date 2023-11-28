using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (cboxpass.Checked)
            {
                tboxpassword.PasswordChar = '\0';
            }
            else
            {
                tboxpassword.PasswordChar = '*';
            }
        }

        private void gunaAdvenceButton4_Click(object sender, EventArgs e)
        {
            string username = tboxemail.Text;
            string password = tboxpassword.Text;

            if (username == "admin" && password == "admin")
            {
                MainDashboard profileForm = new MainDashboard();
                profileForm.Show();
                this.Hide();

            }
            else if (username == "a" && password == "a")
            {
                MainDashboard profileForm = new MainDashboard();
                profileForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Username atau password salah. Silakan coba lagi.");
                tboxemail.Clear();
                tboxpassword.Clear();
            }
        }
    }
}
