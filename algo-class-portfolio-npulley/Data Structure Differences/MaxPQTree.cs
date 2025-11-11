using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace algo_class_portfolio_npulley.Data_Structure_Differences
{
    internal class PQNodeTree<T>
    {
        public readonly int key;
        public readonly T value;

        public T parent;
        public T child1;
        public T child2;

        public PQNodeTree(int key, T value)
        {
            this.key = key;
            this.value = value;
        }
    }

    public class MaxPQTree<T>
    {
        private PQNodeTree<T> Head;

        public MaxPQTree()
        { 
            
        }

        public void Enqueue(int priority, T element)
        {
            PQNodeTree<T> node = new PQNodeTree<T>(priority, element);
            if (Head is null) Head = node;
            else
            { 
                
            }
        }

        public void Dequeue()
        { 
            
        }
    }
}
