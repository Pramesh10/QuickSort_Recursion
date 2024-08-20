using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickSort_Recursion
{
    public class Swap
    {
        public static void SwapElementOfArray(int[] arrayToswap , int postition1 , int position2)
        {
            int temp = arrayToswap[postition1];
            arrayToswap[postition1] = arrayToswap[position2];
            arrayToswap[position2] = temp;
        }
    }
}
