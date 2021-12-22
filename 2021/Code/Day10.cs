using System.Collections;
using System.Collections.Generic;

namespace Y2021
{
    public class Day10
    {
        private readonly Dictionary<char, int> INCOMPLETE = new()
        {
            { '(', 1 },
            { '[', 2 },
            { '{', 3 },
            { '<', 4 },
        };

        private readonly Dictionary<char, int> CORRUPT = new()
        {
            { ')', 3 },
            { ']', 57 },
            { '}', 1197 },
            { '>', 25137 },
        };
        
        private string[] syntaxes;
        public string[] Syntaxes 
        { 
            get => syntaxes;
            set {
                syntaxes = value;
                ComputeCorruptedScore();
                }
        }

        public long CorruptScore { get; set; } = 0;
        public long IncompleteScore { get; set; } = 0;

        private void ComputeCorruptedScore()
        {
            List<long> IncompletePoints = new();

            foreach (string syntax in syntaxes)
            {
                (bool isError, long score) = ComputeSyntaxValue(syntax.ToCharArray());
                if (isError)
                {
                    CorruptScore += score;
                }
                else
                {
                    IncompletePoints.Add(score);
                }
            }
            
            IncompletePoints.Sort();

            int midIndex = IncompletePoints.Count / 2;

            IncompleteScore = IncompletePoints[midIndex];
        }

        private (bool, long) ComputeSyntaxValue(char[] x)
        {
            Stack data = new();

            for (int i = 0; i < x.Length; i++)
            {
                if (data.Count == 0)
                {
                    data.Push(x[i]);
                }
                else
                {
                    if (x[i] == '(' || x[i] == '[' || x[i] == '{' || x[i] == '<')
                    {
                        data.Push(x[i]);
                    }
                    else if (data.Peek().Equals('(') && x[i] == ')')
                    {
                        data.Pop();
                    }
                    else if (data.Peek().Equals('[') && x[i] == ']')
                    {
                        data.Pop();
                    }
                    else if (data.Peek().Equals('{') && x[i] == '}')
                    {
                        data.Pop();
                    }
                    else if (data.Peek().Equals('<') && x[i] == '>')
                    {
                        data.Pop();
                    }
                    else
                    {
                        return (true, CORRUPT[x[i]]);
                    }
                }
            }

            long score = 0;

            while (data.Count != 0)
            {
                score = score * 5 + INCOMPLETE[(char)data.Pop()];
            }

            return (false, score);
        }
    }
}
