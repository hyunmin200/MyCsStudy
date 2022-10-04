using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading

namespace _058_CheckPoint01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string Line = "-------------------------------------------";
            while (true)
            {
                Console.WriteLine(Line);
                Console.WriteLine("1");
                Console.WriteLine("2");
                Console.WriteLine("3");
                Console.WriteLine("4");
                Console.WriteLine(Line);

                Thread.Sleep(100);
                Console.Clear(); //화면 지우기
            }
        }
    }
}
