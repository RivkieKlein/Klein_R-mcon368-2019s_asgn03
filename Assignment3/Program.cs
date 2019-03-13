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

            Sale sale1 = new Sale();
            sale1.Item = "Tea";
            sale1.Customer = "LLC";
            sale1.PricePerItem = 10.0;
            sale1.Quantity = 10;
            sale1.Address = "13 Park lane";
            sale1.ExpeditedShipping = false;

            Sale sale2 = new Sale();
            sale2.Item = "Coffee";
            sale2.Customer = "javabean llc";
            sale2.PricePerItem = 11.0;
            sale2.Quantity = 10;
            sale2.Address = "25 bridge lane";
            sale2.ExpeditedShipping = true;

            Sale sale3 = new Sale();
            sale3.Item = "Candy";
            sale3.Customer = "sweet treats";
            sale3.PricePerItem = 9.0;
            sale3.Quantity = 1;
            sale3.Address = "10 river street";
            sale3.ExpeditedShipping = false;

            Sale sale4 = new Sale();
            sale4.Item = "Skis";
            sale4.Customer = "Snow Gear LLC";
            sale4.PricePerItem = 100.0;
            sale4.Quantity = 1;
            sale4.Address = "2 Mountain Drive";
            sale4.ExpeditedShipping = false;

            Sale sale5 = new Sale();
            sale5.Item = "Book";
            sale5.Customer = "readers inc.";
            sale5.PricePerItem = 5.0;
            sale5.Quantity = 20;
            sale5.Address = "2047 8th ave";
            sale5.ExpeditedShipping = true;

            Sale[] sales = { sale1, sale2, sale3, sale4, sale5 };


            //question 1
            var itemPriceOver10 =
                from s in sales
                where s.PricePerItem > 10.0
                select s;



            //question 2
            var itemQuant1 =
                from i in sales
                where i.Quantity == 1
                orderby i.PricePerItem descending
                select i;



            //question 3
            var itemTea =
               from t in sales
               where t.Item == "Tea" && !t.ExpeditedShipping
               select t;

            //question 4
            var itemof100OrderAdress =
                from e in sales
                where (e.PricePerItem * e.Quantity) > 100.0
                select e.Address;

            //question 5
            var anonymousItems =
                from m in sales
                where m.Customer.ToUpper().Contains("LLC")
                orderby m.PricePerItem * m.Quantity
                select new { m.Item, TotalPrice = m.PricePerItem * m.Quantity,Shipping = m.ExpeditedShipping ? m.Address + " Expedite":  m.Address };

            //write for testing
            

            Console.WriteLine("itemPriceOver10:");
            foreach(var element in itemPriceOver10)
            {
                Console.WriteLine(element);
            }

            Console.WriteLine("itemQuant1:");
            foreach(var element in itemQuant1)
            {
                Console.WriteLine(element);
            }

            Console.WriteLine("itemTea:");
            foreach (var element in itemTea)
            {
                Console.WriteLine(element);
            }

            Console.WriteLine("itemof100OrderAdress:");
            foreach (var element in itemof100OrderAdress)
            {
                Console.WriteLine(element);
            }

            Console.WriteLine("anonymousItems: ");
            foreach (var element in anonymousItems)
            {
                Console.WriteLine(element);
            }

            Console.Read();
        }
    }
}
