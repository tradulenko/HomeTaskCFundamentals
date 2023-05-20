using HomeTaskSimpleOrderApp.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTaskSimpleOrderApp.Products
{
    public class Food : Product
    {
        public DateTime ShelfDate { get; private set; }
        public Food(string name, decimal price) : base(name, price)
        {
            ShelfDate = DateTime.Now.AddDays(5);
        }
        public Food(string name, decimal price, DateTime dateTime) : base(name, price)
        {
            ShelfDate = dateTime;
        }

        public override string ToString()
        {
            return Helper.PropertiesToString(this);
        }

    }
}
