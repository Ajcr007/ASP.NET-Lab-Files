using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ajin
{
    internal class Conditional
    {
        static void Main(string[] args)
        {
            int a = 30, b = 50, c = 10;
            if (a > b && a > c)
            {
                Console.WriteLine("a is the greatest number.");
            }
            else if (b > a && b > c)
            {
                Console.WriteLine("b is the greatest number");
            }
            else
            {
                Console.WriteLine("c is the greatest number");
            }
        }
    }
}
