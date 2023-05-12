﻿namespace HomeTaskGenerics.newTypes
{
    internal interface INumber<T>
    {
        T Add(T number);
        T Sub(T number);
        T Mul(int constant);

    }
}