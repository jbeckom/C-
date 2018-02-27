#region Namespaces
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
            //for (int i = 1; i < 11; i++)
            //{
            //    Console.WriteLine("Number: " + i);
            //}

            string[] fruit = { "Apples", "Oranges", "Grapes" };
            //Console.WriteLine(fruit.Length.ToString());
            for (int i = fruit.Length-1; i >= 0; i--)
            {
                Console.WriteLine(fruit[i]);
            }

        }
    }
}
