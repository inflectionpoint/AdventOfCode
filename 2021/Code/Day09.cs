using System.Collections.Generic;
using System.Linq;

namespace Y2021
{
    public class Day09
    {
        public List<int[]> HeightMap { get; set; } = new();

        public int ComputeRiskLevelSum()
        {
            int riskLevel = 0;

            foreach (var (row, col) in GetLowPoints())
            {
                riskLevel += HeightMap[row][col] + 1;
            }
            return riskLevel;
        }

        private List<(int, int)> GetLowPoints()
        {
            List<(int, int)> LowPoints = new();

            for (int row = 0; row <= HeightMap.Count - 1; row++)
            {
                for (int col = 0; col <= HeightMap[row].Length - 1; col++)
                {
                    //Left Column
                    if (col == 0)
                    {
                        //Top Corner
                        if (row == 0)
                        {
                            if (HeightMap[row][col] < HeightMap[row][col + 1]
                                && HeightMap[row][col] < HeightMap[row + 1][col])
                            {
                                LowPoints.Add((row, col));
                            }
                        }
                        //Btm Corner
                        else if (row == HeightMap.Count - 1)
                        {
                            if (HeightMap[row][col] < HeightMap[row][col + 1]
                                && HeightMap[row][col] < HeightMap[row - 1][col])
                            {
                                LowPoints.Add((row, col));
                            }
                        }
                        //mid edge
                        else
                        {
                            if (HeightMap[row][col] < HeightMap[row][col + 1]
                                && HeightMap[row][col] < HeightMap[row - 1][col]
                                && HeightMap[row][col] < HeightMap[row + 1][col])
                            {
                                LowPoints.Add((row, col));
                            }
                        }
                    }
                    //Right Column
                    else if (col == HeightMap[row].Length - 1)
                    {
                        //Top Corner
                        if (row == 0)
                        {
                            if (HeightMap[row][col] < HeightMap[row][col - 1]
                                && HeightMap[row][col] < HeightMap[row + 1][col])
                            {
                                LowPoints.Add((row, col));
                            }
                        }
                        //Btm Corner
                        else if (row == HeightMap.Count - 1)
                        {
                            if (HeightMap[row][col] < HeightMap[row][col - 1]
                                && HeightMap[row][col] < HeightMap[row - 1][col])
                            {
                                LowPoints.Add((row, col));
                            }
                        }
                        //mid edge
                        else
                        {
                            if (HeightMap[row][col] < HeightMap[row][col - 1]
                                && HeightMap[row][col] < HeightMap[row - 1][col]
                                && HeightMap[row][col] < HeightMap[row + 1][col])
                            {
                                LowPoints.Add((row, col));
                            }
                        }
                    }
                    //Top
                    else if (row == 0)
                    {
                        if (HeightMap[row][col] < HeightMap[row + 1][col]
                            && HeightMap[row][col] < HeightMap[row][col - 1]
                            && HeightMap[row][col] < HeightMap[row][col + 1])
                        {
                            LowPoints.Add((row, col));
                        }
                    }
                    //Btm
                    else if (row == HeightMap.Count - 1)
                    {
                        if (HeightMap[row][col] < HeightMap[row - 1][col]
                            && HeightMap[row][col] < HeightMap[row][col - 1]
                            && HeightMap[row][col] < HeightMap[row][col + 1])
                        {
                            LowPoints.Add((row, col));
                        }
                    }
                    //Center
                    else
                    {
                        if (HeightMap[row][col] < HeightMap[row - 1][col]
                            && HeightMap[row][col] < HeightMap[row + 1][col]
                            && HeightMap[row][col] < HeightMap[row][col - 1]
                            && HeightMap[row][col] < HeightMap[row][col + 1])
                        {
                            LowPoints.Add((row, col));
                        }
                    }
                }
            }

            return LowPoints;

        }

        public int ComputeBasinValue()
        {
            List<int> basins = new();

            List<(int, int)> lowPoints = GetLowPoints();

            foreach ((int x, int y) lowPoint in lowPoints)
            {
                basins.Add(ComputeBasinSize(lowPoint.x, lowPoint.y));
            }

            var basinsOrdered = basins.OrderByDescending(i => i).ToList();
            int result = 1;

            for (int i = 0; i < 3; i++)
            {
                result *= basinsOrdered[i];
            }

            return result;
        }

        private int ComputeBasinSize(int row, int col)
        {
            //TBD....
            return 0;
        }

    }
}
