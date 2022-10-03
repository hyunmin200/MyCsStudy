﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _040_Operator_Bit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 15;     //0000 0000    0000 0000    0000 0000   0000 1111
            int b = 22;     //0000 0000    0000 0000    0000 0000   0001 0110
            int c = a & b;  //0000 0000    0000 0000    0000 0000   0000 0110 => 6
            Console.WriteLine("a & b: " + c);

                            //0000 0000    0000 0000    0000 0000   0000 1111
                            //0000 0000    0000 0000    0000 0000   0001 0110
            int d = a | b;  //0000 0000    0000 0000    0000 0000   0001 1111 => 31
            Console.WriteLine("a | b: " + d);

                            //0000 0000    0000 0000    0000 0000   0000 1111
                            //0000 0000    0000 0000    0000 0000   0001 0110
            int e = a ^ b;  //0000 0000    0000 0000    0000 0000   0001 1001 => 25
            Console.WriteLine("a ^ b: " + e);

                            //0000 0000    0000 0000    0000 0000   0000 1111
            int f = a << 2; //0000 0000    0000 0000    0000 0000   0011 1100 => 60
            Console.WriteLine("a << 2: " + f);
            Console.WriteLine("a << 1: " + (a << 1)); //왼쪽으로 1시프트 하면 2배로 증가(곱셈연산)

                             //0000 0000    0000 0000    0000 0000   0001 0100
            int g = 20 >> 2; //0000 0000    0000 0000    0000 0000   0011 0101 => 5
            Console.WriteLine("20 >> 2: " + g);
            Console.WriteLine("20 >> 1: " + (20 >> 1)); //오른쪽으로 1시프트 하면 2로 나눔(나눗기 연산)

                             //0000 0000    0000 0000    0000 0000   0001 0110
            int h = ~b;      //1111 1111    1111 1111    1111 1111   1110 1001 => -23
            Console.WriteLine("h = ~b: " + h);

            //0000 0000    0000 0000    0000 0000   0001 0110
            //1111 1111    1111 1111    1111 1111   1110 1001 => -23
            //1111 1111    1111 1111    1111 1111   1111 1010 => -6
            //(CPU에 따라 다른 결과)(0으로 채워지는 경우도 있고 1로 채워지는 경우도 있음)
            int i = (~b) >> 2;
            Console.WriteLine("i = (~b) >> 2: " + i);

            //string s = Convert.ToString(a, 2).PadLeft(32, '0');
        }
    }
}
