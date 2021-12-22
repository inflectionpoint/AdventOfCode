using System;

namespace Y2021
{
    class Program
    {
        static void Main(string[] args)
        {
            string action = "";
            while (action != "X")
            {
                Console.WriteLine("Enter the Day number you would like to run or Exit with X:");
                action = Console.ReadLine();
                if (action.ToUpper() == "X")
                {
                    return;
                }
                else
                {
                    try
                    {
                        switch (int.Parse(action))
                        {
                            case 1:
                                Day01 D1 = new();
                                D1.Soundings = DataLoader.D01Load();
                                Console.WriteLine("Part A | Simple Soundings Count: {0}", D1.ComputeCountIncreaseSimple());
                                Console.WriteLine("Part B | Window Soundings Count: {0}", D1.ComputeCountIncreaseWindow());
                                Console.WriteLine();
                                break;
                            case 2:
                                Day02 D2 = new();
                                D2.Movements = DataLoader.D02Load();
                                Console.WriteLine("Part A | Simple Position: {0}", D2.ComputeMovementSimple());
                                Console.WriteLine("Part B | Complex Position: {0}", D2.ComputeMovementComplex());
                                Console.WriteLine();
                                break;
                            case 3:
                                Day03 D3 = new();
                                D3.Diagnostics = DataLoader.D03Load();
                                Console.WriteLine("Part A | Power Consumption Rating: {0}", D3.ComputeLifeSupportRating());
                                Console.WriteLine("Part B | Life Support Rating: {0}", D3.ComputeLifeSupportRating());
                                Console.WriteLine();
                                break;
                            case 4:
                                Day04 D4 = new();
                                (D4.Drawings, D4.Boards) = DataLoader.D04Load(false);
                                Console.WriteLine("Part A | First To Win Board Score: {0}", D4.ComputeFirstToWinBoard());
                                (D4.Drawings, D4.Boards) = DataLoader.D04Load(false);
                                Console.WriteLine("Part B | Last To Win Board Score: {0}", D4.ComputeLastToWinBoard());
                                Console.WriteLine();
                                break;
                            case 5:
                                Day05 D5 = new(false);
                                Console.WriteLine("Part A | Line Intersections: {0}", D5.ComputeIntersections(false));
                                Console.WriteLine("Part B | Line Intersections: {0}", D5.ComputeIntersections(true));
                                Console.WriteLine();
                                break;
                            case 6:
                                Day06 D6 = new();
                                D6.FishAges = DataLoader.Day06Load();
                                Console.WriteLine("Part A | Total Fish Population: {0}", D6.SimulatePopulation(80));
                                Console.WriteLine("Part B | Total Fish Population: {0}", D6.SimulatePopulation(256));
                                Console.WriteLine();
                                break;
                            case 7:
                                Day07 D7 = new();
                                D7.HorizontalPositions = DataLoader.Day07Load();
                                Console.WriteLine("Part A | Constant Fuel Consumption: {0}", D7.ComputeFuelConsumptionConst());
                                Console.WriteLine("Part B | Linear Fuel Consumption: {0}", D7.ComputeFuelConsumptionLinear());
                                Console.WriteLine();
                                break;
                            case 8:
                                Day08 D8 = new();
                                (D8.InputSignals, D8.OutputSignals) = DataLoader.Day08Load(false);
                                Console.WriteLine("Part A | Digits 1,4,7,8 appear: {0}", D8.CountOutputDigits());
                                Console.WriteLine("Part B | Decoded Output Sum: {0}", D8.SumDecodedOutputs());
                                Console.WriteLine();
                                break;
                            case 9:
                                Day09 D9 = new();
                                D9.HeightMap = DataLoader.Day09Load();
                                Console.WriteLine("Part A | Risk Level: {0}", D9.ComputeRiskLevelSum());
                                Console.WriteLine("Part B | TBD: {0}", 0);
                                Console.WriteLine();
                                break;
                            case 10:
                                Day10 D10 = new();
                                D10.SyntaxErrors = DataLoader.Day10Load();
                                Console.WriteLine("Part A | Corrupted Syntax Points: {0}", D10.ComputeCorruptedScore());
                                Console.WriteLine("Part B | Incomplete Syntax Points: {0}", D10.ComputeIncompleteScore());
                                Console.WriteLine();
                                break;
                            case 11:
                                Day11 D11 = new();
                                D11.OctopusEnergies = DataLoader.Day11Load(false);
                                Console.WriteLine("Not Yet Completed.");
                                Console.WriteLine("Part A | TBD: {0}", 0);
                                Console.WriteLine("Part B | TBD: {0}", 0);
                                Console.WriteLine();
                                break;
                            case 12:
                                Day12 D12 = new();
                                Console.WriteLine("Not Yet Completed.");
                                Console.WriteLine("Part A | TBD: {0}", 0);
                                Console.WriteLine("Part B | TBD: {0}", 0);
                                Console.WriteLine();
                                break;
                            case 13:
                                Day13 D13 = new();
                                Console.WriteLine("Not Yet Completed.");
                                Console.WriteLine("Part A | TBD: {0}", 0);
                                Console.WriteLine("Part B | TBD: {0}", 0);
                                Console.WriteLine();
                                break;
                            case 14:
                                Day14 D14 = new();
                                Console.WriteLine("Not Yet Completed.");
                                Console.WriteLine("Part A | TBD: {0}", 0);
                                Console.WriteLine("Part B | TBD: {0}", 0);
                                Console.WriteLine();
                                break;
                            case 15:
                                Day15 D15 = new();
                                Console.WriteLine("Not Yet Completed.");
                                Console.WriteLine("Part A | TBD: {0}", 0);
                                Console.WriteLine("Part B | TBD: {0}", 0);
                                Console.WriteLine();
                                break;
                            case 16:
                                Day16 D16 = new();
                                Console.WriteLine("Not Yet Completed.");
                                Console.WriteLine("Part A | TBD: {0}", 0);
                                Console.WriteLine("Part B | TBD: {0}", 0);
                                Console.WriteLine();
                                break;
                            case 17:
                                Day17 D17 = new();
                                Console.WriteLine("Not Yet Completed.");
                                Console.WriteLine("Part A | TBD: {0}", 0);
                                Console.WriteLine("Part B | TBD: {0}", 0);
                                Console.WriteLine();
                                break;
                            case 18:
                                Day18 D18 = new();
                                Console.WriteLine("Not Yet Completed.");
                                Console.WriteLine("Part A | TBD: {0}", 0);
                                Console.WriteLine("Part B | TBD: {0}", 0);
                                Console.WriteLine();
                                break;
                            case 19:
                                Day19 D19 = new();
                                Console.WriteLine("Not Yet Completed.");
                                Console.WriteLine("Part A | TBD: {0}", 0);
                                Console.WriteLine("Part B | TBD: {0}", 0);
                                Console.WriteLine();
                                break;
                            case 20:
                                Day20 D20 = new();
                                Console.WriteLine("Not Yet Completed.");
                                Console.WriteLine("Part A | TBD: {0}", 0);
                                Console.WriteLine("Part B | TBD: {0}", 0);
                                Console.WriteLine();
                                break;
                            case 21:
                                Day21 D21 = new();
                                Console.WriteLine("Not Yet Completed.");
                                Console.WriteLine("Part A | TBD: {0}", 0);
                                Console.WriteLine("Part B | TBD: {0}", 0);
                                Console.WriteLine();
                                break;
                            case 22:
                                Day22 D22 = new();
                                Console.WriteLine("Not Yet Completed.");
                                Console.WriteLine("Part A | TBD: {0}", 0);
                                Console.WriteLine("Part B | TBD: {0}", 0);
                                Console.WriteLine();
                                break;
                            case 23:
                                Day23 D23 = new();
                                Console.WriteLine("Not Yet Completed.");
                                Console.WriteLine("Part A | TBD: {0}", 0);
                                Console.WriteLine("Part B | TBD: {0}", 0);
                                Console.WriteLine();
                                break;
                            case 24:
                                Day24 D24 = new();
                                Console.WriteLine("Not Yet Completed.");
                                Console.WriteLine("Part A | TBD: {0}", 0);
                                Console.WriteLine("Part B | TBD: {0}", 0);
                                Console.WriteLine();
                                break;
                            case 25:
                                Day25 D25 = new();
                                Console.WriteLine("Not Yet Completed.");
                                Console.WriteLine("Part A | TBD: {0}", 0);
                                Console.WriteLine("Part B | TBD: {0}", 0);
                                Console.WriteLine();
                                break;
                            default:
                                Console.WriteLine("Number must be between 1 - 25");
                                break;
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex);
                    }
                }
            } 
        }
    }
}
