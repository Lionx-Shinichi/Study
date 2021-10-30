using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_10_24_01_方法的调用问题
{
    class Program
    {
        public static int Test(int x)//这里写下int x，将传入的参数限定为int类型，并赋值给x
        {
            return x += 5;
        }
        public static int _number = 10;  //使用字段模拟全局变量，可以直接在函数中运用

        //练习部分
        /// <summary>
        /// 判断参数是否是闰年
        /// </summary>
        /// <param name="year">年份</param>
        /// <returns>一个表示是否是闰年的 bool 值</returns>
        public static bool LeapYearJudgment(int year)
        {
            bool result = (year % 400 == 0) || (year % 4 == 0 && year % 100 != 0);
            return result;
        }
        static void Main(string[] args)
        {
            /*
            int a = 3;
            a = Test(a);               //这个括号里的a就是把a这个参数传递给Test函数（传参方法）
            Console.WriteLine(a);
            Console.WriteLine(_number);
            Console.ReadKey();
            */

            //练习1：写一个方法，判断这个年份是否是闰年
            //闰年条件是能被400整除的年份或者是能被4整除但是不能被100整除的年份。
            Console.WriteLine("请输入一个年份，将判断是否是闰年");
            try
            {
                int year = int.Parse(Console.ReadLine());
                bool result = LeapYearJudgment(year);
                if (result)
                {
                    Console.WriteLine("{0}是闰年", year);
                }
                else
                {
                    Console.WriteLine("{0}不是闰年", year);
                }
            }
            catch
            {
                Console.WriteLine("输入值不合法，按任意键退出程序");
            }
            Console.ReadKey();
        }
    }
}
