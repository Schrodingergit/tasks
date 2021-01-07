using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_2
{
    class Program
    {
        static void Insert(ref int[] array, int newValue, int index) // Insert element into array
        {
            int[] newArray = new int[array.Length + 1];

            newArray[index] = newValue;

            for (int i = 0; i < index; i++)
            {
                newArray[i] = array[i];
            }
            for (int i = index; i < array.Length; i++)
            {
                newArray[i + 1] = array[i];
            }

            array = newArray;
        }

        static void InsertFirst(ref int[] array, int newValue)
        {
            Insert(ref array, newValue, 0);
        }

        static void InsertLast(ref int[] array, int newValue)
        {
            Insert(ref array, newValue, array.Length);
        }

        static void Main(string[] args)
        {
            int[] myArr = { 1, 4, 6, 2 };
            Insert(ref myArr, -5, 2);
        }
    }
}
