using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accessor
{
    public class SaleItemAuto
    {
        public string Name
        { get; set; }

        public decimal Price
        { get; set; }
        public SaleItemAuto()
        {
            Name = "";
            Price = 0;
        }
        public SaleItemAuto(string name, decimal price)
        {
            Name = name;
            Price = price;

        }
    }

    class UseAutoProgram
    {
        static void Main(string[] args)
        {
            //var item = new SaleItemAuto { Name = "Shoes", Price = 19.95m };

            SaleItemAuto[] items = { new SaleItemAuto { Name = "Shoes", Price = 19.95m },
                            new SaleItemAuto { Name = "Shoes", Price = 19.95m },
                             new SaleItemAuto { Name = "Shoes", Price = 19.95m } };


            var item = new SaleItemAuto("Saree", 40000);
            Console.WriteLine($"{item.Name}: sells for {item.Price:C2}");
            Console.ReadKey();
        }
    }
}
