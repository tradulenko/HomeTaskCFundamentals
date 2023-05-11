using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTaskGenerics
{
    internal interface INumber<T>
    {
        T Add(T Number);
        T Sub(T Number);
        T Mul(int Constant);
        
    }

    class Integer : INumber<Integer>
    {
        int Value;
        public Integer(int Value)
        {
            this.Value = Value;
        }

        public Integer Add(Integer Number)
        {
            return new Integer(this.Value + Number.Value);
        }

        public Integer Mul(int Constant)
        {
            return new Integer(this.Value * Constant);
        }

        public Integer Sub(Integer Number)
        {
            return new Integer(this.Value - Number.Value);
        }

        public override string ToString()
        {
            return Value.ToString();
        }
    }

    class Double : INumber<Double>
    {
        public double Value;
        public Double(double Value)
        {
            this.Value = Value;     
        }

        public Double Add(Double Number)
        {
            return new Double(this.Value + Number.Value);   
        }

        public Double Mul(int Constant)
        {
            return new Double(this.Value * Constant);
        }

        public Double Sub(Double Number)
        {
            return new Double(this.Value - Number.Value);
        }

        public override string ToString()
        {
            return Value.ToString();
        }
    }

    class Decimal : INumber<Decimal> { 
        public decimal Value;

        public Decimal(decimal Value)
        {
            this.Value = Value;
        }

        public Decimal Add(Decimal Number)
        {
            return new Decimal(this.Value + Number.Value);  
        }

        public Decimal Mul(int Constant)
        {
            return new Decimal(this.Value * Constant);
        }

        public Decimal Sub(Decimal Number)
        {
            return new Decimal(this.Value - Number.Value);
        }

        public override string ToString()
        {
            return Value.ToString();
        }
        

    }

    class Matrix<T> where T : INumber<T> 
    {
        T[,] internalMatrix;

        public Matrix(T[,] matrix)
        {
            this.internalMatrix = matrix;
        }

        public bool IsSizeTheSame(T[,] matrix)
        {
            if ((internalMatrix.GetLength(0) == matrix.GetLength(0)) && (internalMatrix.GetLength(1) == matrix.GetLength(1))) 
            {
                return true; 
            }
            return false;
        }

       
        public static void Print(Matrix<T>? matrixForPrint)
        {
            if (matrixForPrint is not null)
            {
                Console.WriteLine("\nMatrix : ");
                for (int i = 0; i < matrixForPrint.internalMatrix.GetLength(0); i++)
                {
                    for (int j = 0; j < matrixForPrint.internalMatrix.GetLength(1); j++)
                    {
                        System.Console.Write(matrixForPrint.internalMatrix[i, j] + " ");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            } else
            {
                Console.WriteLine("Can`t print null matrix!");
            }
        }

        public Matrix<T>? AddMatix(Matrix<T> secondMatrix)
        {
            if (secondMatrix is not null && IsSizeTheSame(secondMatrix.internalMatrix)) 
            {
                T[,] tempMatrix = new T[internalMatrix.GetLength(0), internalMatrix.GetLength(1)];
                for (int i = 0; i < internalMatrix.GetLength(0); i++)
                {
                    for (int j = 0; j < internalMatrix.GetLength(1); j++)
                    {
                        tempMatrix[i, j] = internalMatrix[i, j].Add(secondMatrix.internalMatrix[i, j]);
                    }
                }


                return new Matrix<T>(tempMatrix);
            } else
            {
                Console.WriteLine("Matrixs have different size");
                return null;
            }
        }

        public Matrix<T>? SubstructMatix(Matrix<T> secondMatrix)
        {
            if (secondMatrix is not null && IsSizeTheSame(secondMatrix.internalMatrix))
            {
                T[,] tempMatrix = new T[internalMatrix.GetLength(0), internalMatrix.GetLength(1)];
                for (int i = 0; i < internalMatrix.GetLength(0); i++)
                {
                    for (int j = 0; j < internalMatrix.GetLength(1); j++)
                    {
                        tempMatrix[i, j] = internalMatrix[i, j].Sub(secondMatrix.internalMatrix[i, j]);
                    }
                }


                return new Matrix<T>(tempMatrix);
            }
            else
            {
                Console.WriteLine("Matrixs have different size");
                return null;
            }
        }

        public Matrix<T>? MultByConstant(int constant)
        {
            T[,] tempMatrix = new T[internalMatrix.GetLength(0), internalMatrix.GetLength(1)];
            for (int i = 0; i < internalMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < internalMatrix.GetLength(1); j++)
                {
                    tempMatrix[i, j] = internalMatrix[i, j].Mul(constant);
                }
            }


            return new Matrix<T>(tempMatrix);
        }
    }

}
