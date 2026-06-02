namespace ScreenSoundBackend.Models;

internal class Music
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public virtual Band Band { get; set; } = null!;
    public int Duration { get; set; }
    public bool Available { get; set; }
    public string ResumeDescription => $"The music {Name} belongs to the band {Band.Name}";

    public Music() { }

    public Music(string name, Band band)
    {
        Name = name;
        Band = band;
    }

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