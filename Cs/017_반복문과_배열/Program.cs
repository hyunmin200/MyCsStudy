using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _017_반복문과_배열
{
    class Program
    {
        static void Main(string[] args)
        {
            //복사해서 붙여넣기를 사용한 반복
            Console.WriteLine("출력");
            Console.WriteLine("출력");
            Console.WriteLine("출력");
            Console.WriteLine("출력");
            Console.WriteLine("출력");

            //반복문을 사용한 반복
            for(int i = 0; i < 1000; i++)
            {
                Console.WriteLine("출력");
            }

            //기본적인 배열 생성 방법
            int[] intArray = { 1, 2, 3, 4, 5, 6 };
            long[] longArray = { 1, 2, 3, 4, 5, 6 };
            float[] floatArray = { 1, 2, 3, 4, 5, 6 };
            double[] doubleArray = { 1, 2, 3, 4, 5, 6 };
            char[] charArray = {'가', '나', '다', '라'};
            string[] stringArray = {"안녕", "반갑다", "하이"};
            //배열안에 각각의 자료를 요소라고 부른다.
            //배열의 요소에 접근할 떄는 다음과 같이 대괄호[]를 사용한다. 이떄 대괄호 안에 넣는 숫자를 인덱스라고 부른다.

            //배열 생성하고 요소에 접근
            int[] int1Array = { 1, 2, 3, 4, 5 };
            //배열의 요소를 변경한다
            int1Array[1] = 0;
            //요소를 출력한다.
            Console.WriteLine(int1Array[0]);
            Console.WriteLine(int1Array[1]);
            Console.WriteLine(int1Array[2]);
            Console.WriteLine(int1Array[3]);
            Console.WriteLine(int1Array[4]);

            //배열의 length 속성
            //배열을 생성한다.
            int[] int2Array = { 1, 2, 3, 4, 5 };
            //배열의 길이를 출력한다.
            Console.WriteLine(int2Array.Length);
            //이걸로 배열에 몇 개의 요소가 있는지 확인할 수 있다.

            //원하는 크기의 배열 생성 방법
            int[] array = new int[100];

            //배열을 생성합니다.
            int[] int3Array = new int[100];
            //요소의 길이를 출력한다.
            Console.WriteLine(int3Array[0]);
            Console.WriteLine(int3Array[99]);
        }
    }
}
