using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_10_03_04_if_else结构
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            //编程实现：如果学习的时间大于60分钟，那么奖励可以玩一会儿游戏。
            Console.WriteLine("请输入你学习了多长时间");
            double time = Convert.ToDouble(Console.ReadLine());

            if (time > 60)
            {
                Console.WriteLine("那么放松一下玩一会儿游戏吧");
            }
            if (time < 60)
            {
                Console.WriteLine("才学了这点？");
            }
            Console.ReadKey();
            */

            //以上代码，可以利用if-else结构简便表达
            //编程实现：如果学习的时间大于60分钟，那么奖励可以玩一会儿游戏。
            Console.WriteLine("请输入你学习了多长时间");
            double time = Convert.ToDouble(Console.ReadLine());

            if (time > 60)
            {
                Console.WriteLine("那么放松一下玩一会儿游戏吧");
            }
            else
            {
                Console.WriteLine("才学了这点？");
            }
            Console.ReadKey();

            //练习：请输出你的考试成绩
            //如果考试成绩达到80分，则奖励100元，否则就鼓励他继续学习
            Console.WriteLine("请输入你的考试成绩");
            double score = Convert.ToDouble(Console.ReadLine());
            if (score >= 80)
            {
                Console.WriteLine("奖励你100元");
            }
            else
            {
                Console.WriteLine("下次再接再厉");
            }
            Console.ReadKey();

            //练习2：请输入你的考试成绩
            //然后测评学员的考试成绩，A=100~90（含） B=90~80（含） C=80~70（含） D=70~60（含） E=60以下
            Console.WriteLine("请输入您的成绩");
            double score2 = Convert.ToDouble(Console.ReadLine());
            if (score2 >= 90)
            {
                Console.WriteLine("您的成绩等第是A");
            }
            else
            {
                if (score2 >= 80)
                {
                    Console.WriteLine("您的成绩等第是B");
                }
                else
                {
                    if (score2 >= 70)
                    {
                        Console.WriteLine("您的成绩等第是C");
                    }
                    else
                    {
                        if (score2 >= 60)
                        {
                            Console.WriteLine("您的成绩等第是D");
                        }
                        else
                        {
                            Console.WriteLine("您的成绩等第是E");
                        }
                    }
                }
            }
            Console.ReadKey();

            #region 笔记
            /*
            if-else语句
            语法：
            if（判断条件）
            {
                要执行的代码;
            }
            else
            {
                要执行的代码
            }
            
            执行过程：
            程序运行到if处，会首先判断if所带的小括号的判断条件
            如果条件成立（True），则执行if所带的大括号的代码，跳过else所带的大括号的代码
            如果条件不成立（False），则跳过if所带的大括号的代码，执行else所带的大括号的代码
            执行结束后，该跳出if-else结构继续向下执行
            
            if-else结构的特点：
            先判断，再选择执行。
            至少要执行一条代码。
            适用于判断会有两个情况的问题。
            */

            #endregion
        }
    }
}
