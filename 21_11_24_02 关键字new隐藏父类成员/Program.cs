using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_11_24_02_关键字new隐藏父类成员
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Programmer mario = new Programmer("Mario", 25, 5);
            mario.SayHello();
            Console.ReadKey();
            //当子类和父类拥有相同名称的方法时，子类的方法会覆盖父类的方法，在子类的方法返回值类型前添加一个new关键字。
            //在书写代码时不建议父类子类写一个方法名，如果执意要写就无法调用到父类的该方法

        }
    }
}
