using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace BinarySearchTree
{
    public class SortingWithGeneric<T> where T : IComparable<T>
    {
         public void DisplayBubble(T[] arr)
        {
           
            T temp;
            for (int j = 0; j <= arr.Length - 2; j++)
            {
                for (int i = 0; i <= arr.Length - 2; i++)
                {
                    if (arr[i].CompareTo(arr[i + 1])>0)
                    {
                        temp = arr[i + 1];
                        arr[i+1] = arr[i];
                        arr[i] = temp;
                    }
                }
            }
            Console.WriteLine("Sorted: ");
            foreach (T p in arr)
            {
                Console.WriteLine(p + " ");
            }
        }

        //FOR SEARCHING IN GENERIC
        public int BinarySearch(T[] arr, T value)
        {
            int left = 0;
            int right = arr.Length - 1;

            while (left <= right)
            {
                int mid = (left + right) / 2;

                if (arr[mid].Equals(value))
                {
                    return mid;
                }
                else if (arr[mid].CompareTo(value) < 0)
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }
            }

            return -1;
        }

    }
}
