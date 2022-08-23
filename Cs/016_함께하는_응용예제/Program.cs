using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _016_함께하는_응용예제
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("입력: ");
            String line = Console.ReadLine();

            if (line.Contains("안녕"))
            {
                Console.WriteLine("안녕하세요...!");
            }
            else
            {
                Console.WriteLine("^^");
            }

            //키 입력 구분
            while (true)
            {
                ConsoleKeyInfo info = Console.ReadKey();
                if(info.Key == ConsoleKey.Escape) //info.key가 esc를받으면 종료된다.
                {
                    break;
                }
                switch (info.Key)
                {
                    case ConsoleKey.UpArrow:
                        Console.WriteLine("위로 이동");
                        break;
                    case ConsoleKey.RightArrow:
                        Console.WriteLine("오른쪽으로 이동");
                        break;
                    case ConsoleKey.DownArrow:
                        Console.WriteLine("아래로 이동");
                        break;
                    case ConsoleKey.LeftArrow:
                        Console.WriteLine("오른쪽으로 이동");
                        break;
                    default:
                        Console.WriteLine("다른 키를 눌렀습니다.");
                        break;
                }
            }
        }
    }
}
