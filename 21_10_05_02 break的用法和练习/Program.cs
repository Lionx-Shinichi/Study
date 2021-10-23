using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_10_05_02_break的用法和练习
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int i = 1;
            while (i <= 10)
            {
                Console.WriteLine("Hello world");
                if (i == 5)
                {
                    break;
                }
                i++;
            }
            Console.ReadKey();
            //break的作用就是跳出距离最近的循环和switch结构
            //最后Hello world打印了5遍

            //练习1：输入班级人数，然后依次输入学员成绩，计算班级学员的平均成绩和总成绩
            try
            {
                Console.WriteLine("请输入班级人数");
                int member1 = Convert.ToInt32(Console.ReadLine());
                int i1 = 1;
                double sumscore1 = 0;
                bool error1 = false;
                while (i1 <= member1)
                {
                    Console.WriteLine("请依次输入学生成绩，现在请输出第{0}位学生的成绩", i1);
                    try
                    {
                        sumscore1 += Convert.ToDouble(Console.ReadLine());
                        i1++;
                    }
                    catch
                    {
                        Console.WriteLine("您输入的值不符合规定，请按任意键盘键退出程序");
                        Console.ReadKey();
                        error1 = true;
                        break;
                    }
                }
                if (error1 == false)
                {
                    Console.WriteLine("学生的总成绩是{0}，平均成绩是{1}", sumscore1, sumscore1 / member1);
                    Console.ReadKey();
                }
            }
            catch
            {
                Console.WriteLine("您输入的值不符合规定，请按任意键盘键退出程序");
                Console.ReadKey();
            }

            //练习2：要求用户输入用户名和密码 用户名只要不是admin 密码不是888888则发回重输，模糊化具体的错误内容
            string username2 = "";
            string pwd2 = "";
            Console.WriteLine("请输入您的用户名");
            username2 = Console.ReadLine();
            Console.WriteLine("请输入您的密码");
            pwd2 = Console.ReadLine();
            while (username2 != "admin" || pwd2 != "888888")
            {
                Console.WriteLine("用户名或密码错误，请再次输入您的用户名");
                username2 = Console.ReadLine();
                Console.WriteLine("请再次输入您的密码");
                pwd2 = Console.ReadLine();
            }
            Console.WriteLine("登录成功!");
            Console.ReadKey();

            //练习2第二种思路
            string username3 = "";
            string pwd3 = "";
            bool i3 = true;
            while (i3)
            {
                Console.WriteLine("请输入您的用户名");
                username3 = Console.ReadLine();
                Console.WriteLine("请输入您的密码");
                pwd3 = Console.ReadLine();
                if (username3 == "admin" && pwd3 == "888888")
                {
                    i3 = false;
                }
                else
                {
                    Console.WriteLine("用户名或密码错误");
                }
            }
            Console.WriteLine("登录成功!");
            Console.ReadKey();


            //练习3：要求用户输入用户名和密码 用户名只要不是admin 密码不是888888则发回重输，模糊化具体的错误内容，且最多尝试3次
            string username4 = "";
            string pwd4 = "";
            int i4 = 1;

            while (i4 < 4)
            {
                Console.WriteLine("请输入您的用户名");
                username4 = Console.ReadLine();
                Console.WriteLine("请输入您的密码");
                pwd4 = Console.ReadLine();
                if (username4 == "admin" && pwd4 == "888888")
                {
                    Console.WriteLine("登录成功!");
                    Console.ReadKey();
                    break;//break用来跳出最近的循环或者switch结构。在这里跳出即结束程序
                }
                else
                {
                    Console.WriteLine("用户名或密码错误");
                    i4++;
                }
            }
            
            //练习4:老师问学生，这道题你会做了吗？如果学生回答"会了（Y）"，则可以放学
            //否则老师再讲一遍，再问学生是否会了，直到学生回为止，才可以放学
            //但是如果讲了10遍学生还不会，则直接放学
            int i5 = 1;
            string answer5 = "";
            while (i5 <= 10)
            {
                Console.WriteLine("这是我第{0}遍给你讲，这道题要用到while循环，你会了吗？", i5);
                answer5 = Console.ReadLine();
                if (answer5 == "会了")
                {
                    break;
                }
                else
                {
                    i5++;
                    if (i5 <= 10)
                    {
                        Console.WriteLine("那我再讲一遍");
                    }
                }
            }
            if (i5 <= 10)
            {
                Console.WriteLine("很好，可以放学了");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("时间不早了，可以放学了");
                Console.ReadKey();
            }


            //练习5：2006年培养学员80000人，每年增长25%，请问按照此速度，到那一年培训学员的人数可以达到20万人。
            double students6 = 80000;
            int i6 = 0;
            while (students6 < 200000)
            {
                students6 *= 1.25;
                i6++;
            }
            Console.WriteLine("到{0}年，培训学员的人数可以达到20万人。", i6 + 2006);
            Console.ReadKey();
            #region 笔记

            /*
            break
            可以跳出最近的switch-case结构和循环结构
            执行过程：结构执行到break时，程序就会终结其所处最近的switch语句或循环
            break一般在循环中搭配if使用，表示满足某些条件即终止循环
            */

            #endregion

        }
    }
}
