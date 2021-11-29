using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_11_28_07_var推断类型
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //var:根据值可以推断出类型
            //C#是一门强类型语言,要求在代码中必须对每一个变量的类型明确定义
            //Js是一门弱类型语言,很多类型都可以用var表示,不需要明确定义,系统会根据值来推断出变量的类型
            var n1 = 15;
            var n2 = "张三";
            var n3 = 3.14;
            var n4 = 5000m;
            var n5 = true;
            var n6 = '男';
            Console.WriteLine(n1.GetType());
            Console.WriteLine(n2.GetType());
            Console.WriteLine(n3.GetType());
            Console.WriteLine(n4.GetType());
            Console.WriteLine(n5.GetType());
            Console.WriteLine(n6.GetType());
            Console.ReadKey();

            //但是如果变量一旦没有初值,就无法判断变量类型,系统就会报错
        }
    }
}
