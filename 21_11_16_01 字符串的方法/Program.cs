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
            string[] str = s.Split(new char[] { ' ', '-' }, StringSplitOptions.RemoveEmptyEntries);
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
            string strB = "你jb谁啊";
            if (str.Contains("jb"))
            {
                strB = strB.Replace("jb", "话筒");
            }
            Console.WriteLine(strB);
            Console.ReadLine();
            //打印结果为 你话筒谁啊
            //Contains方法：检查对象字符串是否含有传入关键字，含有返回true，否则返回false
            //Replace方法：将对象字符串中所有的oldValue替换成newValue，然后返回替换完的字符串

            
            //截取字符串
            //使用SubString方法可以截取字符串中的部分内容，第一个参数表示从字符串的第几个字符开始(填写的具体数字是其对应char数组的下标)，第二个参数是指从这个字符开始截取几个字符
            string strC = "超级的敏感，全与你有关";
            strC = strC.Substring(3,2);
            //截取从下标3开始的字符，即【敏】这个字，然后截取两个字符，即【敏感】二字
            Console.WriteLine(strC);
            Console.ReadKey(true);
            //打印结果为敏感
            

            //确定对象字符串是否以某字符串开始/结束
            //使用StartsWith/EndsWith方法，该方法会确定对象字符串是否以参数字符串开始/结束，并返回一个Bool类型的值
            //字符串一定以他本身开始或结束
            string strD = "有你的陪伴，从不觉孤单";
            if(strD.StartsWith("有"))
            {
                Console.WriteLine("该字符串以有开始");
            }
            else
            {
                Console.WriteLine("该字符串不以有开始");
            }
            if(strD.EndsWith("陪伴"))
            {
                Console.WriteLine("该字符串以陪伴结束");
            }
            else
            {
                Console.WriteLine("该字符串不以陪伴结束");
            }
            Console.ReadKey();
            //打印结果为：该字符串以有开始
            //          该字符串不以陪伴结束
            

            //寻找字符串中对应字符串的位置
            //使用IndexOf方法，可以寻找参数字符串在对象字符串中第一个符合的字符串，然后int返回其具体下标，还可以传入一个int参数要求其从第几个字符起开始查找
            //LastIndexOf就是寻找最后一个符合的字符串,然后int返回其具体下标，还可以传入一个int参数要求其仅查询到第几个字符
            //以上两个方法如果查询字符串均会返回其第一个字符的下标，如果查询范围不能完整覆盖相同的字符内容，则不能查询到这个内容
            //如果要找出每一个项目，就应该使用for循环
            string strH = "超级的敏感，超级不平淡";
            int index = strH.IndexOf("超级", 2);
            int indexB = strH.LastIndexOf("超级", 6);
            Console.Write(index);
            Console.WriteLine("   " + indexB);
            Console.ReadKey();
            //打印结果为6   0
            //一般这个方法配合截取文件名使用
            

            //去除字符串里的空格
            //使用Trim方法，将对象字符串中的前端和后端空格全部去除后返回,该方法不能去除字符串中间的空格
            //TrimStart就是去除对象字符串前端的空格后返回
            //TrimEnd就是去除对象字符串后端的空格后返回
            string strE = "      Avava Ava     ";
            strE = strE.TrimStart();
            Console.Write(strE);
            Console.ReadKey(true);
            //打印结果为Avava Ava
            

            //判断是否为空字符串或值为null
            //使用string.IsNullOrEmpty方法，将待判断的字符串传入该方法，判断该字符串是否为空或者为null，返回一个bool变量
            //空格不能算作无内容
            string strF = null;
            if (string.IsNullOrEmpty(strF))
            {
                Console.WriteLine("该字符串为空或为null");
            }
            else
            {
                Console.WriteLine("该字符串含有字符内容");
            }
            Console.ReadKey(true);
            //打印结果为 该字符串为空或为null

            //将数组的所有元素组成一个字符串
            //使用string.Join方法，先传入一个作分割符的字符串，然后传入一个params属性的字符串数组，然后返回串联了每一个元素，之间添加了分隔符的字符串
            string[] names = { "张三", "李四", "王五", "赵六", "田七" };
            string strG = string.Join("|", names);
            //因为待传入的字符串数组参数带有params，因此也可以这样写
            strG = string.Join("|", "张三", "李四", "王五", "赵六", "田七");
            Console.WriteLine(strG);
            Console.ReadKey();
            //打印结果为张三|李四|王五|赵六|田七

            #region 笔记
            /*
            字符串的方法
            1)	Length 返回对象字符串的字符个数
            2)	ToUpper 将对象字符串中的字符转换成大写形式后返回
            3)	ToLower 将对象字符串中的字符转换成小写形式后返回
            4)	Equals 将对象字符串和参数字符串比较，可以用StringComparison限制比较规则
            5)	Split 分割字符串，删除不需要的分割用字符，可以用StringSplitOptions删除输出数组中因为删除字符串的部分而导致的null元素，返回字符串类型的数组
            6)	Contains 检查对象字符串是否含有传入关键字，含有返回true，否则返回false
            7)	Replace 将对象字符串中所有的oldValue替换成newValue，然后返回替换完的字符串
            8)	Substring 截取字符串的部分内容后返回，第一个参数表示从字符串的第几个字符开始(填写的具体数字是其对应char数组的下标)，第二个参数是指从这个字符开始截取几个字符
            9)	StartsWith/EndsWith 确定对象字符串是否以某字符串开始/结束，该方法会确定对象字符串是否以参数字符串开始/结束，并返回一个Bool类型的值，字符串一定以他本身开始或结束
            10)	IndexOf 可以寻找参数字符串在对象字符串中第一个符合的字符串，然后int返回其具体下标，还可以传入一个int参数要求其从第几个字符起开始查找
            11)	LastIndexOf 可以寻找参数字符串在对象字符串中最后一个符合的字符串，然后int返回其具体下标，还可以传入一个int参数要求其仅查询到第几个字符
            以上两个方法如果查询字符串均会返回其第一个字符的下标，如果查询范围不能完整覆盖相同的字符内容，则不能查询到这个内容，如果查询不到内容则返回-1
            12)	Trim 将对象字符串中的前端和后端空格全部去除后返回,该方法不能去除字符串中间的空格
            13)	TrimStart 去除对象字符串前端的空格后返回
            14)	TrimEnd 去除对象字符串后端的空格后返回
            15)	string.IsNullOrEmpty 将待判断的字符串传入该方法，判断该字符串是否为空或者为null，返回一个bool变量
            16)	string.Join 先传入一个作分割符的字符串，然后传入一个params属性的字符串数组，然后返回串联了每一个元素，之间添加了分隔符的字符串
            */
            #endregion

        }
    }
}
