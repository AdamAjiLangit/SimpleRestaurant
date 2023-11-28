using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS
{
    public class Food
    {
        public Image productImage { get; set; }
        public string name { get; set; }
        public decimal? price { get; set; }
    }
}
