using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_09_28_02_接收用户的输入练习
{
    class Program
    {
        static void Main(string[] args)
        {
            //练习：请用户输入姓名，性别，年龄。当用户按下任意按键后在屏幕上显示：您好：XX，您的年龄是XX是个X生。
            Console.WriteLine("你好，请输入你的姓名");
            string name = Console.ReadLine();
            Console.WriteLine("接下来请输入你的性别");
            String gender = Console.ReadLine();
            Console.WriteLine("接下来请出入你的年龄");
            String age = Console.ReadLine();
            Console.WriteLine("您好：{0}，您的年龄是{1}，是个{2}生。", name, age, gender);
            Console.ReadKey();

        }
    }
}
