namespace Y2021
{
    public class BingoBoard
    {
        public int Id { get; set; }

        public (int num, bool drawn)[,] Table { get; set; }
        public int TableSum { get; set; }
        public bool IsWinner { get; set; }
        public int WinningNumber { get; set; }

        public BingoBoard((int, bool)[,] table)
        {
            Table = table;
            foreach (var (num, _) in table)
            {
                TableSum += num;
            }
        }

        public void CheckDraw(int draw)
        {
            if (!IsWinner)
            {
                for (int i = 0; i < Table.GetLength(0); i++)
                {
                    for (int j = 0; j < Table.GetLength(1); j++)
                    {
                        if (Table[i, j].num == draw)
                        {
                            TableSum -= draw;
                            Table[i, j].drawn = true;
                        }
                    }
                }

                CheckForWin();

                if (IsWinner)
                {
                    WinningNumber = draw;

                }
            }
        }

        private void CheckForWin()
        {
            int counterRow;
            int counterCol;

            for (int i = 0; i < 5; i++)
            {
                counterRow = 0;
                counterCol = 0;

                for (int j = 0; j < 5; j++)
                {
                    if (Table[i, j].drawn == true)
                    {
                        counterRow++;
                    }
                    if (Table[j, i].drawn == true)
                    {
                        counterCol++;
                    }
                }

                if (counterCol == 5 || counterRow == 5)
                {
                    IsWinner = true;
                    return;
                }
            }
        }
    }
}