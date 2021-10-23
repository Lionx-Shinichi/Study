using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_10_10_02_三元表达式
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            //练习1：让用户输入两个数字，计算两个数字的大小，求出最大的
            Console.WriteLine("将输入两个数字，系统会返回最大的那个数字，先请输入第一个数字");
            try
            {
                double number1 = double.Parse(Console.ReadLine());
                Console.WriteLine("请输入第二个数字");
                double number2 = double.Parse(Console.ReadLine());
                double max = number1 > number2 ? number1 : number2;
                Console.WriteLine("最大的数是{0}", max);
            }
            catch
            {
                Console.WriteLine("您的输入值不合法，程序即将退出");
            }
            Console.ReadKey();
            */

            //练习2：让用户输入姓名，返回员工等级，老赵是经理，其他人是员工
            Console.WriteLine("请输入你要查询的员工姓名");
            string name2 = Console.ReadLine();
            string levle2 = name2 == "老赵" ? "经理" : "员工";
            Console.WriteLine("{0}在该部门里的职位是{1}", name2, levle2);
            Console.ReadKey();

            #region 笔记
            /*
            三元表达式
            语法：
            bool类型?值1:值2;
            
            如果bool类型为True，则值1为整个三元表达式的值
            如果bool类型为False，则值2为整个三元表达式的值
            值1和值2的类型必须一致，并且要和输出值的类型一致
            */
            #endregion
        }
    }
}
