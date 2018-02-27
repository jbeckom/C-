#region Namespaces
using System;
using System.Collections.Generic;
using System.Diagnostics;
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
            string[] fruits = { "Apples", "Oranges", "Grapes" };
            for (int i = 0; i <= fruits.Length; i++)
            {
                Debug.WriteLine("Value of i : " + i);
                Console.WriteLine(fruits[i]);
            }
        }
    }
}
