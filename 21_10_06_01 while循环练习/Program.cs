using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_10_06_01_while循环练习
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //练习1：提示用户输入yes或者no
            //如果不是yes或者no就要求用户一直输入
            string input1 = "";
            while (input1 != "yes" && input1 != "no")
            {
                Console.WriteLine("请输入yes/no");
                input1 = Console.ReadLine();

            }
            
            //练习2：提示用户输入用户名
            //要求：用户名为admin，密码为888888
            //只要用户名错误或密码错误，就退回重新输入，但是最多只能输入三次
            string username2 = "";
            string pwd2 = "";
            int i2 = 1;
            while (i2 <= 3)
            {
                Console.WriteLine("请输入您的用户名");
                username2 = Console.ReadLine();
                Console.WriteLine("请输入您的密码");
                pwd2 = Console.ReadLine();
                if (username2 == "admin" && pwd2 == "888888")
                {
                    Console.WriteLine("登录成功");
                    break;
                }
                else
                {
                    Console.WriteLine("用户名或密码错误,请再试一次");
                }
                i2++;
            }
            if (i2 > 3)
            {
                Console.WriteLine("您已达到重试上限,程序即将退出");
            }
            Console.ReadKey();
            
            //练习3：
            //先要求用户A设置一个用户名，不能为空，否则发回再次输入。
            //再要求用户B设置一个用户名，不能为空，不能和A重名，否则发回再次输入。
            Console.WriteLine("用户A您好，请设置您的用户名");
            string usernameA3 = Console.ReadLine();
            while (usernameA3 == "")
            {
                Console.WriteLine("设置的用户名不合法，请再次设置您的用户名");
                usernameA3 = Console.ReadLine();
            }
            Console.WriteLine("设置成功！请按任意键盘键继续");
            Console.ReadKey();
            Console.WriteLine("用户B您好，请设置您的用户名");
            string usernameB3 = Console.ReadLine();
            while (usernameB3 == "" || usernameB3 == usernameA3)
            {
                Console.WriteLine("设置的用户名不合法或已被占用，请再次设置您的用户名");
                usernameB3 = Console.ReadLine();
            }
            Console.WriteLine("设置成功！");
            Console.WriteLine("用户A的用户名为{0},用户B的用户名为{1}",usernameA3,usernameB3);
            Console.WriteLine("请按任意键盘键退出程序");
            Console.ReadKey();
        }
    }
}
