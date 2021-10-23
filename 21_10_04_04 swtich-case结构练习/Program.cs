using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_10_04_04_swtich_case结构练习
{
    class Program
    {
        static void Main(string[] args)
        {
            //不常规练习：请输入你的考试成绩
            //然后测评学员的考试成绩，A=100~90（含） B=90~80（含） C=80~70（含） D=70~60（含） E=60以下（成绩不含有任何小数成分）
            Console.WriteLine("请输入您的考试成绩");
            int score = Convert.ToInt32(Console.ReadLine());
            string level;
            switch (score / 10)
            //利用成绩没有小数的特点，int/10的结果也一定是int类型，使得一个数字可以涵盖10个数字的范围
            //利用这个方法可以使得一个区间变成一个定值
            {
                case 10:    //当数个case的执行内容完全相同时，可以串联起来只留一个指令和break;
                case 9:
                    level = "A";
                    break;
                case 8:
                    level = "B";
                    break;
                case 7:
                    level = "C";
                    break;
                case 6:
                    level = "D";
                    break;
                default:
                    level = "E";
                    break;
            }
            Console.WriteLine("您的成绩等第为{0}", level);
            Console.ReadKey();
        }
    }
}
