using Assignment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
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
                    if (item.Price < 0)
                    {
                        throw new Exception("Price cannot be a negative number!");
                    }

                    var importTax = GetImportedTax(item);
                    var salesTax = GetSalesTax(item);

                    //set item price including taxes
                    item.PriceIncludingSalesTax = item.Price + importTax + salesTax;
                    item.PriceIncludingSalesTax = Math.Round(item.PriceIncludingSalesTax, 2, MidpointRounding.AwayFromZero);

                    //increment total receipt price and sales taxes
                    receipt.SalesTax += salesTax + importTax;
                    receipt.Total += item.Price + importTax + salesTax;

                    //add the item to the receipt
                    receipt.ReceiptItems.Add(item);
                }
            }

            //compute total
            receipt.Total = Math.Round(receipt.Total, 2, MidpointRounding.AwayFromZero);

            //compute taxes
            receipt.SalesTax = Math.Round(receipt.SalesTax, 2, MidpointRounding.AwayFromZero);

            return receipt;
        }

        private static decimal GetImportedTax(Item item)
        {
            if (item.Imported)
            {
                return item.Price * Constants.ImportTaxPercent / 100;
            }
            return 0;
        }

        private static decimal GetSalesTax(Item item)
        {
            var tax = CategoryManager.GetTaxPercentage(item.Category);
            return item.Price * tax / 100;
        }
    }
}
