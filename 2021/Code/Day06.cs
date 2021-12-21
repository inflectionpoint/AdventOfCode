using System.Collections.Generic;

namespace Y2021
{
    public class Day06
    {
        public List<int> FishAges { get; set; } = new();

        //Brute Force Idea 1
        public int SimulatePopulation1(int days)
        {
            for (int i = 0; i < days; i++)
            {
                int Population = FishAges.Count;

                for (int j = 0; j < Population; j++)
                {
                    FishAges[j]--;

                    if (FishAges[j] == -1)
                    {
                        FishAges[j] = 6;
                        FishAges.Add(8);
                    }
                }
            }

            return FishAges.Count;
        }

        //Brute Force Idea 2 (Recursive)
        public int SimulatePopulation2(int days)
        {
            int population = 0;

            foreach (int age in FishAges)
            {
                population += ComputeFishAge(1, age, days);
            }

            return population;
        }

        //Recurisve Age Function
        private int ComputeFishAge(int count, int age, int days)
        {
            int result = count;
            int daysRemaining = days - (age + 1);

            if (daysRemaining >= 0)
            {
                result += ComputeFishAge(0, 6, daysRemaining);
                result += ComputeFishAge(1, 8, daysRemaining);
            }

            return result;
        }

        //More Intelligent Methodology
        public long SimulatePopulation(int days)
        {
            long[] population = new long[9];

            foreach (int age in FishAges)
            {
                population[age] += 1;
            }

            for (int i = 0; i < days; i++)
            {

                long[] populationNew = new long[]{
                    population[1],
                    population[2],
                    population[3],
                    population[4],
                    population[5],
                    population[6],
                    population[0] + population[7],
                    population[8],
                    population[0]
                    };

                population = populationNew;
            }

            long TotalPopulation = 0;

            foreach (var populationAtAge in population)
            {
                TotalPopulation += populationAtAge;
            }

            return TotalPopulation;
        }

    }
}