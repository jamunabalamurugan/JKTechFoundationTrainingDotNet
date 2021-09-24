using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accessor
{
    public class SaleItem
    {
        string _name;
        decimal _cost;

        public SaleItem(string name, decimal cost)
        {
            _name = name;
            _cost = cost;
        }

        public string Name
        {
            get => _name; //or get{return _name;}
            set => _name = value;//set {_name=value;}
        }

        public decimal Price
        {
            get => _cost;
            set => _cost = value;
        }
    }

    class UseLamdaEg
    {
        static void Main(string[] args)
        {
            var item = new SaleItem("Shoes", 19.95m);
            Console.WriteLine($"{item.Name}: sells for {item.Price:C2}");
            Console.ReadKey();
        }
    }
}
