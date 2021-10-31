using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_10_31_01_ref参数
{
    class Program
    {
        /// <summary>
        /// 例题1用：将ref参数+500（奖金）
        /// </summary>
        /// <param name="input">待运算的ref参数</param>
        public static void Bonus(ref double input)//这里用ref参数可以在方法结束后将该值带出方法，不必再用return带出
        {
            input += 500;
        }
        /// <summary>
        /// 例题1用：将ref参数-500（罚金）
        /// </summary>
        /// <param name="input">待运算的ref参数</param>
        public static void Fine(ref double input)
        {
            input -= 500;
        }
        /// <summary>
        /// 练习1用：交换两个导入的int类型的ref参数
        /// </summary>
        /// <param name="input1">int类型的ref参数1</param>
        /// <param name="input2">int类型的ref参数2</param>
        public static void IntExchange(ref int input1, ref int input2)
        {
            input1 = input1 + input2;
            input2 = input1 - input2;
            input1 -= input2;
        }

        static void Main(string[] args)
        {
            //例题1：发500元奖金
            double salary = 5000;
            Bonus(ref salary);//如果要使用ref参数就必须导入一个ref参数
            Console.WriteLine(salary);
            Console.ReadKey();
            //打印结果为5500

            //练习1：使用方法交换两个int类型的变量
            int number1 = 5;
            int number2 = 3;
            IntExchange(ref number1, ref number2);
            Console.WriteLine("第一个值为{0}，第二个值为{1}", number1, number2);
            Console.ReadKey();

            #region 笔记
            /*
            ref参数
            能够将一个变量带入一个方法中运算，方法完成后可以将值带出方法。
            ref参数要求在方法外必须为变量赋值，在方法内可以不赋值，和out参数相反。
            */
            #endregion

        }
    }
}
