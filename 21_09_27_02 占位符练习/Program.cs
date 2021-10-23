using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_09_27_02_占位符练习
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            练习题：
            定义四个变量，分别存储一个人的姓名，性别（Gender），年龄，电话（TelephoneNumber）。然后打印在屏幕上
            我叫X，我今年X岁了，我是X生（性别），我的电话是XX
            */

            string name = "张三";
            char gender = '男';
            int age = 18;
            string telephoneNumber = "010-12345";

            Console.WriteLine("我叫{0}，我今年{1}岁了，我是{2}生，我的电话是{3}", name, age, gender, telephoneNumber);
            Console.ReadKey();
        }
    }
}
