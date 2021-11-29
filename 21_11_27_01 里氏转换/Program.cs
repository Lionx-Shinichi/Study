using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_11_27_01_里氏转换
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //子类可以赋值给父类
            Student s = new Student();
            //在这里将子类对象赋值给了父类对象
            Person p = s;
            //也可以简写为
            Person p2 = new Student();
            //如果一个地方需要一个父类作为参数，可以用子类代替
            //在这里，Join方法要求传入一个params object[] values，我们创建了一个string对象，相当于把这个string对象赋值给了object类的对象
            string.Join("|", new string[] { "1", "2", "3" });

            //如果父类中装着子类对象，那么可以将这个父类对象强制转换为子类对象
            //is：表示类型转换，如果转换成功就返回true，否则返回false
            //as：表示类型转换，如果转换成功就返回对应对象，否则返回null

            //is用法：
            if (p2 is Teacher)
            {
                Student s2 = (Student)p2;
                Console.WriteLine("is用法部分");
                s2.StudentSayHello();
            }
            else
            {
                Console.WriteLine("is用法部分");
                Console.WriteLine("转换失败");
            }
            Console.ReadKey();
            Console.WriteLine();

            //as用法：
            Person p3 = new Student();
            Teacher s3 = p3 as Teacher;
            Console.WriteLine("as用法部分");
            if (s3 != null)
            {

                s3.TeacherSayHello();
            }
            else
            {
                Console.WriteLine("s3结果为null");
            }
            Console.ReadKey();
            Console.WriteLine();
        }
    }
}
