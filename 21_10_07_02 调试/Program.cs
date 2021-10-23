using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_10_07_02_调试
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            //尝试使用F11对以下代码进行逐语句调试
            //以下代码的作用是：不断要求用户输入数字，当用户输入end的时候显示刚才输入的数字的最大值
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
            */

            //断点调试：程序将从断点处开始逐语句调试，设置好断点就可以直接启动程序
            int i2 = 1;
            Console.WriteLine("第{0}行",i2);
            i2++;
            Console.WriteLine("第{0}行", i2);
            i2++;
            Console.WriteLine("第{0}行", i2);
            i2++;
            Console.WriteLine("第{0}行", i2);
            i2++;
            Console.WriteLine("第{0}行", i2);
            i2++;
            Console.WriteLine("第{0}行", i2);
            i2++;
            Console.WriteLine("第{0}行", i2);
            i2++;
            Console.WriteLine("第{0}行", i2);
            i2++;
            Console.WriteLine("第{0}行", i2);
            i2++;
            Console.ReadKey();
            


            #region 笔记
            /*
            程序调试
            当发生如下情况时需要程序调试
            1)写完一段程序后，想看一下程序的执行过程
            2)写完一段程序后，发现程序没有依照开发初衷运行
            
            调试方法：
            1)F11逐语句调试（单步调试）
            黄色的部分是将要执行的代码，每次按下F11就会执行一行代码
            
            2)F10逐过程调试
            
            3)断点调试
            程序将从断点处开始逐语句调试，设置好断点就可以直接启动程序

            */
            #endregion
        }
    }
}