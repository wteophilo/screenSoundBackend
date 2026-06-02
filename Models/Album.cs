namespace ScreenSoundBackend.Models;

internal class Album : IEvaluable
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;

    public virtual ICollection<Music> Musics { get; set; } = new List<Music>();
    public virtual ICollection<Evaluate> Evaluations { get; set; } = new List<Evaluate>();

    public Album() {}

    public Album(string name)
    {
        Name = name;
    }

    public int DurationTotal => Musics.Sum(m => m.Duration);

    public double Average
    {
        get
        {
            if (Evaluations.Count == 0) return 0;
            return Evaluations.Average(e => e.Score);
        }
    }

    public void AddEvaluation(Evaluate evaluation)
    {
        this.Evaluations.Add(evaluation);
    }

    public void AddMusic(Music music)
    {
        Musics.Add(music);
    }

    public void ShowMusics()
    {
        Console.WriteLine($"List of songs of the album {Name}:\n");
        foreach (var music in Musics)
        {
            Console.WriteLine($"Music: {music.Name}");
        }
        Console.WriteLine($"\nTo listen to this album in full you need {DurationTotal} seconds.");
    }
}