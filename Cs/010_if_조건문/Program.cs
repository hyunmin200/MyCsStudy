using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _010_if_조건문
{
    class Program
    {
        static void Main(string[] args)
        {
            //홀수 짝수 구분(1)
            Console.Write("숫자 입력: ");
            int input = int.Parse(Console.ReadLine());

            if(input % 2 == 0)
            {
                Console.WriteLine("짝수 입니다");
            }
            if(input % 2 == 1)
            {
                Console.WriteLine("홀수 입니다.");
            }

            //중괄호의 사용 방식(1)
            if (true)
            {

            }
            //중괄호의 사용 방식(2)
            if (true) {

            }

            //현재 시간 구하기
            Console.WriteLine("현재 시간 구하기");
            Console.WriteLine(DateTime.Now.Year);
            Console.WriteLine(DateTime.Now.Month);
            Console.WriteLine(DateTime.Now.Day);
            Console.WriteLine(DateTime.Now.Hour);
            Console.WriteLine(DateTime.Now.Minute);
            Console.WriteLine(DateTime.Now.Second);

            //오전과 오후 구분하기
            if(DateTime.Now.Hour < 12)
            {
                Console.WriteLine("오전입니다.");
            }

            if(12 <= DateTime.Now.Hour)
            {
                Console.WriteLine("오후입니다.");
            }
        }
    }
}
