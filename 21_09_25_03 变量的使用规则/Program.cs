using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_09_25_03_变量的使用规则
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            number = 20;
            //代码中出现绿色波浪线代表代码语法没有错误，但是提示你有可能会出现错误。
            string name;
            name = "张三";
            Console.WriteLine(number);
            Console.ReadKey();
            //代码中出现红色波浪线代表代码出现了语法错误。
            Console.WriteLine(wwww);
            
            #region 笔记
            /*
            波浪线
            代码中出现红色波浪线代表代码出现了语法错误
            代码中出现绿色波浪线代表代码语法没有错误，但是提示你有可能会出现错误。
            
            变量的使用规则
            先声明
            再赋值
            再使用

            */
            #endregion

        }
    }
}
