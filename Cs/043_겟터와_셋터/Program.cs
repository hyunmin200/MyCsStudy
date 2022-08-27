using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _043_겟터와_셋터
{
    //class Box
    //{
    //    //변수
    //    private int width;
    //    private int height;

    //    //생성자
    //    public Box(int width, int height)
    //    {
    //        if(width > 0 || height > 0)
    //        {
    //            this.width = width;
    //            this.height = height; 
    //        }
    //        else
    //        {
    //            Console.WriteLine("너비와 높이는 자연수로 초기화해주세요!");
    //        }
    //    }

    //    //인스턴스 메서드
    //    public int Area() { return this.width * this.height; }

    //    //겟터(Getter)
    //    public int GetWidth() { return width; }
    //    public int GetHeight() { return height; }

    //    //셋터(Setter)
    //    public void SetWidth(int width)
    //    {
    //        if(width > 0) { this.width = width; }
    //        else { Console.WriteLine("너비는 자연수를 입력해주세요"); }
    //    }
    //    public void SetHeight(int height)
    //    {
    //        if (width > 0) { this.height = height; }
    //        else { Console.WriteLine("높이는 자연수를 입력해주세요"); }
    //    }

        //이렇게 겟터와 셋터를 사용하면 안전하게 값을 넣고 빼는 것이 가능해진다.
        //C# 개발자들은 이를 조금 더 짧게 쓸 수 있는 방법을 만들었다.
        //속성은 겟터와 셋터를 손쉽게 만들 수 있는 방법입니다. 속성을 만드는 방법이 굉장히 다양하다. 일반적으로는 다음과 같다.
        //private int [변수 이름];
        //public int [속성 이름]
        //{
        //  get { retrun [변수 이름]; }
        //  set { [변수 이름] = value; }
        //}
        //아직 어떻게 사용하는 것인지 조금 힘들다. 이렇게 만들어진 속성은 다음과 같이 사용한다.
        //[인스턴스 이름].[속성 이름]  //겟터 호출
        //[인스턴스 이름].[속성 이름] = [값] //셋터 호출
    
    //}

    class Box
    {
        private int width;
        public int Width //속성 Width를 생성한다.
        {
            get { return width; }
            set
            {
                if(value > 0) { width = value; }
                else { Console.WriteLine("너비는 자연수를 입력해주세요"); }
            }
        }

        private int height;
        public int Height //속성 Height를 생성한다.
        {
            get { return height; }
            set
            {
                if(value > 0) { height = value; }
                else { Console.WriteLine("높이는 자연수를 입력해주세요"); }
            }
        }

        //생성자
        public Box(int width, int height)
        {
            Width = width;
            Height = height;
        }

        //인스턴스 메서드
        public int Area() { return this.width * this.height; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //전에꺼에서 이어짐
            //일단 public으로 변수를 선언해버리면 외부에서 마음대로 값을 설정해버릴 수 있다.
            //음수를 넣을 수 있는 가능성이 발생한다. 그렇다고 private으로 변수를 선언하면 외부에서 아예값을 건드릴 수 없다.
            //값을 안전하게 변경하려면 어떻게 해야할까?
            //여기서 겟터(Getter)와 셋터(Setter)이다.
            //변수를 바로 건드릴 수는 없지만 변수를 변경하는 메서드를 만들고, 메서드 호훌해 변경하면 된다.
            Box box = new Box(-10, -20);

            box.Width = -200;
            box.Height = -100;
        }
            //box.했을 때 자동완성으로 스페너모양이 뜬다면 속성을 의미하는 것이다.
            //속성의 이름은 대문자로 시작하는 것이 C# 개발자들의 약속이다.

            //이런것도 10개, 20개 만들다 보면 힘들기 때문에
            //진짜 간단하게 속성은 생성하는 방법이 있다
            //public int Width { get; set; }
            //public int Height { get; set; }
            //이렇게 입력하면서 속성을 사용하는 것이나, 변수를 사용하는 것이나 큰 차이 없다.
            //하지만 프레임워크를 사용할 때 이런 코드를 자주 사용하게 된다.

            //이래도 외우기 힘들기 때문에 자동완성 기능을 이용하는것도 좋다
            //prop을 적고 탭을 두번 누르면 밑에 코드가 나오고
            public int MyProperty { get; set; }
            //propfull을 적고 탭을 두번 누르면 밑에 코드가 나온다
            private int myVar;

            public int MyProperty1
            {
                get { return myVar; }
                set { myVar = value; }
            }
            //굉장히 유용한 코드 조각이기 때문에 기억해두자
    }
}
