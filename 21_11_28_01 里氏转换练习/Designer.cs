using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_11_28_01_里氏转换练习
{
    internal class Designer:Person
    {
        public void DesignerSayHello()
        {
            Console.WriteLine("我是设计师");
        }
    }
}
