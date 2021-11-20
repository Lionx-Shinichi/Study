using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_11_15_02_值类型和引用类型简介
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 笔记
            /*
            值类型和引用类型
            1.	值类型和引用类型在内存上存储的地方不同
            2.	在传递值类型和传递引用类型的时候，传递的方式不一样。
            值类型称为值传递，引用类型称之为引用传递（超纲）
            
            值类型：int double bool char decimal struct(结构) enum(枚举)
            引用类型：string 自定义的类 数组
            
            值类型的值和名称均存储在内存的栈当中
            引用类型的值存储在内存的堆当中，但是名称依然存储在栈中，堆的数据会对应着一个内存地址
            这个内存地址会存储在栈中，对应着存在栈中的名称
            */
            #endregion
        }
    }
}
