using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _21_11_21_01_字符串练习
{
    internal class Program
    {
        /// <summary>
        /// 练习1用：传入一个字符串，将空格分隔符号去除并分割成多个字符串，返回分割完成的字符串数组
        /// </summary>
        /// <param name="input">待分割的字符串</param>
        /// <returns>分割完成的字符串数组</returns>
        public static string[] RemoveSpace(string input)
        {
            string[] output = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            return output;
        }

        static void Main(string[] args)
        {
            //练习1：
            //文本文件中存储了多个文章的标题和作者
            //标题和作者之间用若干个空格隔开，每行一组
            //标题有长有短，输出到控制台的时候标题最长为10个字符
            //如果超过10个字符，则截取8个字符，然后加3个点(...)，加一个竖线后输出作者的名字
            //法制的细节             罗翔
            //新编日语第四册          周平
            //C#从入门到精通（第5版）  明日科技
            

            //使用该程序应该在对应地址放置一个含有书名的文本文档
            string path = @"C:\Users\Lionx.Shinichi\Desktop\好书目录.txt";
            string[] bookName = File.ReadAllLines(path);
            string[] bookNameAfterSplit = new string[bookName.Length];
            string[] temp = new string[2];
            for (int i = 0; i < bookName.Length; i++)
            {
                temp = RemoveSpace(bookName[i]);
                if (temp[0].Length > 10)
                {
                    temp[0] = temp[0].Substring(0, 8);
                    temp[0] += "...";
                }
                bookNameAfterSplit[i] = temp[0] + "|" + temp[1];
                Console.WriteLine(bookNameAfterSplit[i]);
            }
            Console.ReadKey();


            //练习2：接收用户输入的字符串，然后倒序输出
            Console.WriteLine("请输入一个字符串，系统将倒序输出该字符串");
            string input = Console.ReadLine();
            char[] charInput = input.ToCharArray();
            //Array.Reverse(charInput);
            for (int i = 0; i < charInput.Length / 2; i++)
            {
                char temp2 = charInput[charInput.Length - 1 - i];
                charInput[charInput.Length - 1 - i] = charInput[i];
                charInput[i] = temp2;
            }
            input = new string(charInput);
            Console.WriteLine(input);
            Console.ReadKey();


            //练习3：接收用户输入的一串英文，然后以单词为单位倒序输出
            Console.WriteLine("请输入一句英语，系统将以单词为单位倒序输出该句英语");
            string input3 = Console.ReadLine();
            string[] inputAfterSplit3 = input3.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            //Array.Reverse(inputAfterSplit);
            for (int i = 0; i < inputAfterSplit3.Length / 2; i++)
            {
                string temp3 = inputAfterSplit3[inputAfterSplit3.Length - 1 - i];
                inputAfterSplit3[inputAfterSplit3.Length - 1 - i] = inputAfterSplit3[i];
                inputAfterSplit3[i] = temp3;
            }

            //for (int i = 0; i < inputAfterSplit.Length; i++)
            //{
            //    if (i == 0)
            //    {
            //        input = inputAfterSplit[i];
            //    }
            //    else
            //    {
            //        input += inputAfterSplit[i];
            //    }
            //    if (i < inputAfterSplit.Length - 1)
            //    {
            //        input += " ";
            //    }
            //}

            input3 = string.Join(" ", inputAfterSplit3);
            Console.WriteLine(input3);
            Console.ReadKey(true);

            //练习4：从Email中提取出用户名和域名
            //Lionx.Shinichi@Gmail.com
            string email = "Lionx.Shinichi@Gmail.com";
            string[] emailAfterSplit = email.Split(new char[] { '@' }, StringSplitOptions.RemoveEmptyEntries);
            Console.WriteLine("用户名是{0}", emailAfterSplit[0]);
            Console.WriteLine("域名是{0}", emailAfterSplit[1]);
            Console.ReadKey();

            //练习5：让用户输入一段话，找出其中的所有e的位置
            string str5 = "asdveeaggegsdgawr";
            int position = -1;
            int nextPosition = 0;
            for (int i = 0; i < str5.Length; i++)
            {
                nextPosition = str5.IndexOf("asd", i);
                if (nextPosition == -1) { break; }
                if (nextPosition != position)
                {
                    position = nextPosition;
                    i = position;
                    Console.Write("{0} ", position);
                }
            }
            Console.ReadKey();

            //如果仅寻找单个字符的话可以使用比较简单的寻找方法
            string str5B = "asdveeaggegsdgawr";
            for (int i = 0; i < str5B.Length; i++)
            {
                if (str5B[i] == 'e')
                {
                    Console.Write("{0} ", i);
                }
            }
            Console.ReadKey();
            

            //练习6：检测用户输入的话语有没有敏感关键字，如果有就替换成**
            Console.WriteLine("输入您要发送的内容");
            string input6 = Console.ReadLine();
            Console.WriteLine();
            if (input6.Contains("jb"))
            {
                input6 = input6.Replace("jb", "**");
            }
            if (input6.Contains("指导"))
            {
                input6 = input6.Replace("指导", "**");
            }
            Console.WriteLine("已发送：");
            Console.WriteLine(input6);
            Console.ReadKey(true);

            //练习7：把给定字符串数组之间用|分割，再将分隔符去除
            string[] aSoul = { "Diana", "Ava", "Eileen", "Carol", "Bella" };
            string aSoulStr = string.Join("|", aSoul);
            Console.WriteLine(aSoulStr);
            string[] aSoulAfterSplit = aSoulStr.Split(new char[] { '|' }, StringSplitOptions.RemoveEmptyEntries);
            aSoulStr = string.Join("",aSoulAfterSplit);
            Console.WriteLine(aSoulStr);
            Console.ReadKey();
        }
    }
}
