using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _030_클래스_사용
{
    class Program
    {
        static void Main(string[] args)
        {
            //Random 클래스
            //Random 클래스는 임의의 숫자를 생성할 때에 사용하고, 다음과 같은 방법으로 인스턴스를 생성한다.
            //Random 클래스의 Next() 메서드는 임의의 정수를 생성할 때에 사용된다.

            //Random 클래스를 사용한 임의의 정수 생성
            Random random = new Random();
            Console.WriteLine(random.Next(10, 100));
            Console.WriteLine(random.Next(10, 100));
            Console.WriteLine(random.Next(10, 100));
            Console.WriteLine(random.Next(10, 100));
            Console.WriteLine(random.Next(10, 100));

            //NextDouble() 메서드를 사용하면 된다. NextDouble() 메서드를 사용하면 실수를 생성할 수 있음
            //NextDouble() 메서드는 0.0과 1.0 사이의 난수(임의의 수)를 반환합니다.
            //Random 클래스를 사용한 임의의 실수 생성
            Random random1 = new Random();
            Console.WriteLine(random1.NextDouble());
            Console.WriteLine(random1.NextDouble());
            Console.WriteLine(random1.NextDouble());
            Console.WriteLine(random1.NextDouble());

            //원하는 범위의 실수 난수 생성
            Random random2 = new Random();
            Console.WriteLine(random2.NextDouble() * 10);
            Console.WriteLine(random2.NextDouble() * 10);
            Console.WriteLine(random2.NextDouble() * 10);
            Console.WriteLine(random2.NextDouble() * 10);

            //이렇게 인스턴스 뒤에 점을 찍고 사용하는 멤버를 인스턴스 멤버라고 부른다.
            //그리고 해당멤버가 변수이면 인스턴스 변수, 메서드이면 인스턴스 메서드, 속성이면 인스턴스 속성 등으로 부른다.

            //List클래스

            //일반적인 배열 생성
            int[] intArray = new int[10];
            long[] longArray = new long[10];
            string[] stringArray = new string[10];

            //하지만 List를 사용하면 크기가 가변적인 배열을 만들 수 있다.
            //1개를 넣고싶을때는 1개를 넣으면 되고, 10개를 넣고 싶을 때는 10개를 넣으면 된다.
            //List클래스는 배열과 유사하다. 어떤 자료형으로 리스트를 선언하게 된다.
            //자료형을 나타내는 방법은 제네릭(Generic)이라는 것을 사용한다.
            //제네릭은 클래스 이름 뒤에 <와 > 괄호로 감싸 적용한다.

            //Lis 클래스의 인스턴스 생성
            //변수를 선언합니다.
            List<int> list = new List<int>();
            //참조 오류가 난다면 ctrl+. 단축키를 눌럼 파란색 상자를 선택해서 참조를 추가 하면 된다.

            //Add() 메서드를 사용하면 리스트에 요소를 넣을 수 있다.

            //리스트 요소 추가
            //변수를 선언합니다.
            //List<int> list = new List<int>();

            //리스트에 요소를 추가한다.
            list.Add(52);
            list.Add(233);
            list.Add(213);
            list.Add(32);
            
            //반복을 수행한다.
            foreach (var item in list)
            {
                Console.WriteLine("Count: " + list.Count + "\titem: " + item);
            }

            //List 인스턴스 생성과 동시에 요소 추가
            //변수를 선언합니다.
            List<int> list1 = new List<int>() { 1, 2, 3, 4, 5 };
            //c#에서 가능하기 때문에 사용하면 좋다

            //반복을 수행합니다.
            foreach (var item in list)
            {
                Console.WriteLine("Count: " + list.Count + "\titem: " + item);
            }

            //math 클래스
            //Math 클래스 인스턴스를 만들지 않고 사용한다.

            //Math 클래스의 메서드
            //Abs(숫자) 절대 값을 구한다.
            //Ceiling(숫자) 지정된 숫자보다 크거나 같은 최소 정수를 구한다.
            //floor(숫자) 지정된 숫자보다 작거나 같은 최대 정수를 구한다.
            //Max(숫자, 숫자) 두 개의 매개변수 중에서 큰 값을 구한다.
            //Min(숫자, 숫자) 두 개의 매개변수 중에서 작은 값을 구한다.
            //Round(숫자) 반올림한다.

            Console.WriteLine(Math.Abs(-13213));
            Console.WriteLine(Math.Ceiling(52.123));
            Console.WriteLine(Math.Floor(52.22));
            Console.WriteLine(Math.Max(52, 273));
            Console.WriteLine(Math.Min(52, 273));
            Console.WriteLine(Math.Round(52.273));

            //Math클래스 처럼 클래스 이름 뒤에 점을 찍고사용하는 멤버를 클래스 멤버라고 부른다.
            //마찬가지로 해당 멤버가 변수이면 클래스 변수, 매서드이면 클래스 메서드, 속성이면 클래스 속성 등으로 부른다.

        }
    }
}
