using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_10_03_05_if_else_if结构
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            //练习：请输入你的考试成绩
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
            */

            //以上代码，可以利用if else-if结构简便表达
            //练习：请输入你的考试成绩
            //然后测评学员的考试成绩，A=100~90（含） B=90~80（含） C=80~70（含） D=70~60（含） E=60以下
            Console.WriteLine("请输入您的成绩");
            double score = Convert.ToDouble(Console.ReadLine());
            if (score >= 90)
            {
                Console.WriteLine("您的成绩等第是A");
            }
            else if (score >= 80)
            {
                Console.WriteLine("您的成绩等第是B");
            }
            else if (score >= 70)
            {
                Console.WriteLine("您的成绩等第是C");
            }
            else if (score >= 60)
            {
                Console.WriteLine("您的成绩等第是D");
            }
            else
            {
                Console.WriteLine("您的成绩等第是E");
            }
            Console.ReadKey();

            #region 笔记
            /*
            if else-if语句
            语法：
            if（判断条件）
            {
                要执行的代码;
            }
            else if(判断条件)
            {
                要执行的代码;
            }
            else if(判断条件)
            {
                要执行的代码;
            }
            ……
            else       （在编写中这个else可有可无）
            {
                要执行的代码;
            }
            
            执行过程：
            程序首先判断第一个if所带的判断条件
            如果条件成立（True），则执行if所带的大括号的代码之后跳出该if else-if结构
            如果条件不成立（False），则跳过if所带的大括号的代码，判断下一个else if的条件是否成立 
            如果条件成立（True），则执行其所带的大括号的代码之后立即跳出该if else-if结构
            如果条件不成立（False），则跳过其所带的大括号的代码，判断下一个else if的条件是否成立 
            若判断完全部else if后条件依然不成立，则运行else所带的大括号的代码之后跳出该if else-if结构
            如果没有else，则整个if else-if全部跳过，不执行其中的任何代码。
            
            if else-if结构的特点：
            先判断，再选择执行。
            可以不执行其中的代码跳过该结构。
            适用于判断会有两个以上情况的问题。
            
            */

            #endregion
        }
    }
}
