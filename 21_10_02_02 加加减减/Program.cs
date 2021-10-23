using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_10_02_02_加加减减
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            int number = 10;
            number++;
            //单独使用也可以写成++number;
            Console.WriteLine(number);
            Console.ReadKey();
            //打印结果为11
            */

            /*
            int number_1 = 10;
            number_1--;
            //单独使用也可以写成--number_1;
            Console.WriteLine(number_1);
            Console.ReadKey();
            //打印结果为9
            */

            //int number = 10;
            //int result = 10 + number++;
            //Console.WriteLine(number);
            //Console.WriteLine(result);
            //Console.ReadKey();
            //打印结果为11 20

            //重点
            //++在前，则会将+1后的值带入运算，然后在程序读过该符号之后立刻将其+1
            int number_1 = 10;
            int result_1 = 10 + ++number_1 + number_1;
            //           = 10 +    11      +    11   ;
            //           = 32
            Console.WriteLine(number_1);
            Console.WriteLine(result_1);
            Console.ReadKey();
            //打印结果为11 32

            //++在后，则会将原值带入运算，然后在程序读过该符号之后立刻将其+1
            int number_2 = 10;
            int result_2 = 10 + number_2++ + number_2;
            //           = 10 +    10      +    11   ;
            //           = 31
            Console.WriteLine(number_2);
            Console.WriteLine(result_2);
            Console.ReadKey();
            //打印结果为 11 31

            //训练题：
            int a = 5;
            int b = a++ + ++a * 2 + --a + a + a++ + a;
            //程序会先计算一元运算符，从左到右依次确定所有a的值（没有一元运算符的a和有一元运算符的a同优先级），然后再进行二元运算符的运算
            //    =  5  +  7  * 2 +  6  + 6 +  6  + 7;
            //    =  44
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.ReadKey();
            //打印结果为7 44

            #region 笔记
            /*
            算数运算符++和--
            ++分前++和后++
            单独使用时不管是前++还是后++，最终结果都是给变量 + 1
            例如number++;和++number;
            
            如果在表达式中
            ++在前，则会将+1后的值带入运算，然后在程序读过该符号之后立刻将其+1
            ++在后，则会将原值带入运算，然后在程序读过该符号之后立刻将其+1
            --同上
            
            
            运算符优先级
            1.一元运算符
            像++ --这种仅需要一个操作数就可以进行运算的（自己+1-1）
            2.二元运算符
            + - * / 这种至少需要两个操作数的（至少有两个数才能相加）
            
            在表达式中，一元运算符的运算优先级高于二元运算符
            int number = 10;
            int result = 10 + number++;
            在这里优先会确定number的值是10，然后再和10相加。
            
            int a = 5;
            int b = a++ + ++a * 2 + --a + a + a++ + a;
            在这里会优先计算一元的运算符，因此会先从左到右依次确定全部的a的值（没有一元运算符的a和有一元运算符的a同优先级），然后再进行二元运算。
            所以会变成
            //    =  5  +  7  * 2 +  6  + 6 +  6  + 7;

            练习：
            var1=5 var2=5 var3=6
            var1=var2++ * --var3；
                =  5    *   5
            var1=25
            var2=6
            var3=5

            var1=5 var2=5 var3=6
            var1=++var2 * var3--
                =  6    *  6
            var1=36
            var2=6
            var3=5
            */
            #endregion
        }
    }
}
