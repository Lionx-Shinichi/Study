using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_10_11_02_枚举
{
    public enum Gender
    {
        男,
        女
    }

    public enum Seasons
    {
        春,
        夏,
        秋,
        冬
    }

    public enum QQState
    {
        OnLine,
        OffLine,
        Leave,
        Busy,
        QMe
    }

    class Program
    {
        static void Main(string[] args)
        {
            Gender gender = Gender.男;
            //给一个枚举类型赋值的方法：枚举名.枚举内的值
            //枚举的主要作用就是规范化词汇的使用

            #region 笔记
            /*
            枚举
            语法：
            [public] enum 枚举名
            {
                值1,
                值2,
                值3,
                ……
                值x   (最后一个值的逗号可以加也可以不加)
            }
            放在中括号里代表这个public可以省略
            public：访问修饰符（用来修饰访问权限的），public权限等级最高，可以访问全部。
            enum：声明枚举的关键字
            枚举名：符合Pascal命名规范（每个单词首字母大写）
            
            不能在Main函数里声明枚举
            最好写在命名空间下类上，这样所有的类都可以使用这个枚举
            
            枚举就是一个变量类型，只是声明，赋值，使用的方式和普通变量不同

            给一个枚举类型赋值的方法：枚举名.枚举内的值
            */
            #endregion
        }
    }
}
