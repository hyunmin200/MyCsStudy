using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _038_오버로딩
{
    class Program
    {
        class TestWorld
        {
            //public int Test(int input) { Console.WriteLine("Hello"); }
            //public double Test(double input) { Console.WriteLine("Hello"); }
            //public float Test(float input) { Console.WriteLine("Hello"); }
            //이렇게 하면 오버로딩 오류가 난다
        }
        class MyMath
        {
            public static int Abs(int input)
            {
                if (input < 0) { return -input; }
                else { return input; }
            }

            public static double Abs(double input)
            {
                if(input < 0) { return -input; }
                else { return input; }
            }

            public static long Abs(long input)
            {
                if(input < 0) { return -input; }
                else { return input; }
            }
        }
        static void Main(string[] args)
        {
            //Math.Abs 메서드를 사용할 때에 자동 완성 기능에 설명이 뜨는데
            //이렇게 이름은 같고, 매개변수는 다른 메서드를 만드는 것은 오버로딩이라고 부른다
            //오버로딩은 그냥 이름은 같고, 매개변수를 다르게 해서 메서드를 만들기만 하면 된다.
            //이전에 만들었었던 Abs() 메서드를 더 다양한 자료형에서 동작할 수 있게 오버로딩 한다!

            //int
            Console.WriteLine(MyMath.Abs(52));
            Console.WriteLine(MyMath.Abs(-273));

            //double
            Console.WriteLine(MyMath.Abs(52));
            Console.WriteLine(MyMath.Abs(-32.103));

            //long
            Console.WriteLine(MyMath.Abs(21474836470));
            Console.WriteLine(MyMath.Abs(-21474836470));
        }

        
    }
}
