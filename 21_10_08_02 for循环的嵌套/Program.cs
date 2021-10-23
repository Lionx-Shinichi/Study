using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_10_08_02_for循环的嵌套
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //练习：输出乘法口诀表
            for (int i = 1; i <= 9; i++)
            {
                for (int j = 1; j <= 9; j++)
                {
                    if (j == 9)
                    {
                        Console.WriteLine("{0}*{1}={2}", i, j, i * j);
                    }
                    else
                    {
                        Console.Write("{0}*{1}={2}\t", i, j, i * j);
                    }
                }
            }
            Console.ReadKey();
            

            //练习2:不重复输出乘法口诀表
            for (int i2 = 1; i2 <= 9; i2++)
            {
                for (int j2 = 1; j2 <= i2; j2++)
                {
                    if (j2 == i2)
                    {
                        Console.WriteLine("{0}*{1}={2}", i2, j2, i2 * j2);
                    }
                    else
                    {
                        Console.Write("{0}*{1}={2}\t", i2, j2, i2 * j2);
                    }
                }
            }
            Console.ReadKey();

            //练习3：让用户输入一个整数，然后显示其作为两个正整数的和的全部可能
            int number3 = 0;
            while (true)
            {
                Console.WriteLine("请输入一个整数,将显示其作为两个正整数的和的全部可能");
                try
                {
                    number3 = Convert.ToInt32(Console.ReadLine());
                    for (int i3 = 0; i3 <= number3; i3++)
                    {
                        Console.WriteLine("{0}\t+\t{1}\t=\t{2}", i3, number3 - i3, number3);
                    }
                    break;
                    
                }
                catch
                {
                    Console.WriteLine("您输入的内容不符合条件，请再试一次");
                }
            }
            Console.WriteLine("按任意键盘键退出程序");
            Console.ReadKey();

            //练习4：循环录入5个人的年龄并计算平均年龄，如果录入的数据出现负数或者大于100，则立即停止输入并报错
            int age4 = 0;
            int sum4 = 0;
            bool error4 = false;
            while (error4 == false)
            {
                for (int i4 = 1; i4 <= 5; i4++)
                {
                    Console.WriteLine("请输入第{0}个人的年龄", i4);
                    try
                    {
                        age4 = int.Parse(Console.ReadLine());
                        if (age4 < 0 || age4 > 100)
                        {
                            Console.WriteLine("输入值超出范围，程序即将退出");
                            error4 = true;
                            break;
                        }
                        sum4 += age4;
                    }
                    catch
                    {
                        Console.WriteLine("输入值不合法，程序即将退出");
                        error4 = true;
                        break;
                    }
                }
                if (error4 == false)
                {
                    Console.WriteLine("这5个人的平均年龄是{0}", sum4 / 5);
                    Console.WriteLine();
                    sum4 = 0;
                }
            }
            Console.ReadKey();

            //练习5：在while中用break实现要求用户一直输入用户名和密码
            //只要不是admin，88888就一直要求重新输入，如果正确则提示输入正确
            string username5;
            string pwd5;
            while (true)
            {
                Console.WriteLine("请输入您的用户名");
                username5 = Console.ReadLine();
                Console.WriteLine("请输入您的密码");
                pwd5 = Console.ReadLine();
                if (username5 != "admin" || pwd5 != "88888")
                {
                    Console.WriteLine("用户名和密码错误，请再试一次");
                }
                else
                {
                    Console.WriteLine("登录成功");
                    Console.ReadKey();
                    break;
                }
            }

            //练习6：0和100之间的整数相加，得出累加多少值会达到20
            int sum6 = 0;
            for (int i6 = 0; i6 <= 100; i6++)
            {
                sum6 += i6;
                if (sum6>=20)
                {
                    Console.WriteLine("当累加到{0}时，值达到20",i6);
                    break;
                }
            }
            Console.ReadKey();
        }
    }
}
