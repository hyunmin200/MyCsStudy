using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*-----------------------------------------------------------------------------
 * Name: _027_Data_Convert
 * DESC: Convert 기초, ToStirng, Parse 
------------------------------------------------------------------------------*/

namespace _027_Data_Convert
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 100;
            float b = 3.141593f;
            decimal c = 3.1415926535897932384626433832m;

            string strA = a.ToString(); //"100"
            string strB = b.ToString(); //"3.141593"
            string strC = c.ToString(); //"3.1415926535897932384626433832"

            Console.WriteLine("a.ToString(): {0}", strA);
            Console.WriteLine("b.ToString(): {0}", strB);
            Console.WriteLine("c.ToString(): {0}", strC);
            Console.WriteLine();

            int parseA = int.Parse(strA); //int parseA = 100;
            float parseB = float.Parse(strB); //float parseB = 3.141593; 
            decimal parseC = decimal.Parse(strC); //decimal parseC = 3.1415926535897932384626433832m;

            Console.WriteLine("int.Parse: {0}", parseA);
            Console.WriteLine("float.Parse: {0}", parseB);
            Console.WriteLine("decimal.Parse: {0}", parseC);
            Console.WriteLine();
            
            //string을 int,float,decimal형으로 변환
            int convertA = Convert.ToInt32(strA);
            float convertB = Convert.ToSingle(strB);
            decimal convertC = Convert.ToDecimal(strC);

            Console.WriteLine("Convert.ToInt32(strA): {0}", convertA);
            Console.WriteLine("Convert.ToSingle(strB): {0}", convertB);
            Console.WriteLine("COnvert.ToDecimal(strC): {0}", convertC);
        }
    }
}
