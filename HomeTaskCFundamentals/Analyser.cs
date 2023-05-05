using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTaskCFundamentals
{
    public class Analyser
    {
        public static bool AnalyseNumber(int inputNumber, int thinkedNumber)
        {
            bool isNumberedFound = false;
            if (inputNumber < thinkedNumber)
            {
                Console.WriteLine("My number is bigger..");
            }
            else if (inputNumber > thinkedNumber)
            {
                Console.WriteLine("My number is smaller..");
            }
            else
            {
                Console.WriteLine("Bullseye!");
                isNumberedFound = true;
            }
            return isNumberedFound;
        }
    }
}
