using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _004_자료형_검사
{
    class Program
    {
        static void Main(string[] args)
        {
            //GetType() 메서드 활용
            int _int = 273;
            long _long = 52222222222;
            float _float = 52.333f;
            double _double = 52.222;
            char _char = '글';
            string _string = "문자열";

            //출력파트
            Console.WriteLine(_int.GetType());
            Console.WriteLine(_long.GetType());
            Console.WriteLine(_float.GetType());
            Console.WriteLine(_double.GetType());
            Console.WriteLine(_char.GetType());
            Console.WriteLine(_string.GetType());

            Console.WriteLine("");

            //직접적인 GetType() 메서드 활용
            Console.WriteLine((273).GetType());
            Console.WriteLine((52222222222).GetType());
            Console.WriteLine((52.333f).GetType());
            Console.WriteLine((52.222).GetType());
            Console.WriteLine(('글').GetType());
            Console.WriteLine(("문자열").GetType());
        }
    }
}
