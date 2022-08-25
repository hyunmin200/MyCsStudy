using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _037_클래스_메서드
{
    class Program
    {
        class MyMath
        {
            public static int Abs(int input)
            {
                if(input < 0)
                {
                    return -input;
                }
                else
                {
                    return input;
                }
            }
        }
        //여기에 static을 넣지 않으면 오류가 난다.
        //왜냐? 아직 new 키워드로 메모리에 올라가지 않았지 않았기 때문이다.
        //public int instanceVariable = 10;
        public static int instanceVariable = 10;
        static void Main(string[] args)
        {
            //[접근 제한자] static [반환형] [메서드 이름] ([매개변수])
            //{
            //  
            //}

            //static이라는 키워드를 붙인 변수 또는 메서드는 프래그램을 실행하는 순간에 메모리에 올라가게 됩니다.
            //Math.Abs()와 같은 클래스 메서드는 인스턴스화해서 메모리에 올리는 별도의 작업(new Math()) 없이도 사용할 수 있는 것이다.
            //클래스 메세드에서는 아직 메모리에 올라가지 않는 인스턴스 변수와 인스턴스 메서드를 사용할 수 없습니다.
            Console.WriteLine(MyMath.Abs(52));
            Console.WriteLine(MyMath.Abs(-283));

            Console.WriteLine(instanceVariable);
        }
    }
}
