namespace HanoiTower
{
    public class LinkedList<T> where T : struct
    {
        public class Node<T>
        {
            public T Data;
            public Node<T>? Next;
            public Node<T>? Prev;
        }

        public Node<T> First { get; protected set; }
        public Node<T> Last { get; protected set; }

        public T? GetFirst()
        {
            if (First is null) return null;
            else return First.Data;
        }
        public T? GetLast()
        {
            if (Last is null) return null;
            else return Last.Data;
        }

        public void AddFirst(T data)
        {
            Node<T> newNode = new Node<T> { Data = data, Next = this.First, Prev = null };
            First = newNode;
        }

        public void RemoveFirst()
        {
            if (First.Next is not null)
            {
                First = First.Next;
                First.Prev = null;
            }
            else First = null;
        }

        public void AddLast(T data)
        {
            Node<T> newNode = new Node<T> { Data = data, Next = null, Prev = Last };
            if (Last is null)
            { 
                newNode.Prev = First;
                First.Next = newNode;
            }
            //set one before's next to new Last
            else
            {
                Node<T> node = First;
                while (node.Next is not null) node = node.Next;
                node.Next = newNode;
            }
            Last = newNode;
        }

        public void RemoveLast()
        {
            if (Last.Prev is not null)
            {
                Last = Last.Prev;
                Last.Next = null;
            }
            else Last = null;
        }

        public T? GetAt(int index)
        {
            int i = 0;
            if (First is null) return null;
            Node<T> node = First;
            while (i < index)
            {
                if (node.Next is null) return null;
                i++;
                node = node.Next;
            }
            return node.Data;
        }

        public void InsertAt(int index, T value)
        {
            int i = 0;
            Node<T> node = First;
            //stop one before
            while (i < index - 1)
            {
                if (node.Next is null) throw new ArgumentOutOfRangeException("Index out of bounds of list");
                i++;
                node = node.Next;
            }
            Node<T> newNode = new Node<T> { Data = value, Next = node.Next, Prev = node };
            node.Next = newNode;
        }

        public Iterator<T> Iterator()
        {
            return new LinkedListIterator<T>(this);
        }
    }
}
