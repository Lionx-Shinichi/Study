using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_11_24_01_继承练习
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //练习：写Reporter类，Programmer类和Driver类
            //他们都有一个打招呼的方法
            //不同的是Reporter打招呼会说:"大家好，我叫{0}，我今年{1}岁了，我的爱好是{2}"
            //Programmer:"大家好，我叫{0}，我今年{1}岁了，我已经工作{2}年了"
            //Driver:"大家好，我叫{0}，我今年{1}岁了，我的驾龄是{2}年"
            Reporter mario = new Reporter("Mario",27,"摄影");
            Programmer luigi = new Programmer("Luigi", 26, 3);
            Driver toad = new Driver("toad", 3, 1);
            mario.SelfIntroduction();
            luigi.SelfIntroduction();
            toad.SelfIntroduction();
            Console.ReadKey();
        }
    }
}
