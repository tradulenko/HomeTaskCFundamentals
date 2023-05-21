using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace HomeTaskSimpleOrderApp.MyExceptions
{
    public class NegativeArgumentException : ArgumentException
    {
        public NegativeArgumentException(string? message)
            : base(message)
        {            
        }

    }
}
