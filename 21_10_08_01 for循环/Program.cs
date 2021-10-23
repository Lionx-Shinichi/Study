using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_10_08_01_for循环
{
    class Program
    {
        static void Main(string[] args)
        {
            //向控制台打印10遍今天我要认真学习
            /*
            int i = 1;
            while (i <= 10)
            {
                Console.WriteLine("今天我要认真学习");
                i++;
            }
            Console.ReadKey();

            //以上代码可以用for循环简便表达

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("今天我要认真学习\t{0}", i);
            }
            Console.ReadKey();


            //练习1：打印1~10
            for (int i1 = 1; i1 <= 10; i1++)
            {
                Console.WriteLine(i1);
            }
            Console.ReadKey();

            //练习2：打印10~1
            for (int i2 = 10; i2 >= 1; i2--)
            {
                Console.WriteLine(i2);
            }
            Console.ReadKey();
            

            //练习3：分别求得1~100之间的所有整数和，偶数和，奇数和
            int sum1 = 0;
            int sum2 = 0;
            int sum3 = 0;
            for (int i = 1; i <= 100; i++)
            {
                sum1 += i;
                if (i % 2 == 0)
                {
                    sum2 += i;
                }
                else
                {
                    sum3 += i;
                }
            }
            Console.WriteLine("0~100的整数和为{0}，偶数和为{1}，奇数和为{2}",sum1,sum2,sum3);
            Console.ReadKey();
            */

            //练习4：找出100~999之间的水仙花数
            //水仙花数指的就是这个数字百位立方+十位立方+个位立方==当前这个数字
            int hunereds4 = 0;
            int tens4 = 0;
            int ones4 = 0;
            for (int i4 = 100; i4 < 1000; i4++)
            {
                hunereds4 = i4 / 100;
                tens4 = i4 % 100 / 10;
                ones4 = i4 % 10;
                hunereds4 *= hunereds4 * hunereds4;
                tens4 *= tens4 * tens4;
                ones4 *= ones4 * ones4;
                if (hunereds4 + tens4 + ones4 == i4)
                {
                    Console.WriteLine(i4);
                }
            }
            Console.ReadKey();

        }
    }
}
