using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    class Program
    {
        static void Main(string[] args)
        {
            Sale[] sales;
            
            //question 1
            var itemPriceOver10 =
                from s in sales
                where s.PricePerItem >= 10.0
                select s;

            

            //question 2
            var itemQuant1 =
                from s in sales
                where s.Quantity == 1
                orderby s.PricePerItem descending
                select s;

            //question 3

            //question 4
            var itemTea =
               from s in sales
               where s.Item == "Tea" && !s.ExpeditedShipping
               select s;
        }
    }
}
