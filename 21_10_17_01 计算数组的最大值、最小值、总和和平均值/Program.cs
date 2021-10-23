using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
public struct Number
{
    public int _max;
    public int _min;
    public int _sum;
    public int _average;
}

namespace _21_10_17_01_计算数组的最大值_最小值_总和和平均值
{
    class Program
    {
        static void Main(string[] args)
        {
            //练习1：从一个整数数组中取出最大的，最小的整数，总和和平均值
            //      声明一个int类型的数组 并且随意赋初值
            int[] input = new int[10] { -1, -2, -2, -4, -5, -6, -2, -1, -9, -8 };
            Number num;
            num._max = int.MinValue;
            num._min = int.MaxValue;
            num._sum = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] > num._max)
                {
                    num._max = input[i];
                }
                else if (input[i] < num._min)
                {
                    num._min = input[i];
                }
                num._sum += input[i];
            }
            Console.WriteLine("这组数字最大值为{0}，最小值为{1}，总和值为{2}，平均值为{3}", num._max, num._min, num._sum, num._sum / input.Length);
            Console.ReadKey();

        }
    }
}
