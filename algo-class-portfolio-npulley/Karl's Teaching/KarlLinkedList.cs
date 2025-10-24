using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace algo_class_portfolio_npulley
{
    public class Node<T> //where T : struct
    { 
        public T Value { get; set; }
        public Node<T>? Next { get; set; }
    }

    public class KarlLinkedList<T> //where T : struct
    {
        Node<T>? Head { get; set; }

        public void Append(T data) 
        {
            Node<T>? temp = this.Head;

            Node<T>? newNode = new Node<T> { Value = data, Next = null };

            while (temp?.Next != null)
            { 
                temp = temp.Next;
            }
            if (temp != null) temp.Next = newNode;
        }

        public T? GetAt(int pos)
        {
            Node<T>? temp = this.Head;

            int i = 0;
            while ( i < pos && temp != null )
            {
                temp = temp.Next;
                i++;
            }

            if (temp != null) return temp.Value;
            return default(T);
        }


        public static void Add(Node<T>? node, T val)
        {
            var newNode = new Node<T> { Value = val, Next = null };

            if (node is null) node = newNode;

            while (node.Next is not null)
            {
                node = node.Next;
            }
            node.Next = newNode;
        }

    }

    /**
     * Node<int>? list = null;
     * LinkedList<int>.Add(list, 10);
     * LinkedList<int>.Add(list, 11);
     */


    public class LLQueue<T>
    {
        Node<T>? Head;

        public void Push(T data)
        {
            Node<T>? temp = this.Head;

            Node<T>? newNode = new Node<T> { Value = data, Next = null };

            while (temp?.Next != null)
            {
                temp = temp.Next;
            }
            if (temp != null) temp.Next = newNode;
        }

        public T? Peek()
        {
            if (Head is null) return default(T);
            return Head.Value;
        }

        public void Pop()
        {
            if (this.Head is not null) this.Head = this.Head.Next;
        }

        public bool Empty()
        {
            return this.Head is null;
        }
    }

    public class LLStack<T>
    {
        Node<T>? Tail;

        public void Push(T data)
        {
            Node<T>? temp = this.Tail;

            Node<T>? newNode = new Node<T> { Value = data, Next = temp };

            this.Tail = newNode;
        }

        public void Pop()
        {
            if (this.Tail is not null) this.Tail = this.Tail.Next;
        }

        public T? Peek()
        {
            if (Tail is null) return default(T);
            return Tail.Value;
        }

        public bool IsEmpty()
        {
            return this.Tail is null;
        }

    }
   
    //stack:
    //next would be prev
    //head would be tail (pointer)
}
