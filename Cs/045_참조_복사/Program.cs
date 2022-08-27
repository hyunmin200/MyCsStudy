using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _045_참조_복사
{
    class Program
    {
        class Test
        {
            public int value = 10;
        }

        static void Change(Test input)
        {
            input.value = 20;
        }
        static void Main(string[] args)
        {
            Test test = new Test();
            test.value = 10;
            Change(test);
            Console.WriteLine(test.value);
            //메서드 내부에서 변경한 객체의 값이 원래 객체의 값에 영향을 준것이다.
            //이때 어떤 과정이 일어나는지 살펴본다면 일단 객체는 변수에 값이 아니라 참조(객체의 메모리 위치를 나타내는 주소)가 들어가게 된다.
            //메서드를 호출할 때도 참조가 복사 된다.
            //이후에 Change() 메서드 내부에서 test.value를 변경하면 힙이라는 공간에 있는 value가 변경이 된다.
            //결과적으로 이후에 Main() 메서드에서 test.value를 출력하면 20이 출력되는 것이다.
        }
    }
}
