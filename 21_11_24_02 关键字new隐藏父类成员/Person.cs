using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_11_24_02_关键字new隐藏父类成员
{
    internal class Person
    {
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
        public void SayHello()
        {
            Console.WriteLine("您正在调用父类方法");
        }
    }
}
