using QuickSort_Recursion;
using System.Globalization;

Console.WriteLine("Quick SORT ");


//int[] arr = { 67, 12, 95, 56, 85, 1, 100, 23, 60, 9 };
//int n = 10, i;
//QuickSort.quickSort(arr, 0, 9);
//Console.Write("Sorted Array : ");

//for(i=0; i<n; i++)
//{
//    Console.WriteLine(arr[i] + "");
//}

int[] arr = { 67, 12, 95, 56, 85, 1, 100, 23, 60, 9 };

QuickSort.QuickSortImplementation(arr,0,arr.Length-1);

for (int i = 0; i < arr.Length - 1; i++)
{
    Console.WriteLine(arr[i]);
}

