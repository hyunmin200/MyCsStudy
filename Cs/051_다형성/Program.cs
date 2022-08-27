using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _051_다형성
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
        }
        class Cat : Animal
        {
            public void Meow() { Console.WriteLine("냥냥 웁니다."); }
        }

        static void Main(string[] args)

        {
            //상속을 사용하여 클래스 구현 부분의 코드 중복을 해결하였다
            //이제 다시 Main() 메서드를 살펴보자 Main() 메서드를 보면 다음과 같이 코드가 중복되는 것을 볼 수 있다.
            //List<Dog> Dogs = new List<Dog>();
            //List<Cat> Cats = new List<Cat>();
            //비슷한 코드 중복

            //foreach (var item in Dogs)
            //{
            //    item.Eat();
            //    item.Sleep();
            //    item.Bark();
            //    //비슷한 코드 중복
            //}

            //foreach (var item in Cats)
            //{
            //    item.Eat();
            //    item.Sleep();
            //    item.Meow();
            //    //비슷한 코드 중복
            //}
            //여기서 동물의 종류를 늘리면 어떻게 될까? 그럼 너무 반복문이 많아져서 힘들어진다.
            //이럴때 코드 중복을 해결할 수 있는 것이 다형성이다. 다형성은 하나의 클래스가 여러 형태로 변환될 수 있는 성질이라고 정의한다.
            //간단하게 지식 클래스가 부모 클래스로 위장하는 것으로 알아두길 바란다.
            //예를 들어 다음과 같은 코드이다.
            //Animal dog = new Dog();
            //Animal cat = new Cat();
            //변수 Dog는 외관상으로는 자료형이 Animal이지만 실제 내부에서는 Dog가 들어가 있다.
            //그래서 외관상으로는 Animal 클래스이므로 사용할 수 있는 멤버는 Animal 클래스의 멤버 뿐이다!
            //부모로 위장한 자식은 부모의 멤버만 사용 가능
            //이렇게 부모로 위장하면 하나의 Animal 배열 또는 리스트에 여러 Dog 클래스와 Cat 클래스를 넣을 수 있다. 따라서 코드의 중복을 제거 할 수 있다.

            List<Animal> Animals = new List<Animal>()
            {
                new Dog(), new Cat(), new Cat(), new Dog(),
                new Dog(), new Cat(), new Dog(), new Dog()
            };

            foreach (var item in Animals)
            {
                item.Eat();
                item.Sleep();
                //이러니 코드가 엄청 간략해졌다.
                //그런데 만약 Animal 리스트가 들어있는 요소들이 Dog클래스라면 Bark() 메서드를 호출하고 Cat클래스라면 Meow() 메서드를 호출하게 만들려면 어떻게 해야 할까?
                //바로 전에 부모로 위장한 자식은 부모의 멤버만 사용할 수 있다고 하였다.
                //Dog클래스에 있는 Bark() 메서드 또는 Cat클래스에 있는 Meow() 메서드를 사용할 수 없다.
                //이렇게 자식 클래스에 있는 메서드를 사용하려면, 자식 클래스로 자료형을 바꿔 줘야한다.
                //((Dog)item).Bark();
                //((Cat)item).Meow();
                //하지만 이렇게 막 선언을 해버린다면 변수 item내부에 들어있는 실질적인 자료인
                //Dog를 Cat으로 변환을 할 수가 없어서 예외가 발생한다.
                //변수 item이 Cat클래스라면 문제가 없지만 Dog클래스일 때 이런 예외가 발생한다.
                //그렇기에 내부에 조건문을 넣어서 Dog클래스이면 Dog클래스로 변환해서 Bark() 메서드를 호출하고,
                //Cat클래스라면 Cat클래스로 변환해서 Meow() 메서드를 호출해야 한다.
                //그런데 어떤식으로 item이 Dog클래스 인지 Cat클래스인지 확인할 수 있을까 다음에 알아본다.
            }
        }
    }
}
//최상위 클래스
//클래스를 만들고 사용하다가 보면 우리가 만든적이 없는 메서드가 포함되어 있다 이런 메서드들은 C# 최상위에 있는 메서드 이다.
//따로 상속을 사용하지 않아도 C#에서 만드는 모든 클래스는 Object라는 클래스의 상속을 받게 된다.
//Object 클래스의 선언을 살펴보면 public 접근 제한자가 붙은 메서드들이 상속되는 것들이다.
