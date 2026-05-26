using ScreenSoundBackend.Models;

namespace ScreenSoundBackend.Menus;

internal class Exit : Menu
{
    public override void Execute(Dictionary<string, Band> bands)
    {
        Console.WriteLine("Thanks for using Screen Sound =)");
    }
}