using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_10_16_01_结构
{
    public enum Gender
    {
        男,
        女
    }
    public struct Person
    {
        public string _name;  //字段珈乐访问修饰符public（最高权限）才可以在括号外访问
        public int _age;      //这里面的name，age等属于字段，在程序运行期间可以存储多个值，而变量只能存储一个值
        public Gender _gender;//规范要求字段名前需要添加一个下划线
    }
    public struct MyColor
    {
        public int _red;
        public int _green;
        public int _blue;
    }
    class Program
    {
        static void Main(string[] args)
        {
            //OO大学学生信息管理系统
            //存储了 姓名 性别 年龄 系别 年级
            /*
            string zsName = "张三";
            int zsAge = 21;
            Gender zsGender = Gender.男;
            int zsGrade = 3;
            */
            //这样反复声明变量效率很低，可以使用结构代替声明过程

            Person zsPerson;
            zsPerson._name = "张三";
            zsPerson._age = 21;
            zsPerson._gender = Gender.男;

            Person lsPerson;
            lsPerson._name = "李四";
            lsPerson._age = 22;
            lsPerson._gender = Gender.女;
            //申明一组只需要一个变量
            //这样_name字段里已经分别存储了"张三"，"李四"两个值了

            //练习1：声明一个MyColor的结构来表示颜色，有三个成员，分别定义为int类型的red，green，blue
            //      声明一个MyColor类型的变量，并对其赋值，使得出的颜色为红色
            MyColor color;
            color._red = 255;
            color._green = 0;
            color._blue = 0;
            //现在color三个值得出红色

            //练习2：定义一个Person结构，有三个成员，分别为姓名，年龄，性别（性别使用枚举类型）。
            //      声明两个Person类型的变量，分别表示：张三 男 18岁   小兰 女 16岁
            Person zs;
            zs._name = "张三";
            zs._age = 18;
            zs._gender = Gender.男;

            Person xl;
            xl._name = "小兰";
            xl._age = 16;
            xl._gender = Gender.女;

            #region 笔记
            /*
            4.	结构
            一次声明多个不同类型的变量
            
            语法：
            [public] struct 结构名（Pascal规范）
            {
                成员;（字段）
            }
            字段添加了访问修饰符public（最高权限）才可以在括号外访问
            字段在程序运行期间可以存储多个值，而变量只能存储一个值
            规范要求字段名前需要添加一个下划线
            */
            #endregion
        }
    }
}
