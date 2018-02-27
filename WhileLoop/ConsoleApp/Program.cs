#region
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
#endregion

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 1;
            int maximum = 10;

            while (counter <= maximum)
            {
                Console.WriteLine("Loop number: " + counter);
                counter++;
            }

            string welcome = "Hello world";
            counter = 0;

            while (counter < welcome.Length)
            {
                Console.WriteLine(welcome[counter]);
                counter++;
            }

            counter = 0;
            do
            {
                Console.WriteLine(welcome[counter]);
                counter++;
            } while (counter < welcome.Length);
        }
    }
}
