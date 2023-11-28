using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace POS
{
    public partial class FrmSetting : Form
    {
        public FrmSetting()
        {
            InitializeComponent();
            lblusername.Text = Usernametext;
            lblpass.Text = PasswordText;
        }
        public string Usernametext
        {
            get { return lblusername.Text; }
            set { lblusername.Text = value; }
        }

        public string PasswordText
        {
            get { return lblpass.Text; }
            set { lblpass.Text = value; }
        }

        private void FrmSetting_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void gunaAdvenceButton4_Click(object sender, EventArgs e)
        {
            label1.Visible = false;
            label2.Visible = false;
            tboxemail.Visible = true;
            tboxpassword.Visible = true;
            lblusername.Visible = false;
            lblpass.Visible = false;
            btnChange.Visible = false;
            btnChangeData.Visible = true;
        }

        private void btnChangeData_Click(object sender, EventArgs e)
        {
            string username = tboxemail.Text;
            string password = tboxpassword.Text;

            DialogResult dialogCart = MessageBox.Show("Data berhasil diganti", "Pesan", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (dialogCart == DialogResult.OK)
            {

            }
            Usernametext = username;
            PasswordText = password;
            label1.Visible = true;
            label2.Visible = true;
            tboxemail.Visible = false;
            tboxpassword.Visible = false;
            lblusername.Visible = true;
            lblpass.Visible = true;
            btnChange.Visible = true;
            btnChangeData.Visible = false;

            FrmSetting frmSetting = new FrmSetting();
            frmSetting.lblusername.Text = username;
            frmSetting.PasswordText = password;

            MainDashboard profileForm = new MainDashboard();
            profileForm.UsernameText = username;
            profileForm.Show();
        }
    }
}
