using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Models
{
    public class Item
    {
        public Category Category { get; set; } = Category.Other;
        public bool Imported { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public decimal PriceIncludingSalesTax { get; set; }

        public Item(string name, decimal price)
        {
            this.Name = name;
            this.Price = price;
        }

        public Item(string name, decimal price, Category category, bool imported = false)
            : this(name, price)
        {
            this.Category = category;
            this.Imported = imported;
        }

        public Item(string name, decimal price, bool imported)
            : this(name, price)
        {
            this.Imported = imported;
        }
    }
}
