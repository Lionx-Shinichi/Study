using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_10_02_01_Convert类型转换
{
    class Program
    {
        static void Main(string[] args)
        {
            //将字符串类型转换为int或double类型
            //string secs = "52";
            //double seconds = Convert.ToDouble(secs);
            //int seconds2 = Convert.ToInt32(secs);
            //Console.WriteLine(seconds);
            //Console.WriteLine(seconds2);
            //Console.ReadKey();

            //练习：让用户输入姓名和语数英三门课的成绩，然后给用户显示：OO，你的总成绩为OO分，平均成绩为OO分。
            Console.WriteLine("您好，请输入您的姓名");
            string name = Console.ReadLine();
            Console.WriteLine("请输入您的语文成绩");
            string inputChineseScore = Console.ReadLine();
            Console.WriteLine("请输入您的数学成绩");
            string inputMathsScore = Console.ReadLine();
            Console.WriteLine("请输入您的英语成绩");
            string inputEnglishScore = Console.ReadLine();

            //如果字符串相加会使加号变成连接符，如55+88=5588，所以要转换成数字类型

            double chineseScore = Convert.ToDouble(inputChineseScore);
            double mathsScore = Convert.ToDouble(inputMathsScore);
            double englishScore = Convert.ToDouble(inputEnglishScore);

            double totalScore = chineseScore + mathsScore + englishScore;
            double averageScore = (chineseScore + mathsScore + englishScore) / 3;

            Console.WriteLine("{0}，您的总成绩为{1}，平均成绩为{2:0.00}，按任意键退出程序", name, totalScore, averageScore);
            Console.ReadKey();

            //提示用户输入一个数字，接收它并且在控制台返回其2倍数
            Console.WriteLine("请输入一个数字");
            //这行代码直接包含了将Console.ReadLine的结果定义为string类型的过程
            double number = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(number * 2);
            Console.ReadKey();

            #region 笔记
            /*
            如果两个类型的变量不兼容如何转换
            这时可以使用Convert进行转换
            语法：Convert.Todouble(需转换的变量名);（以转换为double为例）
            如果将string类型的“123abc”转换成int等数字类，程序就会报异常
            强制类型转换仅把原值转换好后赋值给承接的变量，不会改变原变量或者原值的类型和值。
            使用该方法降低精度会四舍五入。
            */
            #endregion
        }
    }
}
