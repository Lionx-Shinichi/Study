using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_11_28_02_protected访问修饰符
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //离开其当前类或子类就访问不到了
            //此时程序报错:Person._name不可访问,因为它具有一定的保护级别
            Person person = new Person();
            person._name = "赵四";
        }
    }
}
