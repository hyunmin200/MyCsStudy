using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _013_if_else_if_조건문
{
    class Program
    {
        static void Main(string[] args)
        {
            //if else if 조건문
            if(DateTime.Now.Hour < 11)
            {
                Console.WriteLine("아침 먹을 시간입니다.");
            }
            else if(DateTime.Now.Hour < 15)
            {
                Console.WriteLine("점심 먹을 시간입니다.");
            }
            else
            {
                Console.WriteLine("저녁 먹을 시간입니다.");
            }

            //논리 연산자와 조건문
            //학점 변수
            double score = 2.6;

            //조건을 구분합니다.
            if (score == 4.5)
                Console.WriteLine("신");
            else if (4.2 <= score && score < 4.5)
                Console.WriteLine("교수님의 사랑");
            else if (3.5 <= score && score < 4.2)
                Console.WriteLine("교수님의 사랑");
            else if (2.8 <= score && score < 3.5)
                Console.WriteLine("현 체제의 수호자");
            else if (2.3 <= score && score < 2.8)
                Console.WriteLine("일반인");

            //조건문 간단 사용
            //if else 조건문은 이전에 비교했던 것이 자동으로 걸러지므로, 이번에 비교했던 것을 다시 비교할 필요가 없다.
            if (score == 4.5)
                Console.WriteLine("신");
            else if (4.2 <= score)
                Console.WriteLine("교수님의 사랑");
            else if (3.5 <= score)
                Console.WriteLine("교수님의 사랑");
            else if (2.8 <= score)
                Console.WriteLine("현 체제의 수호자");
            else if (2.3 <= score)
                Console.WriteLine("일반인");
            else
            {
                Console.WriteLine("어쩔티비");
            }
        }
    }
}
