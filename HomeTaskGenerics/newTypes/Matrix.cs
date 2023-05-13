using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTaskGenerics.newTypes
{
    public class Matrix<T> where T : INumber<T>
    {
        private T[,] _internalMatrix;

        public Matrix(T[,] matrix)
        {
            this._internalMatrix = matrix;
        }

        public bool IsSizeTheSame(T[,] matrix)
        {
            if ((_internalMatrix.GetLength(0) == matrix.GetLength(0)) && (_internalMatrix.GetLength(1) == matrix.GetLength(1)))
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
                for (int i = 0; i < matrixForPrint._internalMatrix.GetLength(0); i++)
                {
                    for (int j = 0; j < matrixForPrint._internalMatrix.GetLength(1); j++)
                    {
                        System.Console.Write(matrixForPrint._internalMatrix[i, j] + " ");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Can`t print null matrix!");
            }
        }

        public Matrix<T>? AddMatix(Matrix<T> secondMatrix)
        {
            if (secondMatrix is not null && IsSizeTheSame(secondMatrix._internalMatrix))
            {
                T[,] tempMatrix = new T[_internalMatrix.GetLength(0), _internalMatrix.GetLength(1)];
                for (int i = 0; i < _internalMatrix.GetLength(0); i++)
                {
                    for (int j = 0; j < _internalMatrix.GetLength(1); j++)
                    {
                        tempMatrix[i, j] = _internalMatrix[i, j].Add(secondMatrix._internalMatrix[i, j]);
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

        public Matrix<T>? SubstructMatix(Matrix<T> secondMatrix)
        {
            if (secondMatrix is not null && IsSizeTheSame(secondMatrix._internalMatrix))
            {
                T[,] tempMatrix = new T[_internalMatrix.GetLength(0), _internalMatrix.GetLength(1)];
                for (int i = 0; i < _internalMatrix.GetLength(0); i++)
                {
                    for (int j = 0; j < _internalMatrix.GetLength(1); j++)
                    {
                        tempMatrix[i, j] = _internalMatrix[i, j].Sub(secondMatrix._internalMatrix[i, j]);
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
            T[,] tempMatrix = new T[_internalMatrix.GetLength(0), _internalMatrix.GetLength(1)];
            for (int i = 0; i < _internalMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < _internalMatrix.GetLength(1); j++)
                {
                    tempMatrix[i, j] = _internalMatrix[i, j].Mul(constant);
                }
            }


            return new Matrix<T>(tempMatrix);
        }
    }
}
