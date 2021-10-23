using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_10_03_03_if结构练习
{
    class Program
    {
        static void Main(string[] args)
        {
            //练习1：让用户输入年龄
            //如果输入的年龄大于（含）23岁，则给用户显示你到了结婚的年龄了
            Console.WriteLine("请输入你的年龄");
            double age = Convert.ToDouble(Console.ReadLine());
            if (age >= 23)
            {
                Console.WriteLine("你可以结婚啦");
            }
            Console.ReadKey();

            //练习2：让用户输入语文和音乐成绩
            //如果（语文成绩达到90且音乐成绩达到80）或（语文成绩达到100且音乐成绩达到70），则奖励100元
            Console.WriteLine("请输入你的语文成绩");
            double chinese = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("请输入你的音乐成绩");
            double music = Convert.ToDouble(Console.ReadLine());
            if ((chinese >= 90 && music >= 80) || (chinese == 100 && music >= 70))
            {
                Console.WriteLine("真好，奖励给你100元");
            }
            Console.ReadKey();

            //练习3：让用户输入用户名和密码
            //如果用户名为admin，密码为mypass，则提示登录成功
            Console.WriteLine("请输入您的用户名");
            string username = Console.ReadLine();
            Console.WriteLine("请输入您的密码");
            string password = Console.ReadLine();
            if(username == "admin" && password == "mypass")
            {
                Console.WriteLine("登录成功！");
            }
            Console.ReadKey();
        }
    }
}
