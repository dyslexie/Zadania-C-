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
            int number;
            int userNumber;
            int attempt = 0;
            bool isConvertable = false;

            Random randomNumber = new Random();

            Console.WriteLine("Zagrajmy w grę...");

            number = randomNumber.Next(1, 10);
            Console.WriteLine("Komputer wylosował już liczbę z zakresu 1 do 10. Jaka to liczba?");

            do
            {
                isConvertable = Int32.TryParse(Console.ReadLine(), out userNumber);

                if (isConvertable == false || userNumber > 10 || userNumber < 1)
                    Console.WriteLine("Podano nieprawidłowe dane. Spróbuj jeszcze raz.");

                if (userNumber > number)
                    Console.WriteLine("Trochę mniej...");
                else if (userNumber < number)
                    Console.WriteLine("Trochę więcej...");

                ++attempt;
            }
            while (number != userNumber);

            Console.WriteLine("Brawo, udało Ci się odgadnąć wylosowaną liczbę za " + attempt + " podejściem!");
            Console.WriteLine("\nCzy chcesz zagrać jeszcze raz? \n1 - TAK; 0 - NIE\n");

            Int32.TryParse(Console.ReadLine(), out userNumber);

            if (userNumber == 1)
            {
                Console.WriteLine("");
                GuessTheNumber();
            }
        }
    }
}