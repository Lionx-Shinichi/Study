using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_11_14_01_面向对象初级篇复习
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //添加一个Ticket类
            //有一个距离属性（本属性只读，在构造方法中赋值，不能为负数）
            //有一个价格属性（本属性只读）
            //并且根据距离distance计算价格price（1元/公里）
            //距离0-100公里不打折，101-200公里9.5折，201-300公里9折，300以上打8折
            Ticket shanghai = new Ticket(182);
            shanghai.TotalPrice();
            Console.ReadKey();

            #region 面向对象初级篇总结
            /*
            实例类使用对象名.方法名调用
            静态类使用类名.方法名调用
            静态类函数不可以访问实例类的成员

            类中可以书写：
            字段，属性，方法，构造函数

            字段：
            保护数据

            属性：
            保护字段，对字段的取值和赋值进行限定，属性的本质就是两个方法（get和set）

            方法：
            描述对象的行为

            构造函数：
            初始化对象（给对象的每个属性依次的赋值）
            构造函数不具有返回值，连void都没有
            构造函数的名称和类名一样
            如果不书写构造函数系统会默认一个空的构造函数
            构造函数可以重载，利用this减少冗余代码

            访问修饰符：
            类中的成员如果不加访问修饰符就会默认为private

            this：
            代表当前类的对象/调用构造函数

            new：
            在内存中开辟一块空间，在该空间中创建一个对象并调用该对象的构造函数


            */
            #endregion
        }
    }
}
