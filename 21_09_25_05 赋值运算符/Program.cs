using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_09_25_05_赋值运算符
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 10;
            //当变量被重新赋值，旧值便会被覆盖（注意不要重复定义）
            n = 50;
            Console.WriteLine(n);
            Console.ReadKey();
            //打印结果为50

            #region 笔记
            /*
            赋值运算符
            =：表示赋值，把等号右边的值赋值给左边的变量，由等号连接的表达式称之为赋值表达式。
            每个表达式都可以求解出一个定值，对于赋值表达式而言，等号左边的变量的值就是整个赋值表达式的值。

            */
            #endregion

        }
    }
}
