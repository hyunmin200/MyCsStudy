using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _057_Check
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int[] stu = new int[5];
            int max = int.MinValue;
            int min = int.MaxValue;
            //for(int i = 0; i < stu.Length; i++)
            //{
            //    Console.Write("학생의 성적을 입력하세요: ");
            //    stu[i] = int.Parse(Console.ReadLine());
            //}
            //for(int i = 0; i < stu.Length; i++)
            //{
            //    if(min > stu[i])
            //    {
            //        min = stu[i];
            //    }
            //    if(max < stu[i])
            //    {
            //        max = stu[i];
            //    }
            //}

            for(int i = 0; i < 5; i++)
            {
                Console.Write("학생의 성적을 입력하세요: ");
                int inputNum = int.Parse(Console.ReadLine());

                if(max < inputNum)
                {
                    max = inputNum;
                }

                if(min > inputNum)
                {
                    min = inputNum;
                }
            }
            Console.WriteLine("최대값: {0}", max);
            Console.WriteLine("최소값: {0}", min);
        }
    }
}
