using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace HomeTaskGenerics.newTypes
{
    class Integer : INumber<Integer>
    {
        private int _value;
        public Integer(int value)
        {
            this._value = value;
        }

        public Integer Add(Integer number)
        {
            return new Integer(this._value + number._value);
        }

        public Integer Mul(int constant)
        {
            return new Integer(this._value * constant);
        }

        public Integer Sub(Integer number)
        {
            return new Integer(this._value - number._value);
        }

        public override string ToString()
        {
            return _value.ToString();
        }
    }
}
