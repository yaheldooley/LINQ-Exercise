namespace LINQ
{
    public class Program
    {
        static void Main(string[] args)
        {
            var videoGames = new List<string>() {
            "Tetris",
            "Minecraft",
            "Pac-Man",
            "Dig Dug",
            "Civilization",
            };

            var sortedGames = videoGames.OrderBy(name => name);
            foreach (string game in sortedGames) Console.WriteLine($"{game}");
        }
    }
}
