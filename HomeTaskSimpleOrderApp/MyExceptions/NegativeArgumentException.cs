using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace HomeTaskSimpleOrderApp.MyExceptions
{
    internal class NegativeArgumentException : ArgumentException
    {
        public NegativeArgumentException(string? message)
            : base(message)
        {            
        }

    }
}
