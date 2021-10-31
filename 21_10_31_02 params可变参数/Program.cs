using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_10_31_02_params可变参数
{
    class Program
    {
        /// <summary>
        /// 例题1：得出该考试者的各科成绩的总和，并打印
        /// </summary>
        /// <param name="name">考试者</param>
        /// <param name="score">所有考试成绩组成的可变参数整数数组</param>
        public static void Test(string name, params int[] score)//可变参数数组必须是形参列表中的最后一个参数
        {
            int sum = 0;
            for (int i = 0; i < score.Length; i++)
            {
                sum += score[i];
            }
            Console.WriteLine("{0}这次考试的总成绩是{1}", name, sum);
        }
        /// <summary>
        /// 练习1：获得导入可变整数数组的最大元素的值并多余返回之
        /// </summary>
        /// <param name="max">多余返回的最大值</param>
        /// <param name="input">导入的可变整数数组</param>
        public static void GetMax(out int max, params int[] input)
        {
            max = int.MinValue;
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] > max)
                {
                    max = input[i];
                }
            }
        }

        static void Main(string[] args)
        {
            //例题1：用方法得出张三本次考试的总成绩
            int[] score = { 99, 98, 97 };
            Test("张三", 99, 98, 97);
            Console.ReadKey();

            //练习1：求任意长度的，整数类型的数组的最大值
            GetMax(out int max, 5, 3, 2, 1, 5, 6, 7, 3, 4, 2, 1, 8, 4, 2, 2, 5, 5, 2, 1, 3);
            Console.WriteLine("这组数组中的最大值为{0}", max);
            Console.ReadKey();

            #region 笔记
            /*
            params可变参数
            将实参列表中对应位置的，和可变参数数组类型一致的元素都当作数组的元素处理。
            因此可变参数数组必须是形参列表中的最后一个参数。
            也因此一个参数列表中只能出现一个可变参数。
            如果填入数组方法也可以运行。
            */
            #endregion
        }
    }
}
