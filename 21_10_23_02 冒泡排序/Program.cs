using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_10_23_02_冒泡排序
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 1, 7, 5, 3, 9, 8, 6, 4, 2, 0, 5, 2, 1, 5, 5, 1, 2, 3, 5, 6, 3, 1, 4 };
            //将以上数组升序排列
            Array.Sort(nums);//数组.升序
            //Array.Reverse(nums);//数组.反转
            /*
            for (int i = 0; i < nums.Length - 1; i++)
            {
                for (int j = 0; j < nums.Length - 1 - i; j++)
                {
                    if (nums[j] > nums[j + 1])
                    {
                        int temp = nums[j + 1];
                        nums[j + 1] = nums[j];
                        nums[j] = temp;
                    }
                }
            }
            */
            for (int j = 0; j < nums.Length - 1; j++)
            {
                Console.Write("{0},", nums[j]);
            }
            Console.Write(nums[nums.Length - 1]);
            Console.ReadKey();
            
        }
    }
}
