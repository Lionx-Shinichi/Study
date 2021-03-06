using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_11_08_01_静态与非静态的区别
{
    class Program
    {
        static void Main(string[] args)
        {
            //调用实例成员
            Person p = new Person();
            p.M1();
            //调用静态成员
            Person.M2();
            //综上所述
            //调用实例成员使用对象名.成员名
            //调用静态成员使用类名.成员名
            Console.ReadKey(true);

            #region 笔记
            /*
            静态与实例的区别
            实例，即非静态
            1)	在实例类中
            既可以声明实例成员，也可以声明静态成员
            可以访问实例成员，也可以访问静态成员
            2)	在静态类中
            不可以声明实例成员
            不可以访问实例成员
            不可以为静态类实例化

            重点：实例和静态成员的调用
            在调用实例成员的时候，需要使用对象名.实例成员();
            在调用静态成员的时候，需要使用类名.静态成员名();
            
            静态类和实例类的使用
            如果想要类当作一个工具类去使用，这时可以将类写成静态类。
            工具类即经常会使用的，为了方便使用单独封装的类。例如Console类
            如果工具类不是静态类，而是实例类的话得先创建对象，会让操作变得麻烦。
            静态类在整个项目中资源共享。因为静态类将数据存储在内存中的静态存储区域，整个项目中的任何人都可以访问这个区域。（winform内容）
            举例：QQ
            如果登录了QQ之后，点击客户端中的邮箱和空间不需要再输入用户名和密码就可以直接登录，但是从外部网页访问就需要再次登录。因为QQ在登录之后将用户信息保存在了一个静态类中，空间邮箱之类的模块可以直接访问其中的数据。
            释放资源：GC（Garbage Collection）
            只有在程序完全结束之后，静态类才会释放资源。
            
            内存
            内存被人为划分为五个区域，分别为
            堆、栈、自由存储区、静态存储区、常量存储区。
            */
            #endregion
        }
    }
}
