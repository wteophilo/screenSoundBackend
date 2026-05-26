using ScreenSoundBackend.Models;

namespace ScreenSoundBackend.Menus;

internal class ShowBandDiscography : Menu
{
    public override void Execute(Dictionary<string, Band> bands)
    {
        base.Execute(bands);
        ShowPageTitle("Show Band Discography");
        Console.Write("What band do you want to see the discography of: ");
        string bandName = Console.ReadLine()!;
        if (bands.TryGetValue(bandName, out Band? foundedBand))
        {
            foundedBand.ShowDiscography();
        }
        else
        {
            Console.WriteLine($"Band {bandName} not found.");
        }
        Thread.Sleep(2000);
    }
}