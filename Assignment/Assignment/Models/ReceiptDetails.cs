using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Models
{
    public class ReceiptDetails
    {
        public List<Item> ReceiptItems { get; set; } = new List<Item>();
        public decimal SalesTax { get; set; }
        public decimal Total { get; set; }
    }
}
