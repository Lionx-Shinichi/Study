using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_09_25_04_变量的命名规范
{
    class Program
    {
        static void Main(string[] args)
        {
            //规范起名方法：字母开头
            int number = 10;
            //起名要有意义
            int number_1 = 20;
            //变量名不要与C#系统中的关键字重复
            int int= 10;
            //C#系统敏感大小写
            int A = 10;
            int a = 20;
            //同一个变量名不可以重复定义
            int b = 10;
            int b = 20;

            #region 笔记
            /*
            变量命名规则
            必须以字母，下划线或@符号开头，不要以数字开头，现阶段给变量起名一般以字母开头
            后面可以跟字母数字下划线等
            起名需要有意义
            变量名不要与C#系统中的关键字重复
            C#系统敏感大小写
            同一个变量名不可以重复定义
            
            变量命名规范
            1.Camel骆驼命名规范 多用于给变量命名
              要求变量名首单词字母要小写，其余每个单词的首字母要大写。
              highSchoolStudents
            2.Pascal 多用于给类或方法命名
              要求每个单词的首字母都要大写，其他字母小写
              HighSchoolStudents

            */
            #endregion

        }
    }
}
