using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_10_08_03_类型转换
{
    class Program
    {
        static void Main(string[] args)
        {
            //int.Parse == Convert.ToInt32

            double number = 50;
            bool a = double.TryParse("3.7?", out number);
            Console.WriteLine("{0},{1}", number, a);
            Console.ReadKey();
            //打印结果为0，False
            //TryParse方法的作用是尝试将值赋给一个变量
            //如果成功赋值则返回True
            //如果失败则返回False，给变量赋值0

            #region 笔记
            /*
            int-TryParse（以int为例）
            尝试将一个字符串转换成int类型

            语法：
            bool类型变量（返回值） = int.TryParse（“字符串”，out 接收变量）
            
            执行过程：
            尝试将字符串转换为int类型（以int为例），如果可以转换，则给接收变量赋值，然后返回一个True
            如果不能转换，则给接收变量赋值0，然后返回一个False

            */
            #endregion
        }
    }
}
