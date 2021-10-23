using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_10_01_02_阶段性练习
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.编程实现计算某天是多少周多少天（以46天为例）
            /*
            int input = 46;
            int weeks = input / 7;
            int days = input % 7;
            Console.WriteLine("{0}天是{1}周余{2}天",input,weeks,days);
            Console.ReadKey();
            */
            //打印结果为46天是6周余4天

            //2.编程实现107653秒是几天几小时几分钟几秒
            //int input = 107653;
            //int days = input / 86400;
            //int remaining = input % 86400;
            //int hours = remaining / 3600;
            //remaining = remaining % 3600;
            //int minutes = remaining / 60;
            //remaining = remaining % 60;
            //Console.WriteLine("{0}秒是{1}天{2}小时{3}分钟{4}秒", input, days, hours, minutes,remaining);
            //Console.ReadKey();


            //3.使用户可以自行输入小时，分钟，秒等信息，得到共计多少秒(使用21_10_02_01 Convert类型转换的知识)
            Console.WriteLine("欢迎使用时间转换器！请输入要转换的时间的小时");
            string inputHours = Console.ReadLine();
            Console.WriteLine("请输入要转换的时间的分钟");
            string inputMinutes = Console.ReadLine();
            Console.WriteLine("请输入要转换的时间的秒");
            string inputSeconds = Console.ReadLine();

            double hours = Convert.ToDouble(inputHours);
            double minutes = Convert.ToDouble(inputMinutes);
            double seconds = Convert.ToDouble(inputSeconds);

            double totalSeconds = hours * 3600 + minutes * 60 + seconds;

            Console.WriteLine("转换晚比！共计{0}秒", totalSeconds);
            Console.ReadKey();

        }
    }
}
