using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickSort_Recursion
{
    public class Partition
    {

        //partition of the array if the element is smaller than pivot place in left 
        // and if larger place the element in the right 
        static public int PartitionHelper(int[] arr, int left, int right)
        {
            int pivot;
            pivot = arr[left];
            while (true)
            {
                while (arr[left] < pivot)
                {
                    left++;
                }
                while (arr[right] > pivot)
                {
                    right--;
                }
                if (left < right)
                {
                    int temp = arr[right];
                    arr[right] = arr[left];
                    arr[left] = temp;
                }
                else
                {
                    return right;
                }
            }
        }


        public static int PartitionArray(int[] arrayToPartition, int leftBoundry, int rightBoundry)
        {
            int pivotPosition = leftBoundry;
            int pivot = arrayToPartition[leftBoundry];
            for (int i = leftBoundry + 1; i <= rightBoundry; i++)
            {
                if (arrayToPartition[i]< pivot)
                {
                    pivotPosition++;
                    Swap.SwapElementOfArray(arrayToPartition, pivotPosition, i);
                }

            }
            Swap.SwapElementOfArray(arrayToPartition,pivotPosition,leftBoundry);
            return pivotPosition;
        }
    }
}
