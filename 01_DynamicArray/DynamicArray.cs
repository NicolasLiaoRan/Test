using System;
using System.Collections.Generic;
using System.Text;

namespace _01_DynamicArray
{
    public class DynamicArray<T>
    {
        //数组中的有效元素个数
        public int N;
        //动态数组
        public T[] myArray;
        //根据容量初始化动态数组
        public DynamicArray(int capacity)
        {
            myArray = new T[capacity];
        }
        //默认初始化
        public DynamicArray() : this(10) { }

        //判空
        public bool IsEmpty { get { return N == 0; } }
        //获取元素个数
        public int Count { get { return N; } }
        //队尾增加元素
        public void AddLast(T t)
        {
            Add(N, t);
        }
        //头部添加元素
        public void AddFirst(T t)
        {
            Add(0, t);
        }
        //删除尾部元素
        public T RemoveLast()
        {
             return Remove(N-1);
        }
        //查询最后元素
        public T QueryLast()
        {
            return Query(N - 1);
        }
        //向指定位置新增元素
        public void Add(int index, T t)
        {
            if (index < 0)
                throw new ArgumentOutOfRangeException("index out of range");
            if (N == myArray.Length)
                ResetCapacity(2 * myArray.Length);
            for (int i = N - 1; i >= index; i--)
            {
                myArray[i + 1] = myArray[i];
            }
            myArray[index] = t;
            N++;
        }
        //删除指定位置元素
        public T Remove(int index)
        {
            if (index < 0)
                throw new ArgumentOutOfRangeException("index out of range");
            if (N == myArray.Length / 2)
                ResetCapacity(myArray.Length / 2);
            T del = myArray[i];
            for (int i = index; i < N; i++)
            {
                myArray[i] = myArray[i + 1];
            }
            myArray[N] = default(T);
            N--;
            return del;
        }
        //查询指定位置元素
        public T Query(int index)
        {
            if (index < 0 || index > myArray.Length - 1)
                throw new ArgumentOutOfRangeException("index out of range");
            for (int i = 0; i < N; i++)
            {
                if (index == i)
                    return myArray[i];
            }
            throw new Exception("can not find index");
        }
        //更新指定位置元素
        public int Update(int index, T t)
        {
            if (index < 0 || index > myArray.Length - 1)
                throw new ArgumentOutOfRangeException("index out of range");
            for (int i = 0; i < N; i++)
            {
                if (index == i)
                {
                    myArray[i] = t;
                    return 1;
                }
            }
            return 0;
        }
        //动态扩容缩容
        public void ResetCapacity(int capacity)
        {
            T[] newArray = new T[capacity];
            for (int i = 0; i < N; i++)
            {
                newArray[i] = myArray[i];
            }
            myArray = newArray;
        }
        public override string ToString()
        {
            string str = $"Count:{N},Element:";
            for (int i = 0; i < N; i++)
            {
                if (i == N - 1)
                    str += $"[{myArray[i]}]";
                else
                    str += $"[{myArray[i]}],";
            }
            return str;
        }


    }
}
