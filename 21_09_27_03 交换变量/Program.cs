using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_09_27_03_交换变量
{
    class Program
    {
        static void Main(string[] args)
        {
            //请交换n1和n2的值（利用第三方变量）
            /*
            int n1 = 10;
            int n2 = 20;

            int temp = n1;
            n1 = n2;
            n2 = temp;

            Console.WriteLine("1.{0}.2.{1}", n1, n2);
            Console.ReadKey();
            */

            //请交换n1和n2的值，不能使用第三方变量
            int n1 = 500;
            int n2 = 30;
            n1 = n1 + n2;// n1=530 n2=30
            n2 = n1 - n2;// n1=530 n2=500
            n1 = n1 - n2;// n1=30  n2=500
            Console.WriteLine("1.{0}.2.{1}", n1, n2);
            Console.ReadKey();
            //该方法仅适用数字类型，string仅可使用第三方变量交换

        }
    }
}
