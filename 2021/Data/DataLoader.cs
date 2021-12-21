using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;

namespace Y2021
{
    public class DataLoader
    {
        //Day 01
        public static List<int> D01Load()
        {
            string[] lines = File.ReadAllLines(@"C:\Users\APK\source\repos\DayOne\DayOne\Data\Day01.txt");
            List<int> data = new();

            foreach (string line in lines)
            {
                data.Add(item: int.Parse(line));
            }

            return data;
        }
        public static List<int> D01Sample()
        {
            List<int> data = new() { 199, 200, 208, 210, 200, 207, 240, 269, 260, 263 };
            return data;
        }

        //Day 02
        public static List<(string, int)> D02Load()
        {
            string[] lines = File.ReadAllLines(@"C:\Users\APK\source\repos\DayOne\DayOne\Data\Day02.txt");
            List<(string, int)> data = new();

            foreach (string line in lines)
            {
                string[] info = line.Split(" ");
                data.Add((info[0], int.Parse(info[1])));
            }

            return data;
        }
        public static List<(string, int)> D02Sample()
        {
            List<(string, int)> data = new()
            {
                ("forward", 5),
                ("down", 5),
                ("forward", 8),
                ("up", 3),
                ("down", 8),
                ("forward", 2)
            };
            return data;
        }

        //Day 03
        public static List<string> D03Load()
        {
            string[] lines = File.ReadAllLines(@"C:\Users\APK\source\repos\DayOne\DayOne\Data\Day03.txt");
            List<string> data = new();

            foreach (string line in lines)
            {
                data.Add(line);
            }

            return data;
        }        
        public static List<string> D03Sample()
        {
            List<string> data = new() 
            {
                "00100",
                "11110",
                "10110",
                "10111",
                "10101",
                "01111",
                "00111",
                "11100",
                "10000",
                "11001",
                "00010",
                "01010"
            };

            return data;
        }

        //Day 04
        public static (List<int>, List<BingoBoard>) D04Load(bool isSample)
        {
            List<int> drawings = new();
            List<BingoBoard> boards = new();
            string[] data;

            if (isSample)
            {
                data = File.ReadAllLines(@"C:\Users\APK\source\repos\DayOne\DayOne\Data\Day04Sample.txt");
            }
            else
            {
                data = File.ReadAllLines(@"C:\Users\APK\source\repos\DayOne\DayOne\Data\Day04.txt");
            }

            foreach (var item in data[0].Split(","))
            {
                drawings.Add(int.Parse(item));
            }

            List<string[]> datasplit = new();

            foreach (var item in data)
            {
                if (item.Length > 1 && item.Length < 50)
                {
                    datasplit.Add(item.Split(" ", StringSplitOptions.RemoveEmptyEntries));

                    if (datasplit.Count == 5)
                    {
                        (int, bool)[,] board = new (int, bool)[5, 5];

                        for (int i = 0; i < 5; i++)
                        {
                            for (int j = 0; j < 5; j++)
                            {
                                board[i, j] = (int.Parse(datasplit[i][j]), false);
                            }
                        }

                        BingoBoard B = new(board);
                        boards.Add(B);
                        datasplit.Clear();
                    }
                }
            }

            return (drawings, boards);
        }

        //Day 05
        public static (int, int, List<(Point, Point)>) Day05Load(bool isSample)
        {
            List<(Point, Point)> Points = new();
            string[] data;

            if (isSample)
            {
                data = File.ReadAllLines(@"C:\Users\APK\source\repos\DayOne\DayOne\Data\Day05Sample.txt");
            }
            else
            {
                data = File.ReadAllLines(@"C:\Users\APK\source\repos\DayOne\DayOne\Data\Day05.txt");
            }

            int SizeX = 0;
            int SizeY = 0;

            foreach (var item in data)
            {
                var x = item.Split(" -> ");
                var y = x[0].Split(",");
                var p1 = new Point(int.Parse(y[0]), int.Parse(y[1]));
                if (p1.X > SizeX)
                {
                    SizeX = p1.X;
                }
                if (p1.Y > SizeY)
                {
                    SizeY = p1.Y;
                }

                var z = x[1].Split(",");
                var p2 = new Point(int.Parse(z[0]), int.Parse(z[1]));
                if (p2.X > SizeX)
                {
                    SizeX = p2.X;
                }
                if (p2.Y > SizeY)
                {
                    SizeY = p2.Y;
                }

                Points.Add((p1, p2));
            }

            return (SizeX, SizeY, Points);
        }

        //Day 06
        public static List<int> Day06Load()
        {
            string[] lines = File.ReadAllLines(@"C:\Users\APK\source\repos\DayOne\DayOne\Data\Day06.txt");
            List<int> data = new();

            foreach (var item in lines[0].Split(","))
            {
                data.Add(int.Parse(item));
            }

            return data;
        }
        public static List<int> Day06Sample()
        {
            return new List<int>() { 3, 4, 3, 1, 2 };
        }

        //Day 07
        public static List<int> Day07Load()
        {
            string[] lines = File.ReadAllLines(@"C:\Users\APK\source\repos\DayOne\DayOne\Data\Day07.txt");
            List<int> data = new();

            foreach (var item in lines[0].Split(","))
            {
                data.Add(int.Parse(item));
            }

            return data;
        }
        public static List<int> Day07Sample()
        {
            return new List<int>() { 16, 1, 2, 0, 4, 2, 7, 1, 2, 14 };
        }
        
        //Day 08
        public static (List<string>, List<string>) Day08Load(bool isSample)
            {
                List<string> dataI = new();
                List<string> dataO = new();

                string[] lines;
                if (isSample)
                {
                    lines = File.ReadAllLines(@"C:\Users\APK\source\repos\DayOne\DayOne\Data\Day08Sample.txt");
                }
                else
                {
                    lines = File.ReadAllLines(@"C:\Users\APK\source\repos\DayOne\DayOne\Data\Day08.txt");
                }

                foreach (var item in lines)
                {
                    string[] x = item.Split("|", StringSplitOptions.TrimEntries);
                    dataI.Add(x[0].ToString());
                    dataO.Add(x[1].ToString());
                }

                return (dataI, dataO);
            }

        //Day 09
        public static List<int[]> Day09Load()
        {
            string[] lines = File.ReadAllLines(@"C:\Users\APK\source\repos\DayOne\DayOne\Data\Day09.txt");

            List<int[]> nums = new();

            foreach (var item in lines)
            {
                nums.Add(Array.ConvertAll(item.ToCharArray(), c => (int)char.GetNumericValue(c)));
            }

            return nums;
        }
        public static List<int[]> Day09Sample()
        {
            List<int[]> data = new();

            data.Add(Array.ConvertAll("2199943210".ToCharArray(), c => (int)char.GetNumericValue(c)));
            data.Add(Array.ConvertAll("3987894921".ToCharArray(), c => (int)char.GetNumericValue(c)));
            data.Add(Array.ConvertAll("9856789892".ToCharArray(), c => (int)char.GetNumericValue(c)));
            data.Add(Array.ConvertAll("8767896789".ToCharArray(), c => (int)char.GetNumericValue(c)));
            data.Add(Array.ConvertAll("9899965678".ToCharArray(), c => (int)char.GetNumericValue(c)));

            return data;
        }

        //Day 10
        public static string[] Day10Load()
        {
            return File.ReadAllLines(@"C:\Users\APK\source\repos\DayOne\DayOne\Data\Day10.txt");
        }
        public static string[] Day10Sample()
        {
            return new string[]
            {
                "[({(<(())[]>[[{[]{<()<>>",
                "[(()[<>])]({[<{<<[]>>(",
                "{([(<{}[<>[]}>{[]{[(<()>",
                "(((({<>}<{<{<>}{[]{[]{}",
                "[[<[([]))<([[{}[[()]]]",
                "[{[{({}]{}}([{[{{{}}([]",
                "{<[[]]>}<{[{[{[]{()[[[]",
                "[<(<(<(<{}))><([]([]()",
                "<{([([[(<>()){}]>(<<{{",
                "<{([{{}}[<[[[<>{}]]]>[]]"
            };
        }

        //Day 11
        public static int[,] Day11Load(bool isSample)
        {
            int[,] data = new int[10,10];
            string[] lines;

            if (isSample)
            {
                lines = File.ReadAllLines(@"C:\Users\APK\source\repos\DayOne\DayOne\Data\Day11.txt");
            }
            else
            {
                lines = File.ReadAllLines(@"C:\Users\APK\source\repos\DayOne\DayOne\Data\Day11Sample.txt");
            }

            for (int i = 0; i < lines.Length; i++)
            {
                int[] line = Array.ConvertAll(lines[i].ToCharArray(), c => (int)char.GetNumericValue(c));

                for (int j = 0; j < line.Length; i++)
                {
                    data[i, j] = line[j];
                }
            }

            return data;
        }

        //Day 12

        //Day 13

        //Day 14
        public static (string, Dictionary<string, string>) Day14Load()
        {
            string[] data = File.ReadAllLines(@"C:\Users\APK\source\repos\DayOne\DayOne\Data\Day14.txt");

            string intital = data[0];
            Dictionary<string, string> info = new();

            for (int i = 2; i < data.Length; i++)
            {
                var line = data[i].Split(" -> ");
                info.Add(line[0], line[1]);
            }

            return (intital, info);

        }
        public static (string, Dictionary<string, string>) Day14Sample()
        {
            string intital = "NNCB";
            Dictionary<string, string> info = new()
            {
                {
                    "CH",
                    "B"
                },
                {
                    "HH",
                    "N"
                },
                {
                    "CB",
                    "H"
                },
                {
                    "NH",
                    "C"
                },
                {
                    "HB",
                    "C"
                },
                {
                    "HC",
                    "B"
                },
                {
                    "HN",
                    "C"
                },
                {
                    "NN",
                    "C"
                },
                {
                    "BH",
                    "H"
                },
                {
                    "NC",
                    "B"
                },
                {
                    "NB",
                    "B"
                },
                {
                    "BN",
                    "B"
                },
                {
                    "BB",
                    "N"
                },
                {
                    "BC",
                    "B"
                },
                {
                    "CC",
                    "N"
                },
                {
                    "CN",
                    "C"
                }
            };

            return (intital, info);

        }

        //Day 15

        //Day 16

        //Day 17

        //Day 18

        //Day 19

        //Day 20

        //Day 21

        //Day 22

        //Day 23

        //Day 24

        //Day 25
    
    }
}
