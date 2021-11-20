using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_11_13_02_析构函数
{
    public class Student
    {
        //该结构就被称为析构函数
        //当创建了该类的对象后，程序结束的时候，就会执行析构函数
        //一般用来协助释放资源
        //由于.Net引入了GC自动释放资源，因此如果想要马上释放资源就使用析构函数，否则就让GC自动释放

        ~Student()
        {
            Console.WriteLine("调用了析构函数");
            Console.ReadKey();
        }
    }
}
