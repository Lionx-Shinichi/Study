using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_12_04_01_File类的基本操作
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////创建一个文件
            //File.Create(@"C:\Users\Lionx.Shinichi\Desktop\向晚大魔王.txt");
            //Console.WriteLine("生成完成");
            //Console.ReadKey(true);
            ////如果重复生成了一个同名文件那么旧文件会被覆盖，在这个过程创建时间不会改变，只会改变该文件的修改时间

            ////删除一个文件
            //File.Delete(@"C:\Users\Lionx.Shinichi\Desktop\向晚大魔王.txt");
            //Console.WriteLine("删除完成");
            //Console.ReadKey(true);
            ////被删除的文件回收站无法找回

            ////拷贝一个文件，Copy传入两个参数，第一个参数是源文件路径，第二个参数是目标文件路径，如果不存在目标文件，就创建一个目标文件，如果存在文件就覆盖，但是目标目录路径必须都存在
            //File.Copy(@"C:\Users\Lionx.Shinichi\Desktop\向晚大魔王.txt", @"C:\Users\Lionx.Shinichi\Desktop\嘉然今天吃什么.txt");
            //Console.WriteLine("拷贝完成");
            //Console.ReadKey(true);

            ////移动一个文件，Move传入两个参数，第一个参数是源文件路径，第二个参数是目标文件路径，如果不存在目标文件，就创建一个目标文件，如果存在文件就覆盖，但是目标目录路径必须都存在
            //File.Move(@"C:\Users\Lionx.Shinichi\Desktop\向晚大魔王.txt", @"C:\Users\Lionx.Shinichi\Desktop\Test\嘉然今天吃什么.txt");
            //Console.WriteLine("移动完成");
            //Console.ReadKey(true);

            
        }
    }
}
