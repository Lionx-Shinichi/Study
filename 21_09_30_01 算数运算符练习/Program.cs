using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_09_30_01_算数运算符练习
{
    class Program
    {
        static void Main(string[] args)
        {
            //练习1：计算半径为5的圆的面积和周长并打印出来（π取3.14）
            int r = 5;
            double area = 3.14 * r * r;
            double perimeter = 2 * 3.14 * r;
            Console.WriteLine("面积是{0},周长是{1}",area,perimeter);
            Console.ReadKey();

            //练习2：某商店T恤（T-shirt）的价格为35元/件，裤子（trousers）的价格为120元/条
            //小明在该商店购买了3件T恤和两条裤子，请计算小明应该支付多少元
            //练习3：如果商家给小明打8.8折，请计算小明应该支付多少元
            int t_shirt = 35;
            int trousers = 120;
            int totalMoney = 3 * t_shirt + 2 * trousers;
            Console.WriteLine("小明应该支付{0}元", totalMoney);
            Console.ReadKey();
            double realMoney = totalMoney * 0.88;
            Console.WriteLine("打折后应该支付{0}元", realMoney);
            Console.ReadKey();

        }
    }
}
