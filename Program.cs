using System.Collections.Generic;

namespace NewC_2_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            int minRandom = 10;
            int maxRandom = 25;
            int lowerLimitSearch = 50;
            int upperLimitSearch = 150;
            int quantityNumbers = 0;
            int numberSearch;

            int numberN = random.Next(minRandom, maxRandom+1);

            for (int i = 0; i <= upperLimitSearch; i+= numberN)
            {
                numberSearch = i;

                if (numberSearch >= lowerLimitSearch)
                {
                    quantityNumbers++;
                }
            }

            Console.WriteLine($"Число N - {numberN}, Количество чисел в диапозоне от {lowerLimitSearch} до {upperLimitSearch} кратных N - {quantityNumbers}");
        }
    }
}