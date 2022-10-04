using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _042_Operator_Branch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool isBool = false;

            if (isBool) //조건문이 가지는 값은(true/false)
            {
                Console.WriteLine("isBool: {0}", isBool);
            }
            else
            {
                Console.WriteLine("IsBool: {0}", isBool);
            }
        }
    }
}
