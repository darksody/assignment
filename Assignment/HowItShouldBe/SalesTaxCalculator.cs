using HowItShouldBe.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HowItShouldBe
{
    public class SalesTaxCalculator
    {
        public static ReceiptDetails Process(params Item[] items)
        {
            var receipt = new ReceiptDetails();
            if (items != null)
            {
                foreach (var item in items)
                {
                    item.Process();
                    receipt.Total += item.PriceIncludingSalesTax;
                    receipt.SalesTax += item.PriceIncludingSalesTax - item.Price;
                    receipt.ReceiptItems.Add(item);
                    //round up to 2 decimals
                    item.PriceIncludingSalesTax = Math.Round(item.PriceIncludingSalesTax, 2, MidpointRounding.AwayFromZero);
                }
            }
            receipt.Total = Math.Round(receipt.Total, 2, MidpointRounding.AwayFromZero);
            receipt.SalesTax = Math.Round(receipt.SalesTax, 2, MidpointRounding.AwayFromZero);
            return receipt;
        }
    }
}
