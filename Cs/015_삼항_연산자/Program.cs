using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _015_삼항_연산자
{
    class Program
    {
        static void Main(string[] args)
        {
            //삼항 연산자를 이용한 자연수 판별
            //변수를 선언합니다.
            string input = Console.ReadLine();
            int number = int.Parse(input);

            //조건을 구분합니다.
            Console.WriteLine(number > 0 ? "자연수입니다" : "자연수가 아닙니다");
        }
    }
}
