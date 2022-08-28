using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _057_하이딩과_오버라이딩
{
    class Program
    {
        class Parent
        {
            public int variable = 273;
            public void Method()
            {
                Console.WriteLine("부모의 메서드");
            }
        }

        class Child : Parent
        {
            public new string variable = "hiding"; //new 키워드를 사용해 변수를 하이딩하겠다고 선언한다
            public new void Method() //new 키워드를 사용해 메서드를 하이딩하겠다고 선언
            {
                Console.WriteLine("자식의 메서드");
            }
        }

        static void Main(string[] args)
        {
            //C# 부모 클래스와 자식 클래스 멤버의 이름을 동일하게 작성할 때 하이딩 또는 오버라이딩되므로 이를 명확하게 구분하라는 것이다.
            //하이딩은 좀 전에 살펴본 것처럼 부모 클래스와 자식 클래스에 동일한 이름으로 멤버를 만들때 발생한다.
            //그런데 하이딩과 같은 형태로 메서드를 작성하고 앞에 virtual이라는 키워드를 붙이면 이는 오버라이딩이라고 부른다.
            //오버라이딩(overriding)은 부모 클래스에 있는 메서드를 자식 클래스에서 다시 구현하는 것을 의미한다.
            //이름 재사용의 일종으로 방금 살펴보았던 하이딩과 자주 혼동되는 내용이다. 하이딩과 오버라이딩 확실하게 구분한다.
            //하이딩은 멤버 전체(변수, 메서드 등)에서 모두 일어나지만, 오버라이딩은 메서드와 관련되어서만 일어난다.

            //new 메서드
            //부모 클래스의 멤버와 자식 클래스의 멤버가 서로 이름이 같으면 하이딩된다.
            //그리고 하이딩을 한다는 것을 명확하게 표시하고자 메서드 이름 앞에 new 키워드 붙인다.
            Child child = new Child();
            child.Method();
            ((Parent)child).Method();
            //하이딩은 '같은 이름으로 멤버를 만들어 부모의 멤버를 숨긴다'고 간단하게 표현할 수 있습니다.
            //숨겨져 있는 뿐이므로 클래스형을 변환하는 등의 작업을 하면 숨겨진 멤버를 찾을 수 있다.
            
            
        }
    }
}
