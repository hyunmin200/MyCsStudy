using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _019_do_while_반복문
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            do
            {
                Console.WriteLine("입력(exit을 입력하면 종료): ");
                input = Console.ReadLine();
            } while (input != "exit");
        }
    }
}
