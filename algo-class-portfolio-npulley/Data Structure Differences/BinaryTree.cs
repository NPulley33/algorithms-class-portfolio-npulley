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

        private Node head;

        public BinaryTree(Node head) { this.head = head; }

        public BinaryTree() { }

        public void Insert(int data)
        {
            if (head == null)
            { 
                head = new Node(data);
                return;
            }

            bool inserted = false;
            Node current = head;

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
