using System;
using System.Collections.Generic;
using System.Text;

namespace _01_DynamicArray
{
    public class DynamicArrayStack<T> : IStack<T>
    {
        private DynamicArray<T> arrayStack;

        public DynamicArrayStack()
        {
            arrayStack = new DynamicArray<T>();
        }
        //出栈 o(1)
        public T Pop()
        {
           return arrayStack.RemoveLast();
        }
        //入栈 o(1)
        public void Push(T t)
        {
            arrayStack.AddLast(t);
        }
        //查询栈顶元素 o(1)
        public T Top()
        {
            return arrayStack.QueryLast();
        }
    }
}
