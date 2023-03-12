using System;

namespace Результаты_олимпиады
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] scores = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int[] numbers = new int[n];

            for (int i = 0; i < n; i++)
            {
                numbers[i] = i + 1;
            }

            for (int i = 1; i < n; i++)
            {
                int score = scores[i];
                int number = numbers[i];
                int j = i - 1;

                while (j >= 0 && scores[j] < score)
                {
                    scores[j + 1] = scores[j];
                    numbers[j + 1] = numbers[j];
                    j--;
                }

                scores[j + 1] = score;
                numbers[j + 1] = number;
            }
            string str = string.Join(" ", numbers);
            Console.WriteLine(str);

        }
    }
}
