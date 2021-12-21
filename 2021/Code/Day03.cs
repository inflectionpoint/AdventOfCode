using System;
using System.Collections.Generic;

namespace Y2021
{
    public class Day03
    {
        public List<string> Diagnostics { get; set; }

        //Part A:
        public int PowerConsumption { get; set; }
        public int GammaRate { get; set; }
        public int EpsilonRate { get; set; }

        //Part B:
        public int LifeSupportRating { get; set; }
        public int OxygenGeneratorRating { get; set; }
        public int ScrubberRating { get; set; }

        public int ComputePowerConsumption()
        {
            string gammaRateStr = "";      //The most common bit at each position
            string epsilonRateStr = "";    //The least common bit at each position


            for (int i = 0; i < Diagnostics[0].Length; i++)
            {
                int countOne = 0;
                int countZero = 0;

                foreach (string Diagnosis in Diagnostics)
                {
                    if (Diagnosis.Substring(i, 1) == "1")
                    {
                        countOne++;
                    }
                    else
                    {
                        countZero++;
                    }
                }

                if (countOne > countZero)
                {
                    gammaRateStr += "1";
                    epsilonRateStr += "0";
                }
                else
                {
                    gammaRateStr += "0";
                    epsilonRateStr += "1";
                }
            }

            GammaRate = Convert.ToInt32(gammaRateStr, 2);
            EpsilonRate = Convert.ToInt32(epsilonRateStr, 2);
            PowerConsumption = GammaRate * EpsilonRate;
            return PowerConsumption;
        }

        public int ComputeLifeSupportRating()
        {
            OxygenGeneratorRating = Convert.ToInt32(GetList(Diagnostics,
                GetCriteria(Diagnostics, 0, true), 0, true)[0], 2);
            ScrubberRating = Convert.ToInt32(GetList(Diagnostics,
                GetCriteria(Diagnostics, 0, false), 0, false)[0], 2);
            LifeSupportRating = OxygenGeneratorRating * ScrubberRating;
            return LifeSupportRating;
        }

        private List<string> GetList(List<string> input, string criteria, int index, bool mostCommon)
        {
            List<string> result = input.FindAll(x => x.Substring(index, 1) == criteria);
            if (result.Count > 1)
            {
                string criteriaNew = GetCriteria(result, index + 1, mostCommon);
                result = GetList(result, criteriaNew, index + 1, mostCommon);
            }
            return result;
        }

        private string GetCriteria(List<string> input, int index, bool mostCommon)
        {
            int countOne = 0;
            int countZero = 0;

            foreach (var item in input)
            {
                if (item.Substring(index, 1) == "1")
                {
                    countOne++;
                }
                else
                {
                    countZero++;
                }
            }

            if (mostCommon)
            {
                if (countOne >= countZero)
                {
                    return "1";
                }
                else
                {
                    return "0";
                }
            }
            else
            {
                if (countZero <= countOne)
                {
                    return "0";
                }
                else
                {
                    return "1";
                }
            }
        }
    }
}