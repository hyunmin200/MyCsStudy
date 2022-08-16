using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_4_연산자_우선순위
{
    class Program
    {
        static void Main(string[] args)
        {
            //결과를 예측해봅니다.
            Console.WriteLine(5 + 3 * 2);
            //*가 우선순위가 +보다 높기때문에 11이 나온다.
            //16만 나오게 하려면
            Console.WriteLine((5 + 3) * 2);
        }
    }
}
