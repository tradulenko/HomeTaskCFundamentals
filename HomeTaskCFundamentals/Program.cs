
using HomeTaskCFundamentals;

var rnd = new Random();
bool wantToExit;
do
{   
    wantToExit = false;
    int thinkedNumber = rnd.Next(0, 50);
    Console.WriteLine(thinkedNumber);

    bool isNumberedFound = false;

    do
    {
        Console.WriteLine("\nEnter your number (for exit enter 'P'):");
        int inputNumber;
        try
        {
            string? inputedValue = Console.ReadLine();
            if ((inputedValue != null) && inputedValue.Equals("P", StringComparison.OrdinalIgnoreCase))
            {
                wantToExit = true;
                break;
            }

            inputNumber = Convert.ToInt32(inputedValue);
        }
        catch (Exception)
        {
            Console.WriteLine("You should enter a number! Try again");
            continue;
        }

        isNumberedFound = Analyser.AnalyseNumber(inputNumber, thinkedNumber);

    } while (!isNumberedFound);

    if (!wantToExit)
    {
        Console.WriteLine("\nDo you want exit Press Y");
        wantToExit = (Console.ReadLine() ?? "").Equals("y", StringComparison.OrdinalIgnoreCase);
    }
} while (!wantToExit);

Console.WriteLine("GoodBuy!");

