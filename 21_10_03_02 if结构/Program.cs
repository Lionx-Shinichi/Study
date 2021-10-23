using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_10_03_02_if结构
{
    class Program
    {
        static void Main(string[] args)
        {
            //编程实现：如果学习的时间大于60分钟，那么奖励可以玩一会儿游戏。
            Console.WriteLine("请输入你学习了多长时间");
            double time = Convert.ToDouble(Console.ReadLine());

            if (time > 60 == true)
            //==true是可以省略的，==false必须要完整写出来
            {
                Console.WriteLine("那么放松一下玩一会儿游戏吧");
            }
            if (time < 60)
            {
                Console.WriteLine("才学了这点？");
            }
            Console.ReadKey();

            #region 笔记
            /*
            if语句
            语法：
            if（判断条件）
            {
                要执行的代码;
            }
            （小括号和大括号后面都没有分号）
            
            判断条件：
            一般为关系表达式或bool类型的值。
            
            执行过程：
            程序运行到if处，会首先判断if所带的小括号的判断条件
            如果条件成立（True），则执行if所带的大括号的代码
            如果条件不成立（False），则跳过该if结构，继续向下执行
           
            if结构的特点：
            先判断，再执行。
            可以不执行其中的代码跳过该结构。
            适用于判断仅有一个情况的问题。

            */
            #endregion
        }
    }
}
