using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WorkwithProperties
{
    class Product
    {
        string _productid;
        string _productname;
        int _price;
        //public Product()
        //{
        //    _productid = "P0001";
        //    _productname = "MObiles";
        //    _price = 1200;
        //}
        public string ProductId
        {
            //get
            //{
            //    return _productid;
            //}
            set
            {
                _productid = value;
            }
        }
        public string ProductName
        {
            //get
            //{
            //    return _productname;
            //}
            set
            {
                _productname = value;
            }
        }
        public int Price
        {
            //get
            //{
            //    return _price;
            //}
            set
            {
                _price = value;
            }
        }
        public void show()
        {
            Console.WriteLine("Product Information");
            Console.WriteLine("ProductId: " + _productid);
            Console.WriteLine("ProductName: " + _productname);
            Console.WriteLine("ProductPrice: " +_price);
        }
    }
    class class1
    {
        static void Main()
        {
            Product p1 = new Product();
            p1.ProductId = "P0001";
            p1.ProductName = "Computers";
            p1.Price = 12000;
            p1.show();
           
            Console.Read();
        }
    }
}
