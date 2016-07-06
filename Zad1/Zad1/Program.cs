using System;

namespace Zad1
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            byte liczba = 22;
            long wynik = Silnia(liczba);

            Console.WriteLine("Wynik operacji " + liczba + "! = " + wynik);
            Console.ReadKey();
        }

        private static long Silnia(byte argument)
        {
            if (argument == 0)
                return 1;

            long result = 1;

            for (int i = 1; i < argument + 1; i++)
            {
                long resultCopy = result;
                result = result * i;

                if (result < result / i)
                {
                    Console.WriteLine("Podano zbyt dużą liczbę. Zwrócono możliwie największy wynik operacji, tj. 21!.");
                    return resultCopy;
                }
            }
            return result;
        }
    }
}