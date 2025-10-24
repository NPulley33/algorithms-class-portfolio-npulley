using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace algo_class_portfolio_npulley.HanoiTower
{
    public interface Iterator<T> where T : struct
    {
        public bool IsDone();
        public T? Next();
    }
}
