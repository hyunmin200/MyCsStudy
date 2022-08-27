using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _047_메모화
{
    class Fibonacci
    {
        private static Dictionary<int, long> memo = new Dictionary<int, long>(); //계산한 피보나치 수를 저장하는 Dictionary 객체를 만든다
        public static long Get(int i)
        {
            //기본값
            if (i < 0) { return 0; }
            if (i == 1) { return 1; }

            //이미 계산했던 값인지 확인한다.
            if (memo.ContainsKey(i))
            {
                return memo[i];
            }
            else
            {
                //계산하지 않았다면 계산합니다.
                long value = Get(i - 2) + Get(i - 1);
                memo[i] = value;
                return value;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //하지만 위 재귀 메서드와 재귀 인덱서에는 큰 문제가 있다.
            //예를 들어 피보나치 4를 구한다고 하면 같은 피보나치 수를 계속해서 구하게된다. 그래서 프로그램의 속도가 느려진다.
            //피보나치 100을 구하려면 엄청난 시간이 걸린다.
            //이런 문제를 해결할 때는 메모화라는 기술을 사용한다.
            //메모화는 한 번 계산했던 값을 저장 해두는 기술을 의미한다
            Console.WriteLine(Fibonacci.Get(40));
            Console.WriteLine(Fibonacci.Get(100));
        }
    }
}
