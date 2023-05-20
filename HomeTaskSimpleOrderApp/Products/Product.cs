using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HomeTaskSimpleOrderApp.MyExceptions;

namespace HomeTaskSimpleOrderApp.Products
{
    abstract public class Product
    {
        public Product(string name, decimal price) {
            Name = name;
            if (price < 0) { throw new NegativeArgumentException("Price can`t be less than 0 "); }
            Price = price;
        }
        public string? Name { get; set; }
        public decimal Price { get; set; }

        public override string ToString()
        {
            return "You never should see this! :)";
        }

    }
}
