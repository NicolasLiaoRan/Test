using System;
using System.Collections.Generic;
using System.Text;

namespace _01_DynamicArray
{
    //必须是可比较的类型
    public class MySortedArray<T> where T : IComparable<T>
    {
        public int N;
        public T[] array;

        public MySortedArray(int capacity)
        {
            array = new T[capacity];
            N = 0;
        }
        public MySortedArray() : this(10) { }

        public int Rank(T target)
        {
            int left = 0;
            int right = array.Length;
            while (left <= right)
            {
                int mid = left + (right - left) / 2;
                if (target.CompareTo(array[mid]) > 0)
                    left = mid + 1;
                else if (target.CompareTo(array[mid]) < 0)
                    right = mid - 1;
                else
                    return mid;
            }
            return -1;
        }
    }
}
