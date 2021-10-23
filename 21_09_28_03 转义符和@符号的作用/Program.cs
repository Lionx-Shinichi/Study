using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_09_28_03_转义符和_符号的作用
{
    class Program
    {
        static void Main(string[] args)
        {
            //换行符 \n
            Console.WriteLine("今天天气好晴\n朗，处处好风光");
            Console.ReadKey();
            
            //双引号符 \"
            Console.WriteLine("我想在这句话中输出一个\"\"英文半角的双引号");
            Console.ReadKey();

            //tab符  \t
            string name1 = "张三";
            string name2 = "李四";
            string name3 = "王五";
            string name4 = "赵六";

            Console.WriteLine("{0}\t{1}",name1,name2);
            Console.WriteLine("{0}\t{1}",name3,name4);
            Console.ReadKey();

            //退格符 \b
            Console.WriteLine("\b这句话中\b间缺少了一个字\b");//退格符在句首句尾不起作用
            Console.ReadKey();

            //windows操作系统的换行符 \r\n
            //警告：运行下列代码会在桌面生成一个文件
            string str = "今天天气好晴\r\n朗，处处好风光";
            System.IO.File.WriteAllText(@"C:\Users\Lionx.Shinichi\Desktop\Test.txt",str);
            Console.WriteLine("写入成功！");
            Console.ReadKey();
            //输出结果为 今天天气好晴
            //          朗，处处好风光

            //斜杠符 \\ 不使用斜杠符会导致Visual Studio将斜杠识别为转义符，无法输出斜杠
            Console.WriteLine("使用了斜杠符号就可以在句子中加入\\了");
            Console.ReadKey();

            //@符号 将字符串按照其原格式输出，取消转义符等的含义
            Console.WriteLine(@"\n\b\a\t");
            Console.ReadKey();
            //输出结果为\n\b\a\t

            //转义符斜杠和内容是一个整体，仅占一个字符
            char a = '\b';

            #region 笔记
            /*
            转义符
            转义符指的就是【\+一个特殊的字符】，组成了一个具有特殊意义的字符。
            \n 表示换行
            \" 表示一个英文半角的双引号
            \t 表示一个tab键
            \b 表示一个退格键
            \r\n 是windows操作系统可识别的\n
            \\ 表示一个\
            
            @符号
            将@后的字符串按照其原格式输出，取消转义符等的含义。

            */
            #endregion
        }
    }
}
