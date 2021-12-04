using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _21_11_29_01_Path类
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //path是静态类
            //例题1：取得路径里的文件名
            string str = @"C:\Users\Lionx.Shinichi\Desktop\好书目录.txt";
            int index = str.LastIndexOf("\\");
            str = str.Substring(index + 1);
            Console.WriteLine(str);
            Console.ReadKey(true);

            //Path类下的方法GetFileName可以获取路径中的文件名，传入路径字符串，返回文件名
            //GetFileNameWithoutExtension将返回不带有扩展名的文件名
            //GetExtension则仅返回文件的拓展名
            //GetDirectoryName返回存储该文件的文件夹的路径
            //GetFullPath 返回该文件路径
            //Combine 用来将两个字符串合成成路径
            str = @"C:\Users\Lionx.Shinichi\Desktop\好书目录.txt";
            Console.WriteLine(Path.GetFileNameWithoutExtension(str));
            Console.WriteLine(Path.GetExtension(str));
            Console.WriteLine(Path.GetDirectoryName(str));
            Console.WriteLine(Path.GetFullPath(str));
            Console.WriteLine(Path.Combine(@"c:\a\", "b.txt"));
            Console.ReadKey(true);
        }
    }
}
