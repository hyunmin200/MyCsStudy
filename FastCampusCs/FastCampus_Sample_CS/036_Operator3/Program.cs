using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _036_Operator3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 10;

            Console.WriteLine(num++); //후치 연산
            Console.WriteLine(num);
            Console.WriteLine(++num); //천치 연산

            Console.WriteLine(num--); //후치 연산
            Console.WriteLine(num);
            Console.WriteLine(--num); //전치 연산
        }
    }
}
