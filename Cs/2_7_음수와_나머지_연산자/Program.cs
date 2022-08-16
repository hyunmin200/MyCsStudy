using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_7_음수와_나머지_연산자
{
    class Program
    {
        static void Main(string[] args)
        {
            //나머지 연산자의 부호는 왼쪽 피연산자의 부호를 따른다.
            //오른쪽 피연산자의 부호는 전혀 상관이 없으니 주의!
            Console.WriteLine(4 % 3);
            Console.WriteLine(-4 % 3);
            Console.WriteLine(4 % -3);
            Console.WriteLine(-4 % 3);
        }
    }
}
