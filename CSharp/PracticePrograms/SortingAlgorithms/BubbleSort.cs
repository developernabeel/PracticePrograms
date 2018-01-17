using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticePrograms.SortingAlgorithms
{
    class BubbleSort
    {
        public BubbleSort()
        {
            int[] array = { 453, 11, -1, 9, 50, 771, 0, 649, 770, -12, 240, 9, 771 };
            int[] sortedArray = Sort(array);

            foreach (int item in sortedArray)
            {
                Console.WriteLine(item);
            }
        }

        int[] Sort(int[] array)
        {
            if (array.Length <= 1)
                return array;

            int temp = 0;

            for (int i = array.Length- 1; i > 0 ; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }
            return array;
        }
    }
}
