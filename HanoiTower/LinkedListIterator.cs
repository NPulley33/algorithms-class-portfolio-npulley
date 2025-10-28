namespace HanoiTower
{
    public class LinkedListIterator<T> : Iterator<T> where T: struct
    {
        private LinkedList<T> data;
        private int count;

        public LinkedListIterator(LinkedList<T> data) 
        { 
            this.data = data;
            count = 0;
        }

        public bool IsDone()
        {
            return (data.GetAt(count) is null);
        }

        public T? Next()
        {
            
            count++;
            return data.GetAt(count - 1);
        }
    }
}
