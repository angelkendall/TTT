namespace TicTacToe
{
    internal class ConsoleInput
    {
        // Move is a number 1-9
        // Returns the number one less to allow for zero-based array useage 
        public static int GetIntMove()
        {
            Console.Write("Enter your next move (1-9): ");
            return (Convert.ToInt32(Console.ReadLine()))-1;
        }
    }
}
