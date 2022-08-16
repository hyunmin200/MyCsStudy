using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*-----------------------------------------------------------------------------
 * Name: _010_Data3
 * DESC: 데이터 형태 오류
------------------------------------------------------------------------------*/

namespace _010_Data3
{
    class Program
    {
        static void Main(string[] args)
        {
            //데이터 형식의 오류
            byte sbyteData = 255;
            sbyte sbyteData2 = (sbyte)sbyteData; //캐스트 연산오류(강제 형변환)(캐스팅을 통한)
            int num = (int)sbyteData;

            Console.WriteLine("sbyteData: " + sbyteData);
            Console.WriteLine("sbyteData: " + sbyteData2);
            Console.WriteLine("sbyte.MaxValue: " + sbyte.MaxValue);
            Console.WriteLine("num: " + num);
        }
    }
}
