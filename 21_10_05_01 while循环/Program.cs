using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_10_05_01_while循环
{
    class Program
    {
        static void Main(string[] args)
        {
            //向控制台打印一千遍"我下次考试一定要细心"
            //这种大量的重复操作可以使用while循环结构简便表达
            int i = 0;
            while (i < 1000)
            {
                Console.WriteLine("我下次考试一定要细心\t{0}", i);
                i++;
            }
            Console.ReadKey();

            //练习1：求1~100之间所有整数的和
            int i1 = 1;
            int sum1 = 0;
            while (i1 <= 100)
            {
                sum1 += i1++;
            }
            Console.WriteLine(sum1);
            Console.ReadKey();

            //练习2：求1~100之间所有偶数的和
            /*
            int i2 = 0;
            int sum2 = 0;
            while (i2 <= 100)
            {
                sum2 += i2;
                i2+=2;
            }
            Console.WriteLine(sum2);
            Console.ReadKey();
            */
            //也可以利用嵌套if的方法来实现
            int i3 = 1;
            int sum3 = 0;
            while (i3 <= 100) 
            {
                if (i3 % 2 == 0)  //求偶数就把==改成!=即可
                {
                    sum3 += i3;
                }
                i3++;
            }
            Console.WriteLine(sum3);
            Console.ReadKey();

            #region 笔记
            /*
            
            while循环
            语法：
            While(循环条件)
            {
                循环体;
            }
            循环条件一般是bool类型的值
            
            执行过程：程序运行到while处，首先判断循环条件是否成立，如果成立（True），则执行循环体，执行完成后再跳转回循环条件再次判断。
            如果不成立（False），则跳出while循环结构。
            如果循环条件永远成立，程序就会一直重复运行循环体的代码，出现死循环。
            所以在循环体中，应该有一个代码会改变循环条件，使循环条件不再成立。
            如果没有这行代码，就会出现死循环。

            */

            #endregion
        }
    }
}
