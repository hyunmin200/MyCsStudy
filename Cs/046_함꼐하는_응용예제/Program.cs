using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _046_함꼐하는_응용예제
{
    class Fibonacci
    {
        //public long Get(int i) //피보나치 수는 기하급수적으로 커지기 때문에 long 자료형을 사용하였다.
        //{
        //    if(i < 0) { return 0; }//종료조건
        //    if(i == 1) { return 1; }//종료조건
        //    return Get(i - 2) + Get(i - 1);
        //}
        //위에 코드는 전혀 문제가 없는 코드 이지만 인스턴스를 매 순간순간 만들어야 한다는 것은 코드 낭비가 될 수 있다.
        //위에 Get() 메서드를 클래스 메서드로 바꿔주면 조금 더 그럴듯한 코드가 될 것이다.
        public static long Get(int i)
        {
            if (i < 0) { return 0; }
            if (i == 1) { return 1; }
            if (i == 2) { return 1; }
            return Get(i - 2) + Get(i - 1);
        }
        //다음에 계속
    }

    class Program
    {
        static void Main(string[] args)
        {
            //이번 응용에서는 재귀 메서드를 알아 본다.
            //어떠한 메서드 내부에서 자기 자신을 호줄하게 되면, 이 메서드를 재귀 메서드라고 부른다.
            //Main(new string[0]); //자기 자신을 호출한다.
            //그런데 위처럼 메서드를 호출하게 된다면 자기 자신을 계속 호출하게 되어 종료되지 않는다 재귀 메서드는 항상 자기 자신을 탈출할 수 있는 종료 조건이 포함되어야 한다.
            //간단하게 피보나치 수를 만들어보며 재귀 메서드를 만들어 본다.
            //피보나치 수의 규칙 1, 2, 3, 5, 8, 13 처럼 앞에 두개를 더하여 다음 숫자가 나오는 수열이다.
            //피보나치 수의 규칙을 보면 n > 1일때 자기 자신을 계속 사용한다.
            Console.WriteLine(Fibonacci.Get(1));
            Console.WriteLine(Fibonacci.Get(2));
            Console.WriteLine(Fibonacci.Get(3));
            Console.WriteLine(Fibonacci.Get(4));
            Console.WriteLine(Fibonacci.Get(5));
        }
    }
}
