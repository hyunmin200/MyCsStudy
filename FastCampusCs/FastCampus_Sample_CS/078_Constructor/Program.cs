using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _078_Constructor
{
    class AA
    {
        int a;
        float f;

        public AA()
        {
            a = 0;
            f = 0f;
            Console.WriteLine("   Call Constructor  ");
            Console.WriteLine("   a: {0}", a);
            Console.WriteLine("   f: {0}", f);
        }
        public AA(int _a)
        {
            a = _a;

            Console.WriteLine("   Call Constructor  ");
            Console.WriteLine("   a: {0}", a);
            Console.WriteLine("   f: {0}", f);
        }

        public AA(int _a, float _f)
        {
            a = _a;
            f = _f;

            Console.WriteLine("   Call Constructor  ");
            Console.WriteLine("   a: {0}", a);
            Console.WriteLine("   f: {0}", f);
        }

        ~AA()
        {
            Console.WriteLine("   Call Destructor   ");
        }
        //소멸자에는 어떤 파라미터도 넣을 수 없음
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            //생성자가 하나라도 생성이 되어있다면 기본 생성자는 생성되지 않음
            AA aa = new AA();
            AA aaa = new AA(10);
            AA aaaa = new AA(100, 0.5f);
            //오버로딩된 생성자
        }
    }
}
