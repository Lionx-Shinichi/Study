using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_09_25_06__号的使用
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "张三";
            //当加号两边有一边是字符串的时候，加号作为连接符使用
            Console.WriteLine("你好,"+name);
            Console.ReadKey();
            //打印结果为"你好,张三"

            //当加号两边没有字符串的时候，加号起到相加的作用
            Console.WriteLine(5 + 5);
            Console.ReadKey();
            //打印结果为"10"

            #region 笔记
            /*
            加号
            1.连接：当加号两边有一边是字符串的时候
            2.相加：两边没有字符串的时候

            */
            #endregion

        }
    }
}
