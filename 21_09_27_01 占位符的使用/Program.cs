using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_09_27_01_占位符的使用
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = 10;
            int n2 = 20;
            int n3 = 30;

            Console.WriteLine("第一个数字是：" + n1 + "，第二个数字是：" + n2 + "，第三个数字是：" + n3);
            
            //占位符写法
            Console.WriteLine("第一个数字是：{0}，第二个数字是：{1}，第三个数字是：{2}",n1,n2,n3);

            //占位符输出顺序以占位符内的数字为准
            Console.WriteLine("第一个数字是：{0}，第二个数字是：{2}，第三个数字是：{1}", n1, n2, n3);
            //输出结果为10，30，20

            Console.ReadKey();

            #region 笔记
            /*
            占位符
            使用方法：先挖坑，再填坑。
            符号：{ }
            
            注意事项：
            1.挖了几个坑就要填几个坑，多填无效，少填抛异常
            2.输出顺序以占位符内的数字为准

            用{0.00}的方式可以确定需要保留多少位小数
            用这种方法降低精度会使用四舍五入。

            */
            #endregion

        }
    }
}
