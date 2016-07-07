using System;

namespace Zad5
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            GuessTheNumber();
            Console.ReadKey();
        }

        private static void GuessTheNumber()
        {
            byte number;
            byte userNumber;
            int attempt = 0;

            Random randomNumber = new Random();

            Console.WriteLine("Zagrajmy w grę...");

            do
            {
                if (attempt >= 1)
                    Console.WriteLine("Tym razem komputer Cię przechytrzył. Spróbuj jeszcze raz! :)")

                number = Convert.ToByte(randomNumber.Next(1, 10));
                Console.WriteLine("Komputer wylosował już liczbę z zakresu 1 do 10. Jaka to liczba?");
                userNumber = Convert.ToByte(Console.ReadLine());
                ++attempt;
            }
            while (number != userNumber);

            Console.WriteLine("Brawo, udało Ci się odgadnąć wylosowaną liczbę za " + attempt + " podejściem!");
        }
    }
}