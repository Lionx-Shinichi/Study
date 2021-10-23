using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_10_16_02_数组的定义
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //一次性存储10个int类型的变量 这时可以利用数组
            int[] nums = new int[10];//这时nums已经存储了10个元素，元素值均为0（元素即变量，在数组中称之为元素）
            //给该数组中下标3或索引6的元素赋值
            nums[3] = 10;
            //给数组中的元素从1开始依次递增赋值
            //赋值和取值均通过循环处理
            for (int i = 0; i < nums.Length; i++)//nums.Length是数组长度的意思
            {
                nums[i] = i + 1;
            }
            nums[5] = 10;
            //其中的变量依然可以通过后期再赋值覆盖先前值
            //nums[10] = 11;
            //因为该数组内没有下标为10的元素（超出数组界限），如果运行该行代码就会抛异常
            //取值过程
            for (int i = 0; i < nums.Length; i++)
            {
                Console.WriteLine(nums[i]);
            }
            Console.ReadKey();

            //string类型的数组初值为null，不含有任何内容，也不占用内存
            string[] str = new string[5];
            Console.WriteLine(str[0]);
            Console.ReadKey();
            

            //其他声明数组的方法
            int[] nums2 = { 1, 2, 3, 4, 5, 6 };//这种方法可以快速给其中的元素赋值，但是只能创建这么多元素

            //以下的两种方法不常见
            int[] nums3 = new int[5] { 1, 2, 3, 4, 5 };//后续输入的数字必须和前面的长度相符（但5只生成0~4，也就是只生成长度那么多的元素)，否则无法运行，也就是nums2的复杂写法

            int[] nums4 = new int[] { 1, 2, 3, 4, 5 };//和nums2效果相同

            #region 笔记
            /*
            数组
            数组一次性存储多个相同类型的变量。

            数组语法：
            数组数组类型[] 数组名称 = new 数组类型[数组长度];
            
            数组数组在创建的时候，就会将其中的元素全部赋予一个初值
            数组int类型为0，string类型为null（即无任何内容，未占用内存），bool类型为false
            数组如果想要访问到数组中的某个元素，需要通过这个元素的下标或者索引访问
            数组最先的元素下标数字为0，依次递增
            数组最先的元素索引数字为长度-1，依次递减
            数组赋值和取值均可以通过循环处理
            数组其中的变量依然可以通过后期再赋值覆盖先前值
            数组如果给不存在的元素赋值（超出数组界限），就会抛异常
            数组数组长度不可以在程序运行途中更改
            */
            #endregion
        }
    }
}
