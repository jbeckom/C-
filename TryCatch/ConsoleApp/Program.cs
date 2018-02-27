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
            try
            {
                string[] fruits = { "Apples", "Oranges", "Grapes" };

                for (int i = 0; i <= fruits.Length; i++)
                {
                    Console.WriteLine(fruits[i]);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }
    }
}
