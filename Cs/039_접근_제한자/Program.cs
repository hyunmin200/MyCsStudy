using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _039_접근_제한자
{
    class Test
    {
        public void TestMethod()
        {
            Program.Main(new string[] { " " });
            //위 주석을 풀고 main에 마우스를 올려본다면 자물쇠가 채워져 있는 것을 볼 수 있다.
            //Main()에 public 접근 제한자를 붙혀서 오류를 고칠 수 있다.
        }
    }
    class Program
    {
        class Test
        {
            public void TestMethod()
            {
                //내부 클래스의 메서드에서 private 메서드 접근
                Program.Main(new string[] { "" });
            }
        }

        public void TestMethod()
        {
            //자신의 클래스가 가진 메서드에서 private 메서드 접근
            Program.Main(new string[] { "" });
        }

        //public 추가함
        public static void Main(string[] args)
        {
            //접근 제한자
            //접근 제한자를 입력하지 않으면 자동으로 private 접근 제한자가 설정이 된다.
            //지금 Main()과 같이 안적어둔다면 private로 자동 설정이 된다.
            //private 접근 제한자가 걸리면 자신의 클래스 내부에서만 해당 메서드를 사용할 수 있게 된다.
            //다음 코드와 같이 있는 자신의 클래스의 내부에 있는 클래스의 매서드(내부 클래스 메서드) 또는 자신의 클래스 내부에 있는 매서드에서는 접근 가능합니다.
            //private 접근 제한자와 달리 public 접근 제한자가 걸린 변수 또는 메서드 모든 곳에서 접근할 수 있다. 
            //지금은 public만 쓰면 되지 않나? 라고 할 수 있는데 캡슐화의 관점에서 보면 외부에서 정말 사용할 일이 없는 변수 또는 메서드라면 안전하게
            //private를 붙여주는 것이 좋다.

        }
    }
}
