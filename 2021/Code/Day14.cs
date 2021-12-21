using System.Collections.Generic;
using System.Linq;

namespace Y2021
{
    public class Day14
    {
        public string PolymerTemplate { get; set; }
        public Dictionary<string, string> InsertionPairs { get; set; }


        public Day14()
        {
            //(PolymerTemplate, InsertionPairs) = DataLoader.LoadPolymerizationsSample();
            (PolymerTemplate, InsertionPairs) = DataLoader.Day14Load();
            int a = ComputePartA();
        }

        public int ComputePartA()
        {
            string polymer = GeneratePolymer(40);

            var derp = polymer.Distinct();

            int mincount = int.MaxValue;
            int maxcount = int.MinValue;

            foreach (var item in derp)
            {
                int count = polymer.ToCharArray().Count(x => x == item);
                if (count <= mincount)
                {
                    mincount = count;
                }
                if (count >= maxcount)
                {
                    maxcount = count;
                }

            }

            return maxcount - mincount;
        }


        private string GeneratePolymer(int steps)
        {
            string polymer = PolymerTemplate;
            string polymerNew = "";

            for (int i = 0; i < steps; i++)
            {
                for (int j = 0; j < polymer.Length - 1; j++)
                {
                    string pair = polymer.Substring(j, 2);
                    polymerNew += pair[0] + InsertionPairs[pair];

                    if (j == polymer.Length - 2)
                    {
                        polymerNew += pair[1];
                    }
                }
                polymer = polymerNew;
                polymerNew = "";
            }

            return polymer;

        }
    }
}
