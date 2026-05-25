namespace ScreenSoundBackend.Models;

class Album(string name)
{
    private readonly List<Music> musics = [];

    public string Name { get; } = name;
    public int DurationTotal => musics.Sum(m => m.Duration);
    public List<Music> Musics => musics;

    public void AddMusic(Music music)
    {
        musics.Add(music);
    }

    public void ShowMusics()
    {
        Console.WriteLine($"List of songs of the album {Name}:\n");
        foreach (var music in musics)
        {
            Console.WriteLine($"Music: {music.Name}");
        }
        Console.WriteLine($"\nTo listen to this album in full you need {DurationTotal} seconds.");
    }
}