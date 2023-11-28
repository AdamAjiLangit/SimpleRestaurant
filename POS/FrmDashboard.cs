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
    public partial class FrmDashboard : Form
    {
        public FrmDashboard()
        {
            InitializeComponent();
        }

        private void gunaAdvenceButton4_Click(object sender, EventArgs e)
        {

            FrmFood FrmDashboard_Vrb = new FrmFood() { Dock = DockStyle.Fill, TopLevel = false, TopMost = false };

            FrmDashboard_Vrb.Show();
        }
    }
}
