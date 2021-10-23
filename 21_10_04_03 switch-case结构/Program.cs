using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_10_04_03_switch_case结构
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            //李四正在进行年终工作评定
            //如果定为A级，则工资上涨500元
            //如果定为B级，则工资上涨200元
            //如果定为C级，则工资爆出不变
            //如果定为D级，则工资下降200元
            //如果定位E级，则工资下降500元
            //设李四现在的工资为5000元，请用户来为李四今天的工作定级，然后显示李四未来的工资
            bool error = true;
            double salary = 5000;
            Console.WriteLine("请您为李四今年的工作表现作出评价，评价分为五个等第，分别为A，B，C，D和E。");
            string evaluation = Console.ReadLine();
            if (evaluation == "A" || evaluation == "a")
            {
                salary += 500;
            }
            else if (evaluation == "B" || evaluation == "b")
            {
                salary += 200;
            }
            else if (evaluation == "C" || evaluation == "c")
            {
                
            }
            else if (evaluation == "D" || evaluation == "d")
            {
                salary -= 200;
            }
            else if (evaluation == "E" || evaluation == "e")
            {
                salary -= 500;
            }
            else
            {
                Console.WriteLine("评价不符合要求。");
                error = false;
            }
            if (error)
            {
                Console.WriteLine("评价成功，李四来年的工资为{0}元。", salary);
            }
            Console.ReadKey();
            */
            //if else-if多用于区间的判断
            //对于以上这种定值的判断，可以使用switch-case结构简便表达

            //李四正在进行年终工作评定
            //如果定为A级，则工资上涨500元
            //如果定为B级，则工资上涨200元
            //如果定为C级，则工资爆出不变
            //如果定为D级，则工资下降200元
            //如果定位E级，则工资下降500元
            //设李四现在的工资为5000元，请用户来为李四今天的工作定级，然后显示李四未来的工资
            bool error = true;
            double salary = 5000;
            Console.WriteLine("请您为李四今年的工作表现作出评价，评价分为五个等第，分别为A，B，C，D和E。");
            string evaluation = Console.ReadLine();
            switch (evaluation)
            {
                case "A":
                    salary += 500;
                    break;
                case "B":
                    salary += 200;
                    break;
                case "C":
                    break;
                case "D":
                    salary -= 200;
                    break;
                case "E":
                    salary -= 500;
                    break;
                case "a":
                    salary += 500;
                    break;
                case "b":
                    salary += 200;
                    break;
                case "c":
                    break;
                case "d":
                    salary -= 200;
                    break;
                case "e":
                    salary -= 500;
                    break;
                default:
                    Console.WriteLine("评价不符合要求。");
                    error = false;
                    break;
            }
            if (error)
            {
                Console.WriteLine("评价成功，李四来年的工资为{0}元。", salary);
            }
            Console.ReadKey();

            #region 笔记
            /*
            switch-case结构
            用来处理多条件的，定值的判断
            if else-if结构则是多用来处理多条件的，区间的判断
            
            语法：
            switch(变量或者表达式的值)
            {
                case 值1：
                    要执行的代码;
                    break;
                case 值2：
                    要执行的代码;
                    break;
                case 值3：
                    要执行的代码;
                    break;
                ……
                default：
                    要执行的代码;
                    break;
            }
            
            执行过程：程序执行到switch处，首先将括号中的变量或者表达式的值计算出来，然后拿着这个值依次和每个case后面所带的值进行匹配
            一旦匹配成功，则执行该case所带的代码，执行完成后遇到break;，即跳出switch-case结构。
            如果均无法匹配则执行default所带的代码，没有default则直接跳出switch-case结构。
            
            */

            #endregion
        }
    }
}
