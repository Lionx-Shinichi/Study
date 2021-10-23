using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_09_25_07_阶段性练习
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            练习：
            有个叫卡卡西的人在旅店登记的时候前台让他填一张表，这张表里的内容要存到电脑上，
            有姓名，年龄，邮箱，家庭住址，工资。
            之后把这些信息显示出来。

            我叫卡卡西，我住在火影村，我今年30了，我的邮箱是kakaxi@qq.com，我的工资是2000.

            后来又发现他的年龄有误，要改成81岁。
            */

            string name = "卡卡西";
            string address = "火影村";
            int age = 30;
            string email = "kakaxi@qq.com";
            decimal salary = 3000m;

            age = 81;

            //旧写法
            //Console.WriteLine("我叫" + name + "，我住在" + address + "，我今年" + age + "了，我的邮箱是" + email + "，我的工资是" + salary + ".");
            //Console.ReadKey();

            //新写法（占位符写法）
            Console.WriteLine("我叫{0}，我住在{1}，我今年{2}了，我的邮箱是{3}，我的工资是{4}。", name, address, age, email, salary);
            Console.ReadKey();
        }
    }
}
