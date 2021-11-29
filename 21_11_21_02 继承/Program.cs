using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_11_21_02_继承
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //在这个项目下的三个类里，有大量重复的成员
            //在这时应该使用继承，将这几个类中相同的字段属性方法封装成一个类作为他们的父类
            //语法：子类名后跟冒号加父类名
            //子类可以访问父类的公共字段
            //对于父类的私有字段，虽然在子类的内存中可以看到父类的私有字段，但是依然不可以访问。
            Student mario = new Student("mario", '男', 30, 001);
            //mario._name = "mario";
            //错误代码：Person._name不可访问，因为他具有一定的保护级别
            string name = mario.GetName();
            Console.WriteLine(name);
            Console.ReadKey();
            //通过以上代码可以证明，除去私有字段，所有父类里的对象都可以在子类中访问
            //子类又称为派生类 父类又称为基类

            //子类是否继承了父类的构造函数？
            //如果子类继承了父类的构造函数，那么在创建子类的对象时可以调用该构造函数
            //Student xiaolan = new Student("xiaolan", '男', 25);
            //此时程序报错了，显示Student类中不包含采用三个参数的构造函数
            //因此子类没有继承父类的构造函数

            //子类会默认调用父类无参的构造函数用于创建父类的对象，让子类可以使用父类的成员
            //如果在父类中写了一个有参数的构造函数，那么无参的默认构造函数就被覆盖了，子类就无法调用到无参的构造函数，就会报错
            //该问题的解决办法：
            //1.在父类中写一个无参的构造函数
            //2.在子类中显示的调用父类的构造函数，使用关键字:base()

            //Object类
            //该类是所有类的基类，如果一个类没有基类，就会默认作为Object类的派生类
            //因此所有类都直接或者间接为Object类的派生类

        }
    }
}
