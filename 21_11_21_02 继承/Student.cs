using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_11_21_02_继承
{
    internal class Student : Person
    {
        private int _id;
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        public void Teach()
        {
            Console.WriteLine("教授");
        }
        public Student(string name, char gender, int age, int id)
            : base(name, gender, age)
        {
            this.Id = id;
        }
    }
}
