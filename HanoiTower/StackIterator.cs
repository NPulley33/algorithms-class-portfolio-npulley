namespace HanoiTower
{
    public class StackIterator<T> : Iterator<T> where T : struct
    {
        private Stack<T> data;
        public int count { get; private set; }

        public StackIterator(Stack<T> data)
        {
            this.data = data;
            this.count = 0;
            GetCount();
        }

        public void GetCount()
        {
            //no elements
            if (IsDone())
            {
                count = 0;
                return;
            }

            while (!IsDone())
            {
                count++;
            }
            count--;
        }

        public bool IsDone()
        {
            //error if nothing was put in stack
            if (data.First is null && data.Last is null) return true;
            return (data.GetAt(count) is null);
        }

        public T? Next()
        {
            count--;
            return(data.GetAt(count + 1));
        }

    }
}
