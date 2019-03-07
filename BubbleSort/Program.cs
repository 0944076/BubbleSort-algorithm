using System;

namespace BubbleSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] unsortedArray = new int[] {12, 4, 8, 120, 1665, 1, 0, -1};
            System.Console.WriteLine("UNSORTED");


            for (int i = 0; i < unsortedArray.Length; i++)
            {
                System.Console.WriteLine(unsortedArray[i]);
        
            }

            int[] sortedArray = BubbleSort(unsortedArray);
            System.Console.WriteLine("SORTED");

            for (int i = 0; i < sortedArray.Length; i++)
            {
                System.Console.WriteLine(sortedArray[i]);                
            }
            Console.ReadLine();
        }

        private static int[] BubbleSort(int[] unsortedArray)
        {
            int length = unsortedArray.Length;
            for (int i = 0; i < length - 1; i++)
            {
                for (int j = 0; j < length - 1 - i; j++)
                {
                    if(unsortedArray[j] > unsortedArray[j + 1])
                    {
                        int num = unsortedArray[j];
                        unsortedArray[j] = unsortedArray[j + 1];
                        unsortedArray[j+1] = num;
                    }
                }
            }
            return unsortedArray;
        }
    }
}
