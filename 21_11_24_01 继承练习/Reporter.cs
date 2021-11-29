using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_11_24_01_继承练习
{
    internal class Reporter : Person
    {
        public Reporter(string name, int age, string hobby) : base(name, age)
        {
            this.Hobby = hobby;
        }
        private string _hobby;
        public string Hobby
        {
            get { return this._hobby; }
            set { this._hobby = value; }
        }
        public void SelfIntroduction()
        {
            Console.WriteLine("大家好，我叫{0}，我今年{1}岁了，我的爱好是{2}。", this.Name, this.Age, this.Hobby);
        }
    }
}
