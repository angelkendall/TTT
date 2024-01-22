namespace TicTacToe
{
    internal static class Display
    {
        public static void Board(char[] board)
        {
            Console.WriteLine();
            Console.WriteLine(
                $""" 
                 {board[0]} | {board[1]} | {board[2]}
                --------
                 {board[3]} | {board[4]} | {board[5]}
                --------
                 {board[6]} | {board[7]} | {board[8]}
                """);
        }

        public static void CurrentPlayer(char player)
        {
            Console.WriteLine($"It is {player}'s turn.");
        }

        public static void Winner(char player)
        {
            Console.WriteLine($"The winner is {player}.");
        }

        public static void Draw()
        {
            Console.WriteLine($"The game was a draw.");
        }

    }
}
