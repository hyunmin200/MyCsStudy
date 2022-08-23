using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _023_중첩_반복문
{
    class Program
    {
        static void Main(string[] args)
        {
            //별 피라미드(1)
            for(int i = 0; i < 10; i++)
            {
                for(int j = 0; j < i + 1; j++)
                {
                    Console.Write('*');
                }
                Console.Write('\n');
            }

            //별 피라미드(2)
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10 - i; j++)
                {
                    Console.Write(' ');
                }
                for (int j = 0; j < i + 1; j++)
                {
                    Console.Write('*');
                }
                Console.Write("\n");
            }
        }
    }
}
