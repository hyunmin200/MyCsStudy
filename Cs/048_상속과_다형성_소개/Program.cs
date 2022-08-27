using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _048_상속과_다형성_소개
{
    class Program
    {
        //강아지와 고양이를 나타내는 클래스를 만들어보자
        //추상화 해서 만들어보자
        //강아지
        class Dog
        {
            public int Age { get; set; }
            public string Color { get; set; }

            public Dog() { this.Age = 0; }

            public void Eat() { Console.WriteLine("냠냠 먹습니다."); }
            public void Sleep() { Console.WriteLine("쿨쿨 잠을 잡니다."); }
            public void Bark() { Console.WriteLine("왈왈 짓습니다."); }
        }

        //고양이
        class Cat
        {
            public int Age { get; set; }

            public Cat() { this.Age = 0; }

            public void Eat() { Console.WriteLine("냠냠 먹습니다."); }
            public void Sleep() { Console.WriteLine("쿨쿨 잠을 잡니다."); }
            public void Meow() { Console.WriteLine("냥냥 웁니다."); }
        }
        static void Main(string[] args)
        {
            //클래스기반의 클래스 지향 언어에서 가장 중요한 특징은 바로 상속과 다형성 이다.
            //클래스 기반의 클래스 지향 프로그래밍 언어를 공부할 때에 가장 어려운 부분이라고 한다.
            //기본을 공부하는 입장이기에 100%가 아니라  이런게 있구나 하고 넘어가자
            //이제 프로그램 내부에서 강아지와 고양이가 뛰어 놀게 해보자
            //여러 마리의 강아지와 고양이를 다루려면 배열이나 리스트를 사용하는 것이 편하다.
            List<Dog> Dogs = new List<Dog>() { new Dog(), new Dog(), new Dog() };
            List<Cat> Cats = new List<Cat>() { new Cat(), new Cat(), new Cat() };

            foreach(var item in Dogs)
            {
                item.Eat();
                item.Sleep();
                item.Bark();
            }

            foreach (var item in Cats)
            {
                item.Eat();
                item.Sleep();
                item.Meow();
            }
            //이 코드를 보면 의미없이 반복이 된 부분이 많다. 프로그래밍에서는 의미없이 반복되는 부분을 줄이는 것이 좋다.
            //복사 붙여넣기는 많아지면 생상성과 유지보수측면에서 어렵다.
            //그래서 코드의 반복을 줄여 코드를 깔끔하게 만드는 것은 생산성과 유지 보수의 측면에서 굉장히 중요한 작업이다.
            //그래서 C#에서 반복을 줄이기 위해 사용하는 방법이 바로 상속과 다향성이다.
            //이제 코드의 반복을 어떻게 줄이는지 차근차근 알아가보자.
        }
    }
}
