using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _009_불
{
    class Program
    {
        static void Main(string[] args)
        {
            //불
            Console.WriteLine(true);
            Console.WriteLine(false);
            Console.WriteLine("");

            //불과 비교 연산자
            Console.WriteLine(52 < 273);
            Console.WriteLine(52 > 273);
            Console.WriteLine("");

            //논리 부정 연산자
            Console.WriteLine(!true);
            Console.WriteLine(!false);
            Console.WriteLine(!(52 < 273));
            Console.WriteLine(!(52 > 273));
            Console.WriteLine("");

            //불과 논리 연산자
            Console.WriteLine(DateTime.Now.Hour < 3 || 8 < DateTime.Now.Hour);
            Console.WriteLine(3 < DateTime.Now.Hour && DateTime.Now.Hour < 8);
            Console.WriteLine("");
        }
    }
}
