using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _032_클래스의_변수
{
    class Program
    {
        //인스턴스 변수 생성과 사용
        class Product
        {
            //인스턴스 변수를 생성할 때 초기화
            public string name = "default";
            public int price = 1000;
        }

        class MyMath
        {
            //Math 클래스를 사용할 떄는 인스턴스를 따로 만들지 않는다.
            //그냥 클래스 이름을 사용하여 바로 변수와 메서드를 사용할 수 있다.
            //이렇게 클래스 이름으로 곧바로 사용하는 변수와 메서드를 클래스 변수와 클래스 메서드라고 부른다.
            //클래스 변수를 만들 떄는 static 키워드를 사용한다. static 키워드는 이후에 클래스 메서드를 만들 떄도 사용하므로 기억해야한다.
            public static double PI = 3.141592;
        }

        static void Main(string[] args)
        {
            //인스턴스 변수를 만드는 방법
            //인스턴스 변수는 [인스턴스],[변수 이름]의 형태로 사용하고 다음과 같은 방법으로 생성한다
            // [접근 제한자] [자료형] [이름]
            //인스턴스 변수는 여러 개를 만들어도 된다. 인스턴스 변수는 C# 개발자들 사이에서 소문자로 시작한다는 규칙으로 사용된다.
            //Product product = new Product();
            //이렇게 생성한 인스턴스 변수는 지금까지 살펴보았던 다른 멤버처럼 자동 완성 기능에서 확인 할 수 있습니다.

            //인스턴스 변수 사용
            //인스턴스를 생성합니다.
            Product product = new Product();

            //인스턴스 변수를 변경합니다.
            product.name = "감자";
            product.price = 2000;

            //인스턴스 변수를 출력합니다.
            Console.WriteLine(product.name + " : " + product.price + "원");

            //C#은 인스턴스를 생성할 때 원하는 변수를 원하는 값으로 초기화 하는 기능이 있다.
            //일반적인 현대 프로그래밍 언어에는 없는 기능이다.
            //사용하면 꽤나 편리하다.
            Product product1 = new Product() { name = "감자", price = 2000 };
            Product product2 = new Product() { name = "고구마", price = 3000 };

            Console.WriteLine(MyMath.PI);
        }
        
    }
    //인스턴스 변수 선언
    class User
    {
        public string name;
        public string password;
        public string address;
        public string phoneNumber;
        public DateTime regDate;
        //인스턴스 변수는 대부분 private로 선언한다. 지금은 public과 private의 차이를 배우지 않았기 때문에 public을 적용해 사용한다.
    }
}
