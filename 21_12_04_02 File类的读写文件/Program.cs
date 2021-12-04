using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_12_04_02_File类的读写文件
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //如何读取txt文件
            byte[] buffer = File.ReadAllBytes(@"C:\Users\Lionx.Shinichi\Desktop\向晚大魔王.txt");
            //此时字节数组需要被解码才能阅读
            string str = Encoding.UTF8.GetString(buffer);
            Console.WriteLine(str);
            Console.ReadKey(true);

            //如何写入txt文件
            //如果不存在这个文件，就创建一个，如果存在就覆盖掉
            string str2 = "乃琳你快点吃饭";
            //将字符串转换为字节数组
            byte[] buffer2 = Encoding.UTF8.GetBytes(str2);
            File.WriteAllBytes(@"C:\Users\Lionx.Shinichi\Desktop\嘉然今天吃什么.txt", buffer2);
            Console.Write("写入完成");
            Console.ReadKey(true);

            //ReadAllLines会依照行为单位读取文件，然后存入string类型的数组里
            string[] str3 = File.ReadAllLines(@"C:\Users\Lionx.Shinichi\Desktop\向晚大魔王.txt");
            foreach (var item in str3)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey(true);

            //ReadAllText会读取整个文件的字符，然后存入一个string类型的变量里
            string str4 = File.ReadAllText(@"C:\Users\Lionx.Shinichi\Desktop\向晚大魔王.txt", Encoding.UTF8);
            Console.WriteLine(str4);
            Console.ReadKey(true);

            //在读取多媒体文件等的的时候，ReadAllText和ReadAllLines就不能使用
            //在读取文本文件的时候，如果需要精确操作每行文字的话就使用ReadAllLines，否则使用ReadAllText

            //写入方法和读取方法类似，但是注意会覆盖掉源文件
            File.WriteAllText(@"C:\Users\Lionx.Shinichi\Desktop\嘉然今天吃什么.txt", "小小的，香香的");
            Console.ReadKey(true);

            //如果不想覆盖掉源文件可以使用Append系列的三个指令
            File.AppendAllText(@"C:\Users\Lionx.Shinichi\Desktop\向晚大魔王.txt", "\r\n连这种幼儿园小朋友组合你们都能磕CP嘛！");
            Console.ReadKey(true);
            
        }
    }
}
