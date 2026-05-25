namespace ScreenSoundBackend.Models;

class Music(string name, Band band)
{
    public string Name { get; } = name;
    public Band Band { get; } = band;
    public int Duration { get; set; }
    public bool Available { get; set; }
    public string ResumeDescription => $"The music {Name} belongs to the band {Band.Name}";

    public void ShowMusicSheet()
    {
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Band: {Band.Name}");
        Console.WriteLine($"Duration: {Duration}");
        if (Available)
        {
            Console.WriteLine("Available on the plan.");
        }
        else
        {
            Console.WriteLine("Subscribe to the Plus+ plan");
        }
    }
}