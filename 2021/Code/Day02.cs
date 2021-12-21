using System.Collections.Generic;

namespace Y2021
{
    public class Day02
    {
        public List<(string Direction, int Distance)> Movements { get; set; } = new();

        public int ComputeMovementSimple()
        {
            int depth = 0;
            int distance = 0;

            foreach (var (Direction, Distance) in Movements)
            {
                switch (Direction)
                {
                    case "forward":
                        distance += Distance;
                        break;
                    case "up":
                        depth -= Distance;
                        break;
                    case "down":
                        depth += Distance;
                        break;
                    default:
                        break;
                }
            }

            return depth * distance;

        }

        public int ComputeMovementComplex()
        {
            int aim = 0;
            int depth = 0;
            int distance = 0;

            foreach (var (Direction, Distance) in Movements)
            {
                switch (Direction)
                {
                    case "forward":
                        distance += Distance;
                        depth += aim * Distance;
                        break;
                    case "up":
                        aim -= Distance;
                        break;
                    case "down":
                        aim += Distance;
                        break;
                    default:
                        break;
                }
            }

            return depth * distance;
        }
    }
}
