using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _021_역_for_반복문
{
    class Program
    {
        static void Main(string[] args)
        {
            //역 for 반복문
            //배열을 생성합니다
            int[] intArray = { 1, 2, 3, 4, 5 };

            //요소의 길이를 출력합니다.
            for(int i = intArray.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(intArray[i]);
            }
        }
    }
}
