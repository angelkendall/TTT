namespace TicTacToe
{
    internal class Board
    {
        public char[] GameBoard { get; } = new char[9];

        public bool CheckValidMove(int move)
        {
            if (GameBoard[move] == '\0') return true;
            
            return false;
        }

        public void UpdateBoard(int move, char playerSymbol)
        {
            GameBoard[move] = playerSymbol;
        }

        public bool CheckForWinner()
        {
            bool hasNonNullValue = GameBoard.Any(c => c != '\0');

            if (hasNonNullValue)
            {
                // First row
                if (GameBoard[0] != '\0' && GameBoard[0] == GameBoard[1] && GameBoard[1] == GameBoard[2]) return true;

                // Left col
                else if (GameBoard[0] != '\0' && GameBoard[0] == GameBoard[3] && GameBoard[3] == GameBoard[6]) return true;

                // Right col
                else if (GameBoard[2] != '\0' && GameBoard[2] == GameBoard[5] && GameBoard[5] == GameBoard[8]) return true;

                // Bottom row
                else if (GameBoard[6] != '\0' && GameBoard[6] == GameBoard[7] && GameBoard[7] == GameBoard[8]) return true;

                // Middle Row
                else if (GameBoard[3] != '\0' && GameBoard[3] == GameBoard[4] && GameBoard[4] == GameBoard[5]) return true;

                // Middle col
                else if (GameBoard[1] != '\0' && GameBoard[1] == GameBoard[4] && GameBoard[4] == GameBoard[7]) return true;

                // Right start Diagonal 
                else if (GameBoard[2] != '\0' && GameBoard[2] == GameBoard[4] && GameBoard[4] == GameBoard[6]) return true;

                // Left start Diagonal 
                else if (GameBoard[0] != '\0' && GameBoard[0] == GameBoard[4] && GameBoard[4] == GameBoard[8]) return true;

            }

            return false;
        }

        public bool CheckForDraw()
        {
            int total = 0;
            for (int i = 0; i < GameBoard.Length; i++)
            {
                if (GameBoard[i] != '\0') total++;
            }

            if (total == GameBoard.Length) return true;

            return false;
        }

    }
}

