using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HowItShouldBe.Items
{
    public class Item
    {
        public bool Imported { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public decimal PriceIncludingSalesTax { get; set; }
        public int SalesTaxPercent { get; set; } = Constants.DefaultTaxPercent;

        public Item(string name, decimal price, bool imported = false)
        {
            this.Name = name;
            this.Price = price;
            this.Imported = imported;
        }

        public virtual void Process()
        {
            var salesTax = this.Price * this.SalesTaxPercent / 100;
            var importTax = this.Imported == true ? this.Price * Constants.ImportTaxPercent / 100 : 0;

            this.PriceIncludingSalesTax = this.Price + salesTax + importTax;
        }
    }
}
