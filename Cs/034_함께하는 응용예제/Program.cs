using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _034_함께하는_응용예제
{
    class Program
    {
        class Student
        {
            public string name;
            public int grade;
        }
        static void Main(string[] args)
        {
            //앞에서 학생을 추상화해서 클래스를 만들었다. 인스턴스 변수만 가지고 있는 클래스이다.
            //이렇게 변수만 가지고 있는 클래스를 모델 클래스라고 부른다.
            //그리고 실제 응용 프로그램 개발을 할 때 만들 클래스의 90%가 대부분 이러한 모델 클래스이다.

            //모델 클래스와 List 클래스
            //List<Student> list = new List<Student>();
            //list.Add(new Student() { name = "황현민", grade = 1 });
            //list.Add(new Student() { name = "200원", grade = 2 });
            //list.Add(new Student() { name = "나이름", grade = 3 });
            //list.Add(new Student() { name = "김이름", grade = 4 });
            //list.Add(new Student() { name = "김이름", grade = 5 });
            //list.Add(new Student() { name = "박이름", grade = 2 });
            //list.Add(new Student() { name = "성이름", grade = 3 });

            //리스트와 모델 클래스 동시 초기화
            List<Student> list = new List<Student>()
            {
                new Student() { name = "황현민", grade = 1 },
                new Student() { name = "200원", grade = 2 },
                new Student() { name = "나이름", grade = 3 },
                new Student() { name = "김이름", grade = 4 },
                new Student() { name = "김이름", grade = 5 },
                new Student() { name = "박이름", grade = 2 },
                new Student() { name = "성이름", grade = 3 }
            };

            foreach (var item in list)
            {
                Console.WriteLine(item.name + " : " + item.grade);
            }
        }
    }
}
