﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _068_Array_Init
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arrNum = new int[3];
            
            arrNum[0] = 1; // index = 0
            arrNum[1] = 2; // index = 1
            arrNum[2] = 3; // index = 2

            for(int i = 0; i < 3; i++)
            {
                Console.WriteLine(" {0}", arrNum[i]);
            }

            Console.WriteLine("\n arrNum.GetType():  {0}", arrNum.GetType());
        }
    }
}
