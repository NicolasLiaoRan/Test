using System;
using System.Collections.Generic;
using System.Text;

namespace _05_Algorithm
{
    class MyAlgorithm
    {
        //二分法查找，要求必须是有序数组
        public static int BinarySearch(int[] arr, int target)
        {
            int left = 0;
            int right = arr.Length - 1;
            //注意这里是<=
            while (left <= right)
            {
                int mid = left + (right - left) / 2;
                if (target < arr[mid])
                    right = mid - 1;
                else if (target > arr[mid])
                    left = mid + 1;
                else
                    return arr[mid];
            }
            return -1;
        }
        //冒泡排序 o(n^2)
        public static void BubbleSort(int[] arr)
        {
            int n = arr.Length;
            //外层：冒泡总数
            for (int i = 0; i < n; i++)
            {
                //内层：比较总数会比外层少1次
                for (int j = 0; j < n - 1 - i; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
        }
        //选择排序
        
    }
}
