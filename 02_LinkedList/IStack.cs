using System;
using System.Collections.Generic;
using System.Text;

namespace _02_LinkedList
{
    public interface IStack<T>
    {
        //出栈
        T Pop();
        //入栈
        void Push(T t);
        //查询栈顶元素
        T Top();
    }
}
