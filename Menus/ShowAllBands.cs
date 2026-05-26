using ScreenSoundBackend.Models;

namespace ScreenSoundBackend.Menus;

internal class ShowAllBands : Menu
{
    public override void Execute(Dictionary<string, Band> bands)
    {
        base.Execute(bands);
        ShowPageTitle("Show all bands");
        foreach (string band in bands.Keys)
        {
            Console.WriteLine(band);
        }
        Thread.Sleep(2000);
    }
}