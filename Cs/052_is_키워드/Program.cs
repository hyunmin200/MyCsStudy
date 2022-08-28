using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _052_is_키워드
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
            //자식클래스에 있는 매서드를 호출하려면 자식 클래스로 자료형을 변환해야 한다.
            //그럼 item이 Dog클래스 인지 Cat클래스인지 어떻게 구분을 할까?
            //일단 구분을 해야하기 때문에 조건문을 사용한다. 그럼 조건문의 조건에는 무엇을 넣어야 할까?
            //C#에는 특정한 클래스가 어떤 클래스인지 확인하기 위해 is키워드를 제공한다.
            //객체 is 클래스
            //이 객체가 특정한 클래스면 true를 반환한다. 현재 코드에서 클래스를 구분 할 떄는 다음과 같은 코드를 사용하면 된다.
            List<Animal> Animals = new List<Animal>()
            {
                new Dog(), new Cat(), new Cat(), new Dog(),
                new Dog(), new Cat(), new Dog(), new Dog()
            };

            foreach (var item in Animals)
            {
                item.Eat();
                item.Sleep();

                if(item is Dog) { } //만약 변수 item이 Dog클래스라면
                if(item is Cat) { } //만약 변수 item이 Cat클래스라면
                //추가적으로 다형성의 개념이 적용이 되므로 item이 Dog클래스의 클래스라면 이는 Animal클래스의 클래스이기도 하다
                //또한 최종적으로 올라가면 Object클래스의 클래스라고도 할 수 있다.
                //만약 변수 item이 Dog클래스라면 다음과 같은 경우 모두 true를 출력하게 된다.
                //item is Dog
                //item is Animal
                //item is Object;
            }
        }
    }
}
