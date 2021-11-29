using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_11_21_02_继承
{
    internal class Teacher : Person
    {
        private double _salary;
        public double Salary
        {
            get { return _salary; }
            set { _salary = value; }
        }
        public void Study()
        {
            Console.WriteLine("学习");
        }
        public Teacher(string name, char gender, int age, double salary)
            : base(name, gender, age)
        {
            this.Salary = salary;
        }
    }
}
