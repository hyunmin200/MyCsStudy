using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _054_상속의_생성자
{
    class Program
    {
        class Parent
        {
            public Parent() { Console.WriteLine("Parent"); }
            public Parent(int param) { Console.WriteLine("Parent(int param)"); }
            public Parent(string param) { Console.WriteLine("Parent(string param)"); }
        }
        class Child : Parent
        {
            public Child() : base(10) //base 키워드를 사용한다.
            {
                Console.WriteLine("Child() : base(10)");
            }
            public Child(string input) : base(input)
            {
                Console.WriteLine("Child(string input) : base(input)");
            }
        }
        static void Main(string[] args)
        {
            //이제 상속 또는 다형성에 대한 내용을 조금 더 깊게 알아본다.
            //일단 상속했을 때 생성자 메서스가 어떻게 되는지와 관련된 내용이다.
            //생성자는 인스턴스를 초기화할 때 사용합니다. 자식 인스턴스를 생성하면,
            //부모가 가지고 있는 멤버 초기화를 위해 부모 생성자도 자동으로 호출됩니다.

            //상속했을 때 기본적인 생성자 호출 순서
            //Child child = new Child(); //자식 인스턴스 생성
            //만약 부모 생성자 호출 명시적으로 지정하고 싶은 때 base 키워드를 사용합니다.
            //생성자 메서드 뒤에 콜론을 입력하고 base()를 입력합니다.
            //현재 부모 생성자 메서드에 매개변수 없으므로 괄호 안에는 아무것도 넣어주지 않았습니다.
            Child childA = new Child();
            Child childB = new Child("string");
            //생성자는 인스턴스를 생성하는 가장 첫 단계이다. 상속을 할 때 생성자를 제대로 사용할 수 없으면 안 된다
            //생성자 호출 순서와 방법을 기억하자
        }
    }
}
