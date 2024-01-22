namespace TicTacToe
{
    internal class Game
    {
        // property
        readonly Player _playerOne = new('X');
        readonly Player _playerTwo = new('O');

        readonly Board gameBoard = new();

        public Game() { }

        public void PlayGame()
        {
            Round currentRound = new(gameBoard);

            for (int i = 0; i < gameBoard.GameBoard.Length; i++)
            {
                if (i % 2 == 0) currentRound.CurrentRound(_playerOne);
                else currentRound.CurrentRound(_playerTwo);

                if (currentRound.Won == true)
                {
                    break;
                }
            }

        }

    }
}
