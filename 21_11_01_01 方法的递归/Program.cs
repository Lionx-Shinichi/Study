using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_11_01_01_方法的递归
{
    class Program
    {
        public static int i = 1;//通过在类下声明全局变量让方法的递归可以中断
        public static void TellStory()
        {

            Console.WriteLine("从前有座山");
            Console.WriteLine("山里有座庙");
            Console.WriteLine("庙里有个老和尚和小和尚");
            Console.WriteLine("有一天，小和尚哭了，老和尚给小和尚讲了一个故事{0}", i);
            i++;
            if (i > 10)
            {
                return;//在原理上，结束递归时也要一个一个从方法里出来
            }
            TellStory();
        }
        static void Main(string[] args)
        {
            //例题1：让程序讲10次故事
            TellStory();
            Console.ReadKey();
            //现在程度不够，需要等到窗体应用程序再重新讲解
            #region 笔记
            /*
            方法的递归：
            方法自己调用自己。
            */
            #endregion
        }
    }
}
