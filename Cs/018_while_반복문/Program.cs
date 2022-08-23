using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _018_while_반복문
{
    class Program
    {
        static void Main(string[] args)
        {
            //무한 반복
            while (true)
            {
                Console.WriteLine("무한 반복");
                break; //이 줄 주석하면 무한 반복됨
            }

            //while 반복문 이용
            //변수를 선언합니다.
            int i = 0;
            int[] intArray = { 1, 2, 3, 4, 5 };
            //반복을 수행합니다.
            while(i < intArray.Length)
            {
                //출력합니다.
                Console.WriteLine(i + "번째 출력:" + intArray[i]);
                //탈출을 위해 변수를 더합니다.
                i++;
            }
        }
    }
}
