using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_10_04_05_判断每个月有多少天练习
{
    class Program
    {
        static void Main(string[] args)
        {
            //请用户输入年份，再输入月份，输出该月的天数（结合闰年问题），充分利用try-catch防止程序抛异常。
            //闰年条件是：能被400整除的年份或者是能被4整除但是不能被100整除的年份。
            int year = 0;
            int month = 0;
            int day = 0;
            bool errorYearOrMonth = true;
            try
            {
                Console.WriteLine("请输出您要查询的年份。");
                year = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("请输出您要查询的月份。");
                month = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                errorYearOrMonth = false;
            }
            //运算前鉴定，如果输入异常大小的年份或者月份的，直接跳转到报错if
            if (year < 1 || month < 1 || month > 12)
            {
                errorYearOrMonth = false;
            }
            //先前输入错类型的也直接跳转到报错if
            else if (errorYearOrMonth == false)
            {

            }
            //符合条件的加入运算并求值
            else
            {
                switch (month)
                {
                    case 4:
                    case 6:
                    case 9:
                    case 11:
                        day = 30;
                        break;
                    case 2:
                        if ((year % 400 == 0) || (year % 4 == 0 && year % 100 != 0))
                        {
                            day = 29;
                        }
                        else
                        {
                            day = 28;
                        }
                        break;
                    default:
                        day = 31;
                        break;
                }
                //结算
                Console.WriteLine("该月共有{0}天。", day);
                Console.ReadKey();
            }
            //报错if
            if (errorYearOrMonth == false)
            {
                Console.WriteLine("输入有误，程序即将关闭");
                Console.ReadKey();
            }
        }
    }
}
