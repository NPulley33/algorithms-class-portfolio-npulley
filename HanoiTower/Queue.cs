namespace HanoiTower
{
    public class Queue<T> : LinkedList<T> where T : struct
    {

        public void Enqueue(T data)
        {
            if (First is null) base.AddFirst(data);
            else base.AddLast(data);
        }

        public T? Dequeue()
        {
            T? item = base.GetFirst();
            base.RemoveFirst();
            return item;
        }

        public T? Peek()
        { 
            return base.GetFirst();
        }

        public int Size()
        {
            QueueIterator<T> iterator = new QueueIterator<T>(this);
            while (!iterator.IsDone())
            {
                iterator.Next();
            }
            return iterator.count;
        }

        public bool IsEmpty()
        {
            int size = Size();
            return size == 0;
        }

        public new Iterator<T> Iterator()
        {
            return new QueueIterator<T>(this);
        }
    }
}
