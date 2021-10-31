using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_10_31_03_方法的重载
{
    class Program
    {
        public static void M1(int n1, int n2)
        {
            int result = n1 + n2;
        }
        public static double M(double d1, double d2)
        {
            return d1 + d2;
        }
        public static int M(int n1, int n2, int n3)
        {
            int result = n1 + n2 + n3;
            return result;
        }
        public static string M(string s1, string s2)
        {
            return s1 + s2;
        }
        public static void M1(string s1, string s2, string s3)
        {
            string result = s1 + s2 + s3;
        }

        static void Main(string[] args)
        {
            //M1~M4四个方法都在干相类似的一件事：相加
            //但是因为传入参数的类型不同，因此在调用时需要分别调用这四个方法
            //为了方便，就可以将四个方法设置成一个名字，系统会自动匹配最合适的方法使用

            Console.WriteLine(M(5, 2, 3));
            Console.ReadKey();


            #region 笔记
            /*
            方法的重载
            方法的重载指的就是方法的名称相同，但是参数不同。
            但是提前得满足以下情况：
            1)	参数的个数相同，参数的类型就不能相同。
            2)	参数的类型相同，参数的个数就不能相同。
            即：
            如果参数的个数和类型完全相同，不能构成重载
    
            方法的重载与返回值无关。
            */
            #endregion
        }
    }
}
