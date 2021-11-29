using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_11_28_04_集合的长度问题
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList list = new ArrayList();
            //Count表示这个集合中实际包含的元素的个数
            //Capcity表示这个集合中可以包含的元素的个数
            Console.WriteLine(list.Count);
            Console.WriteLine(list.Capacity);
            Console.ReadKey();
            //当集合中没有元素时,Count和Capcity都是0
            list.Add(1);
            Console.WriteLine(list.Count);
            Console.WriteLine(list.Capacity);
            Console.ReadKey();
            //此时Count为1，Capcity为4
            list.Add(1);
            list.Add(1);
            list.Add(1);
            Console.WriteLine(list.Count);
            Console.WriteLine(list.Capacity);
            Console.ReadKey();
            //此时Count为4，Capcity为4
            list.Add(1);
            Console.WriteLine(list.Count);
            Console.WriteLine(list.Capacity);
            Console.ReadKey();
            //此时Count为5，Capcity为8
            
            //可得知每次超过当前集合长度上限就向内存多开一倍的空间(4)保证集合长度足够使用
        }
    }
}
