using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_1
{
    
    class Program
    {
        static void Resize<T>(ref T[] array, int newSize) //Change size of the array
        {
            T[] newArray = new T[newSize];
            for (int i = 0; i < array.Length && i < newArray.Length; i++)
            {
                newArray[i] = array[i];
            }

            array = newArray;
        }
        static void Main(string[] args)
        {
            //int[] arr = { 1, 4, 6 };

            string[] strArr = { "Hello", "Testing", "This" };

           // Resize(ref arr, 10);

            Resize(ref strArr, 10);
        }
    }
}
