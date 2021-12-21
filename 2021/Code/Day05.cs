using System;
using System.Collections.Generic;
using System.Drawing;

namespace Y2021
{
    public class Day05
    {
        public int[,] Diagram { get; set; }
        public List<(Point, Point)> Points { get; set; } = new();

        public Day05(bool isSample)
        {
            int x;
            int y;
            (x, y, Points) = DataLoader.Day05Load(isSample);

            Diagram = new int[x + 1, y + 1];

        }

        public int ComputeIntersections(bool IncludeDiagionals)
        {
            foreach (var (ptA, ptB) in Points)
            {
                //Vertical Line
                if (ptA.X == ptB.X)
                {
                    for (int i = Math.Min(ptA.Y, ptB.Y); i <= Math.Max(ptA.Y, ptB.Y); i++)
                    {
                        Diagram[ptA.X, i]++;
                    }
                }

                //Horizontal Line 
                if (ptA.Y == ptB.Y)
                {
                    for (int i = Math.Min(ptA.X, ptB.X); i <= Math.Max(ptA.X, ptB.X); i++)
                    {
                        Diagram[i, ptA.Y]++;
                    }
                }

                //45 Deg Lines (Delta X = Delta Y)
                if (Math.Abs(ptA.X - ptB.X) == Math.Abs(ptA.Y - ptB.Y) && IncludeDiagionals)
                {
                    if (ptA.X < ptB.X)
                    {
                        if (ptA.Y < ptB.Y)
                        {
                            for (int i = 0; i <= Math.Abs(ptA.X - ptB.X); i++)
                            {
                                Diagram[ptA.X + i, ptA.Y + i]++;
                            }
                        }
                        else
                        {
                            for (int i = 0; i <= Math.Abs(ptA.X - ptB.X); i++)
                            {
                                Diagram[ptA.X + i, ptA.Y - i]++;
                            }
                        }
                    }
                    else
                    {
                        if (ptA.Y < ptB.Y)
                        {
                            for (int i = 0; i <= Math.Abs(ptA.X - ptB.X); i++)
                            {
                                Diagram[ptA.X - i, ptA.Y + i]++;
                            }
                        }
                        else
                        {
                            for (int i = 0; i <= Math.Abs(ptA.X - ptB.X); i++)
                            {
                                Diagram[ptA.X - i, ptA.Y - i]++;
                            }
                        }
                    }
                }

            }

            return CountIntersects();
        }

        private int CountIntersects()
        {
            int intersects = 0;
            foreach (var item in Diagram)
            {
                if (item > 1)
                {
                    intersects++;
                }
            }

            return intersects;
        }
    }
}
