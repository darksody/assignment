using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HowItShouldBe.Items
{
    public class ElectronicItem : Item
    {
        public ElectronicItem(string name, decimal price, bool imported = false)
            : base(name, price, imported)
        {
            this.SalesTaxPercent = Constants.ElectronicsTaxPercent;
        }
    }
}
