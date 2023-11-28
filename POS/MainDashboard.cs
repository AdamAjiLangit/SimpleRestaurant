using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI.Lib;

namespace POS
{
    public partial class MainDashboard : Form
    {
        bool sidebarExpand;
        public MainDashboard()
        {
            InitializeComponent();
            username.Text = UsernameText;

        }

        public string UsernameText
        {
            get { return username.Text; }
            set { username.Text = value; }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void gunaGradientTileButton1_Click(object sender, EventArgs e)
        {

        }

        private void gunaControlBox3_Click(object sender, EventArgs e)
        {

        }

        private void userControl17_Load(object sender, EventArgs e)
        {

        }

        private void gunaLabel5_Click(object sender, EventArgs e)
        {

        }

        private void gunaGradientTileButton7_Click(object sender, EventArgs e)
        {
            this.pnlContent.Controls.Clear();
            FrmFood FrmDashboard_Vrb = new FrmFood() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.pnlContent.Controls.Add(FrmDashboard_Vrb);
            FrmDashboard_Vrb.Show();
        }

        private void gunaGradientTileButton8_Click(object sender, EventArgs e)
        {
            this.pnlContent.Controls.Clear();
            FrmCart FrmDashboard_Vrb = new FrmCart() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.pnlContent.Controls.Add(FrmDashboard_Vrb);
            FrmDashboard_Vrb.Show();
        }

        private void gunaGradientTileButton6_Click(object sender, EventArgs e)
        {
            this.pnlContent.Controls.Clear();
            FrmDashboard FrmDashboard_Vrb = new FrmDashboard() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.pnlContent.Controls.Add(FrmDashboard_Vrb);
            FrmDashboard_Vrb.Show();
        }

        private void gunaAdvenceButton4_Click(object sender, EventArgs e)
        {
            this.pnlContent.Controls.Clear();
            FrmFood FrmDashboard_Vrb = new FrmFood() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.pnlContent.Controls.Add(FrmDashboard_Vrb);
            FrmDashboard_Vrb.Show();
        }

        private void gunaGradientTileButton9_Click(object sender, EventArgs e)
        {

        }

        private void gunaGradient2Panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gunaAdvenceButton1_Click(object sender, EventArgs e)
        {
            FrmSetting frmSetting = new FrmSetting();
            frmSetting.Usernametext = UsernameText;
                        
            this.pnlContent.Controls.Clear();
            FrmSetting FrmDashboard_Vrb = new FrmSetting() { Dock = DockStyle.Fill, TopLevel = false, TopMost = false };
            this.pnlContent.Controls.Add(FrmDashboard_Vrb);
            FrmDashboard_Vrb.Show();
        }

        private void sidebarTimer_Tick(object sender, EventArgs e)
        {

        }

        private void gunaControlBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
