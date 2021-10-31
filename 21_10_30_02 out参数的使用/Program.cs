using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_10_30_02_out参数的使用
{
    class Program
    {
        /// <summary>
        /// 例题1用：传入一个整数数组，计算出该数组的最大值，最小值，总和，平均值后传出按照上文顺序排列的整数数组。
        /// </summary>
        /// <param name="input">待计算的整数数组</param>
        /// <returns>按照最大值，最小值，总和，平均值排列的整数数组</returns>
        public static int[] GetMaxMinSumAvg(int[] input)
        {
            Array.Sort(input);
            int[] res = new int[4];
            res[0] = input[0];
            res[1] = input[input.Length - 1];
            for (int i = 0; i < input.Length; i++)
            {
                res[2] += input[i];
            }
            res[3] = res[2] / input.Length;
            return res;
        }
        /// <summary>
        /// 例题1用：传入一个整数数组，计算出该数组的最大值，最小值，总和，平均值，多余返回这四个值
        /// </summary>
        /// <param name="input">待计算的整数数组</param>
        /// <param name="max">多余返回的最大值</param>
        /// <param name="min">多余返回的最小值</param>
        /// <param name="sum">多余返回的总和</param>
        /// <param name="avg">多余返回的平均值</param>
        public static void Test(int[] input, out int max, out int min, out int sum, out int avg, out bool x)
        {
            //out参数要求在方法内部必须为其赋值
            Array.Sort(input);
            int[] res = new int[4];
            max = input[0];
            min = input[input.Length - 1];
            sum = 0;
            for (int i = 0; i < input.Length; i++)
            {
                sum += input[i];
            }
            avg = sum / input.Length;
            x = true;
        }
        /// <summary>
        /// 测试输入的用户名和密码是否分别是admin和666666，若错误返回false，多余返回错误报告，若正确返回true，多余返回登录成功
        /// </summary>
        /// <param name="username">待判断的用户名</param>
        /// <param name="pwd">待判断的密码</param>
        /// <param name="msg">多余返回的错误报告/登录成功</param>
        /// <returns>登录是否成功的bool值</returns>
        public static bool Login(string username, string pwd, out string msg)
        {
            if (username == "admin")
            {
                if (pwd == "666666")
                {
                    msg = null;
                    return true;
                }
                else
                {
                    msg = "密码错误";
                    return false;
                }
            }
            else
            {
                msg = "用户名或密码错误";
                return false;
            }
        }
        /// <summary>
        /// 练习2用：测试参数是否可以转换为int类型
        /// </summary>
        /// <param name="input">传入的参数</param>
        /// <param name="output">传出的参数</param>
        /// <returns>是否成功转换的bool类型</returns>
        public static bool TryParse(string input, out int output)
        {
            try
            {
                output = int.Parse(input);
                return true;
            }
            catch
            {
                output = 0;
                return false;
            }
        }

        static void Main(string[] args)
        {
            //写一个方法，求一个数组中的最大值，最小值，总和，平均值
            int[] numbers = { 9, 2, 3, 4, 5, 6, 7, 8, 1 };
            //将要返回的四个值放入数组中返回即可
            int[] output = GetMaxMinSumAvg(numbers);
            Console.WriteLine("这个数组的最大值是{0}，最小值是{1}，总和是{2}，平均值是{3}", output[0], output[1], output[2], output[3]);
            Console.ReadKey();

            //如果需要返回一些字符串等不能被int数组加入的内容时（即多个不同类型的值），就应该使用out参数
            Test(numbers, out int max, out int min, out int sum, out int avg, out bool a);//这里的实参也不必和形参名称一样
            Console.WriteLine("这个数组的最大值是{0}，最小值是{1}，总和是{2}，平均值是{3},{4}", max, min, sum, avg, a);
            Console.ReadKey();

            //练习1：分别提示用户输入用户名和密码，判断用户输入的是否正确，返回给用户一个登录的结果"登录成功/失败"
            //       如果用户名错误，除了返回登录界面还要返回一个"用户名错误"的字符串
            //       如果密码错误，除了返回登录界面还要返回一个"密码错误"的字符串
            while (true)
            {
                Console.WriteLine("请输入您的用户名");
                string username = Console.ReadLine();
                Console.WriteLine("请输入您的密码");
                string pwd = Console.ReadLine();
                bool res = Login(username, pwd, out string msg);
                if (res == false)
                {
                    Console.WriteLine("登录失败");
                    Console.WriteLine(msg);
                    continue;
                }
                else
                {
                    Console.WriteLine("登录成功");
                    break;
                }
            }
            Console.ReadLine();

            //练习2：实现TryParse
            Console.WriteLine("请输入一个整数");
            bool resBool = TryParse(Console.ReadLine(), out int resNumber);
            Console.WriteLine("转换结果为{0}，转换后result的值为{1}",resBool,resNumber);
            Console.ReadKey();

            #region 笔记
            /*
            out参数
            如果在方法中返回多个相同类型的值的时候，可以考虑返回一个数组。
            但是如果返回多个不同类型的值的时候，就不能再返回数组，这时可以使用out参数
            out参数侧重与在一个方法中返回多个不同类型的值。
            out参数要求在方法外可以不为变量赋值，在方法内必须赋值。
            */
            #endregion
        }
    }
}
