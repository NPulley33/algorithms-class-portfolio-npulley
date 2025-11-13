using System;

namespace algo_class_portfolio_npulley.Data_Structure_Differences
{
    internal class PQNodeArr<T>
    {
        public readonly int key;
        public readonly T value;

        public PQNodeArr(int key, T value)
        { 
            this.key = key;
            this.value = value;
        }
    }


    public class MaxPQArray<T>
    {
        private PQNodeArr<T>[] tree;
        int next;

        public MaxPQArray() 
        {
            tree = new PQNodeArr<T>[2];
            next = 1;
        }

        public void Enqueue(int priority, T element)
        {
            if (next >= tree.Length) Resize(tree.Length * 2);

            tree[next] = new PQNodeArr<T>(priority, element);
            Swim(next);
            next++;
        }

        public T Dequeue()
        {
            PQNodeArr<T> max = tree[1];

            next--;
            tree[1] = tree[next];
            tree[next + 1] = null;

            Sink();
            //if usued values is <= 1/4 of total array size then resize the length of the array to 1/2 curr length
            for (int i = 0; i < tree.Length; i++)
            {
                if (tree[i] == null)
                {
                    if (i <= tree.Length / 4)
                    {
                        Resize(tree.Length / 2);
                        break;
                    }
                    else break;
                }
            }

            return max.value;
        }

        public void Swim(int index)
        {
            if (index == 1) return;

            //check parent node key and see if it is less than current key
            //if so then swap

            int parentIndex = GetParentNodeForIndex(index);
            bool done = false;

            while (!done && index > 1)
            {
                if (tree[parentIndex].key > tree[index].key)
                {
                    PQNodeArr<T> temp = tree[index];
                    tree[index] = tree[parentIndex];
                    tree[parentIndex] = temp;

                    index = parentIndex;
                }
                else done = true;
            }

        }

        public void Sink()
        {
            int index = 1;
            bool done = false;

            //check left child and right child for greater of 2 keys
            //and swap
            //keep doing it
            while ( !done && index < next)
            {
                int leftChildIndex = GetLeftChildIndexForParent(index);
                int rightChildIndex = GetRightChildIndexForParent(index);
                
                bool leftChildNull = (tree[leftChildIndex] == null);
                bool rightChildNull = (tree[rightChildIndex] == null);

                if (leftChildNull && rightChildNull) return;
                
                int currIndexKey = tree[index].key;

                int leftChildKey = currIndexKey;
                if (leftChildNull == false) leftChildKey = tree[leftChildIndex].key;

                int rightChildKey= currIndexKey;
                if (rightChildNull == false) rightChildKey = tree[rightChildIndex].key;

                if (leftChildKey <= currIndexKey && rightChildKey <= currIndexKey)
                { 
                    done = true;
                    continue;
                }

                int swapIndex = index;
                if (leftChildKey > currIndexKey)
                {
                    swapIndex = GetLeftChildIndexForParent(index);
                }
                else if (rightChildKey > currIndexKey)
                {
                    swapIndex = GetRightChildIndexForParent(index);
                }

                PQNodeArr<T> temp = tree[index];
                tree[index] = tree[swapIndex];
                tree[swapIndex] = temp;
                index = swapIndex;
            }

        }

        public int GetLeftChildIndexForParent(int index)
        {
            if (index <= 0) return -1;
            return index * 2;
        }

        public int GetRightChildIndexForParent(int index)
        {
            return GetLeftChildIndexForParent(index) + 1;
        }

        //clac child & parent node function
        public int GetParentNodeForIndex(int index)
        {
            if (index <= 0) return -1;
            if (index == 1) return 1;

            if (index % 2 == 0) return index / 2;
            else return (index - 1) / 2;
        }

        private void Resize(int count)
        { 
            PQNodeArr<T>[] newArray = new PQNodeArr<T>[count];
            for (int i = 0; i < tree.Length; i++)
            { 
                if (tree[i] == null) break; //accounts for downsizing

                newArray[i] = tree[i];
            }
            tree = newArray;
        }

    }
}
