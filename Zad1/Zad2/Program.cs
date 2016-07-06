using System;

namespace Zad2
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int[] tablica = new int[10];
            tablica = CiagFibonacciego(tablica);

            int j = 0;

            foreach (int i in tablica)
            {
                Console.WriteLine("tablica[" + j + "] = " + i);
                j++;
            }

            Console.ReadKey();
        }

        private static int[] CiagFibonacciego(int[] tab)
        {
            int[] tabFibonacci = new int[tab.Length];

            for (int i = 0; i < tab.Length; i++)
            {
                if (i > 1)
                {
                    tabFibonacci[i] = tabFibonacci[i - 1] + tabFibonacci[i - 2];
                    continue;
                }

                if (i == 0)
                    tabFibonacci[i] = 0;

                if (i == 1)
                    tabFibonacci[i] = 1;
            }

            return tabFibonacci;
        }
    }
}