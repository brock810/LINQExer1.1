using System.Security.Cryptography;
using System.Linq;

namespace LINQ
{
    public class Program
    {
        static void Main(string[] args)
        {
            var videoGames = new List<string> { "CALL OF DUTY", "Mafia", "Mario", "RedFall" };

            var letters = new List<int>() { 10, 5, 5, 6 };

            var sorted = letters.OrderBy(letters => letters).ToList();
            
            letters.Sort();

            foreach (var letter in sorted)
            {
                Console.WriteLine(letter.ToString());
            }

        }
    }
}
