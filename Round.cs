namespace TicTacToe
{
    internal class Round(Board currentBoard)
    {
        readonly Board _board = currentBoard;

        // For stopping the game if a win has occurred before draw
        public bool Won { get; private set; } = false;

        public void CurrentRound(Player currentPlayer)
        {
            Display.Board(_board.GameBoard);
            Display.CurrentPlayer(currentPlayer.Symbol);

            while (true)
            {
                int move = ConsoleInput.GetIntMove();

                if (_board.CheckValidMove(move))
                {
                    _board.UpdateBoard(move, currentPlayer.Symbol);
                    break;
                }
            }

            if (_board.CheckForWinner())
            {
                Display.Board(_board.GameBoard);
                Display.Winner(currentPlayer.Symbol);
                Won = true;
            }
            else if (_board.CheckForDraw()) Display.Draw();

        }
    }

}

