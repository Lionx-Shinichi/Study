using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_11_13_01_构造函数
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //在Main函数中初始化对象及其繁琐，特别是创建多个对象时
            //例如：zhangSan.Name="张三";
            //可以使用构造函数将初始化赋值的部分写到构造函数中
            //然后向构造函数传参，就可以简化该过程

            //使用构造函数初始化对象zhangSan的过程
            Student zhangSan = new Student("张三", 18, '男', 82, 93, 79);
            zhangSan.SayHello();
            zhangSan.ShowScoal();
            Console.ReadKey();

            //使用构造函数初始化对象xiaoHong的过程
            Student xiaoHong = new Student("小红", 18, '女', 98, 79, 89);
            xiaoHong.SayHello();
            xiaoHong.ShowScoal();
            Console.ReadKey();

            //使用使用了this关键字的构造函数初始化对象路易的过程
            Student luYi = new Student("路易", 80, 80, 80);
            luYi.SayHello();
            luYi.ShowScoal();
            Console.ReadKey();
        }
    }
}
