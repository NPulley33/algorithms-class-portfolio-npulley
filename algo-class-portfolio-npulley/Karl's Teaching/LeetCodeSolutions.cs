using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace algo_class_portfolio_npulley
{
    public class LeetCodeSolutions
    {
        //problem 1
        public int[] TwoSum(int[] nums, int target)
        {

            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++) //j = i + 1 to avoid duplicate checks
                {
                    if (nums[i] + nums[j] == target)
                    {
                        return new int[] { i, j };
                    }
                }
            }

            return new int[0];
        }

        //problem 9
        public bool IsPalindrome(int x)
        {
            if (x < 0) return false;

            int n = x;
            int r = 0;
            while (n > 0)
            {
                r += ((r * 10) + (n % 10));
                n = n / 10;
            }
            return r == x;
        }

        //problem 20
        public bool IsValid(string s)
        {
            //if odd false
            if (s == string.Empty || s.Length % 2 != 0) return false;

            Stack<char> stack = new Stack<char>();

            foreach (char c in s)
            {
                if (c == '(' || c == '{' || c == '[')
                {
                    stack.Push(c);
                }
                if (c == ')' && (stack.Pop() != '(')) return false;
                if (c == ']' && (stack.Pop() != '[')) return false;
                if (c == '}' && (stack.Pop() != '{')) return false;
            }

            if (stack.Count != 0) return false;
            return true;
        }

        //problem 26
        public int RemoveDuplicates(int[] nums)
        {
            int l = 1;
            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] != nums[i - 1])
                {
                    nums[l] = nums[i];
                    l++;
                }
            }
            return l;
        }


        //neetcode: https://neetcode.io/problems/buy-and-sell-crypto?list=neetcode150
        public int MaxProfit(int[] prices)
        {
            int maxProfit = 0;

            for (int i = 0; i < prices.Length; i++)
            {
                for (int j = i + 1; j < prices.Length; j++)
                {
                    if (prices[j] - prices[i] > maxProfit)
                    {
                        maxProfit = prices[j] - prices[i];
                    }
                }
            }

            return maxProfit;
        }
    }
}
