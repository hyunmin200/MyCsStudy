using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace _027_이동하는_달팽이
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.Clear() 콘솔 화면을 지운다.
            //Console.SetCursorPosition() 콘솔 화면의 특정한 위치로 커서를 옮깁니다.
            //Thread.Sleep() 특정한 시간만큼 스레드를 정지합니다.

            //Console.SetCursorPosition() 메서드
            //Console.Write("메서드 호출 전");
            //Console.SetCursorPosition(5, 5);
            //Console.Write("메서드 호출 후\n");

            //Thread.Sleep() 메서드
            //Console.WriteLine("첫 번째 출력");
            //Thread.Sleep(1000);
            //Console.WriteLine("두 번째 출력");
            //Thread.Sleep(1000);
            //Console.WriteLine("세 번째 출력");

            //이동하는 달팽이
            int x = 1;
            while(x < 50)
            {
                //화면을 지우고 커서를 이동합니다.
                Console.Clear();
                Console.SetCursorPosition(x, 5);

                //출력합니다
                if (x % 3 == 0)
                    Console.WriteLine("__@");
                else if (x % 3 == 1)
                    Console.WriteLine("_^@");
                else
                    Console.WriteLine("^_@");

                //100밀리초 정지하고 x를 증가합니다.
                Thread.Sleep(100);
                x++;
            }
        }
    }
}
