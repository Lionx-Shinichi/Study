using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_11_21_02_继承
{
    internal class Driver : Teacher
    {
        private double _driverTime;
        public double DriverTime
        {
            get { return _driverTime; }
            set { _driverTime = value; }
        }
        public void Drive()
        {
            Console.WriteLine("驾驶");
        }
        public Driver(string name, char gender, int age, double driverTime, int salary)
            : base(name, gender, age, salary)
        {
            this.DriverTime = driverTime;
        }
    }
}
