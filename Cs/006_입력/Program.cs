using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _006_입력
{
    class Program
    {
        static void Main(string[] args)
        {
            //문자열 입력과 출력
            string input = Console.ReadLine();
            Console.WriteLine("input: " + input);

            //string?자료형으로 나옴
            //nullable은 이 책에서는 나오지 않지만
            //null이 들어갈 수 있는 자료형이라고 들었음
            //그리고 ReadLine()은 문자열만 받을 수 있기 때문에 숫자를 입력받아 더하는 프로그램을 만들려면 문자열을 숫자로 바꾸는 방법이 필요하다
            //다음장에서
        }
    }
}
