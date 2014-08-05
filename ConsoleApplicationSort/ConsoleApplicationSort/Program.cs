using System;
using System.CodeDom;
using System.Runtime.InteropServices;


namespace ConsoleApplicationSort
{
    /// <summary>
    ///  This class performs the initialization, the insertion sort and console
    ///  output of an array 
    /// </summary>
    class InsertionSort
    {
        static void Main()
        {
            const int m = 29;
            var array = new int[m];
            var r = new Random();
            const string message1 = "Non-sorted array:";
            const string message2 = "Sorted array:";
            Initialize(array, m, r);
            PrintArray(array, message1);
            Sort(array);
            PrintArray(array, message2);
            Console.Read();
        }

        /// <summary>
        /// This function realizes the initialization of array.
        /// </summary>
        /// <param name="array"></param>
        /// <param name="m"></param>
        /// <param name="r"></param>
        public static void Initialize (int[] array, int m, Random r)
        {
            for (var i = 0; i < array.Length; i++)
            {
                array[i] = r.Next(m);
            }

        }

        /// <summary>
        /// This function realizes insertion sort of array.
        /// </summary>
        /// <param name="array"></param>
        public static void Sort (int[] array)
        {
            for (var i = 0; i < array.Length; i++)
            {
                var key = array[i];
                var j = i;
                while (j > 0 && key < array[j - 1])
                {
                    array[j] = array[j - 1];
                    j--;

                }
                array[j] = key;
                              
            }
            
        }

        /// <summary>
        /// This function realizes output stream of array.
        /// </summary>
        /// <param name="array"></param>
        /// <param name="message"></param>
        public static void PrintArray(int[] array, String message)
        {
            Console.WriteLine(message);
            foreach (var t in array)
            {
                Console.Write(t + " ");
            }
            Console.WriteLine();
        }
    }
}
