using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_11_01_03_大型项目_飞行棋游戏
{
    class Program
    {
        public static void GameShow()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("*****************************");
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("*****************************");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("*****************************");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("***飞行棋游戏**开发：Lionx***");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("*****************************");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("*****************************");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("*****************************");
        }
        static void Main(string[] args)
        {
            //程序运行步骤：
            //1.画游戏头
            //2.初始化地图（加载地图所需要的资源）
            //3.画地图
            //4.玩游戏

            //游戏规则：
            //如果有玩家被踩到，被踩到的玩家后退6格
            //踩到地雷，后退6格
            //踩到时空隧道，前进10格
            //踩到幸运轮盘，选择1.交换双方的位置 2.轰炸对方 使对方退六格
            //踩到暂停，暂停一回合
            //踩到方块，什么都不会发生
            GameShow();
            Console.ReadKey();
        }
    }
}
