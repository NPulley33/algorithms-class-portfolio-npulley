using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace algo_class_portfolio_npulley.Data_Structure_Differences
{
    public class Node
    {
        public int Data;
        public Node Left;
        public Node Right;

        public Node() { }
        public Node(int data) { this.Data = data; }
    }

    public class BinaryTree
    {

        public Node Head;

        public BinaryTree(int head) { this.Head = new Node(head); }

        public BinaryTree() { }

        public void Insert(int data)
        {
            if (Head == null)
            { 
                Head = new Node(data);
                return;
            }

            bool inserted = false;
            Node current = Head;

            while (!inserted)
            {
                if (data < current.Data)
                {
                    if (current.Left == null)
                    {
                        current.Left = new Node(data);
                        inserted = true;
                        return;
                    }
                    else
                    {
                        current = current.Left;
                        continue;
                    }
                }
                else
                {
                    if (current.Right == null)
                    {
                        current.Right = new Node(data);
                        inserted = true;
                        return;
                    }
                    else 
                    {
                        current = current.Right;
                        continue;
                    }
                }
            }
        }

    }
}
