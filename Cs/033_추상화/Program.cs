using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _033_추상화
{
    class Program
    {
        class Student
        {
            public string id;
            public string name;
            public int grade;
            public string major;
            public DateTime birthday;
        }
        static void Main(string[] args)
        {
            //추상화
            //클래스는 왜 사용하냐?
            //일반적으로 클래스 기반의 객체 지향 프로그래밍 언어는 다음 네 가지 특징이 있다. 그리고 이 클래스를 사용하는 기본 이유이다.
            // -추상화     -캡슐화      -상속      -다형성     이 있다
            //상황에 맞는 속성만 사용하는 것이다
            //예로 학생 관리 프로그램을 만든다고 하면 학번,이름,생년월일,학과,학년 등이 있다
            //여기서 핵심적인 부분을 추출하는 것을 추상화라고 부른다.
            //학생이라는 객체에서 핵심적인 부분을 추출해보자 -class student
        }
    }
}
