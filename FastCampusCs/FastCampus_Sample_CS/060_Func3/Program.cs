using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _060_Func3
{
    internal class Program
    {

        static int Square(int i)
        {
            int input = i;
            return input * input;
        }
        static void Main(string[] args)
        {
            int a = 2;
            int resultA = Square(a); 
            Console.WriteLine("resultA: " + resultA);

            int b = 4;
            int resultB = Square(a);
            Console.WriteLine("resultA: " + resultB);

            int resultC = Square(3);
            Console.WriteLine("resultA: " + resultC);

            resultC = Square(resultA * 3);
            Console.WriteLine("resultA: " + resultC);
        }
    }
}
