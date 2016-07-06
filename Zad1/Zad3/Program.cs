using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad3
{
    class Program
    {
        static void Main(string[] args)
        {
            int amount = 15000;
            Console.WriteLine("Podatek od kwoty " + amount + " wynosi: " + CountTax(amount));
            Console.ReadKey();
        }

        private static double CountTax(int amount)
        {
            double result;

            if (amount < 10000)
            {
                result = 0.1 * amount;
            }
            else if (amount > 30000)
            {
                result = 0.2 * amount;
            }
            else
                result = 0.15 * amount;

            return result;
        }
    }
}
