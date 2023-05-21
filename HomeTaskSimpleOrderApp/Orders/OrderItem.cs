using HomeTaskSimpleOrderApp.Products;
using HomeTaskSimpleOrderApp.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace HomeTaskSimpleOrderApp.Orders
{
    public class OrderItem
    {   
        private decimal _price;
        private decimal _quantity;
        private decimal _discount;
        public string? Name { get; set; }    
        public decimal Price {
                get { return _price; }
                set {
                    _price = value;
                    RecalculateAmount();                
                }
        }
        public decimal Quantity {
            get { return _quantity; }
            set
            {
                _quantity = value;
                RecalculateAmount();
            }
        }
        public decimal Discount {
            get { return _discount; }
            set
            {
                _discount = value;
                RecalculateAmount();
            }
        }
        public decimal Amount { get; set;}

        public OrderItem(string? name, decimal price, decimal quantity) { 
            Name = name;
            Price = price;
            Quantity = quantity;
            Discount = 0;
            Amount = price * quantity;
        }

        public override string ToString()
        {
            return Helper.PropertiesToString(this);
        }
    
        private void RecalculateAmount()
        {
            Amount = Quantity * Price - Discount;
        }

    }
}
