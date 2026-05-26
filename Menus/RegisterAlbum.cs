using ScreenSoundBackend.Models;

namespace ScreenSoundBackend.Menus;

internal class RegisterAlbum : Menu
{
    public override void Execute(Dictionary<string, Band> bands)
    {
        base.Execute(bands);
        ShowPageTitle("Register an album");
        Console.Write("What album do you want do add: ");
        string albumName = Console.ReadLine()!;

        Console.Write("What band do you want do add album to: ");
        string bandName = Console.ReadLine()!;
        if (bands.TryGetValue(bandName, out Band? foundedBand))
        {
            Album newAlbum = new(albumName);
            foundedBand.AddAlbum(newAlbum);
            Console.WriteLine($"{albumName} was registered successfully!");
        }
        else
        {
            Console.WriteLine($"Band {bandName} not found.");
        }
        Thread.Sleep(2000);
    }
}