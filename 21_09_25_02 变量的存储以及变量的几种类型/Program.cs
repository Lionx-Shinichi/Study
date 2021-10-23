using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_09_25_02_变量的存储以及变量的几种类型
{
    class Program
    {
        static void Main(string[] args)
        {
            //项目：在内存中存储数据

            //以下代码是在内存中开辟了一块能够存储整数的空间（声明或者定义了一个int类型的变量）
            int number;
            //以下代码是表示把100存储到了这块空间内（给这个变量进行赋值）（等于号在C#中是赋值符号）
            number = 100;
            //以下代码是将以上代码合并（简写形式）
            int a = 100;
            //存储小数应该使用double，double的范围大于int，也可以用来存储整数，精度为15~16位
            double b = 3.14;
            //存储文本应该使用string（字符串）,需要带双引号，也可以仅输入双引号表示空
            string c = "张三";
            //char仅可存储一个字符，需要带单引号，不可以空
            char d = '男';
            //decimal精度为28~29位，更适合用于财务和货币计算，值后面跟m
            decimal money = 5000m;
            
            #region 笔记
            /*
            变量
            用来在计算机中存储数据

            项目：存储整数100
            数据类型：整数
            在内存中开辟的空间应该是整数类型 【int】
            1.	要确定存储的数据的类型
            2.	要给这个空间起一个有意义的名字，方便使用空间中的内容

            存储变量的语法：
            变量类型 变量名；
            变量名=值；
            等于号在这里不代表等于的意思，而是赋值的意思，表示把等号右边的值赋值给等号左边的变量。
            
            声明并且给变量赋值的简写形式：
            变量类型 变量名=值；

            数据类型：
            1.	int     整数类型，仅整数
            2.	double  小数类型，可存储整数或小数，精度为15~16位
            3.	decimal 金钱类型，用来存储金钱，值后面要加m
            4.	string  字符串类型，用来存储多个文本或空，需要双引号（英文半角）
            5.	char    字符类型，用来存储单个字符，不能空，需要单引号（英文半角）

            */
            #endregion

        }
    }
}
