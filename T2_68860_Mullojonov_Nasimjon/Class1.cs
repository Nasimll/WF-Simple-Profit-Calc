using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace T2_68860_Mullojonov_Nasimjon
{
     class Product
    {

        public string name;
        public int quantity;
        public int price;
        public int profit;
        private string id;

        public Product(string name,  int quantity, int price, int profit)
        {
            this.name = name;
            this.quantity = quantity;
            this.price = price;
            this.profit = profit;
            this.id = genID();

        }
        public string genID()
        {
            if (name.Length >= 2 && char.IsLetter(name[0]) && char.IsLetter(name[1]))
            {

                Random rnd = new Random();
                int rand = rnd.Next(1000, 10000);
                return $"{name[0]}{name[1]}-{rand}";
            }
            else
            {
                return "<<You should input at least 2 letters>>";
            }
           
        }
       

        public int quanC()
        {
            quantity *= price;
            return quantity;


        }
        public double percentProfit()
        {
            double result = 0;
            result = (quantity * profit )/ 100.0;
            return result;
        }


    }
}
