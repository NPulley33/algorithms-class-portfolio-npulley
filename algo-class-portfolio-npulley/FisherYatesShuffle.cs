using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace algo_class_portfolio_npulley
{
    public static class FisherYatesShuffle
    {

        public static void Shuffle<T>(T[] arr)
        { 
            Random rand = new Random(); 
            for (int i = arr.Length - 1; i > 0; i--)
            {
                int randIndex = rand.Next(0, i + 1);
                T temp = arr[i];
                arr[i] = arr[randIndex];
                arr[randIndex] = temp;
            }
        }

    }
}
