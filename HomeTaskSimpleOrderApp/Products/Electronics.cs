using HomeTaskSimpleOrderApp.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTaskSimpleOrderApp.Products
{
    internal class Electronics : Product
    {
        public Electronics(string name, decimal price) : base(name, price)
        {
        }

        public override string ToString()
        {
            return Helper.PropertiesToString(this);
        }
    }
}
