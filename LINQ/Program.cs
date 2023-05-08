using System.Security.Cryptography;
using System.Linq;

namespace LINQ
{
    public class Program
    {
        static void Main(string[] args)
        {
            var videoGames = new List<string> { "CALL OF DUTY", "Mafia", "Mario", "RedFall" };

            var sortedGames = videoGames.OrderBy(g => g.Length);

            foreach (var game in sortedGames)
            {
                Console.WriteLine(game);
            }
        }
    }
}

