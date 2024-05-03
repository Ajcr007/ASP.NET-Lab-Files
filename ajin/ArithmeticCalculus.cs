using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ajin
{
    public class ArithmeticCalculus
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Arithmetic Operations");
            int a = 20; int b = 10;
            int sum = 0, mul = 0, rem = 0, sub = 0;
            float div = 0;
            sum = a + b;
            mul = a * b;
            rem = a % b;
            sub = a - b;
            div = a / b;
            Console.WriteLine("The sum is :" + sum);
            Console.WriteLine("The product is :" + mul);
            Console.WriteLine("The division is :" + div);
            Console.WriteLine("The reminder is :" + rem);
            Console.WriteLine("The difference is :" + sub);
        }
    }
}
