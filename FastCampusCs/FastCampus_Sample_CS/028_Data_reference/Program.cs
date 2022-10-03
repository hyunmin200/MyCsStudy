using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*-----------------------------------------------------------------------------
 * Name: _028_Data_reference
 * DESC: Refrence참조 기초(두 개의 값이서로 영향을 준다)
------------------------------------------------------------------------------*/

namespace _028_Data_reference
{
    class Program
    {
        static void Main(string[] args)
        {
            //어떤 하나를 바꿔도 영향을 받지 않음
            int num = 100;
            int refNum = num;
            refNum = 1000;

            Console.WriteLine("refStr: {0}   ReferenceEquals: {1}", num, Object.ReferenceEquals(num, refNum));
            
            //어떤 하나를 바꾸면 영향을 받음
            int[] arrNum = { 100, 200 };
            int[] refArrNum = arrNum; //주소값 주기
            refArrNum[0] = 1000;

            Console.WriteLine("refStr: {0}  ReferenceEquals: {1}", arrNum[0], Object.ReferenceEquals(refArrNum, arrNum));
        }
    }
}
