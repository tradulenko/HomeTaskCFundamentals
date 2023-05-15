using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTaskCollections
{
    public class ShoppingItem
    {
        public string? name { get; init; }
        public double price { get; init;  }
        public int quantity { get; init; }

        public override string ToString()
        {
            return string.Format("ShoppingItem: name -> '{0}' price -> {1} quantity {2}", name, price, quantity);
        }
    }
}
