using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace POS
{
    public partial class FrmFood : Form
    {
        public static List<Food> cart = new List<Food>();

        public FrmFood()
        {
            InitializeComponent();
            
        }

        private void gunaGradientTileButton1_Click(object sender, EventArgs e)
        {

        }

        private void FrmFood_Load(object sender, EventArgs e)
        {
            Guna.UI.Lib.ScrollBar.PanelScrollHelper flowphelper = new Guna.UI.Lib.ScrollBar.PanelScrollHelper(flowLayoutPanel2, gunaVScrollBar1, true);

        }

        private void gunaGradientTileButton1_Click_1(object sender, EventArgs e)
        {
            Food cheeseburger = new Food
            {
                productImage = Properties.Resources._11953574_452,
                name = "Cheese Burger",
                price = 20000
            };
            DialogResult result = MessageBox.Show("Apakah Anda yakin ingin menambahkan Burger ke cart?", "Konfirmasi", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                // Menambahkan steak ke cart
                cart.Add(cheeseburger);
                MessageBox.Show("Burger telah ditambahkan ke cart!");
            }
            else
            {

            }
        }

        private void gunaGradientTileButton2_Click(object sender, EventArgs e)
        {
            Food noodles = new Food
            {
                productImage = Properties.Resources.noodles,
                name = "Noodles",
                price = 18000
            };
            DialogResult result = MessageBox.Show("Apakah Anda yakin ingin menambahkan Noodles ke cart?", "Konfirmasi", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                // Menambahkan steak ke cart
                cart.Add(noodles);
                MessageBox.Show("Noodles telah ditambahkan ke cart!");
            }
            else
            {

            }
        }

        private void gunaGradientTileButton3_Click(object sender, EventArgs e)
        {
            Food steak = new Food
            {
                productImage = Properties.Resources.steak,
                name = "Steak",
                price = 50000
            };
            DialogResult result = MessageBox.Show("Apakah Anda yakin ingin menambahkan Steak ke cart?", "Konfirmasi", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                // Menambahkan steak ke cart
                cart.Add(steak);
                MessageBox.Show("Steak telah ditambahkan ke cart!");
            }
            else
            {

            }
        }
    }
}
