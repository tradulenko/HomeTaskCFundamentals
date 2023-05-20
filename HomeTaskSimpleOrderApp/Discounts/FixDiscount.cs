using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HomeTaskSimpleOrderApp.MyExceptions;

namespace HomeTaskSimpleOrderApp.Discounts
{
    public class FixDiscount : IDiscount
    {
        private decimal _discount;
        
        public decimal DiscountAmount{ get
            {
                return _discount;
            }
            private set
            {
                _discount = value;
            } }

        public FixDiscount(decimal discount) { 
            if (discount < 0) { throw new NegativeArgumentException("Discount can`t be less than zero"); }    
            _discount = discount;
        }


        public decimal GetDiscount(decimal price)
        {   
            if (price > DiscountAmount)
            {
                return DiscountAmount;
            } else
            {
                return price;
            }
        }
    }
}
