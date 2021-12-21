using System.Collections.Generic;

namespace Y2021
{
    public class Day01
    {
        public List<int> Soundings { get; set; } = new();

        public int ComputeCountIncreaseSimple()
        {
            int lastDepth = int.MaxValue;
            int countIncrease = 0;

            foreach (int depth in Soundings)
            {
                if (depth > lastDepth)
                {
                    countIncrease++;
                }

                lastDepth = depth;
            }
            return countIncrease;
        }

        public int ComputeCountIncreaseWindow()
        {
            int lastDepth = int.MaxValue;
            int countIncrease = 0;

            for (int i = 1; i < Soundings.Count - 1; i++)
            {
                int depth = Soundings[i - 1] + Soundings[i] + Soundings[i + 1];

                if (depth > lastDepth)
                {
                    countIncrease++;
                }

                lastDepth = depth;
            }

            return countIncrease;
        }
    }
}
