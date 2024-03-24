namespace Tic_Tac_Toe
{
    internal class RunTime
    {
        static void Main()
        {
            Menu mainMenu = new("Main Menu",
                new KeyValuePair<string, Action>("option 1", () => Console.WriteLine("1")),
                new KeyValuePair<string, Action>("option 2", () => Console.WriteLine("2")),
                new KeyValuePair<string, Action>("option 3", () => Console.WriteLine("3")));
            Game game = new();
        }
    }
}