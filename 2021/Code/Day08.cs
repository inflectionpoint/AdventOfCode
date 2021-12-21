using System;
using System.Collections.Generic;
using System.Linq;

namespace Y2021
{
    public class Day08
    {
        public List<string> InputSignals { get; set; }
        public List<string> OutputSignals { get; set; }

        public int CountOutputDigits()
        {
            int digitCounter = 0;

            foreach (string output in OutputSignals)
            {
                string[] digits = output.Split(" ");
                foreach (var digit in digits)
                {
                    int x = digit.Length;
                    if (x == 2 || x == 3 || x == 4 || x == 7)
                    {
                        digitCounter += 1;
                    }
                }
            }

            return digitCounter;
        }

        private Dictionary<char, string> MapWires(string input)
        {
            Dictionary<char, string> wiremap = new();

            char[] one = null;
            char[] four = null;
            char[] seven = null;
            char[] eight = null;

            char[] ADG = null;
            char[] ABFG = null;

            List<string> digits = input.Split(" ").ToList();

            var result = digits.GroupBy(x => x.Length).OrderBy(y => y.Key).ToList();

            //foreach (var digit in digits.OrderBy(x => x.Length))
            foreach (var item in result)
            {
                switch (item.Key)
                {
                    case 2:
                        //#1 - Segments C,F
                        one = item.ToList()[0].ToCharArray();
                        Array.Sort(one);
                        break;
                    case 3:
                        //#7 - Segments A,C,F - Common "One"
                        seven = item.ToList()[0].ToCharArray();
                        Array.Sort(seven);
                        break;
                    case 4:
                        //#4 - Segments B,C,D,F - Common "one"
                        four = item.ToList()[0].ToCharArray();
                        Array.Sort(four);
                        break;
                    case 5:
                        //#2,3,5 - Segments A,D,G Common 
                        foreach (var digit in item.ToList().Distinct())
                        {
                            if (ADG == null)
                            {
                                ADG = digit.ToCharArray();
                            }
                            else
                            {
                                ADG = ADG.Intersect(digit.ToCharArray()).ToArray();
                            }
                        }
                        Array.Sort(ADG);
                        break;
                    case 6:
                        //#0,6,9 - Segements A,B,F,G Common
                        foreach (var digit in item.ToList())
                        {
                            if (ABFG == null)
                            {
                                ABFG = digit.ToCharArray();
                            }
                            else
                            {
                                ABFG = ABFG.Intersect(digit.ToCharArray()).ToArray();
                            }
                        }
                        Array.Sort(ABFG);
                        break;
                    case 7:
                        //#8 - Segments A,B,C,D,E,F,G
                        eight = item.ToList()[0].ToCharArray();
                        Array.Sort(eight);
                        break;
                    default:
                        break;
                }

            }

            wiremap.Add(seven.Except(one).First(), "A");                     //ok
            wiremap.Add(ABFG.Intersect(four.Except(one)).First(), "B");      //ok
            wiremap.Add(one.Except(ABFG).First(), "C");                      //ok
            wiremap.Add(ADG.Except(ABFG).First(), "D");                      //ok
            wiremap.Add(eight.Except(ABFG.Concat(four)).First(), "E");       //ok
            wiremap.Add(ABFG.Intersect(one).First(), "F");                   //ok
            wiremap.Add(ADG.Except(four.Concat(seven)).First(), "G");        //ok

            return wiremap;
        }

        private int Decode(string input, string output)
        {
            int number = 0;

            Dictionary<char, string> mapping = MapWires(input);

            int place = 1000;
            foreach (var item in output.Split(" "))
            {
                string segments = "";
                var x = item.ToCharArray();
                foreach (var letter in x)
                {
                    segments += mapping[letter];
                }
                var y = segments.ToCharArray();
                Array.Sort(y);
                segments = new string(y);

                int digit;
                switch (segments)
                {
                    case "ABCEFG":
                        digit = 0;
                        break;
                    case "CF":
                        digit = 1;
                        break;
                    case "ACDEG":
                        digit = 2;
                        break;
                    case "ACDFG":
                        digit = 3;
                        break;
                    case "BCDF":
                        digit = 4;
                        break;
                    case "ABDFG":
                        digit = 5;
                        break;
                    case "ABDEFG":
                        digit = 6;
                        break;
                    case "ACF":
                        digit = 7;
                        break;
                    case "ABCDEFG":
                        digit = 8;
                        break;
                    case "ABCDFG":
                        digit = 9;
                        break;
                    default:
                        throw new Exception();
                }
                number += digit * place;
                place /= 10;
            }

            return number;
        }

        public int SumDecodedOutputs()
        {
            int sum = 0;
            for (int i = 0; i < InputSignals.Count; i++)
            {
                sum += Decode(InputSignals[i], OutputSignals[i]);
            }

            return sum;
        }
    }
}