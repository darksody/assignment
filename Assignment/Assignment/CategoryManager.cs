using Assignment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    public class CategoryManager
    {
        //this could get the categories from a DB instead of an enum, and also their tax values
        public static int GetTaxPercentage(Category category)
        {
            switch (category)
            {
                case Category.Magazines:
                    return Constants.MagazineTaxPercent;
                case Category.Food:
                    return Constants.FoodTaxPercent;
                case Category.Electronics:
                    return Constants.ElectronicsTaxPercent;
                case Category.Other:
                default:
                    return Constants.DefaultTaxPercent;
            }
        }
    }
}
