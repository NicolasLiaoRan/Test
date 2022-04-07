using System;
using System.Collections.Generic;
using System.Text;

namespace _02_LinkedList
{
    public class MyLinkedList<T>
    {
        //第一次尝试不成功，现第二次尝试
        public class Node
        {
            public T data;
            public Node next;

            public Node(T newData,Node node)
            {
                data = newData;
                next = node;
            }
            public Node(T newData)
            {
                data = newData;
                next = null;
            }
        }
        //头节点
        private Node head;
        //当前链表有多少有效节点
        private int N;
        //初始化头结点
        public MyLinkedList()
        {
            head = null;
            N = 0;
        }
        //向指定位置新增节点
        public void Add(int index,T t)
        {
            if (index < 0)
                throw new ArgumentOutOfRangeException("index out of range");
            if(index==0)
            {
                Node node = new Node(t);
                node.next = head;
                head = node;
            }
            else
            {
                Node pre = head;
                //找到指定节点的前一个节点
                for(int i=0;i<index-1;i++)
                {
                    pre = pre.next;
                }
                Node node = new Node(t);
                //原来的pre节点的下一个节点指向旧的index节点，现在让node指向旧的index节点
                node.next = pre.next;
                //原来的pre节点指向node节点，这样node节点就插入进来
                pre.next = node;
            }
            N++;
        }
        //删除指定位置节点
        public T Remove(int index)
        {
            if(index<0)
                throw new ArgumentOutOfRangeException("index out of range");
            if(index==0)
            {
                Node delNode = head;
                head = head.next;
                N--;
                return delNode.data;
            }
            else
            {
                Node pre = head;
                for(int i=0;i<index-1;i++)
                {
                    pre = pre.next;
                }
                Node delNode = pre.next;
                pre.next = delNode.next;
                N--;
                return delNode.data;
            }
        }
        //删除指定值的节点
        public void RemoveByData(T t)
        {
            if (head == null)
                throw new ArgumentOutOfRangeException("index out of range");
            if(head.data.Equals(t))
            {
                head = head.next;
                N--;
            }
            else
            {
                Node cur = head;
                Node pre = null;
                while(cur!=null)
                {
                    if (cur.data.Equals(t))
                        break;
                    pre = cur;
                    cur = cur.next;                    
                }
                if(cur!=null)
                {
                    pre.next = pre.next.next;
                    N--;
                }
            }
        }
        //查询指定位置的值
        public T Query(int index)
        {
            if (index < 0)
                throw new ArgumentOutOfRangeException("index out of range");
            if (head == null)
                throw new Exception("linkedlist is empty");
            if (index == 0)
                return head.data;
            else
            {
                Node pre = head;
                for(int i=0;i<index;i++)
                {
                    pre = pre.next;
                }
                return pre.data;
            }
        }
        //更新指定位置的值
        public void Update(int index,T t)
        {
            if(index<0||index>=N)
                throw new ArgumentOutOfRangeException("index out of range");
            if (head == null)
                throw new Exception("linkedlist is empty");
            if (index == 0)
            {
                head.data = t;
            }
            else
            {
                Node cur = head;
                for(int i=0;i<index;i++)
                {
                    cur = cur.next;
                }
                cur.data = t;
            }
        }
        public bool Contains(T t)
        {
            if (head == null)
                throw new Exception("linkedlist is null");
            Node cur = head;
            while(cur!=null)
            {
                if (cur.data.Equals(t))
                    return true;
                cur = cur.next;
            }
            return false;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            Node cur = head;
            while(cur!=null)
            {
                sb.Append(cur.data + "->");
                cur = cur.next;
            }
            sb.Append("null");
            return sb.ToString();
        }

        //头部添加
        public void AddFirst(T t)
        {
            Add(0, t);
        }
        //尾部添加
        public void AddLast(T t)
        {
            Add(N - 1, t);
        }
        //头部删除
        public T RemoveFirst()
        {
            return Remove(0);
        }
        //尾部删除
        public T RemoveLast()
        {
            return Remove(N - 1);
        }
        //查询尾元素
        public T QueryLast()
        {
            return Query(N - 1);
        }
    }
}
