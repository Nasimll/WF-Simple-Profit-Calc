using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace T2_68860_Mullojonov_Nasimjon
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Product product = new Product(productN.Text, Convert.ToInt32(quantity.Text), Convert.ToInt32(price.Text), Convert.ToInt32(profit.Text));
            string id = product.genID();
            ID.Text = $"{id}";
            sum.Text = Convert.ToString(product.quanC());
            allprofit.Text = Convert.ToString(product.percentProfit());
        }
    }
}   
