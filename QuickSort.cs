using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickSort_Recursion
{
    public class QuickSort
    {

        static public void quickSort(int[] arr, int left, int right)
        {
            int pivot;
            if (left < right)
            {
                pivot = Partition.PartitionHelper(arr, left, right);
                if (pivot > 1)
                {
                    quickSort(arr, left, pivot - 1);
                }
                if (pivot + 1 < right)
                {
                    quickSort(arr, pivot + 1, right);
                }
            }
        }


        public static void QuickSortImplementation(int[] arrayToSort, int leftBoundry , int rightBoundry)
        {
            if(leftBoundry < rightBoundry)
            {
                var partition = Partition.PartitionArray(arrayToSort, leftBoundry, rightBoundry);
                QuickSort.QuickSortImplementation(arrayToSort,leftBoundry,partition-1);
                QuickSort.QuickSortImplementation(arrayToSort,partition+1,rightBoundry);
            }
        }
    }
}
