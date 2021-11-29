using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_11_28_03_ArrayList集合的方法
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //数组的缺点:长度固定 类型单一
            //集合的特点:长度可变化 类型不固定
            //创建一个集合对象
            ArrayList list = new ArrayList();
            //用ArrayList类下的Add方法向集合添加数据,Add方法要求传入一个object类型数据
            list.Add(1);//int
            list.Add(3.14);//double
            list.Add(true);//bool
            list.Add("张三");//string
            list.Add('男');//char
            list.Add(5000m);//decimal
            list.Add(new int[] { 1, 2, 3, 4, 5 });//数组
            Person person = new Person();
            list.Add(person);//自定义类对象
            list.Add(list);//自己

            //在集合中没有Length,用Count代替,下标原理和数组一致
            //如果打印一个对象,那么就会打印出这个对象的命名空间
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] is Person)
                {
                    ((Person)list[i]).SayHello();
                }
                else if (list[i] is int[])
                {
                    for (int j = 0; j < ((int[])list[i]).Length; j++)
                    {
                        Console.Write(((int[])list[i])[j]);
                        Console.WriteLine();
                    }
                }
                else if (list[i] is ArrayList)
                {
                    //i = 0;
                    continue;
                }
                else
                {
                    Console.WriteLine(list[i]);
                }
            }
            Console.ReadKey(true);

            //添加集合进入ArrayList类型后取出很麻烦,这时可以利用ArrayList类下的方法AddRange添加集合,在使用Write指令打印时可以直接打印出整个集合的内容而不是命名空间
            //其原理是将集合的元素展开导入该集合，例如加入一个9个元素的数组，就在被加入的集合中开9个新空间分别写入内容，其下标也会扩展9个
            ArrayList list2 = new ArrayList();
            list2.Add("张三");
            list2.AddRange(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 });
            list2.AddRange(list2);
            list2.Insert(0, "临时");
            for (int i = 0; i < list2.Count; i++)
            {
                Console.WriteLine(list2[i]);
            }
            Console.ReadKey();
            //ArrayList类的方法:
            //clear方法可以移除一个集合对象的全部元素
            //Remove方法可以移除一个集合对象的单个元素,传入需要删除的元素本身
            //RemoveAt方法可以移除一个集合对象的单个元素,传入需要删除的元素下标
            //RemoveRange方法可以移除一个集合对象的一定范围内的元素,传入的第一个参数为从哪个下标起删除(包括其本身),第二个参数为依次删除几个元素
            //Sort方法可以依次给元素升序排列,但是需要注意类型,一旦两个元素无法比较就会报错
            //Reverse方法可以给元素顺序反转
            //Insert方法可以在指定位置插入一个元素,传入的第一个参数为该元素将要占用的下标,其他元素依照顺序依次向后移动,第二个参数为插入元素的内容
            //InsertRange方法可以在指定位置插入一个集合,传入的第一个参数为该集合的第一个元素将要占用的下标,其他元素依照顺序向后移动,第二个参数为插入集合的内容
            //Contains方法可以查询集合中是否包含某元素,返回bool类型,传入参数为具体要查询的元素


        }
    }
}
