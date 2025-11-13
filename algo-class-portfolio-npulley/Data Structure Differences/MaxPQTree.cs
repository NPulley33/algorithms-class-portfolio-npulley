using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace algo_class_portfolio_npulley.Data_Structure_Differences
{
    public class PQNodeTree<T>
    {
        public readonly int key;
        public readonly T value;

        public PQNodeTree<T>? parent;
        public PQNodeTree<T>? leftChild;
        public PQNodeTree<T>? rightChild;

        public PQNodeTree(int key, T value)
        {
            this.key = key;
            this.value = value;
        }
    }

    public class MaxPQTree<T>
    {
        private PQNodeTree<T>? Head;
        private PQNodeTree<T>? next;

        public MaxPQTree()
        { 
            
        }

        public void Enqueue(int priority, T element)
        {
            PQNodeTree<T> node = new PQNodeTree<T>(priority, element);
            if (Head is null)
            { 
                Head = node;
                next = node.leftChild;
            } 
            else
            {
                PQNodeTree<T> parent = next.parent;
                if (parent.leftChild is null)
                {
                    parent.leftChild = node;
                    next = parent.rightChild;
                }
                else if (parent.rightChild is null)
                {
                    parent.rightChild = node;
                    //find next
                }
            }
        }

        public void Dequeue()
        { 
            
        }

        public void Swim(PQNodeTree<T> node)
        {
            if (node == Head) return;
            while (node.key > node.parent.key)
            {
                
            }
        }

        public void Sink()
        {
            PQNodeTree <T> node = Head;
            while (node.key < node.rightChild.key || node.key < node.leftChild.key)
            {
                if (node.key < node.leftChild.key)
                {

                }
                else if (node.key < node.rightChild.key)
                { 
                }

                //swapping childrenn & parents, not nodes themselves
            }
        }
    }
}
