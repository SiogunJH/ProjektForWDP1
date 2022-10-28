using System;

namespace Zadania_petle
{
    class Zadanie2
    {
        static void Main2()
        {
            //wczytywanie i parsowanie danych wejściowych
            string wejscie = Console.ReadLine();
            int[] dane = Array.ConvertAll<string, int>(wejscie.Split(" "), int.Parse);

            //Sortowanie
            if (dane[1] < dane[0])
            {
                int temp = dane[0];
                dane[0] = dane[1];
                dane[1] = temp;
            };

            //Brak Liczb
            if (dane[1] - dane[0] <= 1) Console.WriteLine("empty");

            //Jeśli liczb jest nie więcej niż 10
            if (dane[1] - dane[0] <= 11)
                for (int i = dane[0] + 1; i < dane[1]; i++)
                {
                    Console.Write(i);
                    if (i != dane[1] - 1) Console.Write(", ");
                }

            //Jeśli liczb jest więcej niż 10
            else
            {
                for (int i = dane[0] + 1; i < dane[0] + 4; i++)
                {
                    Console.Write(i);
                    if (i != dane[0] - 1) Console.Write(", ");
                }
                Console.Write("..., ");
                for (int i = dane[1] - 2; i < dane[1]; i++)
                {
                    Console.Write(i);
                    if (i != dane[1] - 1) Console.Write(", ");
                }
            }
        }
    }
}