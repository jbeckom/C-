using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfElse
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            if (input.Equals("Hello",StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("Yep, that's it");
            }
            else if (input.Equals("goodbye", StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("Later, dude!");
            }
            else
            {
                Console.WriteLine("Nope, try again");
            }
        }
    }
}
