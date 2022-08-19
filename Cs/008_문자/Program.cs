using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _008_문자
{
    class Program
    {
        static void Main(string[] args)
        {
            //문자
            Console.WriteLine('A');
            Console.WriteLine('가');
            Console.WriteLine('나');
            Console.WriteLine("");

            //문자열
            Console.WriteLine("안녕하세요!");
            Console.WriteLine("");

            //이스케이프 문자
            Console.WriteLine("황\t현민"); //수평 탭
            Console.WriteLine("황\n현민"); //행 바꿈(줄 바꿈)
            Console.WriteLine("\"\"\""); // 큰 따음표
            Console.WriteLine("");

            //문자열 연결 연산자
            Console.WriteLine("가나다" + "라마" + "바사아" + "자차카타" + "파하");
            Console.WriteLine("");

            //문자 선택
            Console.WriteLine("안녕하세요"[0]);
            Console.WriteLine("안녕하세요"[1]);
            Console.WriteLine("안녕하세요"[2]);
            Console.WriteLine("안녕하세요"[3]);
            Console.WriteLine("안녕하세요"[4]);
            //Console.WriteLine("안녕하세요"[100]); 에러 발생
            Console.WriteLine("");

            //문자 덧셈
            Console.WriteLine('가' + '힣');
            Console.WriteLine("");
            //이렇게 하면 가를 나타내는 44032와 힣을 나타내는 55203이 덧셈 연산된다.
        }
    }
}
