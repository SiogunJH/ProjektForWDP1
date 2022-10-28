using System;

namespace Zadania_petle
{
    class Zadanie3
    {
        static void Main3()
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

            //Znajdź nowe dane
            bool canDivide = false;
            int min = 0;
            int max = 0;

            for (int i = dane[0] + 1; i < dane[1]; i++)
            {
                if (i % dane[2] == 0)
                {
                    canDivide = true;
                    min = i;
                    //Console.WriteLine(i);
                    break;
                }
            }
            for (int i = dane[1] - 1; i > dane[0]; i--)
            {
                if (i % dane[2] == 0)
                {
                    max = i;
                    //Console.WriteLine(i);
                    break;
                }
            }
            dane[0] = min;
            dane[1] = max;
            //Console.WriteLine($"{dane[0]} {dane[1]}");

            //Jeśli nie ma liczb
            if (!canDivide)
            {
                Console.Write("empty");
                return;
            }

            //Jeśli liczb jest nie więcej niż 10
            if (dane[1] - dane[0] <= 9 * dane[2])
                for (int i = dane[0]; i <= dane[1]; i += dane[2])
                {
                    Console.Write(i);
                    if (i != dane[1]) Console.Write(", ");
                }
            //Jeśli liczb jest więcej niż 10
            else
            {
                for (int i = dane[0]; i <= dane[0] + (2 * dane[2]); i += dane[2])
                {
                    Console.Write(i);
                    Console.Write(", ");
                }
                Console.Write("..., ");
                for (int i = dane[1] - dane[2]; i <= dane[1]; i += dane[2])
                {
                    Console.Write(i);
                    if (i != dane[1]) Console.Write(", ");
                }
            }
        }
    }
}