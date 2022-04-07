using System;
using System.Collections.Generic;
using System.Text;

namespace _03_CycleArray
{
    public class CycleArray<T>
    {
        //循环队列
        private T[] cycleArray;
        //有效元素个数
        private int N;
        //first指针
        private int first;
        //last指针
        private int last;

        //根据容量初始化
        public CycleArray(int capacity)
        {
            cycleArray = new T[capacity];
            N = 0;
            first = 0;
            last = 0;
        }
        //默认初始化
        public CycleArray()
        {
            cycleArray = new T[10];
            N = 0;
            first = 0;
            last = 0;
        }
        //向队尾新增元素
        public void AddLast(T t)
        {
            if (N == cycleArray.Length)
                ResetCapacity(2 * cycleArray.Length);
            cycleArray[last] = t;
            last = (last + 1) % cycleArray.Length;
            N++;
        }
        //删除队首元素
        public T RemoveFirst()
        {
            T firstEle = cycleArray[first];
            cycleArray[first] = default(T);
            first = (first + 1) % cycleArray.Length;
            N--;
            if (N == cycleArray.Length / 4)
                ResetCapacity(cycleArray.Length / 2);
            return firstEle;
        }
        private void ResetCapacity(int length)
        {
            T[] newArray = new T[length];
            for(int i=0;i<cycleArray.Length;i++)
            {
                newArray[i] = cycleArray[(first + i) % cycleArray.Length];
            }
            cycleArray = newArray;
            first = 0;
            last = N;

        }
        public override string ToString()
        {
            StringBuilder res = new StringBuilder();
            res.Append("[");
            for (int i = 0; i < N; i++)
            {
                res.Append(cycleArray[(first + i) % cycleArray.Length]);
                if ((first + i + 1) % cycleArray.Length != last)
                    res.Append(",");
            }
            res.Append("]");
            return res.ToString();
        }
    }
}
