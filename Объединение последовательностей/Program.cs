using System;

namespace Объединение_последовательностей
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double k = int.Parse(Console.ReadLine());

            double i = 1;
            double j = 1;
            double a = i;
            double b = i;
            double sum = 0;
            int count = 0;

            while (count < k)
            {
                a = i * i;
                b = j * j * j;

                if (a < b)
                {
                    sum = a ;
                    i++;
                    count++;
                }
                else if (a>b)
                {
                    sum = b ;
                    j++;
                    count++;
                }
                else if (a == b)
                {
                    sum = a; 
                    i++;
                    j++;
                    count++;
                }
            }

            Console.WriteLine(sum);
        }
    }
}
