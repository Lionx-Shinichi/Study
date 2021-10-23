using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_10_23_01_数组练习
{
    class Program
    {
        static void Main(string[] args)
        {
            //练习2：数组里面都是人的名字(老杨，老苏，老邹，老虎，老牛，老蒋，老王，老马)
            //       将其转换成字符串老杨|老苏|老邹|老虎|老牛|老蒋|老王|老马（将每个字符都累加到字符串中,用竖线分割）
            string[] names = { "老杨", "老苏", "老邹", "老虎", "老牛", "老蒋", "老王", "老马" };
            for (int i = 0; i < names.Length; i++)
            {
                if (i == names.Length - 1)
                {
                    Console.WriteLine("{0}", names[i]);
                }
                else
                {
                    Console.Write("{0}|", names[i]);
                }
            }
            Console.ReadKey();

            //练习3：把一个整数数组进行如下处理：
            //       如果该元素为正则+1
            //       如果该元素为负则-1
            //       如果该元素为0则不变
            int[] nums3 = { 1, 2, 5, 3, 7, 0, -2, 5, -8, -4 };
            int i3 = 0;
            for (; i3 < nums3.Length; i3++)
            {
                if (nums3[i3] > 0)
                {
                    nums3[i3] += 1;
                }
                else if (nums3[i3] < 0)
                {
                    nums3[i3] -= 1;
                }
            }
            for (i3 = 0; i3 < nums3.Length; i3++)
            {
                Console.WriteLine(nums3[i3]);
            }
            Console.ReadKey();

            //练习4：将一个字符串数组的元素的顺序进行反转。{“我”，“是”，“好人”}-->{"好人"，"是"，"我"}
            //       第i个和第Length-1-i个进行交换
            //第一种思路：创建一个缓存数组temp，长度同原数组，将原数组内的值依次赋值给其相反顺序的元素，然后在重新赋值回原数组后输出
            string[] str4 = { "我", "是", "好人" };
            string[] temp4 = new string[str4.Length];
            for (int i4 = 0; i4 < str4.Length; i4++)
            {
                temp4[str4.Length - i4 - 1] = str4[i4];
            }
            for (int i4 = 0; i4 < str4.Length; i4++)
            {
                str4[i4] = temp4[i4];
                Console.Write(str4[i4]);
            }
            Console.WriteLine();
            Console.ReadKey();

            //第二种思路：创建一个字符串变量，将第Length个元素的值赋值给该变量，然后将第一个元素的值赋值给第Length个元素，再将变量的值赋值给第一个元素
            //           依次类推完成所有元素的交换
            string[] str5 = { "我", "是", "个", "好", "人" };
            for (int i5 = 0; i5 < str5.Length / 2; i5++)
            {
                string temp5 = str5[str5.Length - i5 - 1];
                str5[str5.Length - i5 - 1] = str5[i5];
                str5[i5] = temp5;
            }
            for (int i5 = 0; i5 < str5.Length; i5++)
            {
                Console.Write(str5[i5]);
            }
            Console.WriteLine();
            Console.ReadKey();
            //测试
        }
    }
}
