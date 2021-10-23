using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_10_13_01_枚举类型和string类型以及int类型之间的转换
{
    public enum QQState
    {
        OnLine = 1,//(当前是练习6环境)      //=2  可以用赋值运算符给枚举赋值，没有赋值的就会按照系统默认规律递加
        OffLine,     // 3
        Leave,       //=5
        Busy,        // 6
        QMe          // 7
    }

    public enum Gender
    {
        男,
        女
    }
    class Program
    {
        static void Main(string[] args)
        {
            /*
            QQState state = QQState.OnLine;
            //枚举类型默认可以和int类型互相转换
            int n = (int)state;
            Console.WriteLine(n);
            Console.WriteLine((int)QQState.OffLine);
            Console.WriteLine((int)QQState.Leave);
            Console.ReadKey();
            //打印结果为 0 1 2(当枚举未被赋值时)

            //将int类型值强制转换为枚举类型
            int n1 = 3;
            QQState state1 = (QQState)n1;
            Console.WriteLine(state1);
            Console.ReadKey();
            //打印结果为位于第四个的Busy

            //如果输入数字超出枚举范围的不抛异常，会原值返回
            int n2 = 6;
            QQState state2 = (QQState)n2;
            Console.WriteLine(state2);
            Console.ReadKey();
            //打印结果为6

            //所有类型都可以转换成string类型
            double n3 = 3.14;
            string s3 = n3.ToString();
            Console.WriteLine(s3);
            Console.ReadKey();
            //打印结果为3.14
            QQState state4 = QQState.OnLine;
            string s4 = state4.ToString();
            Console.WriteLine(s4);
            Console.ReadKey();
            //打印结果为Online

            //将字符串转换为枚举类型
            string s5 = "200";//将这个0转换成枚举类型
            //调用Parse方法 帮助将字符串转换成对应的枚举类型
            //如果数字超出枚举范围则返回原值
            QQState state5 = (QQState)Enum.Parse(typeof(QQState), s5);
            //Enum.Parse(枚举类型,待转换的值) typeof的意思是：获得哪个类型 typeof(QQState)的作用就是获得QQState这个类型
            Console.WriteLine(state5);
            Console.ReadKey();
            //打印结果为Online
            //如果输入枚举内的值，就会返回该值，如果输入不是枚举内的值，就会抛异常
            */

            //练习6：提示用户选择一个QQ在线状态，接收并转换成枚举类型，再次打印到控制台中（调整了QQState的环境）
            Console.WriteLine("请输入您需要的QQ在线状态所对应的英文（区分大小写）或输入所对应的数字代号");
            Console.WriteLine("1：在线（OnLine）");
            Console.WriteLine("2：离线（OffLine）");
            Console.WriteLine("3：离开（Leave）");
            Console.WriteLine("4：忙碌(Busy)");
            Console.WriteLine("5：Q我吧（QMe）");
            string input6 = Console.ReadLine();
            try
            {
                int number6 = int.Parse(input6);
                if (number6 <= 5 && number6 >= 1)
                {
                    QQState State6 = (QQState)Enum.Parse(typeof(QQState), input6);
                    Console.WriteLine("您的在线状态现在已经设置为{0}", State6);
                }
                else
                {
                    Console.WriteLine("您的输入有误，程序即将退出");
                }
            }
            catch
            {
                if (input6 == "OnLine" || input6 == "OffLine" || input6 == "Leave" || input6 == "Busy" || input6 == "QMe")
                {
                    QQState State6 = (QQState)Enum.Parse(typeof(QQState), input6);
                    Console.WriteLine("您的在线状态现在已经设置为{0}", State6);
                }
                else
                {
                    Console.WriteLine("您的输入有误，程序即将退出");
                }
            }
            Console.ReadKey();

            #region 笔记
            /*
            枚举和其他类型转换
            枚举就是一个类型，默认可以和int强制转换，会直接转换到所对应的枚举值
            枚举值可以赋值，没有赋值的则会依照他之前的被赋值的枚举值，递加出该枚举值的值
            当数字超过枚举范围，则会返回原值
            当输入枚举内的值，则返回该值
            当输入不是该枚举内的字符串，则抛异常
            所有类型都可以转换成string类型，使用ToString();
            将string类型转化成枚举类型需要
            （枚举名）Enum.Parse(typeof(枚举名), 待转换值);
            */
            #endregion

        }
    }
}
