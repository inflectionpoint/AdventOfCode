using System;
using System.Collections.Generic;
using System.Linq;

namespace Y2021
{
    public class Day07
    {
        private List<int> horizontalPositions = new();

        public List<int> HorizontalPositions
        {
            get { return horizontalPositions; }
            set {
                horizontalPositions = value;
                ComputeListProperties();
            }
        }

        public int FuelConsumptionConst { get; set; }
        public int FuelConsumptionLinear { get; set; }

        private int targetMedian = 0;
        private int targetAverage = 0;

        private void ComputeListProperties()
        {

            //List Median
            int numberCount = horizontalPositions.Count;
            int halfIndex = horizontalPositions.Count / 2;
            var sortedNumbers = horizontalPositions.OrderBy(n => n);

            if ((numberCount % 2) == 0)
            {
                targetMedian = (sortedNumbers.ElementAt(halfIndex) + sortedNumbers.ElementAt(halfIndex - 1)) / 2;
            }
            else
            {
                targetMedian = sortedNumbers.ElementAt(halfIndex);
            }

            //List Average
            double x = horizontalPositions.Average();
            targetAverage = (int)Math.Floor(x);

            //List Mode
            //targetMode = HorizontalPositions.GroupBy(n => n).
            //    OrderByDescending(g => g.Count()).
            //    Select(g => g.Key).FirstOrDefault();

        }

        public int ComputeFuelConsumptionConst()
        {
            FuelConsumptionConst = 0;

            foreach (int position in HorizontalPositions)
            {
                FuelConsumptionConst += Math.Abs(position - targetMedian);

                //int distance = Math.Abs(position - targetMedian);
                //FuelConsumptionMedian += (int)(Math.Pow(distance, 2) + distance) / 2;
            }
            return FuelConsumptionConst;
        }

        public int ComputeFuelConsumptionLinear()
        {
            int fuelConsumptionLinearA = 0;
            int fuelConsumptionLinearB = 0;
            int fuelConsumptionLinearC = 0;

            foreach (int position in HorizontalPositions)
            {
                int distanceA = Math.Abs(position - targetAverage - 1);
                int distanceB = Math.Abs(position - targetAverage);
                int distanceC = Math.Abs(position - targetAverage + 1);

                fuelConsumptionLinearA += (int)(Math.Pow(distanceA, 2) + distanceA) / 2;
                fuelConsumptionLinearB += (int)(Math.Pow(distanceB, 2) + distanceB) / 2;
                fuelConsumptionLinearC += (int)(Math.Pow(distanceC, 2) + distanceC) / 2;
            }

            FuelConsumptionLinear = Math.Min(fuelConsumptionLinearA, Math.Min(fuelConsumptionLinearB, fuelConsumptionLinearC));
            return FuelConsumptionLinear;
        }
    }
}