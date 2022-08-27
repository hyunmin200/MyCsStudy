using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _049_상속
{
    class Program
    {
        class Animal
        {
            public int Age { get; set; }

            public Animal() { this.Age = 0; }

            public void Eat() { Console.WriteLine("냠냠 먹습니다."); }
            public void Sleep() { Console.WriteLine("쿨쿨 잠을 잡니다."); }
            //이렇게 부모 클래스를 정의하면 자식 클래스에서 "나의 부모는 누구이다" 라고 이야기하면 된다 이때 ' : ' 기호를 사용한다.
        }

        class Dog : Animal
        {
            public string Color { get; set; }
            public void Bark() { Console.WriteLine("왈왈 짓습니다"); }
            //만약 자식 클래스에서 부모 클래스에서 정의한 멤버를 사용하고 싶다면 그냥 이렇게 사용해라
            //하지만 이름이 겹치거나 특수한 이유(이후 나오는 하이딩 등)가 발생해서 부모의 메서드에 접근을 할 수 없을 수 있다
            //이럴 때는 this 키워드와 같은 형태로 base 키워드를 사용한다. this가 자신을 나타내는 키워드라면 base는 부모를 나타내는 키워드 이다.
            public void Test()
            {
                Eat();
                Sleep();
                base.Sleep();//이런식으로 베이스를 사용한다.
                //부모에게서 상속받은 Eat() 메서드와 Sleep() 메서드를 호출한다.
            }
        }

        class Cat : Animal
        {
            public void Meow() { Console.WriteLine("냥냥 웁니다."); }
        }
        //이런 식으로 클래스의 부모 자식 관계가 형성되면 자식 클래스는 부모 클래스의 public 또는 protected멤버에 접근할 수 있다.
        //현재 부모의 모든 멤버가 public이므로 Dog 클래스의 인스턴스를 만들면 해당 인스턴스에서 자신의 멤버는 물론 부모의 멤버에 모두 접근 가능하다.(간단하쥬?)

        
        static void Main(string[] args)
        {
            //상속은 클래스 사이에 부모 자식 관계를 정의하는 작업이다.
            //부모 클래스 하나는 자식을 여러 개 가질 수 있고, 부모 자신이 가진 것을 자식에게 물려주게 된다.
            //지금 전에 Dog클래스와 Cat클래스에는 동일한 메서드가 있었다.
            //그렇기에 Animal이라는 부모 클래스를 만든다면 Animal의 공통의 요소를 넣고 Dog클래스와 Cat클래스에는 그 자신만의 메서드를 만들면 된다.
            //이렇게 중복되는 코드의 반복을 줄일 수 있다.
            //이후에 양쪽 모두에 추가를 하고 싶다? 라고 하면 Animal클래스에만 추가를 하면된다.
            //그럼 코드로 어떻게 나타낼까? 알아보자
            //Dog dog = new Dog();
            //dog.Bark();
        }
    }
}
