using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_11_08_01_静态与非静态的区别
{
    public class Person
    {
        //在实例类中，既可以声明实例成员，也可以声明静态成员
        //在静态类中不可以声明一个实例成员

        //在实例方法中，既可以访问实例成员，也可以访问静态成员
        //在静态方法不可以访问一个实例成员
        public void M1()
        {
            Age = 5;
            Name = "x";//可以访问静态成员
            Console.WriteLine("我是一个非静态的方法");
        }
        public static void M2()
        {
            //Age = 5;  尝试访问实例成员被拒绝
            Console.WriteLine("我是一个静态方法");
        }
        //字段,属性也是一样
        public static string _name;
        public static string Name
        {
            get { return Person._name; }
            set { Person._name = value; }
        }
        public int _age;
        public int Age
        {
            get { return this._age; }
            set { this._age = value; }
        }
    }
}
