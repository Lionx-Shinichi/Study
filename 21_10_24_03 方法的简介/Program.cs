using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace _21_10_24_03_方法的简介
{
    class Program
    {
        /// <summary>
        /// 计算两个整数之间的最大值，然后返回最大值
        /// </summary>
        /// <param name="n1">第一个整数</param>
        /// <param name="n2">第二个整数</param>
        /// <returns>将最大值返回</returns>
        public static int GetMax(int n1, int n2)//写方法需要写注释！文档注释是三个斜杠
        {
            return n1 > n2 ? n1 : n2;//return会直接跳出最近的方法然后返回值，在这里最近的方法是GetMax
        }

        static void Main(string[] args)
        {
            //计算两个整数之间的最大值
            int max = Program.GetMax(1, 3);
            Console.WriteLine(max);
            Console.ReadKey();

            #region 笔记
            /*
            方法（函数）语法：
            [public] static 返回值类型 方法名(Pascal规范)（参数列表）

            函数就是将一堆代码进行重复利用的一种机制
            函数就是一段代码，这段代码可能有需要输入的值（也就是参数），可能会返回值。

            public：访问修饰符
            static：静态的
            返回值类型：如果不需要返回值，写void（无返回值）
            方法名：Pascal规范
            参数列表：完成这个方法所必须提供给这个方法的条件，如果没有参数也不能省略这个小括号

            方法写完后执行需要在main函数中调用

            return：
            1)	在方法中返回要返回的值
            2)	立即结束本次方法
            */
            #endregion
        }
    }
}
