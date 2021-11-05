using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_11_01_03_大型项目_飞行棋游戏
{
    #region 题目要求
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
    //□◎☆▲卐 拿去复制
    #endregion

    class Program
    {
        /// <summary>
        /// 写游戏头
        /// </summary>
        public static void GameShow()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("***********************************");
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("***********************************");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("***********************************");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("******飞行棋游戏**开发：Lionx******");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("***********************************");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("***********************************");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("***********************************");
        }
        /// <summary>
        /// 初始化游戏地图
        /// </summary>
        public static void InitailMap()
        {
            for (int i = 0; i < LuckyTurn.Length; i++)//设置幸运轮盘的值为1
            {
                Maps[LuckyTurn[i]] = 1;
            }
            for (int i = 0; i < LandMine.Length; i++)//设置地雷的值为2
            {
                Maps[LandMine[i]] = 2;
            }
            for (int i = 0; i < Pause.Length; i++)//设置暂停的值为3
            {
                Maps[Pause[i]] = 3;
            }
            for (int i = 0; i < TimeTunnel.Length; i++)//设置时空隧道的值为4
            {
                Maps[TimeTunnel[i]] = 4;
            }
        }
        /// <summary>
        /// 确定每一个单元格应该画什么内容，然后打印出来
        /// </summary>
        /// <param name="i">地图点的序号</param>
        public static void DrawPoint(int i)
        {

            //如果玩家A和玩家B的坐标相同，且坐标与i相同，都在这个地图上，就写两个尖括号
            if (PlayerPos[0] == PlayerPos[1] && PlayerPos[0] == i)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write("<>");
            }
            else if (PlayerPos[0] == i)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write("Ａ");
            }
            else if (PlayerPos[1] == i)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write("Ｂ");
            }
            else
            {
                switch (Maps[i])
                {
                    case 0:
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.Write("□");//普通格
                        break;
                    case 1:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write("◎");//幸运轮盘
                        break;
                    case 2:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write("☆");//地雷
                        break;
                    case 3:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write("▲");//暂停
                        break;
                    case 4:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write("卐");//时空隧道
                        break;
                }
            }
        }
        /// <summary>
        /// 将地图打印在控制台上
        /// </summary>
        public static void DrawMap()
        {
            //限定值域
            if (PlayerPos[0] > 99)
            {
                PlayerPos[0] = 99;
            }
            else if (PlayerPos[0] < 0)
            {
                PlayerPos[0] = 0;
            }
            if (PlayerPos[1] > 99)
            {
                PlayerPos[1] = 99;
            }
            else if (PlayerPos[1] < 0)
            {
                PlayerPos[1] = 0;
            }
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("{0}的士兵用A表示，{1}的士兵用B表示", PlayerNames[0], PlayerNames[1]);
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("图例：普通格：□   幸运轮盘：◎   地雷：☆   暂停：▲   ");
            Console.WriteLine("      时空隧道：卐 玩家重叠：<>");
            //第一横行（0-29）
            for (int i = 0; i <= 29; i++)
            {
                DrawPoint(i);
            }
            //第一竖行（30~34）
            Console.WriteLine();
            for (int i = 30; i <= 34; i++)
            {
                for (int j = 0; j < 29; j++)
                {
                    Console.Write("  ");
                }
                DrawPoint(i);
                Console.WriteLine();

            }
            //第二横行（35~64）
            for (int i = 64; i >= 35; i--)
            {
                DrawPoint(i);
            }
            Console.WriteLine();
            //第二竖行（65~69）
            for (int i = 65; i <= 69; i++)
            {
                DrawPoint(i);
                Console.WriteLine();
            }
            //第三横行(70~99)
            for (int i = 70; i <= 99; i++)
            {
                DrawPoint(i);
            }
            Console.WriteLine();
        }
        /// <summary>
        /// 获得玩家的ID，防止用户输入重复名称或空白名称
        /// </summary>
        /// <param name="playerA">额外返回的玩家A名称</param>
        /// <param name="playerB">额外返回的玩家B名称</param>
        public static void GetPlayerID()
        {
            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("请输入玩家1的ID");
                PlayerNames[0] = Console.ReadLine();
                if (PlayerNames[0] == "")
                {
                    Console.WriteLine("玩家名称不能为空，请重新输入");
                    continue;
                }
                break;
            }
            while (true)
            {
                Console.WriteLine("请输入玩家2的ID");
                PlayerNames[1] = Console.ReadLine();
                if (PlayerNames[1] == "")
                {
                    Console.WriteLine("玩家名称不能为空，请重新输入");
                    continue;
                }
                else if (PlayerNames[0] == PlayerNames[1])
                {
                    Console.WriteLine("玩家名称不能重复，请重新输入");
                    continue;
                }
                break;
            }
        }
        /// <summary>
        /// 检查玩家是否踩到了特殊格子，并且给予相关反馈
        /// </summary>
        /// <param name="roundA">现在是谁的回合判断</param>
        public static void CheckPos(bool roundA)
        {
            //幸运轮盘检查
            for (int i = 0; i < LuckyTurn.Length; i++)
            {
                if (roundA)
                {
                    if (PlayerPos[0] == LuckyTurn[i])
                    {
                        Console.WriteLine("触碰到幸运轮盘，可以选择1.和对方交换位置 2.使对方后退六格");
                        while (true)
                        {
                            Console.WriteLine("请输入您要选择的序号");
                            try
                            {
                                int choose = int.Parse(Console.ReadLine());
                                if (choose == 1)
                                {
                                    int temp = PlayerPos[0];
                                    PlayerPos[0] = PlayerPos[1];
                                    PlayerPos[1] = temp;
                                    Console.WriteLine("成功和对方互换位置");
                                    return;
                                }
                                else if (choose == 2)
                                {
                                    PlayerPos[1] -= 6;
                                    Console.WriteLine("成功使对方后退六格");
                                    return;
                                }
                                else
                                {
                                    Console.WriteLine("输入错误，请重新输入");
                                }
                            }
                            catch
                            {
                                Console.WriteLine("输入错误，请重新输入");
                            }
                        }
                    }
                }
                else if (roundA == false)
                {
                    if (PlayerPos[1] == LuckyTurn[i])
                    {
                        Console.WriteLine("触碰到幸运轮盘，可以选择1.和对方交换位置 2.使对方后退六格");
                        while (true)
                        {
                            Console.WriteLine("请输入您要选择的序号");
                            try
                            {
                                int choose = int.Parse(Console.ReadLine());
                                if (choose == 1)
                                {
                                    int temp = PlayerPos[0];
                                    PlayerPos[0] = PlayerPos[1];
                                    PlayerPos[1] = temp;
                                    Console.WriteLine("成功和对方互换位置");
                                    return;
                                }
                                else if (choose == 2)
                                {
                                    PlayerPos[0] -= 6;
                                    Console.WriteLine("成功使对方后退六格");
                                    return;
                                }
                                else
                                {
                                    Console.WriteLine("输入错误，请重新输入");
                                }
                            }
                            catch
                            {
                                Console.WriteLine("输入错误，请重新输入");
                            }
                        }
                    }
                }
            }
            //地雷检查
            for (int i = 0; i < LandMine.Length; i++)
            {
                if (roundA)
                {
                    if (PlayerPos[0] == LandMine[i])
                    {
                        PlayerPos[0] -= 6;
                        Console.WriteLine("触碰到地雷，后退六格");
                        return;
                    }
                }
                else if (roundA == false)
                {
                    if (PlayerPos[1] == LandMine[i])
                    {
                        PlayerPos[1] -= 6;
                        Console.WriteLine("触碰到地雷，后退六格");
                        return;
                    }
                }
            }
            //暂停检查
            for (int i = 0; i < Pause.Length; i++)
            {
                if (roundA)
                {
                    if (PlayerPos[0] == Pause[i])
                    {
                        PauseBool[0] = true;
                        Console.WriteLine("触碰到暂停，下回合无法移动");
                        return;
                    }
                }
                else if(roundA==false)
                {
                    if (PlayerPos[1] == Pause[i])
                    {
                        PauseBool[1] = true;
                        Console.WriteLine("触碰到暂停，下回合无法移动");
                        return;
                    }
                }
            }
            //时空隧道检查
            for (int i = 0; i < TimeTunnel.Length; i++)
            {
                if(roundA)
                {
                    if(PlayerPos[0]==TimeTunnel[i])
                    {
                        PlayerPos[0] += 10;
                        Console.WriteLine("触碰到时空隧道，向前移动10格");
                        return;
                    }
                }
                else if(roundA==false)
                {
                    if(PlayerPos[1]==TimeTunnel[i])
                    {
                        PlayerPos[1] += 10;
                        Console.WriteLine("触碰到时空隧道，向前移动10格");
                        return;
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            GameShow();
            InitailMap();
            GetPlayerID();
            while (PlayerPos[0] < 99 && PlayerPos[1] < 99)
            {
                Console.Clear();
                GameShow();
                Console.ForegroundColor = ConsoleColor.Cyan;
                DrawMap();
                Random r = new Random();
                bool roundA;
                if (PauseBool[0] == false)
                {
                    Console.WriteLine("请玩家{0}按任意键开始掷骰子", PlayerNames[0]);
                    roundA = true;
                    Console.ReadKey(true);
                    int rNumberA = r.Next(1, 7);
                    Console.WriteLine("玩家{0}掷出了{1}", PlayerNames[0], rNumberA);
                    PlayerPos[0] += rNumberA;
                    CheckPos(roundA);
                    Console.WriteLine("玩家{0}按任意键开始移动棋子", PlayerNames[0]);
                    Console.ReadKey(true);
                    Console.Clear();
                    GameShow();
                    DrawMap();
                    if (PlayerPos[0] == 99)
                    {
                        break;
                    }
                }
                else
                {
                    Console.WriteLine("玩家A上回合被暂停，无法移动");
                    Console.ReadKey(true);
                    PauseBool[0] = false;
                    Console.Clear();
                    GameShow();
                    DrawMap();
                }

                if (PauseBool[1] == false)
                {
                    roundA = false;
                    Console.WriteLine("请玩家{0}按任意键开始掷骰子", PlayerNames[1]);
                    Console.ReadKey(true);
                    int rNumberB = r.Next(1, 7);
                    Console.WriteLine("玩家{0}掷出了{1}", PlayerNames[1], rNumberB);
                    PlayerPos[1] += rNumberB;
                    CheckPos(roundA);
                    Console.WriteLine("玩家{0}按任意键开始移动棋子", PlayerNames[1]);
                    Console.ReadKey(true);
                    Console.Clear();
                    GameShow();
                    DrawMap();
                    if (PlayerPos[1] == 99)
                    {
                        break;
                    }
                }
                else
                {
                    Console.WriteLine("玩家B上回合被暂停，无法移动");
                    Console.ReadKey(true);
                    PauseBool[1] = false;
                    Console.Clear();
                    GameShow();
                    DrawMap();
                }

            }
            string winner;
            if (PlayerPos[0] > PlayerPos[1])
            {
                winner = PlayerNames[0];
            }
            else
            {
                winner = PlayerNames[1];
            }
            Console.WriteLine("恭喜玩家{0}赢得了游戏！按任意键退出游戏。", winner);
            Console.ReadKey();

        }
        //声明静态数组来存储相应坐标内容
        public static int[] Maps = new int[100];
        public static int[] LuckyTurn = { 6, 23, 40, 55, 69, 83 };
        public static int[] LandMine = { 5, 13, 17, 33, 38, 50, 64, 80, 94 };
        public static int[] Pause = { 9, 27, 60, 93 };
        public static int[] TimeTunnel = { 20, 25, 45, 63, 72, 88, 90 };
        public static int[] PlayerPos = new int[2];
        public static string[] PlayerNames = new string[2];
        public static bool[] PauseBool = { false, false };
    }
}
