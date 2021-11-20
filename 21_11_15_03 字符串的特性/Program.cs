using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_11_15_03_字符串的特性
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //可以将string类型看作是char类型的一个只读数组
            string s = "abcdefg";
            Console.WriteLine(s[0]);
            Console.ReadKey();
            //打印结果为a
            //当试图给s[0]赋值时
            //s[0] = "e";
            //此时就会报错：无法为其赋值，他是只读的

            //如果想要修改s[0]的内容时，应该将其类型更改为char类型的数组 使用面向对象方法ToCharArray
            char[] chs = s.ToCharArray();
            chs[0] = 'h';
            //使用 new string(char[]); 将char类型数组转换为string类型
            s = new string(chs);
            Console.WriteLine(s);
            Console.ReadKey();
            //此时首字母被改为了h

            StringBuilder sb = new StringBuilder();
            string str = null;
            //创建一个叫做sw的计时器用来记录程序的运行时间
            Stopwatch sw = new Stopwatch();
            sw.Start();
            for (int i = 0; i < 100000; i++)
            {
                //使用这个方法可以让字符串始终在一个内存空间中重新赋值，不需要再另开空间
                sb.Append(i);
            }
            sw.Stop();
            Console.WriteLine(str);
            Console.WriteLine(sb.ToString());
            //打印出程序从Start到Stop所经过的时间
            Console.WriteLine(sw.Elapsed);
            //使用StringBuilder的运行时间大约在0.01s 使用string自己赋值的运行时间大约在18s
            Console.ReadKey();

            //练习

            #region 笔记
            /*
            1.字符串的不可变性
            当给字符串重新赋值时，旧值没有销毁，而是开辟一块新空间存储新的值，其在栈中指向的内存地址将更改为新值的地址，因此在程序中大量给字符串重新赋值会产生大量垃圾
            当程序结束后，GC扫描整个内存，当发现有的空间没有被指向，就直接将其销毁
            当两个字符串均为同一个值的时候，那么这两个栈空间会指向同一个堆空间，而不会开两个相同的堆空间。
            
            2.字符串可以看作是char类型的一个只读数组

            */
            #endregion
        }
    }
}
