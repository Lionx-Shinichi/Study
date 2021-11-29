using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_11_24_01_继承练习
{
    internal class Person//父类
    {
        //构造函数
        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }
        private string _name;
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        private int _age;
        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }
    }
}
