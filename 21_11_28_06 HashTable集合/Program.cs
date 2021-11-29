using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_11_28_06_HashTable集合
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //又称键值对集合
            Hashtable ht = new Hashtable();
            //使用方法Add或【键值对集合名[键]=值】来传入数据
            //要求传入第一个参数为键,第二个参数为值,均为object类型
            ht.Add(1, "张三");
            ht.Add(2, true);
            ht.Add(3, '男');
            ht[false] = "错误的";
            //由此可见,键和值可以是任何类型
            //键必须是唯一的,用Add方法给同一个键添加值会抛异常,但用赋值方法就会覆盖掉这个键上的旧值
            ht[1] = "李四";
            //键值对集合的长度使用Count属性
            //键值对集合是根据键来找值的
            Console.WriteLine(ht[1]);
            Console.WriteLine(ht[2]);
            Console.WriteLine(ht[3]);
            Console.WriteLine(ht[false]);
            Console.ReadKey(true);
            //使用for循环来遍历的话就无法读取到int以外的键所对应的值
            //所以需要使用foreach循环
            //foreach循环作用：用于遍历集合
            //var：item的类型
            //item：被遍历的每一个值
            //in：关键字，指向collection
            //collection：被遍历的集合

            foreach (var item in ht.Keys)
            {
                Console.WriteLine(ht[item]);
            }
            Console.ReadKey(true);


            //键值对集合的方法:
            //Contains方法:传入要判断的键，如果该键值对集合中含有该键，就会返回True，否则返回False
            //ContainsKey方法：同Contains方法，因为视觉观感上直接明显，一般习惯使用本方法
            if (!ht.ContainsKey(false))
            {
                ht[false] = "错误的";
                Console.WriteLine("该集合中不含有该键,现已赋值");
            }
            else
            {
                Console.WriteLine("该集合中含有该键,现已跳过赋值");
            }
            Console.ReadKey(true);

            //ContainsValue方法：传入一个值，方法将返回该键值对中是否含有该值的bool类型的值
            if (ht.ContainsValue("测试项目"))
            {
                Console.WriteLine("该键值对含有该值");
            }
            else
            {
                Console.WriteLine("该键值对无该值");
            }
            Console.ReadKey(true);

            //Remove方法：传入一个键，删除该键和所对应的值，无返回值
            ht.Remove(3);

            //Clear方法：清空该键值对中所有数据，无需传入数据也无返回值
            ht.Clear();
        }
    }
}
