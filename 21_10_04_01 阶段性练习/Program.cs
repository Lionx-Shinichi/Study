using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_10_04_01_阶段性练习
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            //练习1：接收用户的3个数字，挑选出最大的数字，不考虑等于情况
            Console.WriteLine("请输入第一个数字");
            double number1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("请输入第二个数字");
            double number2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("请输入第三个数字");
            double number3 = Convert.ToDouble(Console.ReadLine());

            if (number1 > number2 && number1 > number3)
            {
                Console.WriteLine(number1);
            }
            else if (number2 > number1 && number2 > number3)
            {
                Console.WriteLine(number2);
            }
            else
            {
                Console.WriteLine(number3);
            }
            Console.ReadKey();


            //练习2：提示用户输入密码，如果密码是"88888"则提示密码正确，否则就要求用户再输入一次，如果密码是"88888"则提示密码正确，否则提示密码错误，程序结束。
            Console.WriteLine("请输入您的密码。");
            string password = Console.ReadLine();
            if (password == "88888")
            {
                Console.WriteLine("密码正确！");
            }
            else
            {
                Console.WriteLine("密码错误！请再试一次");
                password = Console.ReadLine();
                if (password == "88888")
                {
                    Console.WriteLine("密码正确！");
                }
                else
                {
                    Console.WriteLine("密码错误！按任意键退出程序。");
                }
            }
            Console.ReadKey();
            

            //练习3：提示用户输入用户名，然后再提示输入密码，如果密码是"admin"并且密码是"88888"则提示正确
            //否则，如果用户名不是admin就提示用户不存在，如果用户名是admin就提示密码错误。
            Console.WriteLine("请输入用户名");
            String username = Console.ReadLine();
            Console.WriteLine("请输入密码");
            String pwd = Console.ReadLine();
            if (username == "admin" && pwd == "88888")
            {
                Console.WriteLine("登陆成功");
            }
            else if (username != "admin")
            {
                Console.WriteLine("用户名不存在");
            }
            else if (pwd != "88888")
            {
                Console.WriteLine("密码错误");
            }
            Console.ReadKey();
            */

            //练习4：提示用户输入年龄
            //如果年龄达到18，则提示用户可以查看，
            //如果年龄小于10，则不允许查看，
            //如果年龄达到10岁但不满18岁，则提示用户是否查看，如果输入Y则显示内容，如果输入N则提示用户主动放弃查看
            Console.WriteLine("当前信息为限制级内容，请输入您的年龄");
            double age = Convert.ToDouble(Console.ReadLine());
            if (age >= 18)
            {
                Console.WriteLine("你可以查看相关内容，按回车键继续");
                Console.ReadKey();
                Console.WriteLine("https://www.bilibili.com/video/BV1vQ4y1Z7C2?from=search&seid=15094439592877749349&spm_id_from=333.337.0.0");
            }
            else if (age < 18 && age >= 10)
            {
                Console.WriteLine("你需要得到监护人同意才能查看相关内容");
                Console.WriteLine("你是否已经获得监护人的同意？同意请输入Y，不同意请输入N");
                string input = Console.ReadLine();
                if (input == "Y" || input == "y")
                {
                    Console.WriteLine("你可以查看相关内容，按回车键继续");
                    Console.ReadKey();
                    Console.WriteLine("https://www.bilibili.com/video/BV1vQ4y1Z7C2?from=search&seid=15094439592877749349&spm_id_from=333.337.0.0");
                }
                else
                {
                    Console.WriteLine("你不能查看相关内容");
                }
            }
            else
            {
                Console.WriteLine("你不能查看相关内容");
            }
            Console.WriteLine("按任意键退出程序");
            Console.ReadKey();
        }
    }
}
