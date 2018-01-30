using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticePrograms.SortingAlgorithms
{
    class QuickSort
    {
        public QuickSort()
        {
            int[] array = { 453, 11, -1, 9, 50, 771, 0, 649, 770, -12, 240, 9, 771 };
            Sort(array, 0, array.Length - 1);

            foreach (int item in array)
            {
                Console.WriteLine(item);
            }
        }

        void Sort(int[] array, int low, int high)
        {
            if (low >= high)
                return;

            int partitionIndex = Partition(array, low, high);

            Sort(array, low, partitionIndex - 1);
            Sort(array, partitionIndex + 1, high);
        }

        int Partition(int[] arr, int low, int high)
        {
            int pivot = arr[high];
            int i = (low - 1); // index of smaller element
            for (int j = low; j < high; j++)
            {
                // If current element is smaller than or equal to pivot
                if (arr[j] <= pivot)
                {
                    i++;
                    // swap arr[i] and arr[j]
                    Swap(arr, i, j);
                }
            }
            // swap arr[i+1] and arr[high] (or pivot)
            Swap(arr, i + 1, high);
            return i + 1;
        }

        void Swap(int[] array, int firstIndex, int secondIndex)
        {
            int temp = array[firstIndex];
            array[firstIndex] = array[secondIndex];
            array[secondIndex] = temp;
        }
    }
}
