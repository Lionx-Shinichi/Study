using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_11_16_01_字符串的方法
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            //例题1：随机输入一个名字，然后输出他的字符串长度
            Console.WriteLine("请输入一个名字");
            string name = Console.ReadLine();
            //使用方法Length来获取字符串的字符个数
            Console.WriteLine("名字长度为{0}个字符", name.Length);
            Console.ReadKey(true);
            

            //例题2：要求两个用户输入课程，如果输入内容一样就返回相同，反之返回不同
            Console.WriteLine("A同学，请输入你喜欢的课程");
            string lessonA = Console.ReadLine();
            //lessonA = lessonA.ToUpper();
            Console.WriteLine("B同学，请输入你喜欢的课程");
            string lessonB = Console.ReadLine();
            //lessonB = lessonB.ToUpper();
            if (lessonA.Equals(lessonB, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("A与B选择的课程相同");
            }
            else
            {
                Console.WriteLine("A与B选择的课程不同");
            }
            Console.ReadKey(true);
            //发现如果书写的内容是一样的，但是大小写不一，也会进入else
            //因此在比较的时候统一转换成大写或小写即可,使用ToUpper方法转换成大写，也可以用ToLower方法转换成小写
            //也可以调用Equals方法，在比较方法（StringComparison）中选择忽略大小写(OrdinalIgnoreCase)
            

            //分割字符串
            string s = "a-b-c-d e f g";
            string[] str = s.Split(new char[]{ ' ', '-' },StringSplitOptions.RemoveEmptyEntries);
            //使用Split指令去除字符串中作为分隔符的部分，然后使用StringSplitOptions中的RemoveEmptyEntries选项选择删除输出数组中因为删除字符串的部分而导致的null元素，返回字符串类型的数组
            //此时输出的字符串数组str就由7个元素构成，分别是a b c d e f g
            

            //分割字符串练习：从日期字符串("2008-08-08")中分析出年、月、日；2008年08月08日。
            //让用户输入一个日期格式如：2008-01-02，输出2008年01月02日。

            Console.WriteLine("请输入一个xxxx-xx-xx格式的日期");
            string date = Console.ReadLine();
            string[] charDate = date.Split(new char[] { '-' }, StringSplitOptions.RemoveEmptyEntries);
            Console.WriteLine("{0}年{1}月{2}日", charDate[0], charDate[1], charDate[2]);
            Console.ReadKey(true);
            

            //检查字符串中是否含有关键字(Contains)和替换字符串内容(Replace)
            string str = "你jb谁啊";
            if (str.Contains("jb"))
            {
                str = str.Replace("jb", "话筒");
            }
            Console.WriteLine(str);
            Console.ReadLine();
            //打印结果为 你话筒谁啊
            //Contains方法：检查对象字符串是否含有传入关键字，含有返回true，否则返回false
            //Replace方法：将对象字符串中所有的oldValue替换成newValue，然后返回替换完的字符串
            */

            //截取字符串

        }
    }
}
