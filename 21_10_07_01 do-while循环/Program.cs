using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_10_07_01_do_while循环
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //明天小兰就要登台演出了，老师说把明天演出的歌曲再唱一遍
            //如果用户（老师）满意，小兰就可以回家了，否则就要再练习一遍，直到用户（老师）满意为止。
            Console.WriteLine("老师，明天我就要登台演出了，我现在把明天要唱的歌再唱一遍，老师能给我评价一下吗");
            string answer = "";

            while (answer != "很好")
            {
                Console.WriteLine("小兰演出中...");
                Console.WriteLine("老师，我表演的怎么样？如果不满意我就再练习一次。");
                answer = Console.ReadLine();
            }
            Console.WriteLine("谢谢老师！那我先回家了~");
            Console.ReadKey();

            //像这种先执行一遍，然后再去判断循环条件是否成立的循环，可以使用do-while循环

            Console.WriteLine("老师，明天我就要登台演出了，我现在把明天要唱的歌再唱一遍，老师能给我评价一下吗");
            string answer1 = "";
            do
            {
                Console.WriteLine("小兰演出中...");
                Console.WriteLine("老师，我表演的怎么样？如果不满意我就再练习一次。");
                answer1 = Console.ReadLine();
            } while (answer1 != "很好");
            Console.WriteLine("谢谢老师！那我先回家了~");
            Console.ReadKey();

            //练习1：要求用户输入账号密码，admin和888888，否则退回。
            string username1 = "";
            string pwd1 = "";
            do
            {
                Console.WriteLine("请输入你的用户名");
                username1 = Console.ReadLine();
                Console.WriteLine("请输入你的密码");
                pwd1 = Console.ReadLine();
                if (username1 != "admin" || pwd1 != "888888")
                {
                    Console.WriteLine("账号或密码错误");
                }
            } while (username1 != "admin" || pwd1 != "888888");
            Console.WriteLine("登录成功");
            Console.ReadKey();

            //练习2：要求用户输入学生姓名，输入q结束
            string input2 = "";
            do
            {
                Console.WriteLine("请输入学生姓名，输入q离开程序");
                input2 = Console.ReadLine();
            } while (input2 != "q");

            //练习3：要求用户输入数字，然后打印这个数字的2倍，当用户输入q的时候程序退出
            string input3 = "";
            double number3 = 0;
            while (input3 != "q")
            {
                Console.WriteLine("请输入一个数字，将返回其二倍");
                try
                {
                    number3 = Convert.ToDouble(input3 = Console.ReadLine());
                    Console.WriteLine(number3*2);
                }
                catch
                {
                    if(input3!="q")
                    {
                        Console.WriteLine("您的输入不合法，请重新输入");
                    }
                    else
                    {
                        break;
                    }
                }
            }

            //练习4：不断要求用户输入数字，当用户输入end的时候显示刚才输入的数字的最大值
            string input4 = "";
            double number4 = 0;
            int i4 = 1;
            int imax4 = 0;
            double max4 = 0;
            while (input4 != "end")
            {
                Console.WriteLine("请输入第{0}个数字，输入完全部数字后输入end可以筛选出其中的最大值", i4);
                try
                {
                    number4 = Convert.ToDouble(input4 = Console.ReadLine());
                    if (number4 > max4 || i4 == 1)
                    {
                        max4 = number4;
                        imax4 = i4;
                    }
                    i4++;
                }
                catch
                {
                    if (input4 != "end")
                    {
                        Console.WriteLine("您的输入有误,请再试一次");
                    }
                    else
                    {
                        Console.WriteLine("计算晚比，第{0}次输入的数字{1}最大", imax4, max4);
                        Console.ReadKey();
                    }
                }
            }

            #region 笔记
            /*
            do-while循环
            
            do
            {
                循环体;
            }while(循环条件);
            
            执行过程：先执行一遍do括号内的循环体，然后再判断while后面的循环条件是否成立，如果成立则继续执行do中的循环体，如果不成立则跳出do-while循环。
            
            特点：至少会执行一遍循环体，而while可能一遍都不执行。

            */
            #endregion
        }
    }
}
