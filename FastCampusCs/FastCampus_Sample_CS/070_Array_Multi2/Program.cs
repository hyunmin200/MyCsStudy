using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _070_Array_Multi2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] arrNum = new int[3, 2];
            int[,] arrNum2 = new int[,] { { 0, 1 }, { 2, 3 }, { 4, 5 } };
            int[,] arrNum3 = { { 0,1},{ 2,3},{ 4,5} };
            
            foreach(int temp in arrNum2)
            {
                Console.Write(" " + temp);
            }

            Console.Write("\n arrMulti.Length: " + arrNum2.Length);

            foreach (int temp in arrNum3)
            {
                Console.Write(" " + temp);
            }

            Console.Write("\n arrMulti.Length: " + arrNum3.Length);

            int[,,] arrMulti = new int[4, 3, 2];
            //다른 선언방식은 너무 길어서 생략

            Console.WriteLine("arrMulti.Length: " + arrMulti.Length);

            foreach (int temp in arrMulti)
            {
                Console.WriteLine("  " + temp);
            }

            Console.WriteLine();
        }
    }
}
