using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_10_03_01_判断闰年练习
{
    class Program
    {
        static void Main(string[] args)
        {
            //练习：让用户输入一个年份判断是否为闰年
            //条件是：能被400整除的年份或者是能被4整除但是不能被100整除的年份。
            Console.WriteLine("请输入要判断的年份");
            int year = Convert.ToInt32(Console.ReadLine());
            //逻辑与和逻辑或是有优先级的 先与再或，但是因为便于阅读，在编写时应该用括号括起来。
            bool answer = (year % 400 == 0) || (year % 4 == 0 && year % 100 != 0);
            Console.WriteLine(answer);
            Console.ReadKey();
        }
    }
}
