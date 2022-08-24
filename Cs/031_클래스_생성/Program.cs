using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _031_클래스_생성
{
    class Program
    {
        class Math { }
        static void Main(string[] args)
        {
            //클래스 빠르게 생성하기
            Product product = new Product();
            //이렇게 적어놓고 ctrl + . 을 하여 클래스를 생성할 수 있다
            //Console.WriteLine(Math.Abs(-10));
            //위에 class Math 처럼 원래 있던 클래스 메서드의 이름으로 만들면 쓰면 오류가 난다
            //그러니 진짜 특별한 경우가 아니라면 저런 이름으로 만드는 것을 피하자
        }
    }
}
