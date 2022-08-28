using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _059_활용_하이딩
{
    class Program
    {
        class Animal
        {
            public void Eat()
            {
                Console.WriteLine("냠냠 먹습니다");
            }
        }

        class Dog : Animal
        {
            public void Eat()
            {
                Console.WriteLine("강아지 사료를 먹습니다");
            }
        }

        class Cat : Animal
        {
            public void Eat()
            {
                Console.WriteLine("고양이 사료를 먹습니다");
            }
        }

        static void Main(string[] args)
        {
            List<Animal> Animals = new List<Animal>()
            {
                new Dog(), new Cat(), new Cat(), new Dog(),
                new Dog(), new Cat(), new Dog(), new Dog()
            };

            foreach(var item in Animals)
            {
                item.Eat(); //Eat 메서드를 호출한다.
            }
            //하이딩과 오버라이딩 중에 어떤 것을 사용하고 있는지 구분할 수 있을까? 하이딩을 사용하고 있다.
            //따로 new 키워드를 적지 않았으므로 경고는 발생합니다. 그래도 실행은 당연히 되며 다음과 같이 출력합니다.
            //하이딩했으므로 부모의 메서드만 실행하게 되는 것이다.
            //강아지는 강아지 사료를 먹고 고양이는 고양이 사료를 먹게 하고 싶다면 어떻게 해야 할까요?
            //간단하게 오버라이딩하면 된다.
        }
    }
}
