using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _064_Func_default
{
    internal class Program
    {
        //뒤에서부터 순차적으로 초기화
        static void PrintValue(int a, int b, int c = 100, int d = 0)
        {
            Console.WriteLine("PrintValue: {0}  {1}  {2}  {3}", a, b, c, d);
        }

        static void Main(string[] args)
        {
            PrintValue(0, 0, 0, 0);
            PrintValue(100, 2, 1);
            PrintValue(300, 300);
        }
    }
}
