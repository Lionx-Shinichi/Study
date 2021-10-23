using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_09_29_01_算数运算符
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //两个int类型值进行算数运算，最后得出的结果也一定是int类型值
            int n1 = 10;
            int n2 = 3;
            double result = n1 / n2;
            Console.WriteLine(result);
            Console.ReadKey();
            //result值为3
            

            //演示：某学生三门课成绩为，语文：90，数学：80，英语：67，编程求总分和平均分。
            int chinese = 90;
            int math = 80;
            int english = 67;
            Console.WriteLine("总成绩是{0}，平均成绩是{1}",chinese+math+english,(chinese+math+english)/3);
            Console.ReadKey();

        }
    }
}
