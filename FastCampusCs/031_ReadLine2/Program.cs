using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*-----------------------------------------------------------------------------
 * Name: _031_ReadLine2
 * DESC: ReadLine2
-ㅏ-----------------------------------------------------------------------------*/

namespace _031_ReadLine2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("첫번째 정수를 입력하세요  ");
            string str1 = Console.ReadLine();
            Console.Write("두번째 정수를 입력하세요  ");
            string str2 = Console.ReadLine();

            int num1 = int.Parse(str1);
            int num2 = int.Parse(str2);
            int num3 = Convert.ToInt32(str1);
            int num4 = Convert.ToInt32(str2);

            int sum = num1 + num2; // 두 수의 합
            Console.WriteLine("{0} + {1} = {2}", num1, num2, sum);
        }
    }
}
