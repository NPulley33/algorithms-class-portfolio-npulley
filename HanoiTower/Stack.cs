namespace HanoiTower
{
    public class Stack<T> : LinkedList<T> where T : struct
    {
        public void Push(T item)
        {
            if (base.First is null) base.AddFirst(item);
            base.AddLast(item);
        }

        public T? Pop()
        {
            T? item = base.GetLast();
            base.RemoveLast();
            return item;
        }

        public T? Peek()
        { 
            return base.GetLast();
        }

        public int Size()
        {
            StackIterator<T> iterator = new StackIterator<T>(this);
            return iterator.count;
        }

        public bool IsEmpty()
        {
            int size = Size();
            return size == 0;
        }

        public new Iterator<T> Iterator()
        { 
            return new StackIterator<T>(this);
        }
    }
}
