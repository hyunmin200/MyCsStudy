using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _020_for_반복문
{
    class Program
    {
        static void Main(string[] args)
        {
            //for 반복문으로 덧셈
            int output = 0;
            //반복을 수행합니다.
            for (int i = 0; i <= 100; i++)
            {
                output += i;
            }
            //출력합니다.
            Console.WriteLine(output);

            //for 반복문으로 곱셈
            int output1 = 0;
            //반복을 수행합니다.
            for(int i = 0; i <= 20; i++)
            {
                output1 *= 1;
            }
            //출력합니다
            Console.WriteLine(output1);

            //한글 전부 출력
            for(int i = '가'; i <= '힣'; i++)
            {
                Console.Write((char)i);
                Console.Write(" ");
            }

            //시간를 사용한 반북문 이탈
            long start = DateTime.Now.Ticks;
            long count = 0;
            //반복을 수행합니다
            while(start + (10000000) > DateTime.Now.Ticks)
            {
                count++;
            }
            Console.WriteLine(count + "만큼 반복했습니다.");    //출력
        }
    }
}
