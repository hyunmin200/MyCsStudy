using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _056_메서드_하이딩
{
    class Program
    {
        //이번에는 메서드 하이딩을 해보겠다
        class Parent
        {
            public void Method()
            {
                Console.WriteLine("부모의 메서드");
            }
        }

        class Child : Parent
        {
            public void Method()
            {
                Console.WriteLine("자식의 메서드");
            }
        }
        
        static void Main(string[] args)
        {
            Child child = new Child();
            child.Method();
            ((Parent)child).Method();
            //실행 결과는 어느 정도 예측 할 수 있을 것이다.
            //실행도 정상적으로 된다. 하지만 개발 환경을 보면 경고가 뜬다.
            //Child.Method()은 상속된 Parent.Method() 멤버를 숨긴다. 숨기려면 new키워드를 사용하라고 되어있다.
            //일단 앞의 말은 Method() 메서드가 하이딩되었다는 말이다.
            //뒤에 말은 무슨 뜻일까? 매서드는 변수와 다르게 충돌이 발생할 때 하이딩할지 오버라이딩할지를 결정할 수 있다.
            //하이딩과 오버라이딩이 무엇이고 각각을 사용할 때 어떤 일이 일어나는지 다음에 알아보겠다.
        }
    }
}
