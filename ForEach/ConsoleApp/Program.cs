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
            string[] fruits = { "Apples", "Oranges", "Grapes", "Avacado" };
            foreach (var fruit in fruits)
            {
                Console.WriteLine(fruit);
            }
        }
    }
}
