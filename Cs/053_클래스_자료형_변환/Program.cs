using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _053_클래스_자료형_반환
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
    class Program
    {
        static void Main(string[] args)
        {
            //부모로 위장한 자신이 누군지 정체성을 깨달았다면 이제 남은 것은 자신으로 돌아가는 것이다.
            //C#은 클래스 자료형을 변환할 때 다음 두 가지 방법을 제공한다.
            //1.일반적인 자료형 변환
            //(클래스) 변수
            List<Animal> Animals = new List<Animal>()
            {
                new Dog(), new Cat(), new Cat(), new Dog(),
                new Dog(), new Cat(), new Dog(), new Dog()
            };

            foreach (var item in Animals)
            {
                item.Eat();
                item.Sleep();

                if (item is Dog) { ((Dog)item).Bark(); }
                if (item is Cat) { ((Cat)item).Meow(); }
                //is키워드를 사용한 부분에 자료형 변환과 메서드 호출 부분을 추가한다.
                //이번에는 자료형을 확인하고 변환하므로 예외가 발생하지 않는다.
                //item클래스가 Dog라면 Bark() 메서드를 Cat이라면 Meow() 메서드를 호출하게 된다.
            }
            
            foreach (var item in Animals)
            {
                item.Eat();
                item.Sleep();

                //as 키워드로 자료형 변환
                //C#은 as라는 키워드를 사용해서 자료형을 변환할 수있다. 이전에 본 자료형 변환에서는 변환에 실패하면 예외가 발생하지만
                //as 키워드를 사용해 자료형을 변환하면 변환에 실패를해도 예외가 발생하지는 않는다.
                //그저 변환에 실패를 하였기 때문에 null을 넣게 된다.
                //as 키워드를 사용해 변환 할 때는 다음과 같은 구문사용한다.
                //변수 as 클래스
                //if(item in Dog) { (item as Dog).Bark(); }
                //if(item in Cat) { (item as Cat).Meow(); }
                //이런 경우에는 as키워드를 사용할 필요가없다.
                //사전에 is 키워드 사용해서 어떤 클래스의 클래스인지 구분을 하였기 때문이다.
                //그래서 item as Dog 또는 item as Cat이 null이 나올 가능성이 없기 때문이다.

                //as클래스를 사용할 때는 이런식으로 사용한다.

                var dog = item as Dog;
                if (dog != null) { dog.Bark(); }

                var cat = item as Cat;
                if (cat != null) { cat.Meow(); }
            }
        }
    }
}
