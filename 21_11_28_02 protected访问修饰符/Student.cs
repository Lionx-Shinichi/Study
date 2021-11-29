using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_11_28_02_protected访问修饰符
{
    internal class Student : Person
    {
        public void Test()
        {
            //在其子类可以访问到
            _name = "张三";
        }
    }
}
