using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_11_07_01_类的基本语法
{
    public class Person
    {
        //字段
        string _name;
        //属性：保护字段，对字段的赋值和取值进行限制
        public string Name
        {
            //当给属性赋值时，会首先执行set方法，将值赋值给字段
            //当输出属性的值的时候，执行get方法，将字段中的值给return出来
            get { return _name; }
            set { _name = value; }
        }
        //访问修饰符，表示私有的，只能在当前类中访问，如果不书写访问修饰符会默认private
        private int _age;
        public int Age
        {
            get { return _age; }
            set
            {
                //在通过该属性赋值时如果赋值小于0或大于100，则改为赋值0
                if (value < 0 || value > 100)
                {
                    value = 0;
                }
                _age = value;
            }
        }
        char _gender;
        public char Gender
        {
            get
            {
                //在通过该属性取值时如果性别字段存储的不是男女，则返回一个问号
                if (_gender != '男' && _gender != '女')
                {
                    return _gender = '？';
                }
                return _gender;
            }
            set { _gender = value; }
        }
        //不是每个属性都有get和set，如果属性中缺少了get就会变成只写属性，缺少了set就会变成只读属性

        //方法
        public void Programming()
        {                                                                        //this关键字表示当前这个类的对象
            Console.WriteLine("我叫{0}，年龄{1}，性别是{2}，我的特长是编译程序。", this.Name, this.Age, this.Gender);
        }
    }
}
