using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_10_02_03_关系运算符和逻辑运算符
{
    class Program
    {
        static void Main(string[] args)
        {
            bool a = 1500 > 1;
            Console.WriteLine(a);
            Console.ReadKey();
            //打印结果为True

            bool b = 3 > 1000;
            Console.WriteLine(b);
            Console.ReadKey();
            //打印结果为False

            bool c = 20 == 20;
            Console.WriteLine(c);
            Console.ReadKey();
            //打印结果为True

            
            //逻辑运算符&&
            bool d = 5 > 3 && true;
            Console.WriteLine(d);
            Console.ReadKey();
            //打印结果为True

            //练习
            //让用户输入老苏的语文和数学成绩，判断和以下条件是否符合并输出True或False
            //1.老苏的语文和数学成绩均高于90分
            //2.老苏的语文和数学成绩有一科高于90分

            Console.WriteLine("请输入老苏的语文成绩");
            double chinese = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("请输入老苏的数学成绩");
            double maths = Convert.ToDouble(Console.ReadLine());

            bool e = chinese > 90 && maths > 90;
            Console.WriteLine(e);
            Console.ReadKey();

            bool f = chinese > 90 || maths > 90;
            Console.WriteLine(f);
            Console.ReadKey();

            #region 笔记
            /*
            关系运算符
            1)	>
            2)	<
            3)	>=
            4)	<=
            5)	==
            6)	!=
            关系运算符使用来描述两个事物之间的关系
            由关系运算符连接的表达式叫做关系表达式
            
            bool类型
            在C#中用bool类型来描述对错
            bool类型的变量的值只有两个——true和false
            
            逻辑运算符
            1)	&& 逻辑与  若左右都是True 则输出True 否则输出False
            2)	|| 逻辑或  若左右只要有一个值为True 则输出True 否则输出False
            3)	!  逻辑非  一般关系表达式写在！右边 若是False 则输出True 否则输出False
            由逻辑运算符连接的表达式叫做逻辑表达式
            逻辑运算符两边一边是关系表达式或者是bool类型的值
            例如
            5 > 3 && true;
            3 > 5 && False; 
            ！True
            逻辑表达式的结果同样也是bool类型
            逻辑与的优先级高于逻辑或
            & | 符号虽然可以提供一样的作用，但是会占用更多资源运算所以不再使用。
            原理：&& || 具备短路效果，例如&&在判断左右是否正确时，如果左侧已经错误，则直接返回False，不再判断右侧，&符号会完整判断完成后再返回结果。


            复合赋值运算符（一种简写形式）
            1)	+=
            2)	-+
            3)	*=
            4)	/=
            属于二元运算符
            int number = 10;
            number += 20;
            也就是number = number + 20;
            Number的值为30

            */
            #endregion

        }
    }
}
