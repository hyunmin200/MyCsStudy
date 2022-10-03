using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _041_Operator_null
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int? a = null;
            int b = 10;
            int? c = null;
            int d = 100;
            int result;

            result = a ?? b; // 10
            //a에 null이 들어가 있다면 뒤에껄 확인하고 null이 아니면 그 값을 넣는다
            Console.WriteLine("result: " + result);

            result = a ?? c ?? d; // 100
            Console.WriteLine("result: " + result);

            c = 100000;
            result = a ?? c ?? d; // c가 null이 아니기 때문에 c값이 나온다.
            Console.WriteLine("result: " + result);
        }
    }
}
