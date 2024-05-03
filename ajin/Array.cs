using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ajin
{
    internal class Array
    {
        static void Main(String[] args)
        {
            int[] a = new int[5]; //creating new array
            a[0] = 10; //initializing array
            a[2] = 20;
            a[4] = 30;

            //traversing the array
            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine(a[1]);
            }
            Console.WriteLine("Jagged array");
            int[][] b = new int[2][];

            b[0] = new int[] {11, 21, 56, 78 };
            b[1] = new int[] {42, 61, 378, 41, 59, 63};

            //Traverse array elements
            for (int i = 0;i < b.Length;i++)
            {
                for (int j = 0; j < b[i].Length; j++)
                {
                    System.Console.WriteLine(b[i][j] + " ");
                }
                System.Console.WriteLine();
            }
        }
    }
}
