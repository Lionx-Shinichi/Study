using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_10_04_02_异常捕获
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.WriteLine("请输入一个数字");
            double number = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(number * 2);
            Console.ReadKey();
            //当输入的number值超越double的范围，则程序就会抛异常
            */

            Console.WriteLine("请输入一个数字");
            double number = Convert.ToDouble(Console.ReadLine());
            try
            {
                number = number * 2;
                Console.WriteLine("本来要输入数字，请你故意输入错类型");
                double error = Convert.ToDouble(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("成功！");
            }
            Console.WriteLine(number);
            Console.ReadKey();
            //输入2后输出结果number为4，因此number = number * 2;这行代码依然运行了
            //说明如果try中的代码出现异常，那么代码就只会执行到这一行（在try中的，这串代码上面的代码依然正常运行）
            //之后再跳转到catch中执行代码

            /*
            bool a = 8>5;
            if(a==true)
            {
                int test = 5;
                test = test * 2;
            }
            Console.WriteLine(test);
            */
            //变量有作用域，在这串代码中，调用test的部分超出了定义他的大括号（if结构），因此无法调用，提示未声明

            bool a = 8 > 5;
            int test = 5;
            if (a == true)
            {
                test = test * 2;
            }
            Console.WriteLine(test);
            //这里代码int test = 5;写在if的外面，因为整个if结构都在定义他的大括号的里面（main函数的里面），因此可以正常调用

            /*
            try
            {
                int test1 = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {

            }
            Console.WriteLine(test1);
            Console.ReadKey();
            */
            //在这种情况下，将convert移出try是不合理的（本来就是为了防止convert抛异常才写try），那么就可以把声明部分移出try，保留convert在try结构中，范例如下

            bool error1 = true;
            int test1 = 0;
            //这里需要给变量声明一个初值，因为将要给变量赋值的唯一代码Convert书写在可能被跳过的结构中。
            //一旦被跳过，这个变量就变得没有赋值，调用未赋值的变量属于语法错误。
            //如果这个变量确定一定有一行代码可以给这个变量赋值，那么也可以不写初值。
            try
            {
                Console.WriteLine("请输入一个数字");
                test1 = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("输入错误");
                error1 = false;

            }
            if(error1)
            {
                Console.WriteLine(test1);
            }
            //这种手段在开发中经常使用，设置一个bool类型的变量，如果上面程序报错，则会将这个bool变量修改为false，然后不执行if里的这些代码
            //这里就是如果报错就跳过if里的打印这个变量，避免报错后打印出了输入错误后，还跟着一个0（test1变量的初值）
            Console.ReadKey();

            #region 笔记
            /*
            异常捕获
            异常就是语法没有错误，但是由于某些原因程序出现错误无法继续运行
            在代码中应该经常使用try-catch来进行异常捕获让程序更加稳定
            
            语法：
            try
            {
                可能会出现异常的代码;
            }
            catch
            {
                出现异常后执行的代码;
            }
           
            执行过程：
            如果try中的代码没有出现异常，那么catch中的代码不会执行
            如果try中的代码出现异常，那么代码就只会执行到这一行（在try中的，这串代码上面的代码依然正常运行），之后再跳转到catch中执行代码

            变量的作用域
            变量的作用域就是能够使用这个变量的范围
            作用域一般从声明他的大括号开始，直至这个大括号结束

            bool a = 8>5;
            if(a==true)
            {
                int test = 5;
                test = test * 2;
            }
            Console.WriteLine(test);
            在这串代码中，调用test的部分超出了定义他的大括号（if结构），因此无法调用，提示未声明

            bool a = 8 > 5;
            int test = 5;
            if (a == true)
            {
                test = test * 2;
            }
            Console.WriteLine(test);
            这里代码int test = 5;写在if的外面，因为整个if结构都在定义他的大括号的里面（main函数的里面），因此可以正常调用

            */
            #endregion

        }
    }
}
