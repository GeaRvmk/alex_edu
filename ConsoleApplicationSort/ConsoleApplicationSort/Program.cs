using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationSort
{
    class InsertionSort
    {
        static void Main(string[] args)
        {
            int m = 100;
            int[] array = new int[m];
            Random r = new Random();
            Console.WriteLine("Non-sorted array:");
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = r.Next(m);
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine("Sorted array:");
            sort(array);
            printArray(array);
            Console.Read();
        }
        public static void sort(int[] array)
        {
            //int[] result = new int[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                int key = array[i];
                int j = i;
                while (j > 0 && key < array[j - 1])
                {
                    array[j] = array[j - 1];
                    j--;

                }
                array[j] = key;
                              
            }
            
        }

        public static void printArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
        }
    }
}
