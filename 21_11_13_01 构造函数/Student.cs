using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_11_13_01_构造函数
{
    public class Student
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
            set
            {
                if (value < 0 || value >= 100)
                {
                    value = 0;
                }
                _age = value;
            }
        }
        private char _gender;
        public char Gender
        {
            get { return _gender; }
            set
            {
                if (value != '男' || value != '女')
                {
                    value = '男';
                }
                _gender = value;
            }
        }
        private int _chinese;
        public int Chinese
        {
            get { return _chinese; }
            set { _chinese = value; }
        }
        private int _math;
        public int Math
        {
            get { return _math; }
            set { _math = value; }
        }
        private int _english;
        public int English
        {
            get { return _english; }
            set { _english = value; }
        }
        //构造函数：
        //访问修饰符必须是public，因为需要跨类访问
        public Student(string name, int age, char gender, int chinese, int math, int english)
        {
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
            this.Chinese = chinese;
            this.Math = math;
            this.English = english;
        }
        //构造函数可以重载
        //使用this关键字来减少冗余代码的产生
        public Student(string name, int chinese, int math, int english) : this(name, 0, 'n', chinese, math, english) { }
        public void SayHello()
        {
            Console.WriteLine("我叫{0}，今年{1}岁，{2}生", this._name, this._age, this._gender);
        }
        public void ShowScoal()
        {
            Console.WriteLine("我的总成绩是{0}，平均成绩是{1}", this.Chinese + this.Math + this.English, (this.Chinese + this.Math + this.English) / 3);
        }
    }
}
