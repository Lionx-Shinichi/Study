using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00_00_00_00_代码词典
{
    class 代码库
    {
        static void Main(string[] args)
        {
            #region Console.ReadLine();
            /*
            将要打印的内容打印在控制台里
            在输入字符串的时候需要""
            占位符是{}，格式是("{0},{1}",a,b); 保留固定位数小数则是{0.00},使用该方法会四舍五入。
            */
            #endregion

            #region Console.ReadKey(); 
            /*
            暂停当前程序，等待用户按下任意键盘键继续，将按下的按键显示在控制台中
            */
            #endregion

            #region Console.ReadLine();
            /*
            暂停当前程序，等待用户输入后继续
            */
            #endregion

            #region 显示类型转换
            /*
            语法：承接的变量=（要转换成什么类型）要转换的变量;
            仅把原值转换好后赋值给承接的变量，不会改变原变量或者原值的类型和值。使用该方法降低精度会使用退一法。
            double a = 3.59;
            int b = (int)a;
            Console.WriteLine("{0},{1}", a, b);
            Console.ReadKey();
            打印结果为3.59,3
            */
            #endregion

            #region 强制类型转换(Convert)
            /*
            语法：承接的变量=Convert.Todouble(需转换的变量名);（以转换为double为例）
            仅把原值转换好后赋值给承接的变量，不会改变原变量或者原值的类型和值。使用该方法降低精度会四舍五入。
            double a = 3.59;
            int b = Convert.ToInt32(a);
            Console.WriteLine("{0},{1}",a,b);
            Console.ReadKey();
            打印结果为3.59,4
            */
            #endregion

            #region if else-if结构
            /*
            if (执行条件)
            {
                当满足该执行条件时执行的代码
            }
            else if (执行条件)
            {
                当满足该执行条件时执行的代码
            }
            else
            {
                当不满足任何一个执行条件时执行的代码（编写中可以没有else）
            }
            
            if else-if结构，从上往下判断，当满足执行条件时执行其所带的代码，之后立即跳出if结构，不满足任何一个时执行else所带的代码（编写中可以没有else）

            测试代码：（测试是否当执行了条件所带的代码会立即跳出if结构）
            int number = 3;
            if (number > 3)
            {
                Console.WriteLine("执行了if的代码");
            }
            else if (number > 2)
            {
                Console.WriteLine("执行了else-if的代码");
            }
            else if (number > 1)
            {
                Console.WriteLine("执行了else-if2的代码");
            }
            Console.ReadKey();
            结果为仅输出了"执行了else-if的代码"，证明执行了条件所带的代码会立即跳出if else-if结构
            */
            #endregion

            #region try-catch结构
            /*
            try
            {
                可能会抛异常的代码
            }
            catch
            {
                抛异常后执行的代码
            }
            当try中的代码抛异常后，就跳过之后的代码，执行catch的代码
            */
            #endregion

            #region switch-case结构
            /*
            switch (变量或表达式的值)
            {
                case 值1:
                    要执行的代码
                    break;
                case 值2:
                    要执行的代码
                    break;
                case 值3:
                    要执行的代码
                    break;
                ......
                default：
                    要执行的代码
                    break;
            }
            当值等于case带的值（不能表示一个区间，也就是不能使用关系运算符），就执行这个case带的代码，遇到break跳出switch-case结构。
            */
            #endregion

            #region while循环
            /*
            while (循环条件)
            {
                当满足条件时执行的代码
            }

            当满足循环条件时，则执行循环体，不满足直接跳过
            */
            #endregion

            #region do-while循环
            /*
            do
            {
                循环体
            }while (循环条件);

            先执行一遍循环体，如果执行完成后满足循环条件则继续执行循环体
            */
            #endregion

            #region  for循环
            /*
            for (声明循环次数的变量; 循环条件; 使循环条件不成立的代码)举例：（int i = 0; i < 10; i++）
            {
                循环体;
            }
            先声明循环次数的变量，然后判断循环条件
            True就执行循环体，False就跳过循环
            然后执行可以使循环条件不成立的代码
            */
            #endregion

            #region int.Parse(以int为例)
            /*
            语法：
            接收变量 = int.Parse(原变量/值);
            和Convert一样，Convert调用的就是Parse
            */
            #endregion

            #region int-TryParse(以int为例)
            /*
            语法：
            bool类型变量（返回值） = int.TryParse（“字符串”，out 接收变量）
            尝试将字符串转换为int类型（以int为例）
            如果可以转换，则给接收变量赋值，然后返回一个True
            如果不能转换，则给接收变量赋值0，然后返回一个False
            */
            #endregion

            #region break;
            /*
            立即跳出距离最近的循环结构或switch-case结构
            */
            #endregion

            #region continue;
            /*
            立即结束本次循环体的执行，然后跳转回判断循环条件处。（for语句的i++;依然会在循环体结束执行后执行一遍）
            一般搭配if使用
            */
            #endregion

            #region 三元表达式
            /*
            语法：
            bool类型?值1:值2;
            
            如果bool类型为True，则值1为整个三元表达式的值
            如果bool类型为False，则值2为整个三元表达式的值
            值1和值2的类型必须一致，并且要和输出值的类型一致
            */
            #endregion

            #region const（常量）
            /*
            常量
            语法：
            const 变量类型 变量名=值;
            常量不能被再次赋值
            */
            #endregion

            #region ToString()
            /*
            将其他类型转换为string类型
            例句：
            double n3 = 3.14;
            string s3 = n3.ToString();
            */
            #endregion

            #region typeof(变量名)
            /*
            获得哪个类型
            例句：
            QQState state5 = (QQState)Enum.Parse(typeof(QQState), s5);
            */
            #endregion

            #region [public] enum 枚举名（Pascal规范）
            /*
            枚举
            语法：
            [public] enum 枚举名
            {
                值1,
                值2,
                值3,
                ……
                值x   (最后一个值的逗号可以加也可以不加)
            }
            放在中括号里代表这个public可以省略
            public：访问修饰符（用来修饰访问权限的），public权限等级最高，可以访问全部。
            enum：声明枚举的关键字
            枚举名：符合Pascal命名规范（每个单词首字母大写）
            
            不能在Main函数里声明枚举
            最好写在命名空间下类上，这样所有的类都可以使用这个枚举
            
            枚举就是一个变量类型，只是声明，赋值，使用的方式和普通变量不同

            给一个枚举类型赋值的方法：枚举名.枚举内的值
            */
            #endregion

            #region (枚举类型)Enum.Parse(枚举类型,待转换值)
            /*
            将值转换为枚举类型
            例句：
            QQState state5 = (QQState)Enum.Parse(typeof(QQState), s5);
            */
            #endregion

            #region [public] struct 结构名（Pascal规范）
            /*
            字段
            语法：
            [public] struct 结构名（Pascal规范）
            {
                成员;（字段）
            }
            一次声明多个不同类型的变量
            字段添加了访问修饰符public（最高权限）才可以在括号外访问
            字段在程序运行期间可以存储多个值，而变量只能存储一个值
            规范要求字段名前需要添加一个下划线
            */
            #endregion

            #region 数组类型[] 数组名称 = new 数组类型[数组长度];
            /*
            数组
            一次性存储多个相同类型的变量
            数组数组在创建的时候，就会将其中的元素全部赋予一个初值
            数组int类型为0，string类型为null（即无任何内容，未占用内存），bool类型为false
            数组如果想要访问到数组中的某个元素，需要通过这个元素的下标或者索引访问
            数组最先的元素下标数字为0，依次递增
            数组最先的元素索引数字为长度-1，依次递减
            数组赋值和取值均可以通过循环处理
            数组其中的变量依然可以通过后期再赋值覆盖先前值
            数组如果给不存在的元素赋值（超出数组界限），就会抛异常
            数组数组长度不可以在程序运行途中更改
            */
            #endregion

            #region Array.Sort(数组名称);
            /*
            将数组升序排列
            */
            #endregion

            #region Array.Reverse(数组名称);
            /*
            将数组倒序排列
            */
            #endregion

            #region [public] static 返回值类型 方法名(Pascal规范)（参数列表）
            /*
            方法（函数）
            函数就是将一堆代码进行重复利用的一种机制
            函数就是一段代码，这段代码可能有需要输入的值（也就是参数），可能会返回值。
            public：访问修饰符
            static：静态的
            返回值类型：如果不需要返回值，写void（无返回值）
            方法名：Pascal规范
            参数列表：完成这个方法所必须提供给这个方法的条件，如果没有参数也不能省略这个小括号
            方法写完后执行需要在main函数中调用
            */
            #endregion

            #region 类名.方法名(参数);
            /*
            方法的调用语法
            在某些情况下类名是可以被省略的，如果方法和Main函数同在一个类中，那么就可以省略类名。
            */
            #endregion

            #region return
            /*
            1)	在方法中返回要返回的值
            2)	立即结束本次方法
            例句： return a;(将a返回)
                  return a=5;(将5返回)
            */
            #endregion


        }
    }
}
