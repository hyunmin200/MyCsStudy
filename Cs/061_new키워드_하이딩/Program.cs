using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _061_new키워드_하이딩
{
    class Animal
    {
        public virtual void Eat()
        {
            Console.WriteLine("냠냠 먹습니다.");
        }
    }

    class Dog : Animal //하이딩으로 변경합니다.
    {
        public new void Eat()
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
            //new 키워드를 사용한 하이딩은 어디에 사용할까?
            //굉장히 특이한 경우인데요. 그냥 부모의 것을 실행하고 싶은 것을 사용한다.
            //Dog 클래스의 Eat() 메서드를 하이딩으로 바꿔보자
            List<Animal> Animals = new List<Animal>()
            {
                new Dog(), new Cat(), new Cat(), new Dog(),
                new Dog(), new Cat(), new Dog(), new Dog()
            };

            foreach (var item in Animals)
            {
                item.Eat(); //Eat 메서드를 호출한다.
            }
            //이는 버전을 관리하는 등의 아주 특수한 경수에만 사용한다. 이전에 언급한 언급한 것처럼 오버라이딩부터 명확하게 이해한다.
        }
    }
}
