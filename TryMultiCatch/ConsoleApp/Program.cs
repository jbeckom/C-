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
                string[] fruits = { "Apples", null, "Grapes" };

                for (int i = 0; i <= fruits.Length; i++)
                {
                    if (fruits[i] == null)
                    {
                        throw (new ArgumentNullException());
                    }
                    Console.WriteLine(fruits[i]);
                }
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine("Index problem");
                Console.WriteLine(e.Message);
            }
            catch(ArgumentNullException e)
            {
                Console.WriteLine("Null problem");
                Console.WriteLine(e.Message);
            }
        }
    }
}
