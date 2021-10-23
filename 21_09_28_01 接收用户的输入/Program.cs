using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_09_28_01_接收用户的输入
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.WriteLine("请输入你的姓名");
            //接收用户在控制台的输入
            string name = Console.ReadLine();
            Console.WriteLine("您的姓名是{0}", name);
            Console.ReadKey();
            */

            //练习：问用户你喜欢吃什么水果(fruits),假如用户输入"OO",则显示"哈哈，这么巧，我也爱吃OO"
            Console.WriteLine("你喜欢吃什么水果？请直接输入");
            string fruits = Console.ReadLine();
            Console.WriteLine("那么巧，我也喜欢吃{0},按任意键退出应用", fruits);
            Console.ReadKey();

        }
    }
}
