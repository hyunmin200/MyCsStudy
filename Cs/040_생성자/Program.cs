using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _040_생성자
{
    class Program
    {
        //기본적인 생성자의 모습
        //public string name;
        //public int price;

        //public Product(string name, int price)
        //{
        //    this.name = name;
        //    this.price = price;
        //}

        class Product
        {
            public static int counter = 0;
            public int id;
            public string name;
            public int price;

            public Product(string name, int price)
            {
                Product.counter = counter + 1;
                //counter를 스테틱으로 저장해 메모리에 올림
                this.id = counter;
                this.name = name;
                this.price = price;
            }
        }
        static void Main(string[] args)
        {
            //생성자는 무언가를 생성할 때 자동으로 호출되는 메서드이다.
            //C#은 특히 다른 프로그래밍 언어보다 생성자 종류가 굉장히 많다.
            //가장 자주사용되는 인스턴스 생성자를 기준으로 알아본다.
            //인스터스 생성자는 인스턴스를 생성할 때자동으로 호출되는 메서드로 다음과 같은 조건이 있다.
            // - 이름은 클래스 이름과 같아야 한다.
            // - 접근 제한자는 public이어야 한다.
            // - 반환과 관련된 선언을 하지 않는다.
            //public [클래스 이름] {[매개변수]}
            //{
            //
            //}
            //생성자에서는 일반적으로 인스턴스 변수를 초기화하는 일은 한다.
            Product productA = new Product("감자", 2000);
            Product productB = new Product("고구마", 3000);

            Console.WriteLine(productA.id + ":" + productA.name);
            Console.WriteLine(productB.id + ":" + productB.name);
            Console.WriteLine(Product.counter + "개 생성되었습니다");
            //자세히 보려면 286쪽으로
        }
    }
}
