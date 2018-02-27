#region Namespaces
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
#endregion

namespace Switch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter an operation: + - * / ");
            string operation = Console.ReadLine();

            switch (operation)
            {
                case "+":
                    Console.WriteLine("You chose to add");
                    break;

                case "-":
                    Console.WriteLine("You chose to subtract");
                    break;

                case "*":
                    Console.WriteLine("You chose to multiply");
                    break;

                case "/":
                    Console.WriteLine("You chose to divide");
                    break;

                default:
                    Console.WriteLine("No such operation");
                    break;
            }
        }
    }
}
