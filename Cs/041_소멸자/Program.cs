using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace _041_소멸자
{
    class Program
    {
        class Product
        {
            public string name;
            public int price;

            public Product(string name, int price)
            {
                this.name = name;
                this.price = price;
            }

            ~Product()
            {
                Console.WriteLine(this.name + "의 소멸자 호출");
            }
        }

        static void Main(string[] args)
        {
            //인스턴스가 소멸될 때에 호줄되는 소멸자가 있다.
            //소멸자를 만들 때는 다음과 같은 규칙을 지켜야 한다.
            // - 이름은 클래스 이름 앞에 ~ 기호가 부은 것이어야 한다
            // - 접근 제한자를 사용하지 않는다.
            // - 봔환과 관련된 선언을 하지 않는다.
            // - 매개변수와 관련된 선언을 하지 않는다.
            // - 하나의 클래스에는 하나의 소멸자만 있을 수 있다.
            //이걸 배운후에 스스로 개발을 하면서 파일을 열거나 웹 통신을 걸면 해당 객체가 소멸할 때 파일을 저장하고 닫거나 웹통신을 안전하게 끊어줘야 한다. 이럴때 소멸자를 사용한다.
            //~[클래스 이름]()
            //{
            //
            //}
            Product product = new Product("과자", 1000);
            //상수 사용
            const int value = 10;
            Console.WriteLine(value);
            //readonly 키워드
            //readonly 키워는 변수를 선언하는 시점과 생성자 메서드에서만 갑을 변경할 수 있다.
        }
    }
}
