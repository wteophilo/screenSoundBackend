using ScreenSoundBackend.Models;

namespace ScreenSoundBackend.Menus;

internal class EvaluateAlbum : Menu
{
    public override void Execute(Dictionary<string, Band> bands)
    {
        base.Execute(bands);
        ShowPageTitle("Evaluate Album");
        Console.Write("What band do you want to evaluate: ");
        string bandName = Console.ReadLine()!;
        if (bands.TryGetValue(bandName, out Band? foundedBand))
        {
            Console.Write("What album do you want do evaluate: ");
            string searchedAlbum = Console.ReadLine()!;
            if (foundedBand.Albums.Any(a => a.Name.Equals(searchedAlbum)))
            {
                Console.Write("Enter your evaluation (1-10): ");
                string text = Console.ReadLine()!;
                try
                {
                    Album foundedAlbum = foundedBand.Albums.First(a => a.Name.Equals(searchedAlbum));
                    Evaluate evaluation = Evaluate.Parse(text);
                    foundedAlbum.AddEvaluation(evaluation);
                    Console.WriteLine($"The evaluation {evaluation.Score} was added to {foundedAlbum.Name}!");
                }
                catch (Exception ex) when (ex is FormatException or ArgumentException or OverflowException)
                {
                    Console.WriteLine("Invalid input. Please enter a valid number between 0 and 10.");
                }
            }
            else
            {
                Console.WriteLine($"Album {searchedAlbum} not found.");
            }
        }
        else
        {
            Console.WriteLine($"Band {bandName} not found.");
        }
    }
}