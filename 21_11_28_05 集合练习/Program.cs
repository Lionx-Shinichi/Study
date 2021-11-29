using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_11_28_05_集合练习
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //练习1:创建一个集合,里面添加一些数字,然后求其平均值,和,最大值,最小值
            ArrayList list = new ArrayList();
            list.AddRange(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 });
            int sum = 0;
            int max = int.MinValue;
            int min = int.MaxValue;
            for (int i = 0; i < list.Count; i++)
            {
                sum += (int)list[i];
                if ((int)list[i] > max)
                {
                    max = (int)list[i];
                }
                if ((int)list[i] < min)
                {
                    min = (int)list[i];
                }
            }
            Console.WriteLine("该集合的平均值为{0},总和为{1},最大值为{2},最小值为{3}", sum / list.Count, sum, max, min);
            Console.ReadKey();

            //练习2:写一个长度为100的集合,要求在其中随机存放100个数字(0~99),且所有数字不得重复
            ArrayList list2 = new ArrayList();
            Random r = new Random();
            int k = 0;
            for (int i = 0; i < 100; i++)
            {
                int ramdom = r.Next(0, 100);
                if (!list2.Contains(ramdom))
                {
                    list2.Add(ramdom);
                }
                else
                {
                    i--;
                }
                k++;
            }
            for (int i = 0; i < list2.Count - 1; i++)
            {
                Console.Write("{0}|", list2[i]);
            }
            Console.Write(list2[list2.Count - 1]);
            Console.WriteLine();
            Console.WriteLine("本次程序共循环{0}次", k);
            Console.ReadKey();
        }
    }
}
