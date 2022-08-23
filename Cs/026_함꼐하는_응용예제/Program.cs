using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _026_함꼐하는_응용예제
{
    class Program
    {
        static void Main(string[] args)
        {
            //대문자화와 소문자화
            //간단한 문자열 처리 메서드를 살펴보자
            //ToUpper() 문자열 내부의 문자를 모두 대문자로 바꿈
            //ToLower() 문자열 내부의 문자를 모두 소문자로 바꿈
            string input = "Potato Tomato";
            Console.WriteLine(input.ToUpper());
            Console.WriteLine(input.ToLower());

            //문자열 자르기
            //Split() 메서드 문자열을 특정한 문자 또는 문자열로 자른다.
            //특정한 기점을 정하여 자르는 것 같다.
            string input1 = "감자 고구마 토마토";
            string[] inputs = input1.Split(new char[] { ' ' });

            foreach(var item in inputs)
            {
                Console.WriteLine(item);
            }

            //문자열 양 옆의 공백 제거
            //문자열 양 옆에 공백이 삽입되는 경우에 양 옆의 공백을 삭제하고자 다음 메서드를 사용한다.
            //Trim() 문자열 양 옆의 공백을 제거합니다
            //TrimStart() 문자열 앞의 공백을 제거합니다
            //TrimEnd() 문자열 뒤의 공백을 제거합니다.

            string input2 = " test     \n";
            Console.WriteLine("::" + input2.Trim() + "::");
            //Console.Read();

            //배열을 문자열로 변환
            //배열에 있는 요소를 연결해서 문자열로 만들 때는 string.Join() 메서드를 사용한다.
            //string.Join() 배열의 요소를 뭉쳐 문자열로 변경합니다.
            string[] array = { "감자", "고구마", "토마토", "가지" };
            Console.WriteLine(string.Join(",", array));
        }
    }
}
