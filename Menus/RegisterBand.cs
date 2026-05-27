using ScreenSoundBackend.Helpers.AI;
using ScreenSoundBackend.Models;

namespace ScreenSoundBackend.Menus;

internal class RegisterBand : Menu
{
    public override void Execute(Dictionary<string, Band> bands)
    {
        base.Execute(bands);
        ShowPageTitle("Register a band");
        Console.Write("What band do you want do add: ");
        string bandName = Console.ReadLine()!;
        Band newBand = new(bandName)
        {
            Summary = DotNetEnv.Env.GetBool("ENABLE_GEMINI") ? GenerateBandSumary.Call(bandName) : ""
        };
        bands.Add(bandName, newBand);
        Console.WriteLine($"{bandName} was registered successfully!");
        Thread.Sleep(2000);
    }
}