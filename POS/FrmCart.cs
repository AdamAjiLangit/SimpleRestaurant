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
    public partial class FrmCart : Form
    {
        List<Food> Products = FrmFood.cart;
        private int quantity = 0;
        private const int minQuantity = 1;
        private const int maxQuantity = 100;
        private int quantity1 = 1;
        private const int minQuantity1 = 1;
        private const int maxQuantity1 = 100;
        private int quantity2 = 1;
        private const int minQuantity2 = 1;
        private const int maxQuantity2 = 100;
        private decimal productPrice = 0;
        private decimal productPrice1 = 0;
        private decimal productPrice2 = 0;
        public FrmCart()
        {
            InitializeComponent();
            DisplayCartContents();
        }
        public static List<Food> cart = new List<Food>();
        private void DisplayCartContents()
        {
            List<Food> cartContents = FrmFood.cart;

            foreach (var product in cartContents)
            {
                
                panel1.Visible = true;
                lblname1.Text = product.name;
                productPrice = product.price ?? 0;
                lblharga1.Text = "Rp " + productPrice.ToString();
                pbox1.Image = product.productImage;

                UpdateQuantityAndPrice();
                UpdateSubtotalAndTotal();
            }
        }

        private void UpdateQuantityAndPrice()
        {
            lblQuantity1.Text = quantity.ToString();
            lblharga1.Text = "Rp " + (quantity * productPrice).ToString();
        }

        private void UpdateSubtotalAndTotal()
        {
            int subTotalFood = (int)(quantity * productPrice);

            int subTotal = subTotalFood;
            lblsubtotal.Text = "Rp " + subTotal.ToString();

            int discount = (int)(subTotal * 0.19m);
            lblDiscount.Text = "Rp " + discount.ToString();

            int total = subTotal - discount;
            lblTotal.Text = "Rp " + total.ToString();
        }


        private void userControl21_Load(object sender, EventArgs e)
        {

        }

        private void gunaNumeric1_ValueChanged(object sender, EventArgs e)
        {
            int currentValue = (int)gunaNumeric1.Value;

            if (currentValue > quantity)
            {
                // Plus button clicked
                if (quantity < maxQuantity)
                {
                    quantity += 1;
                    UpdateQuantityAndPrice();
                    UpdateSubtotalAndTotal();
                }
            }
            else if (currentValue < quantity)
            {
                // Minus button clicked
                if (quantity > minQuantity)
                {
                    quantity -= 1;
                    UpdateQuantityAndPrice();
                    UpdateSubtotalAndTotal();
                }
            }
        }

        private void lblQuantity1_Click(object sender, EventArgs e)
        {

        }

        private void gunaAdvenceButton4_Click(object sender, EventArgs e)
        {
            string totalharga = lblTotal.Text;
            string jumlah = lblQuantity1.Text;
            DialogResult dialogResult = MessageBox.Show("Apakah Anda yakin ingin membayar?", "Konfirmasi Pembayaran", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
            {
                // Kode yang akan dijalankan jika user memilih "Yes"
                MessageBox.Show("Pembayaran Berhasil", "Pesan", MessageBoxButtons.OK, MessageBoxIcon.Information);

                lblsubtotal.Text = "Rp 0";
                lblTotal.Text = "Rp 0";
                lblDiscount.Text = "Rp 0";
                panel1.Visible = false;
                Products.Clear();
                /*frmOrder orderForm = new frmOrder();
                orderForm.totalharga = totalharga;
                orderForm.jumlahbarang = jumlah;*/

            }
        }

        private void gunaAdvenceButton1_Click(object sender, EventArgs e)
        {

            
                DialogResult result = MessageBox.Show("Are you sure you want to delete?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    // User clicked Yes, perform the deletion logic
                    lblsubtotal.Text = "Rp 0";
                    lblTotal.Text = "Rp 0";
                    lblDiscount.Text = "Rp 0";
                    panel1.Visible = false;
                    Products.Clear();

                    // Additional logic if needed
                }
                // If result is DialogResult.No, do nothing or provide additional logic.
            


        }
    }
}
