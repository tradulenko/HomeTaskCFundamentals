using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace HomeTaskGenerics.newTypes
{
    class Decimal : INumber<Decimal>
    {
        private decimal _value;

        public Decimal(decimal value)
        {
            this._value = value;
        }

        public Decimal Add(Decimal number)
        {
            return new Decimal(_value + number._value);
        }

        public Decimal Mul(int constant)
        {
            return new Decimal(_value * constant);
        }

        public Decimal Sub(Decimal number)
        {
            return new Decimal(_value - number._value);
        }

        public override string ToString()
        {
            return _value.ToString();
        }
    }

}
