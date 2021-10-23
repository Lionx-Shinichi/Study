using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_10_10_01_Continue和质数
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            //练习1：用while continue实现计算1到100（含）之间的除了能被7整除之外所有整数的和
            int sum = 0;
            for (int i = 1; i <= 100; i++)
            {
                if (i % 7 != 0)
                {
                    Console.WriteLine(i);
                    sum += i;
                }
            }
            Console.WriteLine("1到100（含）之间的除了能被7整除之外所有整数的和是{0}", sum);
            Console.ReadKey();
            */

            //练习2：找出1000以内的所有素数(高难度)
            //素数即质数，就是只能被1和本身整除的数，质数从2开始。
            bool error=true;
            int times = 0;
            for (int i2 = 2; i2 <= 1000; i2++)
            {
                for (int j2 = 2; j2 < i2; j2++)
                {
                    if (i2 % j2 == 0)
                    {
                        error = false;
                        break;
                    }
                }
                if(error)
                {
                    Console.WriteLine(i2);
                    times++;
                }
                error = true;
            }
            Console.WriteLine("共计{0}个", times);
            Console.ReadKey();

            #region 笔记
            /*
            Continue
            立即结束本次循环体的执行，然后跳转回判断循环条件处。（for语句的i++;依然会在循环体结束执行后执行一遍）
            一般搭配if使用
            */
            #endregion
        }
    }
}
