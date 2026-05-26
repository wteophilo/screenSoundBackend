using ScreenSoundBackend.Models;

namespace ScreenSoundBackend.Menus;

internal class EvaluateBand : Menu
{
    public override void Execute(Dictionary<string, Band> bands)
    {
        base.Execute(bands);
        ShowPageTitle("Evaluate a band");
        Console.Write("What band do you want to evaluate: ");
        string bandName = Console.ReadLine()!;
        if (bands.TryGetValue(bandName, out Band? foundedBand))
        {
            Console.Write("Enter your evaluation (1-10): ");
            string text = Console.ReadLine()!;
            try
            {
                Evaluate evaluation = Evaluate.Parse(text);
                foundedBand.AddEvaluation(evaluation);
                Console.WriteLine($"The evaluation {evaluation.Score} was added to {foundedBand.Name}!");
            }
            catch (Exception ex) when (ex is FormatException or ArgumentException or OverflowException)
            {
                Console.WriteLine("Invalid input. Please enter a valid number between 0 and 10.");
            }
        }
        else
        {
            Console.WriteLine($"Band {bandName} not found.");
        }
        Thread.Sleep(2000);
    }
}