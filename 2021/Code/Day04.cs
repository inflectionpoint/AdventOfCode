using System.Collections.Generic;
using System.Linq;

namespace Y2021
{
    public class Day04
    {
        public List<int> Drawings { get; set; }
        public List<BingoBoard> Boards { get; set; } = new();

        public int ComputeFirstToWinBoard()
        {
            foreach (int draw in Drawings)
            {
                foreach (BingoBoard board in Boards)
                {
                    board.CheckDraw(draw);

                    if (board.IsWinner)
                    {
                        return board.WinningNumber * board.TableSum;
                    }
                }
            }

            return 0;
        }

        public int ComputeLastToWinBoard()
        {
            int id = 0;

            foreach (int draw in Drawings)
            {
                foreach (BingoBoard board in Boards)
                {
                    if (!board.IsWinner)
                    {
                        board.CheckDraw(draw);

                        if (board.IsWinner)
                        {
                            id++;
                            board.Id = id;
                        }
                    }
                }
            }

            BingoBoard Final = Boards.Single(b => b.Id == id);

            return Final.WinningNumber * Final.TableSum;
        }
    }
}
