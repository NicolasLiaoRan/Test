using System;
using System.Collections.Generic;
using System.Text;

namespace _02_LinkedList
{
    public class MyLinkedListStack<T> : IStack<T>
    {
        private MyLinkedList<T> linkedList;

        public MyLinkedListStack()
        {
            linkedList = new MyLinkedList<T>();
        }
        public T Pop()
        {
            return linkedList.RemoveLast();
        }

        public void Push(T t)
        {
            linkedList.AddLast(t);
        }

        public T Top()
        {
            return linkedList.QueryLast();
        }
    }
}
