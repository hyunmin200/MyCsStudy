using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*-----------------------------------------------------------------------------
 * Name: _030_ReadLine
 * DESC: ReadLine
-ㅏ-----------------------------------------------------------------------------*/

namespace _030_ReadLine
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("정수를 입력하세요\n");
            string inputNum = Console.ReadLine();
            int num = int.Parse(inputNum);
            //나중에 예외처리 할 수 있음

            Console.WriteLine("입력한 수는: " + num);
        }
    }
}
