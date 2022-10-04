using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _055_Check
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int count = 0;
            
            int sum = 0;
            for(int i = 0; i < 5; i++)
            {
                int a = rnd.Next(1, 100);
                int b = rnd.Next(1, 100);
                Console.WriteLine("{0}: 다음 두 수의 합은 몇?(총 5문제)", i);
                Console.WriteLine("{0} + {1} = ??", a, b);
                sum = a + b;
                int n = int.Parse(Console.ReadLine());
                if(n == sum)
                {
                    Console.WriteLine("==정답==");
                    count++;
                }
                else
                {
                    Console.WriteLine("오답(정답은: {0})", sum);
                }
                sum = 0;
            }
            Console.WriteLine("{0}개 맞추셨습니다.", count);
        }
    }
}
