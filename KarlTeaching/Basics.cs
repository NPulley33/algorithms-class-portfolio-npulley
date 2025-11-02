using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KarlTeaching
{
    public static class Basics
    {
        /// <summary>
        /// checks if a number is prime by dividing by every possible number up to the number itself
        /// </summary>
        /// <param name="n"> number to check </param>
        /// <returns> if a number is prime </returns>
        public static bool isPrime(int n)
        {
            for (int i = 0; i < n - 1; i++)
            {
                if (n % i == 0) return false;
            }
            return true;
        }

        /// <summary>
        /// finds the greatest common denominator of two integers
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns> greatest common denominator found </returns>
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
