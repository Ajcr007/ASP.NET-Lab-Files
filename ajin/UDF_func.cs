using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ajin
{
    internal class UDF_func
    {
        static void SwapValues(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }

        static void Main()
        {
            int x = 5;
            int y = 10;
            Console.WriteLine($"Before swapping: x = {x}, y = {y}");

            //call the function with pass-by-value using the ref keyword
            SwapValues(ref x, ref y);

            Console.WriteLine($"After swapping: x = {x}, y = {y}");
        }
    }
}
