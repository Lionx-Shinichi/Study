using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_11_24_01_继承练习
{
    internal class Driver:Person
    {
        public Driver(string name, int age, int drivingExperience) : base(name, age)
        {
            this.DrivingExperience = drivingExperience;
        }
        private int _drivingExperience;
        public int DrivingExperience
        {
            get { return this._drivingExperience; }
            set { this._drivingExperience = value; }
        }
        public void SelfIntroduction()
        {
            Console.WriteLine("大家好，我叫{0}，我今年{1}岁了，我的驾龄是{2}年。", this.Name, this.Age, this.DrivingExperience);
        }
    }
}
