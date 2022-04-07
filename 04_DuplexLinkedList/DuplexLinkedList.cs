using System;
using System.Collections.Generic;
using System.Text;

namespace _04_DuplexLinkedList
{
    public class DuplexLinkedList<T>
    {
        public class Node
        {
            public T t;
            public Node next;
            public Node(T t,Node node)
            {
                this.t = t;
                this.next = node;
            }
            public Node(T t)
            {
                this.t = t;
                this.next = null;
            }
        }
        public int N;
        public Node head;//头结点
        public Node tail;//尾节点
        public DuplexLinkedList()
        {
            head = null;
            tail = null;
            N = 0;
        }
        //新增队尾节点
        public void AddLast(T t)
        {
            Node node = new Node(t);
            if(head==null)
            {
                head = node;
                tail = node;
            }
            else
            {
                tail.next = node;
                tail = node;
            }
            N++;
        }
        //删除队首节点
        public T RemoveFirst()
        {
            if (head == null)
                throw new Exception("linkedlist is empty");
            Node node = head;
            head = head.next;
            N--;
            if (head == null)
                tail = null;
            return node.t;
        }
        //获取队首节点
        public T GetFirst()
        {
            if(head==null)
                throw new Exception("linkedlist is empty");
            return head.t;
        }
    }
}
