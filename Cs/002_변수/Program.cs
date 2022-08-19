using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _002_변수
{
    class Program
    {
        static void Main(string[] args)
        {
            //정수 변수 생성
            int a = 273;
            int b = 52;

            Console.WriteLine(a + b);
            Console.WriteLine(a - b);
            Console.WriteLine(a * b);
            Console.WriteLine(a / b);
            Console.WriteLine(a % b);
            Console.WriteLine("");

            //오버 플로우
            int a1 = 2147483640;
            int b1 = 52273;
            //인트의 자료형을 초과함
            Console.WriteLine(a1 + b1);
            Console.WriteLine("");

            //오버 플로우 2
            int a2 = 2000000000;
            int b2 = 1000000000;
            Console.WriteLine(a + b);
            Console.WriteLine("");

            //자료형 변환을 사용한 해결 방법 3가지
            //uint 와 ulong 자료형
            uint unsignedInt = 4147483647;
            ulong unsignedLong = 11223372036854775808;

            Console.WriteLine(unsignedInt);
            Console.WriteLine(unsignedLong);
            Console.WriteLine("");

            //int 자료형의 최댓값과 최소값
            Console.WriteLine(int.MaxValue);
            Console.WriteLine(int.MinValue);
            Console.WriteLine("");

            //long 자료형의 최댓값과 최소값
            Console.WriteLine(long.MaxValue);
            Console.WriteLine(long.MinValue);
            Console.WriteLine("");

            //실수 변수 생성
            double a3 = 12.36;
            double b3 = 34.56;

            Console.WriteLine(a3 + b3);
            Console.WriteLine(a3 - b3);
            Console.WriteLine(a3 * b3);
            Console.WriteLine(a3 / b3);
            Console.WriteLine(a3 % b3);
            Console.WriteLine("");

            //문자 변수 생성
            char a4 = 'a';
            Console.WriteLine(a4);
            Console.WriteLine("");
            //C#에서는 char형은 2바이트임 sizeof()로 알 수 있음
            Console.WriteLine("int: " + sizeof(int));
            Console.WriteLine("long: " + sizeof(long));
            Console.WriteLine("float: " + sizeof(float));
            Console.WriteLine("double: " + sizeof(double));
            Console.WriteLine("char: " + sizeof(char));
            Console.WriteLine("");

            //문자 자료형과 연산자
            char a5 = 'a';
            char b5 = 'b';

            Console.WriteLine(a5 + b5);
            Console.WriteLine(a5 - b5);
            Console.WriteLine(a5 * b5);
            Console.WriteLine(a5 / b5);
            Console.WriteLine(a5 % b5);
            Console.WriteLine("");

            //문자열 변수 생성
            string message = "안녕하세요";

            Console.WriteLine(message + "!");
            Console.WriteLine(message[0]);
            Console.WriteLine(message[1]);
            Console.WriteLine(message[2]);
            Console.WriteLine("");
            //문자열은 sizeof 연산자로 자료형의 크기를 구할 수 없다.

            //불 자료형
            bool one = 10 < 0;
            bool other = 20 > 100;

            Console.WriteLine(one);
            Console.WriteLine(other);
            Console.WriteLine("");
        }
    }
}
