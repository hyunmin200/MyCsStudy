using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _074_Array_Clear
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[3];

            Array.Clear(array, 0, array.Length);
            for(int i = 0; i < array.Length; i++)
            {
                array[i] = i;
            }

            for(int i = 0; i < array.Length; i++)
            {
                Console.Write("  {0}  ", array[i]);
            }
            Console.WriteLine("\n----------------------------");

            int[,] arrNum = new int[3, 2];

            Console.WriteLine("\n---------- Array.Clear -----------");
            Array.Clear(arrNum, 0, arrNum.Length);

            for(int i = 0; i < arrNum.GetLength(0); i++)
            {//arrNum.GetLength(0) => 3
                for (int j = 0; j < arrNum.GetLength(1); j++)
                {//arrNum.GetLength(1) => 2
                    arrNum[i, j] = (i * arrNum.GetLength(1)) + j;
                }
            }

            for(int i = 0; i < arrNum.GetLength(0); i++)
            {
                for(int j = 0; j < arrNum.GetLength(1); j++)
                {
                    Console.Write("  " + arrNum[i, j]);
                }
                Console.WriteLine();
            }

            Console.WriteLine("\n----------------------------");
            
            //3차원 배열은 생략
        }
    }
}
 