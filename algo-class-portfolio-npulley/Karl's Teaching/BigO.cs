using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace algo_class_portfolio_npulley
{
    public class BigO
    {

        //O(1) Constant
        //Time to get the first element of a list stays constant, does not vary with size of list
        public T GetFirstItem<T>(List<T> collection)
        {
            return collection[0];
        }

        //TODO: O(n) Linear
        //Time is dependant on the size of the collection
        //We loop through the array once, meaning it takes n time to complete with an array of n length
        public int GetNumOccurances<T>(T[] collection, T itemToCount)
        {
            int numOccurances = 0;
            for (int i = 0; i < collection.Length; i++)
            {
                if (collection[i].Equals(itemToCount)) numOccurances++;
            }
            return numOccurances;
        }

        //TODO: O(n^2) Quadratic
        //iterating through every element of a 2D array
        //at worst case i & j are the same (for if one is smaller the algorithm is faster) and i = n
        //because you have to search every element of array j, which is stored in one element of array i
        //it takes n^2 time to iterate through
        public int GetNumOccurances2D<T>(T[,] collection, T itemToCount)
        {
            int numOccurances = 0;

            for (int i = 0; i < collection.GetLength(0); i++)
            {
                for (int j = 0; j < collection.GetLength(1); j++)
                {
                    if (collection[i, j].Equals(itemToCount)) numOccurances++;
                }
            }

            return numOccurances;
        }

    }
}
