using System;

namespace _01_DynamicArray
{
    class Program
    {
        static void Main(string[] args)
        {
            DynamicArray<int> dynamicArray = new DynamicArray<int>();
            for(int i=0;i<20;i++)
            {
                dynamicArray.Add(i, i);
            }
            for (int i = 0; i < 5; i++)
            {
                dynamicArray.Add(i, i);
            }
            Console.WriteLine(dynamicArray);
            //add pass
            dynamicArray.Remove(5);
            Console.WriteLine(dynamicArray);
            //remove pass
            var result=dynamicArray.Query(20);
            Console.WriteLine(result);
            //query pass

            Console.ReadLine();
        }
    }
}
