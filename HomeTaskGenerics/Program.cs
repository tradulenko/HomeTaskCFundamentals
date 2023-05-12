using HomeTaskGenerics;
using Double = HomeTaskGenerics.newTypes.Double;
using Decimal = HomeTaskGenerics.newTypes.Decimal;
using Integer = HomeTaskGenerics.newTypes.Integer;
using HomeTaskGenerics.newTypes;

namespace HomeTaskGenerics
{
    public class Program
    {
        public static void Main()
        {

            Integer newInteger = new(15);
            Integer newInteger1 = new(6);
            Double newDouble = new(2.5);
            Decimal newDecimal = new(23);

            Console.WriteLine($"New Integer: {newInteger}");
            Console.WriteLine(newInteger.Sub(newInteger1));
            Console.WriteLine(newDouble);
            Console.WriteLine(newDecimal);

            Integer[,] matrix1 = new Integer[2, 2]
            {
                { new Integer(2), newInteger1 },
                { new Integer(2), newInteger1 }
            };

            Integer[,] matrix2 = new Integer[3, 2]
            {
                { new Integer(1), new Integer(1) },
                { new Integer(1), new Integer(1) },
                { new Integer(1), new Integer(1) }
            };

            Integer[,] matrix3 = new Integer[2, 2]
            {
                { new Integer(1), new Integer(1) },
                { new Integer(1), new Integer(1) }
            };


            Matrix<Integer> matrixInteger = new Matrix<Integer>(matrix1);
            Matrix<Integer>.Print(matrixInteger);

            // Error when try to work with matrix with different size
            matrixInteger.AddMatix(new Matrix<Integer>(matrix2));


            // Try method from Matrix
            Matrix<Integer>.Print(matrixInteger.AddMatix(new Matrix<Integer>(matrix1)));

            Matrix<Integer>.Print(matrixInteger.SubstructMatix(new Matrix<Integer>(matrix3)));

            Matrix<Integer>.Print(matrixInteger.MultByConstant(2));

            //Try Matrix Double
            Double[,] matrixDouble = new Double[2, 2]
            {
                { new Double(1.5), new Double(1) },
                { new Double(1.5), new Double(1) }
            };


            Matrix<Double>.Print(new Matrix<Double>(matrixDouble).MultByConstant(3));

        }
    }
}