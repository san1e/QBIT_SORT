using System;

namespace Сортировка___отрицательные_и_положительные
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int[] negativeNumbers = new int[n];
            int[] nonNegativeNumbers = new int[n];

            int negativeIndex = 0;
            int nonNegativeIndex = 0;
            for (int i = 0; i < n; i++)
            {
                if (arr[i] < 0)
                {
                    negativeNumbers[negativeIndex] = arr[i];
                    negativeIndex++;
                }
                else
                {
                    nonNegativeNumbers[nonNegativeIndex] = arr[i];
                    nonNegativeIndex++;
                }
            }

            for (int i = 0; i < negativeIndex - 1; i++)
            {
                for (int j = i + 1; j < negativeIndex; j++)
                {
                    if (negativeNumbers[i] > negativeNumbers[j])
                    {
                        int temp = negativeNumbers[i];
                        negativeNumbers[i] = negativeNumbers[j];
                        negativeNumbers[j] = temp;
                    }
                }
            }

            for (int i = 0; i < nonNegativeIndex - 1; i++)
            {
                for (int j = i + 1; j < nonNegativeIndex; j++)
                {
                    if (nonNegativeNumbers[i] < nonNegativeNumbers[j])
                    {
                        int temp = nonNegativeNumbers[i];
                        nonNegativeNumbers[i] = nonNegativeNumbers[j];
                        nonNegativeNumbers[j] = temp;
                    }
                }
            }
            for (int i = 0; i < negativeIndex; i++)
            {
                Console.Write(negativeNumbers[i] + " ");
            }
            for (int i = 0; i < nonNegativeIndex; i++)
            {
                if (nonNegativeNumbers[i] == 0)
                {
                    Console.Write(nonNegativeNumbers[i] + " ");
                }
            }

            for (int i = 0; i < nonNegativeIndex; i++)
            {
                if (nonNegativeNumbers[i] > 0)
                {
                    Console.Write(nonNegativeNumbers[i] + " ");
                }
            }
        }
    }
}
