using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _042_속성
{
    class Box
    {
        private int width;
        private int height;
        //public에서 private

        public Box(int width, int height)
        {   
            if(width > 0 || height > 0)
            {
                this.width = width;
                this.height = height;
            }
            else
            {
                Console.WriteLine("너비와 높이는 자연수로 초기화해주세요!");
            }
            //이런 식으로 예외처리를 한다면 오류를 쉽게 찾아낼 수 있다. 
            //하지마 이제 한 번 생성한 width와 height를 바꿀 수 없다.
            //게다나 width와 height에 어떤 값이 들어있는지 확인조차 할 수 없는 대참사가 일어났다.
        }
    
        public int Area()
        {
            return this.width * this.height;
            //이런 코드를 만들었다고 하였는데 협업을 하였는데 다른 팀원이 width를 음수로 하여 따른 값이 나온다면 문제가 될 것이다.
            //그래서 클래스를 만들 때에 이러한 일이 일어나는 것을 원천적으로 봉쇄해야한다.
            //일단 변수 width 와 height에 음수가 들어갈 수 있는 위험성을 찾았습니다. 다른사람이 width와 height를 못 건드리게 다음과 같이 코드를 수정할 수 있다.
        }
    }

    
    class Program
    {
        static void Main(string[] args)
        {
            
        }
    }
}
