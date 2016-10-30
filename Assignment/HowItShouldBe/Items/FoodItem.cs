using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HowItShouldBe.Items
{
    public class FoodItem : Item
    {
        public FoodItem(string name, decimal price, bool imported = false)
            : base(name, price, imported)
        {
            this.SalesTaxPercent = Constants.FoodTaxPercent;
        }
    }
}
