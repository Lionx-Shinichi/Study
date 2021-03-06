using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_11_21_02_继承
{
    internal class Person//作父类
    {
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


        private char _gender;
        public char Gender
        {
            get { return _gender; }
            set { _gender = value; }
        }


        public string GetName()
        {
            return Name;
        }

        public Person(string name, char gender, int age)
        {
            this.Age = age;
            this.Name = name;
            this.Gender = gender;
        }
    }
}
