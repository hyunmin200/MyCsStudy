using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _060_활용_오버라이딩
{
    class Animal
    {
        public virtual void Eat()
        {
            Console.WriteLine("냠냠 먹습니다.");
        }
    }

    class Dog : Animal
    {
        public override void Eat()
        {
            Console.WriteLine("강아지 사료를 먹습니다.");
        }
    }

    class Cat : Animal
    {
        public override void Eat()
        {
            Console.WriteLine("고양이 사료를 먹습니다");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Animal> Animals = new List<Animal>()
            {
                new Dog(), new Cat(), new Cat(), new Dog(),
                new Dog(), new Cat(), new Dog(), new Dog()
            };

            foreach (var item in Animals)
            {
                item.Eat(); //Eat 메서드를 호출한다.
            }
            //자식들이 가지고 있는 메서드를 사용하게 된다.
            //자바와 같은 대부분의 다른 클래스 지향 언어들을 메서드 하이딩을 지원하지 않습니다.
            //이전과 같이 이 말은 어떻게 보면 하이딩이 없어도 프로그래밍하는데 지장이 없다거나
            //하이딩은 굉장히 예외적인 경우에 사용한다고 할 수 있다.
            //일단은 오버라이딩을 어떠한 방법으로 하고 결과적으로 어떤 일이 일어나는지를 이해한다.
        }
    }
}
