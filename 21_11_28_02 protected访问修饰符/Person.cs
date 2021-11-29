using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_11_28_02_protected访问修饰符
{
    internal class Person
    {
        protected string _name;
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
    }
}
