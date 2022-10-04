using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _056_Check
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int a = rnd.Next(1, 100);
            int count = 0;
            for (; ; )
            {
                Console.Write("0~99사이 어떤 숫자일까요?(단, 0은 나가기)");
                int n = int.Parse(Console.ReadLine());
                count++;
                if(a == n)
                {
                    Console.WriteLine("=== 정답 ===");
                    Console.WriteLine("총 {0}번 시도", count);
                    break;
                }
                else if(a > n)
                {
                    Console.WriteLine("입력한 수는 작아요");
                }
                else if(a < n)
                {
                    Console.WriteLine("입력한 수는 커요");
                }
                else if(n == 0)
                {
                    break;
                }
            }
        }
    }
}
