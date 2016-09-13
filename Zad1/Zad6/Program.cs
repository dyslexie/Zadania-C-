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
            City cityT = new City();

            cityT.population = 100000;
            cityT.populationIncrease = 0.03;

            City cityB = new City();

            cityB.population = 300000;
            cityB.populationIncrease = 0.02;

            do
            {
                cityT.population += Convert.ToInt32(cityT.population * cityT.populationIncrease);
                populationT.Add(cityT.population);

                cityB.population += Convert.ToInt32(cityB.population * cityB.populationIncrease);
                populationB.Add(cityB.population);
            }
            while (cityB.population >= cityT.population);

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

    public class City
    {
        public int population { get; set; }
        public double populationIncrease { get; set; }
    }
}
