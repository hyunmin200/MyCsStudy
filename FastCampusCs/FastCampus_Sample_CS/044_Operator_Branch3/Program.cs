using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _044_Operator_Branch3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool isA = false;
            bool isB = true;
            bool isC = true;
            bool isD = false;
            
            if(isA && isB) // false && true => false
            {
                Console.WriteLine("false && true => false"); //X
            }

            if(isB && isC) // true && true => true
            {
                Console.WriteLine("true && true => true"); //O
            }

            if(isC || isD) // true || false => true
            {
                Console.WriteLine("true || false => true"); //O
            }

            if( (2 > 1 && 3 < 4) || 1 > 2)
            {
                Console.WriteLine("true && false || false => true"); //O
            }
        }
    }
}
