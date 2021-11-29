using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_11_28_01_里氏转换练习
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //练习:在一个父类数组里创建10个不同子类的对象,然后依序分别调用其中的方法

            //创建10个对象 通过一个循环去调用格子打招呼的方法
            //根据里氏转换第一个特性,子类可以赋值给父类
            Person[] person = new Person[10];
            Random r = new Random();
            for (int i = 0; i < person.Length; i++)
            {
                int rNumber = r.Next(1, 7);
                switch (rNumber)
                {
                    case 1:
                        person[i] = new Designer();
                        break;
                    case 2:
                        person[i] = new Worker();
                        break;
                    case 3:
                        person[i] = new Farmer();
                        break;
                    case 4:
                        person[i] = new Programmer();
                        break;
                    case 5:
                        person[i] = new Teacher();
                        break;
                    case 6:
                        person[i] = new Student();
                        break;
                }
            }
            //如果父类中装有子类对象,可以强制转换为子类对象
            for (int i = 0; i < person.Length; i++)
            {
                if(person[i] is Designer)
                {
                    ((Designer)person[i]).DesignerSayHello();
                }
                else if(person[i] is Worker)
                {
                    ((Worker)person[i]).WorkerSayHello();
                }
                else if(person[i] is Farmer)
                {
                    ((Farmer)person[i]).FarmerSayHello();
                }
                else if(person[i] is Programmer)
                {
                    ((Programmer)person[i]).ProgrammerSayHello();
                }
                else if(person[i] is Teacher)
                {
                    ((Teacher)person[i]).TeacherSayHello();
                }
                else if(person[i] is Student)
                {
                    ((Student)person[i]).StudentSayHello();
                }
            }
            Console.ReadKey();
        }
    }
}
