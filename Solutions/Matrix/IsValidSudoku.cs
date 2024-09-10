namespace Matrix
{
    public class IsValidSudokuu
    {
        public bool IsValidSudoku(char[][] board)
        {
            HashSet<string> seen = new HashSet<string>();

            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    char number = board[i][j];
                    if (number != '.')
                    {
                        string rowCheck = number + "r" + i;
                        string colCheck = number + "c" + j;
                        string boxCheck = number + "b" + (i / 3) + (j / 3);
                        if (!seen.Add(rowCheck) || !seen.Add(colCheck) || !seen.Add(boxCheck))
                        {
                            return false;
                        }
                    }
                }
            }

            return true;
        }
    }
}
