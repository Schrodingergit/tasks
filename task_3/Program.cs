using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_3
{
    class Program
    {
        static void Remove(ref int[] array, int index) // Remove element from array
        {
            int[] newArray = new int[array.Length - 1];

            for (int i = 0; i < index; i++)
            {
                newArray[i] = array[i];
            }
            for (int i = index + 1; i < array.Length; i++)
            {
                newArray[i - 1] = array[i];
            }

            array = newArray;
        }

        static void RemoveFirst(ref int[] array, int index)
        {
            Remove(ref array, 0);
        }

        static void RemoveLast(ref int[] array, int index)
        {
            Remove(ref array, array.Length - 1);
        }
        static void Main(string[] args)
        {
            int[] arr = { 1, 4, 6, 2 };

            Remove(ref arr, 2);
        }
    }
}
