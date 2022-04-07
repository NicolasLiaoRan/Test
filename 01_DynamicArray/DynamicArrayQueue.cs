using System;
using System.Collections.Generic;
using System.Text;

namespace _01_DynamicArray
{
    public class DynamicArrayQueue<T> : IQueue<T>
    {
        private DynamicArray<T> dynamicArray;

        public DynamicArrayQueue()
        {
            dynamicArray = new DynamicArray<T>();
        }
        public T Dequeue()
        {
            return dynamicArray.RemoveLast();
        }

        public void Enqueue(T t)
        {
            dynamicArray.AddFirst(t);
        }

        public T Query()
        {
            return dynamicArray.Query(0);
        }
    }
}
