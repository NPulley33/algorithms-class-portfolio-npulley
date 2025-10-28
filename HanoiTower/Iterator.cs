namespace HanoiTower
{
    public interface Iterator<T> where T : struct
    {
        public bool IsDone();
        public T? Next();
    }
}
