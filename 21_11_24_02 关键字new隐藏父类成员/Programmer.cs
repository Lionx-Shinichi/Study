using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_11_24_02_关键字new隐藏父类成员
{
    internal class Programmer:Person
    {
        public Programmer(string name, int age, int workingYears) : base(name, age)
        {
            this.WorkingYears = workingYears;
        }
        private int _workingYears;
        public int WorkingYears
        {
            get { return this._workingYears; }
            set { this._workingYears = value; }
        }
        public void SelfIntroduction()
        {
            Console.WriteLine("大家好，我叫{0}，我今年{1}岁了，我已经工作{2}年了。", this.Name, this.Age, this.WorkingYears);
        }
        public new void SayHello()
        {
            Console.WriteLine("您正在调用子类方法");
        }
    }
}
