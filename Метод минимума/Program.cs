using System;
namespace Метод_минимума
{
    internal class Program
    {
        static void Sort(int[] arr)
        {
            int counter = 0;
            int first = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                int min = arr[i];
                int numOfMin = i;
                for (int j = i; j < arr.Length; j++)
                {
                    if (min > arr[j])
                    {
                        min = arr[j];
                        numOfMin = j;
                    }
                }
                if (numOfMin != i)
                {
                    arr[numOfMin] = arr[i];
                    arr[i] = min;
                    if (first == numOfMin)
                    {
                        counter++;
                        first = i;
                    }
                    else if (first == i)
                    {
                        counter++;
                        first = numOfMin;
                    }
                }

            }
            Console.WriteLine( counter);
        }


        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            Sort(arr);

        }
    }
}