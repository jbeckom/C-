#region Namespaces
using System;

#endregion

namespace SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            //Get values to calculate
            double val1 = GetValue("Enter value 1: ");
            double val2 = GetValue("Enter value 2: ");

            //Declare variable to hold result
            double result = 0;

            //Do math
            while (true)
            {
                Console.WriteLine("(A)dd (S)ubtract (M)ultiply (D)ivide : ");
                ConsoleKeyInfo info = Console.ReadKey();
                string operation = info.Key.ToString();

                switch (operation.ToUpper())
                {
                    case "A":
                        result = Add(val1, val2);
                        break;
                    case "S":
                        result = Subtract(val1, val2);
                        break;
                    case "M":
                        result = Multiply(val1, val2);
                        break;
                    case "D":
                        result = Divide(val1, val2);
                        break;
                    default:
                        Console.WriteLine("Choose from supported operations");
                        continue;
                }
                Console.WriteLine("\nResult: " + result);
                Console.Read();
                break;
            }
        }

        private static double GetValue(string label)
        {
            //the value to be returned
            double value;

            //loop until you get a valid entry
            while (true)
            {
                Console.WriteLine(label);
                string input = Console.ReadLine();
                if (Double.TryParse(input, out value))
                {
                    return value;
                }
                else
                {
                    Console.WriteLine("Value can't be parsed as a number");
                }
            }
        }

        private static double Add(double val1, double val2)
        {
            return val1 + val2;
        }

        private static double Subtract(double val1, double val2)
        {
            return val1 - val2;
        }

        private static double Multiply(double val1, double val2)
        {
            return val1 * val2;
        }

        private static double Divide(double val1, double val2)
        {
            if (val1 == 0 | val2 == 0)
            {
                return 0;
            }
            else
            {
                return val1 / val2;
            }
        }
    }
}
