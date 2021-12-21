using System;
using System.Collections;
using System.Collections.Generic;

namespace Y2021
{
    public class Day10
    {
        private string[] syntaxErrors;

        public string[] SyntaxErrors
        {
            get { return syntaxErrors; }
            set {
                syntaxErrors = value;
                GenerateSyntaxLists();
            }
        }

        public List<char[]> IncompleteSyntaxes { get; set; }

        public List<char[]> CorruptedSyntaxes { get; set; }

        public int ComputeCorruptedScore()
        {
            int points = 0;

            foreach (char[] syntax in CorruptedSyntaxes)
            {
                points += ComputeCorruptionValue(syntax);
            }

            return points;
        }

        public int ComputeIncompleteScore()
        {
            List<int> scores = new();

            foreach (char[] syntax in IncompleteSyntaxes)
            {
                scores.Add(ComputeIncompleteValue(syntax));
            }

            scores.Sort();

            int midIndex = scores.Count / 2;

            return scores[midIndex];
        }

        private void GenerateSyntaxLists()
        {
            foreach (var item in syntaxErrors)
            {
                var x = item.ToCharArray();



                if (check)
                {
                    IncompleteSyntaxes.Add(x);
                }
                else
                {
                    CorruptedSyntaxes.Add(x);
                }
            }
        }

        private int ComputeCorruptionValue(char[] x)
        {
            Stack data = new();

            foreach (var item in x)
            {
                if (data.Count == 0)
                {
                    data.Push(item);
                }
                else
                {
                    if (item == '(' || item == '[' || item == '{' || item == '<')
                    {
                        data.Push(item);
                    }
                    else if (data.Peek().Equals('(') && item == ')')
                    {
                        data.Pop();
                    }
                    else if (data.Peek().Equals('[') && item == ']')
                    {
                        data.Pop();
                    }
                    else if (data.Peek().Equals('{') && item == '}')
                    {
                        data.Pop();
                    }
                    else if (data.Peek().Equals('<') && item == '>')
                    {
                        data.Pop();
                    }
                    else
                    {
                        return item switch
                        {
                            ')' => 3,
                            ']' => 57,
                            '}' => 1197,
                            '>' => 25137,
                            _ => 0,
                        };
                    }
                }
            }

            return 0;
        }

        private int ComputeIncompleteValue(char[] x)
        {
            int v = GetValue('x');

            return 0; 

            static int GetValue(char x)
            {
                return x switch
                {
                    ')' => 1,
                    ']' => 2,
                    '}' => 3,
                    '>' => 4,
                    _ => 0,
                };
            }
        }

    }
}
