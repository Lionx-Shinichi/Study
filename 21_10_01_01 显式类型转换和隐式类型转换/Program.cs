using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_10_01_01_显式类型转换和隐式类型转换
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 10;
            double d = number;
            //int类型隐式转成了double类型

            //场景：给价格去尾取整（利用显式类型转换（强制类型转换））
            double price = 303.6;
            //语法:（要转换成什么类型）要转换的变量；（使用该方法会直接退一）
            int newPrice = (int)price;
            Console.WriteLine("303.6被转换成了{0}", newPrice);
            Console.ReadKey();
            //newPrice值为303

            int n1 = 10;
            int n2 = 3;
            double x = n1 / n2;
            //分解过程：先计算出了int类型下x=n1/n2=3，然后发生了隐式类型转换将x从int转换成了double
            //因此x的值为3
            Console.WriteLine(x);
            Console.ReadKey();

            int n3 = 10;
            int n4 = 3;
            //将int隐式转换为double的最快方法就是乘以1.0
            //乘以1.0之后n3隐式转换成了double类型，带动整个表达式隐式类型转换
            //因此y的值为3.3333333.....
            double y = n3 * 1.0 / n4;
            Console.WriteLine(y);
            Console.ReadKey();

            //或者直接在定义阶段修改值的类型
            int n5 = 10;
            double n6 = 3;
            double z = n5 / n6;
            //如果仅保留两位小数(使用该方法会四舍五入)
            Console.WriteLine("{0:0.00}", z);
            Console.ReadKey();
            //z的值为3.33

            #region 笔记
            /*
            类型转换

            隐式类型转换
            等号两边参与运算的操作数的类型必须一致，如果不一致满足下列条件会发生自动类型转换，
            或称之为隐式类型转换，必须满足以下两个条件。
            1.两种类型互相兼容
            Ex：int和double（都是数字类型）
            2.目标类型大于源类型
            Ex: double>int
            
            显式类型转换
            1.两种类型互相兼容
            2.源类型大于目标类型
            语法：
            （要转换成什么类型）要转换的值；（使用该方法降低进度会使用退一法）
            
            保留小数位数方法(使用该方法会四舍五入)
            double z = 5.5555555555;
            Console.WriteLine({0:0.00},z);
            Console.ReadKey();
            输出z的值为5.56

            */
            #endregion

        }
    }
}
