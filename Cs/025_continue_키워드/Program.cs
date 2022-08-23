using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _025_continue_키워드
{
    class Program
    {
        static void Main(string[] args)
        {
            //continue 키워드
            for (int i = 1; i < 10; i++)
            {
                if(i % 2 == 0)
                {
                    continue;
                    //짝수라면 다음 반복으로 바로 넘어 간다 따라서 이 아래의 코드는 실행 되지 않는다
                }
                Console.WriteLine(i);
            }

            //위에 코드를 간단하게 변경
            for(int i = 1; i < 10; i++)
            {
                if(i % 2 != 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
