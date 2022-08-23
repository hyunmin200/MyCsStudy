using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _022_foreach_반복문
{
    class Program
    {
        static void Main(string[] args)
        {
            //foreach 반복문과 배열
            //변수를 선언합니다.
            string[] array = { "사과", "배", "포도", "딸기", "바나나" };
            //반복을 수행합니다.
            foreach(string item in array)
            {
                //출력합니다
                Console.WriteLine(item);
            }

            //foreach 반복문과 var 키워드
            //변부를 선언합니다.
            string[] array1 = { "사과", "배", "포도", "딸기", "바나나" };
            //반복을 수행합니다
            foreach(var item in array)
            {
                Console.WriteLine(item);
            }
        }
    }
}
