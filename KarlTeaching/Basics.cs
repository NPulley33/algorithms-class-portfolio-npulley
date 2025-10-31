using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KarlTeaching
{
    public static class Basics
    {

        public static bool isPrime(int n)
        {
            for (int i = 0; i < n - 1; i++)
            {
                if (n % i == 0) return false;
            }
            return true;
        }

        public static int GDC(int a, int b)
        {
            while (b != 0)
            {
                int t = b;
                b = a % b;
                a = t;
            }
            return a;
        }

    }
}
