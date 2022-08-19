using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _005_var_키워드
{
    class Program
    {
        //var global = 52;            전역(인스턴스) 변수는 var 키워드 사용 불가
        static void Main(string[] args)
        {
            //var 키워드
            var number = 100;

            //var 키워드 제약
            //var number1 = 10.2;
            //number1 = "변경";

            //지역변수
            var local = 273; //지역변수는 var 키워드 사용 가능

            //var 키워드의 선언과 초기화 동시 수행
            var number2 = 20; //var 키워드는 무조건 선언과 초기화를 동시 수행해야 한다!

            //var 키워드를 사용한 다양한 자료형 선언
            var numberA = 100L; //long
            var numberB = 100.0; //double
            var numberC = 100.0F; //float
            //*주의* long은 뒤에 소문자를 쓰면 숫자 1과 비슷해 보이기 때문에 대문자 L을 사용하는 것이 좋다!
        }
    }
}
