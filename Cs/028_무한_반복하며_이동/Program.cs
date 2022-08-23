using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace _028_무한_반복하며_이동
{
    class Program
    {
        //직접 만들어 보았다
        //만들 때 순서를 주의 해야한다.
        static void Main(string[] args)
        {
            int x = 58;
            int y = 16;
            ConsoleKeyInfo info;

            while (true)
            {
                Console.Clear();
                Console.SetCursorPosition(x, y);
                Console.WriteLine("@");
                info = Console.ReadKey(true);
                switch (info.Key)
                {
                    case ConsoleKey.UpArrow:
                        y--;
                        break;
                    case ConsoleKey.RightArrow:
                        x++;
                        break;
                    case ConsoleKey.DownArrow:
                        y++;
                        break;
                    case ConsoleKey.LeftArrow:
                        x--;
                        break;
                    case ConsoleKey.Q:
                        return;
                }
            }
        }
    }
}
