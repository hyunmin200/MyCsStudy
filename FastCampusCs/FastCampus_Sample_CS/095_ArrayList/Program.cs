using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _095_ArrayList
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList arrList = new ArrayList();

            arrList.Add("Hello"); //Add(string name);
            arrList.Add(10f); // Add(float num);
            //Add는 모든 자료형 다 받을 수 있음

            for (int i = 0; i < 10; i++)
            {
                arrList.Add(i);
            }

            foreach (object data in arrList)
            {
                Console.WriteLine("arrList data: " + data);
            }

            //배열데이터로 초기화
            Console.WriteLine("배열데이터로 초기화");
            int[] arrData = { 100, 200, 300 };
            ArrayList arrCopyList = new ArrayList(arrData);

            foreach (object data in arrCopyList)
            {
                Console.WriteLine("arrCopyList data: " + data);
            }
        }
    }
}
