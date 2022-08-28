using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _058_override_메서드
{
    class Program
    {
        class Parent
        {
            public virtual void Method() //부모의 메서드에 virtual 키워드를 적용합니다.
            {
                Console.WriteLine("부모의 메서드");
            }
        }

        class Child : Parent
        {
            public override void Method() //자식의 메서드에 override 키워드를 적용합니다.
            {
                Console.WriteLine("자식의 메서드");
            }
        }

        static void Main(string[] args)
        {
            Child child = new Child();
            child.Method();
            ((Parent)child).Method();
            //이렇게 하고 실행을 하면 다음과 같은 결과가 나온다.
            //이전의 new 키워드를 사용한 하이딩과 전혀 다른 결과가 나오는 걸 알수있다.
            //이는 자식의 메서드가 부모 메서드를 완전히 덮어씌워 부모로 클래스형을 변환했으므로,
            //호출을 해도 덮어씌운 것 때문에 다른 결과가 나오는 것이다.
            //이처럼 오버라이딩하면 클래스형을 어떻게 변환해도 자식에서 다시 정의한 메서드가 호출된다.
        }
    }
}
