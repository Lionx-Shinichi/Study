using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_11_14_01_面向对象初级篇复习
{
    internal class Ticket
    {
        //添加一个Ticket类
        //有一个距离属性（本属性只读，在构造方法中赋值，不能为负数）
        //有一个价格属性（本属性只读）
        //并且根据距离distance计算价格price（1元/公里）
        //距离0-100公里不打折，101-200公里9.5折，201-300公里9折，300以上打8折
        private double _distance;
        public double Distance
        {
            get { return _distance; }
        }
        public Ticket(double distance)
        {
            if (distance < 0)
            {
                distance = 0;
            }
            _distance = distance;
        }
        private double _price;
        public double Price
        {
            get { return _price; }
        }
        public void TotalPrice()
        {
            if (Distance <= 100)
            {
                _price = Distance;
            }
            else if (Distance <= 200)
            {
                _price = Distance * 0.95;
            }
            else if (Distance <= 300)
            {
                _price = Distance * 0.9;
            }
            else
            {
                _price = Distance * 0.8;
            }
            Console.WriteLine("共计{0}公里，价格为{1}元", Distance, Price);
        }
    }
}
