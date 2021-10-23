using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_10_10_03_随机数
{
    class Program
    {
        static void Main(string[] args)
        {
            //（本章暂时超纲，仅留存过程）
            //1.创建一个能产生随机数的对象
            Random r = new Random();
            while (true)
            {
                //2.让产生随机数的这个对象调用方法来产生随机数
                int rNumber = r.Next(1, 10);//值可以取到最左边，取不到最右边（左闭右开区间）
                Console.WriteLine(rNumber);
                Console.ReadKey();
            }
        }
    }
}
