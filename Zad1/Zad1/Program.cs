using System;

namespace Zad1
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            byte liczba = 6;
            long wynik = Silnia(liczba);

            Console.WriteLine("Wynik operacji " + liczba + "! = " + wynik);

            wynik = Silnia(22); //Ta operacja spowoduje wystąpienie wyjątku ArgumentOutOfRange.
            Console.ReadKey();
        }

        private static long Silnia(byte argument)
        {
            if (argument == 0)
                return 1;

            if (argument >= 21) //Gdy przekroczono zakres long.
                throw new ArgumentOutOfRangeException();

            long result = 1;

            for (int i = 1; i < argument + 1; i++)
            {
                result = result * i;
            }

            return result;
        }
    }
}