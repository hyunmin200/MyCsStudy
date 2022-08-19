using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _001_출력
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write_WriteLine
            //줄바꿈 없음
            Console.Write("Console.Write!");
            //줄바꿈 있음
            Console.WriteLine("Console.WriteLine");
            Console.WriteLine("");

            //비교
            Console.WriteLine("비교");
            Console.WriteLine("Console.WriteLine");
            Console.Write("Console.Write");
            Console.Write("Console.Write");
            Console.WriteLine("Console.WriteLine");
            Console.WriteLine("");

            // Hello World 예제
            Console.WriteLine("C# Programming...!");
            Console.WriteLine("");

            //integer 예제
            Console.WriteLine(52);
            Console.WriteLine("");

            //정수 덧셈 연산자
            // 325를 출력한다.
            Console.WriteLine(325);
            Console.WriteLine("");

            //연산자 우선순위
            //결과를 예측해봅니다.
            Console.WriteLine(5 + 3 * 2);
            //*가 우선순위가 +보다 높기때문에 11이 나온다.
            //16만 나오게 하려면
            Console.WriteLine((5 + 3) * 2);
            Console.WriteLine("");

            //나머지 연산자
            Console.WriteLine(10 % 5); //나머지가 없다
            Console.WriteLine(7 % 3); //나머지가 있다
            Console.WriteLine("");

            //정수와 연산자
            Console.WriteLine(1 + 2);
            Console.WriteLine(1 - 2);
            Console.WriteLine(1 * 2);
            Console.WriteLine(1 / 2); // 정수로 연산하였기 때문에 0이 나옴
            Console.WriteLine(1 % 2);
            Console.WriteLine("");

            //음수와 나머지 연산자
            //나머지 연산자의 부호는 왼쪽 피연산자의 부호를 따른다.
            //오른쪽 피연산자의 부호는 전혀 상관이 없으니 주의!
            Console.WriteLine(4 % 3);
            Console.WriteLine(-4 % 3);
            Console.WriteLine(4 % -3);
            Console.WriteLine(-4 % 3);
            Console.WriteLine("");

            //실수
            Console.WriteLine(52.733);
            Console.WriteLine("");

            //정수와 실수
            Console.WriteLine(0);
            Console.WriteLine(0.0);
            Console.WriteLine("");

            //실수와 사칙 연산자
            Console.WriteLine(1.0 + 2.0);
            Console.WriteLine(1.0 - 2.0);
            Console.WriteLine(1.0 * 2.0);
            Console.WriteLine(1.0 / 2.0);
            Console.WriteLine(5.0 % 2.2);
            Console.WriteLine("");
        }
    }
}
