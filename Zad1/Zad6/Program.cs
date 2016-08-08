using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad6
{
    class Program
    {
        static List<int> populationT = new List<int>(new int[0]);
        static List<int> populationB = new List<int>(new int[0]);

        static void Main(string[] args)
        {
            PopulationSimulator();
            Console.ReadKey();
        }

        private static void PopulationSimulator()
        {
            int cityT = 100000;
            int cityB = 300000;

            double cityTinc = 0.03;
            double cityBinc = 0.02;

            do
            {
                cityT += Convert.ToInt32(cityT * cityTinc);
                populationT.Add(cityT);

                cityB += Convert.ToInt32(cityB * cityBinc);
                populationB.Add(cityB);
            }
            while (cityB >= cityT);

            PrintSimulation();
        }

        private static void PrintSimulation()
        {
            int currentYear = DateTime.Today.Year;

            Console.WriteLine("Year\tT city population\tB city population");

            for (int i = 0; i < populationT.Count; i++)
            {
                Console.WriteLine(currentYear + "\t" + populationT.ElementAt(i) + "\t\t\t" + populationB.ElementAt(i));
                ++currentYear;
            }
        }
    }
}
