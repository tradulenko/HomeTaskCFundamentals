using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HomeTaskSimpleOrderApp.Discounts;

namespace HomeTaskSimpleOrderApp.Discounts
{
    internal class PercentDiscount : IDiscount
    {
        private decimal _discountPercent = 0;
        public PercentDiscount(decimal discountPercent) { 
            if ((discountPercent >= 0) && (discountPercent <=100)) { 
                _discountPercent = discountPercent;
            }
        }

        public decimal GetDiscount(decimal price)
        {
            return price * (_discountPercent / 100);
        }
    }
}
