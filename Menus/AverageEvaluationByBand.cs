namespace ScreenSoundBackend.Menus;

using ScreenSoundBackend.Models;

internal class AverageEvaluationByBand : Menu
{
    public override void Execute(Dictionary<string, Band> bands)
    {
        base.Execute(bands);
        ShowPageTitle("Average Evaluation By Band");

        Console.Write("What band do you want to evaluate: ");
        string bandName = Console.ReadLine()!;

        if (bands.TryGetValue(bandName, out Band? foundedBand))
        {
            if (!foundedBand.HasEvaluations())
            {
                Console.WriteLine("This band has no evaluations.");
                return;
            }

            Console.WriteLine($"The average evaluation of {bandName} is {foundedBand.Average}.");
        }
        else
        {
            Console.WriteLine($"Band {bandName} not found.");
        }
        Thread.Sleep(2000);
    }
}