using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _011_if_else_조건문
{
    class Program
    {
        static void Main(string[] args)
        {
            //홀수 짝수 구분하기
            Console.Write("숫자 입력: ");
            int input = int.Parse(Console.ReadLine());

            if (input % 2 == 0)
            {
                Console.WriteLine("짝수 입니다");
            }
            else
            {
                Console.WriteLine("홀수 입니다.");
            }

            //오전과 오후 구분하기
            if (DateTime.Now.Hour < 12)
            {
                Console.WriteLine("오전입니다.");
            }

            else
            {
                Console.WriteLine("오후입니다.");
            }
        }
    }
}
