using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _003_복합_대입_연산자
{
    class Program
    {
        static void Main(string[] args)
        {
            //숫자와 관련된 복합 대입 연산자
            int output = 0;
            output += 52;
            output += 273;
            output += 103;

            Console.WriteLine(output);
            Console.WriteLine("");

            //숫자와 관련된 복합 대입 연산자 다른 방식
            int output1 = 0;
            output1 = output1 + 52;
            output1 = output1 + 273;
            output1 = output1 + 103;

            Console.WriteLine(output);
            Console.WriteLine("");

            //문자열과 관련된 복합 대입 연산자
            string output2 = "hello ";
            output2 += "world";
            output2 += "!";

            Console.WriteLine(output2);
            Console.WriteLine("");

            //문자열과 관련된 복합 대입 연산자 예제 풀어쓰기
            string output3 = "hello ";
            output3 = output3 + "world";
            output3 = output3 + "!";

            Console.WriteLine(output3);
            Console.WriteLine("");

            //증갑 연산자
            int number = 10;
            number++;
            Console.WriteLine(number);
            number--;
            Console.WriteLine(number);
            Console.WriteLine("");

            //증갑 연산자 후위 형태
            int number1 = 10;
            Console.WriteLine(number1);
            Console.WriteLine(number1++);
            Console.WriteLine(number1--);
            Console.WriteLine(number1);
            Console.WriteLine("");

            //증갑 연산자 전위 형태
            int number2 = 10;
            Console.WriteLine(number2);
            Console.WriteLine(++number2);
            Console.WriteLine(--number2);
            Console.WriteLine(number2);
            Console.WriteLine("");
        }
    }
}
