using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_11_08_01_静态与非静态的区别
{
    public static class Student
    {
        private static string _name;
        public static string Name
        {
            get { return _name; }
            set { _name = value; }
        }
    }
}
