using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_11_01_02_方法的综合练习
{
    class Program
    {
        /// <summary>
        /// 练习1用：计算传入的两个整数参数之间所有整数的和并返回， input1 必须是较小的整数
        /// </summary>
        /// <param name="input1">较小的整数</param>
        /// <param name="input2">较大的整数</param>
        /// <returns>两个整数参数之间所有整数的和</returns>
        public static int SumOfInterval(int input1, int input2)
        {
            int sum = 0;
            input1++;
            for (; input1 < input2; input1++)
            {
                sum += input1;
            }
            return sum;
        }
        /// <summary>
        /// 练习2用：将传入的字符串数组中最长的元素返回
        /// </summary>
        /// <param name="input">字符串数组</param>
        /// <returns>最长的元素</returns>
        public static string GetLongest(string[] input)
        {
            int longestLength = 0;
            string longest = null;
            for (int i = 0; i < input.Length; i++)
            {
                if (longestLength < input[i].Length)
                {
                    longest = input[i];
                    longestLength = input[i].Length;
                }
            }
            return longest;
        }
        /// <summary>
        /// 练习3用：传入一个整数数组，计算完成后返回 double 类型平均值
        /// </summary>
        /// <param name="input">整数数组</param>
        /// <returns>double 类型的平均值</returns>
        public static double GetAvg(int[] input)
        {
            double sum = 0;
            for (int i = 0; i < input.Length; i++)
            {
                sum += input[i];
            }
            return sum / input.Length;
        }
        /// <summary>
        /// 练习4用：判断传入的整数参数是否为质数，并返回 bool 类型的判断结果
        /// </summary>
        /// <param name="input">待判断的整数参数</param>
        /// <returns>bool 类型的判断结果</returns>
        public static bool PrimeNumberJudge(int input)
        {
            bool res = true;
            if (input <= 1)
            {
                return false;
            }
            for (int i = 2; i < input; i++)
            {
                if (input % i == 0)
                {
                    res = false;
                }
            }
            return res;
        }
        /// <summary>
        /// 练习4用：要求用户输入大于1的自然数参数，如果不是则要求用户再次输入直至正确
        /// </summary>
        /// <param name="input">用户输入的值</param>
        /// <returns>用户正确输入的整数（int类型）</returns>
        public static int IntJudge(string input)
        {
            while (true)
            {
                try
                {
                    int result = int.Parse(input);
                    if (result <= 1)
                    {
                        Console.WriteLine("不允许输入小于2的自然数或负数，请再试一次");
                        input = Console.ReadLine();
                        continue;
                    }
                    return result;
                }
                catch
                {
                    Console.WriteLine("不允许输入除整数以外的其他内容，请再试一次");
                    input = Console.ReadLine();
                }
            }
        }
        /// <summary>
        /// 练习5用：传入作为成绩的double参数，返回作为等第或错误报告的char类型
        /// </summary>
        /// <param name="input">作为成绩的double参数</param>
        /// <returns>作为等第或错误报告的char类型</returns>
        public static char ScoreJudge(double input)
        {
            if (input <= 100 && input >= 90)
            {
                return '优';
            }
            else if (input < 90 && input >= 80)
            {
                return '良';
            }
            else if (input < 80 && input >= 60)
            {
                return '中';
            }
            else if (input < 60 && input >= 0)
            {
                return '差';
            }
            else
            {
                return '错';
            }
        }
        /// <summary>
        /// 练习6用：仿制Array.Reverse，导入一个字符串数组的ref参数，将其中的元素顺序颠倒。
        /// </summary>
        /// <param name="input">字符串数组的ref参数</param>
        public static void Reverse(ref string[] input)
        {
            string[] temp = new string[input.Length];
            for (int i = 0; i < input.Length; i++)
            {
                temp[input.Length - i - 1] = input[i];
            }
            input = temp;
        }
        /// <summary>
        /// 特别测试：当数组被传入方法，如果实参和形参的名称相同，即使不返回这个数组，在方法中运算后外面的数组的值也会变化。
        /// </summary>
        /// <param name="nums1">特别测试数组</param>
        public static void Test(int[] nums1)
        {
            for (int i = 0; i < nums1.Length - 1; i++)
            {
                nums1[i] += 1;
            }
        }
        /// <summary>
        /// 练习7用：传入圆的半径，计算其面积和周长并多余返回
        /// </summary>
        /// <param name="r">传入的圆的半径</param>
        /// <param name="area">多余返回的面积</param>
        /// <param name="perimeter">多余返回的周长</param>
        public static void AreaPerimeterOfCircle(double r, out double area, out double perimeter)
        {
            area = Math.PI * r * r;
            perimeter = 2 * Math.PI * r;
        }

        static void Main(string[] args)
        {
            
            //练习1：提示用户输入两个数字，计算这两个数字之间的所有整数的和
            //1.用户只能输入数字
            //2.计算两个数字之间所有整数的和
            //3.要求第一个数字必须比第二个数字小，就重新输入
            Console.WriteLine("输入两个数字，将计算这两个数字之间的所有整数的和");
            while (true)
            {
                try
                {
                    Console.WriteLine("请输入第一个，较小的数字");
                    int num1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("请输入第二个，较大的数字");
                    int num2 = int.Parse(Console.ReadLine());
                    if (num1 >= num2)
                    {
                        Console.WriteLine("第一个数字不能大于第二个数字，请再试一次");
                        continue;
                    }
                    else
                    {
                        int res = SumOfInterval(num1, num2);
                        Console.WriteLine("这两个数字之间所有整数的和为{0}", res);
                        Console.ReadKey();
                        break;
                    }
                }
                catch
                {
                    Console.WriteLine("输入的值不合法，请再试一次");
                    continue;
                }
            }

            //练习2：用方法实现，有一个字符串数组，输出其最长的元素
            string[] names = { "马龙", "迈克尔乔丹", "雷吉米勒", "蒂姆邓肯", "科比布莱恩特" };
            string longest = GetLongest(names);
            Console.WriteLine("最长的元素是{0}", longest);
            Console.ReadKey();

            //练习3：请计算出一个整数数组的平均值并且保留两位小数
            int[] numbers = { 1, 5, 125, 6, 547, 458, 2, 23, 56, 45, 8, 124, 64, 3 };
            double avg = GetAvg(numbers);
            avg = double.Parse(avg.ToString("0.00"));//使用转换成字符串并限制位数的方法降低精度会四舍五入
            Console.WriteLine(avg);
            Console.ReadKey();
            
            //练习4：写一个方法，用来判断用户输入的数字是不是质数
            //      再写一个方法，要求用户只能输入整数，输入有误就一直让用户输入
            //      质数的概念就是在大于1的自然数中，除了1和他本身不再有其他因数的自然数
            Console.WriteLine("请输入一个数字，系统将判断该数字是否是质数");
            int input4 = IntJudge(Console.ReadLine());
            if (PrimeNumberJudge(input4))
            {
                Console.WriteLine("{0}是质数", input4);
            }
            else
            {
                Console.WriteLine("{0}不是质数", input4);
            }
            Console.ReadKey();
            
            //练习5：接受输入后判断其等级并显示出来。判断依据如下：优100~90 良89~80 中79~60 差<=59
            Console.WriteLine("请输入您的测试成绩");
            while (true)
            {
                try
                {
                    double score = double.Parse(Console.ReadLine());
                    char result = ScoreJudge(score);
                    if (result == '错')
                    {
                        Console.WriteLine("输入错误，请重新输入您的测试成绩");
                        continue;
                    }
                    Console.WriteLine("您的成绩是{0}，等第为{1}", score, result);
                    Console.ReadKey();
                    break;
                }
                catch
                {
                    Console.WriteLine("输入错误，请重新输入您的测试成绩");
                    continue;
                }
            }
            
            //练习6：写一个Reverse方法
            string[] str = { "泰国", "新加坡", "印度尼西亚", "咖喱", "肉骨茶", "印尼九层塔" };
            Reverse(ref str);
            for (int i = 0; i < str.Length - 1; i++)
            {
                Console.Write("{0},", str[i]);
            }
            Console.WriteLine(str[str.Length - 1]);
            Console.ReadKey();

            //特别测试：当数组（仅数组有这个特质）被传入方法，如果实参和形参的名称相同，即使不返回这个数组，在方法中运算后外面的数组的值也会变化。
            //这个原理将在值类型，隐类型，引用传递和值传递中讲解
            int[] nums1 = { 1, 2, 3 };
            Test(nums1);//Test的导出内容为void，也没有使用out，ref之类的可以传出的参数类型
            Console.WriteLine(nums1[0]);
            Console.ReadKey();
            //打印结果为2
            
            //练习7：写一个方法，计算圆的面积和周长
            //      面积计算公式为π*r*r
            //      周长计算公式为2*π*r
            Console.WriteLine("请输入圆的半径(r)");
            double r = double.Parse(Console.ReadLine());
            AreaPerimeterOfCircle(r, out double area, out double perimeter);
            Console.WriteLine("该圆的面积为{0:0.00}，周长为{1:0.00} (单位与输入的半径的单位对应，结果保留2位小数（四舍五入）)", area, perimeter);
            Console.ReadKey();
        }
        
    }
}
