using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _014_Switch_조건문
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("숫자를 선언하세요");
            int input = int.Parse(Console.ReadLine());

            //조건문
            switch (input % 2)
            {
                case 0:
                    Console.WriteLine("짝수입니다.");
                    break;
                case 1:
                    Console.WriteLine("홀수입니다.");
                    break;
            }

            //break 키워드를 사용하지 않는 switch 조건문
            // 변수를 선언합니다.
            Console.WriteLine("이번 달은 몇 월인가요");
            int input1 = int.Parse(Console.ReadLine());

            switch (input)
            {
                case 12:
                case 1:
                case 2:
                    Console.WriteLine("겨울입니다.");
                    break;
                case 3:
                case 4:
                case 5:
                    Console.WriteLine("봄입니다.");
                    break;
                case 6:
                case 7:
                case 8:
                    Console.WriteLine("여름입니다.");
                    break;
                case 9:
                case 10:
                case 11:
                    Console.WriteLine("가을입니다.");
                    break;
                default:
                    Console.WriteLine("당신은 어떤 행성에 살고 계신가요?");
                    break;
            }
        }
    }
}
