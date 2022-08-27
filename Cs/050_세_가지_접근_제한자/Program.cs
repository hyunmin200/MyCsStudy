using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _050_세_가지_접근_제한자
{
    class Program
    {
        class Animal
        {
            private void Private() { }
            protected void Protected() { }
            public void Public() { }

            public void TestA()
            {
                Private();
                Protected();
                Public();
                //자신의 클래스에서는 모든 변수 사용가능
            }
        }

        class Dog : Animal
        {
            public void TestB()
            {
                Protected();
                Public();
                //상속받은 클래스에서는 private접근 제한자가 붙은 멤버를 사용할 수 없다.
            }
        }

        static void Main(string[] args)
        {
            Dog dog = new Dog();
            dog.Public();
            //이외의 모든 장소에서는 public 접근 제한자가 붙은 멤버만 사용할 수 있다.
        }
    }
}
