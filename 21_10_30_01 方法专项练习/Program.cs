using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_10_30_01_方法专项练习
{
    class Program
    {
        /// <summary>
        /// 练习1用：比较两个输入值的大小，返回较大的参数
        /// </summary>
        /// <param name="input1">第一个参数</param>
        /// <param name="input2">第二个参数</param>
        /// <returns>较大的参数</returns>
        public static double GetMax(double input1, double input2)//形参
        {
            double max = input1 > input2 ? input1 : input2;
            return max;
        }
        /// <summary>
        /// 练习2用：测试传入的参数是否是double类型的，返回bool结果
        /// </summary>
        /// <param name="input">待传入的被测试参数</param>
        /// <returns>测试传入的的参数是否是double类型的bool结果</returns>
        public static bool NumberCheck(string input)
        {
            try
            {
                double number = double.Parse(input);
                return true;
            }
            catch
            {
                return false;
            }
        }
        /// <summary>
        /// 练习2用：测试传入的参数是否是double类型的，如果是则返回原参数，否则要求用户重新输入一次直至正确后返回原参数退出方法。
        /// </summary>
        /// <param name="input">待传入的被测试参数</param>
        /// <returns>原传入的double类型参数</returns>
        public static double NumberCheck2(string input)
        {
            while (true)
            {
                try
                {
                    double number = double.Parse(input);
                    return number;
                }
                catch
                {
                    Console.WriteLine("输入有误，请再试一次");
                    input = Console.ReadLine();
                }
            }
        }
        /// <summary>
        /// 测试传入的参数是否是y或者n，如果是则void return，否则再输入一次直至输入y或n
        /// </summary>
        /// <param name="input">待传入的被测试参数</param>
        public static void CheckYN(string input)//创建一个叫CheckYN的方法
        {
            while (true)//创建一个while循环 循环条件为true
            {
                if (input == "y" || input == "n")//如果input值=y或n
                {
                    return;//则跳出CheckYN
                }
                else//如果input值!=y/n
                {
                    Console.WriteLine("输入有误，请再试一次");//则回报输入有误，请再试一次
                    input = Console.ReadLine();//将用户再次输入的内容重新赋值给input
                }
            }
        }
        /// <summary>
        /// 计算整数类型数组的总和
        /// </summary>
        /// <param name="input">整数类型的数组</param>
        /// <returns>该整数类型的数组的总和</returns>
        public static int SumArray(int[] input)
        {
            int sum = 0;
            for (int i = 0; i < input.Length; i++)
            {
                sum += input[i];
            }
            return sum;
        }
        static void Main(string[] args)
        {
            //练习1：比较两个数字的大小，返回更大的
            double max = GetMax(10, 5);//实参
            Console.WriteLine(max);
            Console.ReadKey();
            //返回值为10

            //练习2：读取输入的整数，定义成方法，多次调用（如果用户输入的是数字，则返回，否则提示用户重新输入）
            Console.WriteLine("请输入一个数字");
            while (true)
            {
                string input2 = Console.ReadLine();
                bool numberCheck2 = NumberCheck(input2);
                if (numberCheck2)
                {
                    Console.WriteLine(input2);
                    Console.ReadKey();
                    break;
                }
                else
                {
                    Console.WriteLine("输入有误，请再试一次");
                }
            }
            //以上写法不满足题目要求将判断过程封装在方法里的要求，但是更加符合实际运用场景
            //以下写法满足题目要求
            Console.WriteLine("请输入一个数字");
            Console.WriteLine(NumberCheck2(Console.ReadLine()));
            Console.ReadKey();

            //练习3：只允许用户输入y/n,否则再次输入(封装成方法)
            Console.WriteLine("请输入y/n");//打印请输入y/n
            CheckYN(Console.ReadLine());//将用户输入值传入方法CheckYN

            //练习4：计算整数类型数组的综合(封装成方法)
            int[] nums = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int sum = SumArray(nums);
            Console.WriteLine(sum);
            Console.ReadKey();

            #region 笔记
            /*
            1.形参和实参
            public static double GetMax(double input1,double input2)
            这里的input1和input2即形参
            这两种类型都在内存中开辟了空间存储相关数据
            形参和实参数量相符，类型相符，一一对应。
            
            2.方法的功能一定要单一
            在方法的设计中最忌讳出现提示用户输入的字眼。这样书写会对方法带来许多限定，使得便于使用的范围大幅下降（变得不便在其他部位使用）。
            */
            #endregion
        }
    }
}
