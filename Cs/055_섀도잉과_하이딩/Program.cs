using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _055_섀도잉과_하이딩
{
    class Program
    {
        class Parent
        {
            public int variable = 273;
        }
        class Child : Parent
        {
            public string variable = "shadowing";
        }
        //섀도잉
        //일단 다음 코드를 살펴봅시다. 다음 코드는 어떤 결과를 출력할까?
        public static int number = 10;
        static void Main(string[] args)
        {
            //변수에 같은 이름을 사용하면 이름 사이에 이름 충돌이 발생하게 된다.
            //이러한 것을 이름을 재사용이라고 부르며 다음과 같은 종류가 있다.
            // 오버로딩, 오버라이딩, 섀도잉, 하이딩, 업스큐어링
            //오버로딩은 같은 이름을 사용해서 메서드를 여러 개 만드는 방법으로 이전에 살펴보았다.
            //이번에는 섀도잉과 하이딩을 살펴보고 다음 절에는 오버라이딩까지 살펴보자.
            //참고로 일부 개발자들은 오버라이딩을 제외한 이름 재사용을 모두 하지 않는 것이 좋다고 주장한다.
            //이름을 재사용하면 코드를 이해하기가 어렵기 때문이다.
            //지금 부터 설명하는 내용도 쓸데없이 꼬는 느낌이라고 생각할 수 있다.
            int number = 20;
            Console.WriteLine(number);
            //C언어 기반의 프로그래밍 언어 대부분은 변수의 이름이 겹칠 때 자신과 가장 가까운 변수를 사용하게 되어 있다.
            //Console.WriteLine(number); 부분에서 가장 가까운 부분은 일단 메서드 내부이다 그렇기에 20을 출력한다.
            //이렇게 특정한 영역에서 이름이 겹쳐서 다른 변수를 가리는 것을 섀도잉(shadowing)이라고 표현한다.
            //어떤 대상이 섀도잉되면 일반적인 방법으로는 가려진 변수에 접근할 수 없다.

            //하이딩
            //부모 클래스와 자식 클래스 사이에 동일한 이름으로 멤버를 만들면 이때에는 조금 다른 용어를 사용한다. 바로 하이딩(Hiding)입니다.
            //일단 변수 하이딩을 살펴보자. 이 코드에는 부모와 자식 클래스에 모두 variable이라는 변수가 있다.
            //Main() 메서드에서는 Child 클래스의 인스턴스를 생성하고 출력한다.
            Child child = new Child();
            Console.WriteLine(child.variable);
            //이전과 마찬가지로 자신과 가장 가까운 것을 사용한다. Child 클래스는 자신과 가까운 클래스 내부의 문자열 변수를 사용하므로 "shadowing"을 출력한다.
            //하이딩을 하면 정상적인 상속을 막을 수 있다.
            //만약 부모에 있는 int 자료형의 변수를 사용하고 싶다면 어떻게 할까?
            //이러한 경우에는 다음과 같이 부모로 자료형을 변환하고 사용하면 된다.
            Console.WriteLine(((Parent)child).variable);
            //이제는 메서드를 하이딩 해본다.
        }
    }
}
