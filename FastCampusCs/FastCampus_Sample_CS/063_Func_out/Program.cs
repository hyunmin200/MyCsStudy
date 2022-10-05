using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _063_Func_out
{
    internal class Program
    {

        static void InitNum(out int addNum)
        {
            addNum = 100;
        }

        static void InitRefNum(ref int refNum)
        {
            refNum = 100;
        }

        static void Main(string[] args)
        {
            int a;
            int b;
            //초기화 필요 없음
            InitNum(out a); // a = 100;
            Console.WriteLine("a: " + a);

            b = 0; //초기화 꼭 필요
            InitNum(out b); // 오류: b를 초기화 하지 않고 사용 불가!!
            Console.WriteLine("b: " + b);
            //하지만 대도록이면 둘다 초기화하는 편이 편함

        }
    }
}
