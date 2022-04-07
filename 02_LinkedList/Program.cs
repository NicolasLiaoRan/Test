using System;

namespace _02_LinkedList
{
    class Program
    {
        //pass
        static void Main(string[] args)
        {
            MyLinkedList<int> linkedList = new MyLinkedList<int>();
            for(int i=0;i<5;i++)
            {
                linkedList.Add(i, i);
            }
            Console.WriteLine(linkedList);
            for(int i=5;i<10;i++)
            {
                linkedList.Add(i, i);
            }
            Console.WriteLine(linkedList);

            var result=linkedList.Query(5);

            linkedList.Update(5, 15);
            Console.WriteLine(result);
            Console.WriteLine(linkedList);
            Console.ReadLine();
        }
    }
}
