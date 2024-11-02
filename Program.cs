using System.Collections.Generic;

namespace NewC_2_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            int minRandom = 10;
            int maxRandom = 26;
            int lowerLimitSearch = 50;
            int upperLimitSearch = 150;
            int quantityNumbers = 0;
            int numberSearch=0;

            int numberN = random.Next(minRandom, maxRandom);

            for (int i = 0;numberSearch<=lowerLimitSearch; i++)
            {
                numberSearch += numberN;
            }

            for (int i = 0; numberSearch<=upperLimitSearch; i++)
            {
                numberSearch += numberN;
                quantityNumbers++;
            }

            Console.WriteLine($"Число N - {numberN}, Количество чисел в диапозоне от {lowerLimitSearch} до {upperLimitSearch} кратных N - {quantityNumbers}");
        }
    }
}