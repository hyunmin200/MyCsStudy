using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _033_Check
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("국어 점수 입력하세요");
            string inputKorean = Console.ReadLine();
            Console.WriteLine("영어 점수 입력하세요");
            string inputEnglish = Console.ReadLine();
            Console.WriteLine("수학 점수 입력하세요");
            string inputMath = Console.ReadLine();
            Console.WriteLine("과학 점수 입력하세요");
            string inputscience = Console.ReadLine();

            int a = int.Parse(inputKorean);
            int b = int.Parse(inputEnglish);
            int c = int.Parse(inputMath);
            int d = int.Parse(inputscience);

            Console.WriteLine("국어: {0}  영어: {1}  수학: {2}  과학: {3}", a, b, c, d);

            int sum = a + b + c + d;
            float avg = sum/4f;
            Console.WriteLine("총점: {0}  평균: {1}", sum, avg);
            //여기까지 만드는 것은 쉬운것 같다
        }
    }
}
