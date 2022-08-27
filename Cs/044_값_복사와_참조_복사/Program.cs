using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _044_값_복사와_참조_복사
{
    class Program
    {
        static void Change(int input)
        {
            input = 20;
        }

        static void Main(string[] args)
        {
            //C#의 모든 자료형은 값 또는 참조 두 가지로 나눌 수 있다.
            //지금까지 배웠던 내용으로 이를 구분한다면 int/float는 기본 자료형(Primitive Type)은 값이고
            //클래스로 만들어진 인스턴스(객체)는 참조이다.

            //일단 기본 자료형을 선언하는 경우이다.
            int a = 10;
            //선언하면 메모리에 곧바로 4바이트의 영역을 잡고 값이 들어간다.(스택에)
            Random a1 = new Random();
            //반면 객체를 선언할 때는 다음과 같은 형대가 된다. 일단 new Random()으로 인스턴스를 생성하면 인스턴스는 힙(Heap)이라는 영역에 위치를 잡습니다.
            //이때에 주소값이 변수 a에 들어가게 된다.

            //변수 자체에 객체의 값이 들어가는 것이 아니라, 객체의 메모리 위치를 나타나는 참조가 들어 가는 것인데요.
            //이러한 차이 때문에 메서드의 매개변수로 값과 참조를 전달할 때에, 미세하지만 큰 차이가 생깁니다.

            int a2 = 10;
            int input = a;
            input = 20;
            //이렇게 해도 10이 나온다
            Change(a);
            Console.WriteLine(a);
            //변수 a에 10을 넣었다 그리고 change() 메서드를 호출했다. 이떄 10이라는 값이 그대로 복사가 된다.
            //이후에 input을 20으로 바꾸면 결과적으로 변수 a와 변수 input은 독립적인 변수이므로 서로가 서로를 변경해도 영향을 주지 않는 것이다.
        }
    }
}
