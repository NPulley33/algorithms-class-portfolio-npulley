using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace algo_class_portfolio_npulley.HanoiTower
{
    internal class QueueIterator<T> : Iterator<T> where T : struct
    {
        private Queue<T> data;
        public int count { get; private set; }

        public QueueIterator(Queue<T> data)
        {
            this.data = data;
            count = 0;
        }

        public bool IsDone()
        {
            if (data.First is null && data.Last is null) return true;
            return (data.GetAt(count) is null);
        }

        public T? Next()
        {
            count++;
            return (data.GetAt(count - 1));
        }
    }
}
