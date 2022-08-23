using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _024_break_키워드
{
    class Program
    {
        static void Main(string[] args)
        {
            //break 키워드
            while (true)
            {
                Console.Write("숫자를 입력해주세요(짝수를 입력하면 종료): ");
                int input = int.Parse(Console.ReadLine());
                if(input % 2 == 0)
                {
                    break;
                }
            }

            //goto 키워드
            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine("외부 반복문");
                for (int j = 0; j < 10; j++) ;
                {
                    Console.WriteLine("내부 반목문");
                    goto doNotUse;
                }
            }

        doNotUse:
            Console.WriteLine("goto 키워드");
            //중첩 반복문을 한꺼번에 벗어나고 싶을 떄가 있을 것이다. c#에서는 goto 키워드를 사용하여 구현할 수 있다
            //하지만 goto 키워드는 현대 프로그래밍에서 사용되지 않는다 그래서 사용하지를 말기를 바란다 goto 키워드를 사용하면
            //스파게티 코드를 만들 수 있기때문에 좀 더 생각을 하여 중첩반복문을 탈출하는 것이 좋다!
        }
    }
}
