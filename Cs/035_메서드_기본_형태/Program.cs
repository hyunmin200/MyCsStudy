using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _035_메서드_기본_형태
{
    class Program
    {
        class Test
        {
            //메서드 Power을 생성하였다.
            //public int Power(int x)
            //{
            //    return x * x;
            //}

            //두 개의 매개변수를 가즌 메서드
            public int Multi(int x, int y)
            {
                return x * y;
            }
            
            //아무것도 반환하지 않는 메서드
            public void Print()
            {
                Console.WriteLine("Print() 메서드가 호출 되었습니다!");
            }

        }
        static void Main(string[] args)
        {
            //Test test = new Test();
            //Console.WriteLine(test.Power(10));
            //Console.WriteLine(test.Power(20));
            
            Test test = new Test();
            Console.WriteLine(test.Multi(52, 273));
            Console.WriteLine(test.Multi(103, 32));

            test.Print();
            test.Print();
            test.Print();
        }
    }
}
