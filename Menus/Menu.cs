using ScreenSoundBackend.Models;

namespace ScreenSoundBackend.Menus;

internal class Menu
{
    public static void ShowOptions()
    {
        Console.WriteLine("\nAvailable options:");
        Console.WriteLine("1. Register a band");
        Console.WriteLine("2. Show all bands");
        Console.WriteLine("3. Register an album");
        Console.WriteLine("4. Evaluate a band");
        Console.WriteLine("5. Show bands with average evaluation");
        Console.WriteLine("0. Exit");
    }

    public static int ReadOption()
    {
        Console.Write("\nChoose an option: ");
        int option = int.Parse(Console.ReadLine()!);
        return option;
    }
    public static void ShowPageTitle(string title)
    {
        string line = string.Empty.PadLeft(title.Length, '=');
        Console.WriteLine(line);
        Console.WriteLine(title);
        Console.WriteLine(line + "\n");
    }

    public virtual void Execute(Dictionary<string, Band> bands)
    {
        Console.Clear();
    }
}