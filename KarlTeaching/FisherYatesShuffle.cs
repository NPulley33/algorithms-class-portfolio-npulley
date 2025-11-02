using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KarlTeaching
{
    public static class FisherYatesShuffle
    {
        /// <summary>
        /// shuffles values in an array by random swapping
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="arr"></param>
        public static void Shuffle<T>(T[] arr)
        { 
            Random rand = new Random(); 
            for (int i = arr.Length - 1; i > 0; i--)
            {
                int randIndex = rand.Next(0, i);
                T temp = arr[i];
                arr[i] = arr[randIndex];
                arr[randIndex] = temp;
            }
        }

    }
}
