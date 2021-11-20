using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _21_11_13_01_构造函数;//引用命名空间
using _21_11_13_02_析构函数;

namespace _21_11_15_01_命名空间
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //这里跨项目调用了_21_11_13_01_构造函数中的Student类
            //先在右侧的引用中勾选需要的类，然后书写命名空间
            //如果调用同名类就需要在类前面再书写一个命名空间用于分别
            _21_11_13_01_构造函数.Student mario = new _21_11_13_01_构造函数.Student("mario",12,98,85);
            mario.SayHello();
            mario.ShowScoal();
            Console.ReadKey();

            #region 笔记
            /*
            命名空间
            可以认为类是属于命名空间的，如果当前项目中没有这个类的命名空间，那么就需要手动导入这个类所在的命名空间。
            1)	鼠标左下角点
            2)	Alt+Shift+F10
            3)	手动输入命名空间

            如果跨项目引用类的时候：
            第一步：添加引用
            第二部：引用命名空间

            */
            #endregion
        }
    }
}
